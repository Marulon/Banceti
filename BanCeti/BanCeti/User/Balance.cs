using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanCeti.User
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            lbl_Balance.Text = "Su saldo es: " + Frm_Login.User.Money.ToString();
        }

        private void btn_UserDeposit_Click(object sender, EventArgs e)
        {
            var x = new Deposit();
            x.Show();
            this.Close();
        }

        private void btn_UserWithdrawals_Click(object sender, EventArgs e)
        {
            var x = new Remove();
            x.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var x = new frm_Home();
            x.Show();
            this.Close();
        }
    }
}
