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
    public partial class Continue : Form
    {
        public Continue()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            var x = new frm_Home();
            MessageBox.Show( Connection.Data.Delete(Search.User.ID));
            if (System.IO.File.Exists("C:\\BanCeti\\BanCeti\\DataBase\\Account Status\\" + Search.User.Code + ".db3"))
            {
                try
                {
                    System.IO.File.Delete("C:\\BanCeti\\BanCeti\\DataBase\\Account Status\\" + Search.User.Code + ".db3");
                }
                catch (System.IO.IOException a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }
            frm_Home.Form_Search.Close();
            x.Show();
            this.Close();
        }

        private void Continue_Load(object sender, EventArgs e)
        {
            label1.Text = "¿Desea continuar? se eliminara la cuenta: " + Search.User.Code;
        }

        private void btn_NO_Click(object sender, EventArgs e)
        {
            frm_Home.Form_Search.Show();
            this.Close();
        }
    }
}
