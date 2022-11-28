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

namespace SpendingApp.Controls
{
    public partial class UsersControl : UserControl
    {
        private readonly User _user;
        public delegate void ItemClick(User user, UsersControl sender);
        public event ItemClick OnItemClick;
        public UsersControl(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void SetUI()
        {
            _lblName.Text = _user.Name;
            _lblSurname.Text = _user.Surname;
        }

        private void UsersControl_Click(object sender, EventArgs e)
        {
            OnItemClick.Invoke(_user, this);
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            SetUI();
        }
    }
}
