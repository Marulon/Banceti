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

namespace BanCeti.User
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void btn_UserDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                    Frm_Login.User.Money += Convert.ToInt32(txt_Depositar.Text);
                    Connection.Data.Update(Frm_Login.User);
                    Connection.StartConnectionStatus("C:\\BanCeti\\BanCeti\\DataBase\\Account Status\\" + Frm_Login.User.Code + ".db3");
                    Connection.Data.Writestatus(DateTime.Now.ToString("g"), txt_Reason.Text + ": $" + txt_Depositar.Text);
                    Connection.CloseConnectionStatus("C:\\BanCeti\\BanCeti\\DataBase\\DataBaseAccounts.db3");
                    var x = new frm_Home();
                    x.Show();
                    this.Close();
            }catch(Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var x = new frm_Home();
            x.Show();
            this.Close();
        }
    }
}
