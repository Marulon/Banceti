using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanCeti.DataBase;

namespace BanCeti
{
    public partial class Frm_Login : Form
    {
        public static Account User;
        public Frm_Login()
        {
            InitializeComponent();
            
        }

        public void Frm_Login_Load(object sender, EventArgs e)
        {
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User = new Account();
            foreach (Account x in Connection.Data.ReadAccount())
            {
                if (Equals(x.Code, txt_Account.Text) == true && x.Pin == Convert.ToInt32 (txt_Pin.Text))
                {
                    User = x;
                    var frm = new frm_Home();
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
