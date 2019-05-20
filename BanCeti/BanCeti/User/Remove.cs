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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void btn_UserWithdrawals_Click(object sender, EventArgs e)
        {
            try
            {
                if (Frm_Login.User.Money >= Convert.ToInt32(txt_Remove.Text))
                {
                    Frm_Login.User.Money -= Convert.ToInt32(txt_Remove.Text);
                    Connection.Data.Update(Frm_Login.User);
                    Connection.StartConnectionStatus("C:\\BanCeti\\BanCeti\\DataBase\\Account Status\\" + Frm_Login.User.Code + ".db3");
                    Connection.Data.Writestatus(DateTime.Now.ToString("g"), "Retiro: -$" + txt_Remove.Text);
                    Connection.CloseConnectionStatus("C:\\BanCeti\\BanCeti\\DataBase\\DataBaseAccounts.db3");
                    var x = new frm_Home();
                    x.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dinero Insuficiente");
                }
            }
            catch (Exception a)
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

        private void Remove_Load(object sender, EventArgs e)
        {
            lbl_Balance.Text = "Su saldo es: " + Frm_Login.User.Money.ToString();
        }
    }
}
