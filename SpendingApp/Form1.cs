using SpendingApp.Controls;
using SpendingApp.Data;
using SpendingApp.Forms;

namespace SpendingApp
{
    public partial class Form1 : Form
    {
        SpendingDbContext _database;
        private List<Spend> _spend;
        private List<User> _users;
        
        public Form1()
        {
            InitializeComponent();
            _database = new();
            _users = new List<User>();
            _spend = new List<Spend>();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var users = _database.Users;
            var spends = _database.Spend;
            if (users == null)
            {
                MessageBox.Show("Can't load users");
            }
            else
            {
                _users = users.ToList();
                _spend = spends.ToList();
            }
            UpdateUi();
        }
        private void UpdateUi()
        {
            _pnlUsers.Controls.Clear();
            int i = 0;
            foreach (var user in _users)
            {
                UsersControl control = new(user);
                control.Location = new Point(0, (control.Height * i) + 5);
                control.OnItemClick += Control_OnItemClick;
                _pnlUsers.Controls.Add(control);
                i++;
            }
        }

        private void Control_OnItemClick(User user, UsersControl sender)
        {
            SpendDetailForm form = new(_database, user);
            form.ShowDialog();
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            _database.Users.Add(new User()
            {
                Name=_txtName.Text,
                Email=_txtEmail.Text,
                Surname=_txtSurname.Text,
            });
            _database.SaveChanges();
        }
    }
}