using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanCeti.Admin;
using BanCeti.User;

namespace BanCeti
{
    public partial class frm_Home : Form
    {
        public static Search Form_Search;
        public frm_Home()
        {
            InitializeComponent();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            this.Text = Frm_Login.User.Name;

            if (Frm_Login.User.AdminAccess == true)
            {
                lbl_welcome.Text = "Bienvenido Administrador " + Frm_Login.User.Name;
                btn_AdminAdd.Visible = true;
                btn_AdminShow.Visible = true;
                btn_AdminShow.Visible = true;
                btn_UserWithdrawals.Visible = false;
                btn_UserDeposit.Visible = false;
                btn_UserMoney.Visible = false;
                btn_UserStatus.Visible = false;
            }
            else
            {
                lbl_welcome.Text = "Bienvenido Usuario " + Frm_Login.User.Name;
                btn_AdminAdd.Visible = false;
                btn_AdminShow.Visible = false;
                btn_AdminShow.Visible = false;
                btn_UserWithdrawals.Visible = true;
                btn_UserDeposit.Visible = true;
                btn_UserMoney.Visible = true;
                btn_UserStatus.Visible = true;
            }
            
            
            
        }

        private void btn_AdminAdd_Click(object sender, EventArgs e)
        {
            var x = new Add();
            x.Show();
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Program.Start.Show();
            Program.Start.txt_Account.Text = null;
            Program.Start.txt_Pin.Text = null;
            this.Close();
        }

        private void btn_AdminShow_Click(object sender, EventArgs e)
        {
            Form_Search = new Search();
            Form_Search.Show();
            this.Close();
        }

        private void btn_UserMoney_Click(object sender, EventArgs e)
        {
            var x = new Balance();
            x.Show();
            this.Close();
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

        private void btn_UserStatus_Click(object sender, EventArgs e)
        {
            var x = new UserStatus();
            x.Show();
            this.Close();
        }
    }
}
