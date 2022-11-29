using Microsoft.EntityFrameworkCore.Infrastructure;
using SpendingApp.Controls;
using SpendingApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendingApp.Forms
{
    public partial class SpendDetailForm : Form
    {
        SpendingDbContext _database;
        private readonly User _user;
        private readonly Spend _spend;
        List<Spend> _spends = new List<Spend>();

        public SpendDetailForm(SpendingDbContext database, User user)
        {
            InitializeComponent();
            _database = database;
            _user = user;
        }

        private void SpendDetailForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
            _spends.Add(_spend);
        }

        private void UpdateUI()
        {
            var name = _user.Name;
            var surname = _user.Surname;
            _lblName.Text = "🧑"+name;
            _lblSurname.Text = surname+"🧑";

            _pnlSpend.Controls.Clear();
            int i = 0;
            foreach (var item in _user.Spends)
            {
                SpendControl control = new SpendControl(item, _database);
                control.Location= new Point(0, (control.Height*i)+5);
                _pnlSpend.Controls.Add(control);
                i++;
            }
        }

        private void _btnSend_Click(object sender, EventArgs e)
        {
            _database.Spend.Add(new Spend()
            {
                Name = _txtName.Text,
                Price = int.Parse(_txtPrice.Text),
                Dateofaddition = DateTime.Now,
                UsersId = _user.UsersId,
                Paid = _checkPaid.Checked ? true : false,
            });
            _database.SaveChanges();
            UpdateUI();
        }
    }
}
