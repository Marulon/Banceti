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
    public partial class Search : Form
    {
        public static Account User;
        public Search()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var x = new frm_Home();
            x.Show();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            bool result = false;

            foreach (var x in Connection.Data.ReadAccount())
            {
                if (Equals(txt_Search.Text, x.Code)&& Equals(txt_Search.Text, Frm_Login.User) == false)
                {
                    User = x;
                    result = true;
                }
            }


            if (result)
            {
                txt_Code.Text = User.Code;
                txt_Name.Text = User.Name;
                txt_Money.Text = User.Money.ToString();
                txt_Pin.Text = User.Pin.ToString();
                txt_Repeat.Text = User.Pin.ToString();
                tbar_AdminAccess.Value = Convert.ToInt32(User.AdminAccess);
                btn_Save.Enabled = true;
                btn_Delete.Enabled = true;
            }
            else
            {
                MessageBox.Show ("No se encontro una cuenta");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Equals(txt_Pin.Text, txt_Repeat.Text))
            {
                try
                {
                    User.Code = txt_Code.Text;
                    User.Name = txt_Name.Text;
                    User.Money = Convert.ToInt32(txt_Money.Text);
                    User.Pin = Convert.ToInt32(txt_Pin.Text);
                    User.AdminAccess = Convert.ToBoolean(tbar_AdminAccess.Value);

                    Connection.Data.Update(User);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var x = new Continue();
            x.Show();
            this.Hide();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
        }
    }
}
