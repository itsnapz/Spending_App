using Microsoft.EntityFrameworkCore;
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
    public partial class SpendControl : UserControl
    {
        SpendingDbContext _database;
        public Spend _spend { get; set; } 
        public SpendControl(Spend spend, SpendingDbContext database)
        {
            _database = database;
            _spend = spend;
            InitializeComponent();
        }

        private void SpendControl_Load(object sender, EventArgs e)
        {
            string price = ",-";
            _lblSpendName.Text = _spend.Name;
            _lblPrice.Text = _spend.Price.ToString()+price;
            if (_spend.Paid == true)
            {
                _checkIsPaid.Checked = true;
                _checkIsPaid.Enabled = false;
            }
            if (_spend.Paid == false)
            {
                _lblDate.Text = string.Empty;
            }
        }

        private void _checkIsPaid_CheckedChanged(object sender, EventArgs e)
        {
            _checkIsPaid.Enabled = false;
            _spend.Paid = true;
            _lblDate.Text = DateTime.Now.ToShortDateString();
            _database.SaveChanges();
        }
    }
}
