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

namespace BanCeti.Admin
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Equals(txt_Pin.Text, txt_Repeat.Text))
            {
                try
                {
                    Connection.Data.WriteAccount(txt_Name.Text, txt_Code.Text, Convert.ToBoolean(tbar_AdminAccess.Value), Convert.ToInt32(txt_Money.Text), Convert.ToInt32(txt_Pin.Text));
                    Connection.StartConnectionStatus("C:\\BanCeti\\BanCeti\\DataBase\\Account Status\\" + txt_Code.Text + ".db3");
                    Connection.Data.Writestatus(DateTime.Now.ToString("g"), "Cuenta Creada");
                    Connection.CloseConnectionStatus("C:\\BanCeti\\BanCeti\\DataBase\\DataBaseAccounts.db3");

                    var x = new frm_Home();
                    x.Show();
                    this.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
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
