using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace MiniProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=MSDAORA Data Source=XE;User ID=system;Password=suyog123;Unicode=True");
        private void Admin_Button(object sender, EventArgs e)
        {
           this.Hide();
            Admin_login a = new Admin_login();
            a.Show();
        }

        private void Customer_button(object sender, EventArgs e)
        {
            this.Hide();
            Customer_login a = new Customer_login();
            a.Show();
        }

        private void Exit_button(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
