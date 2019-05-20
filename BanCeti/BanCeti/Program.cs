using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanCeti.DataBase;

namespace BanCeti
{
    static class Program
    {
        public static Frm_Login Start;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!System.IO.Directory.Exists("C:\\BanCeti\\BanCeti\\DataBase\\Account Status\\"))
            {
                System.IO.Directory.CreateDirectory("C:\\BanCeti\\BanCeti\\DataBase\\Account Status\\");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Connection.StartConnectionAccounts("C:\\BanCeti\\BanCeti\\DataBase\\DataBaseAccounts.db3");
            Application.Run(Start = new Frm_Login());
        }
    }
}
