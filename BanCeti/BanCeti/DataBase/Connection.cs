using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BanCeti.DataBase
{
    public class Connection
    {
        private static SQLiteConnection Communication;
        private static Connection data;
        private Connection (string path)
        {
            Communication = new SQLiteConnection(path);
            Communication.CreateTable<Account>();
            Communication.CreateTable<Status>();
        }

        public static Connection Data
        {
            get
            {
                if (data != null)
                {
                    Default();
                    return data;
                }
                else
                {
                    return null;
                }
            }
        }
        

        public static void StartConnectionAccounts (string path)
        {
            if (Communication != null)
            {
                Communication.Close();
            }
            data = new Connection(path);
        }

        public static void StartConnectionStatus (string path)
        {
            if (Communication != null)
            {
                Communication.Close();
            }
            data = new Connection(path);
        }

        public static void CloseConnectionStatus (string path)
        {
            if (Communication != null)
            {
                Communication.Close();
            }
            Connection.StartConnectionAccounts(path);
        }
        public static void CloseConnectionAccount()
        {
            if (Communication != null)
            {
                Communication.Close();
            }
        }

        public IEnumerable<Account> ReadAccount()
        {
            return Communication.Table<Account>();
        }

        public string WriteAccount (string name, string code, bool adminaccess, int money, int pin)
        {
            string result = "Guardado con exito....";
            try
            {
                Communication.Insert(new Account {
                    Name = name,
                    Code = code,
                    AdminAccess = adminaccess,
                    Money = money,
                    Pin = pin
                });
            }catch (Exception e)
            {
                result = e.Message.ToString();
            }
            return result;
        }

        public IEnumerable<Status> ReadStatus()
        {
            return Communication.Table<Status>();
        }

        public string Writestatus(string date, string movement)
        {
            string result = "realizado con exito....";
            try
            {
                Communication.Insert(new Status
                {
                    Date = date,
                    Movement=movement
                });
            }
            catch (Exception e)
            {
                result = e.Message.ToString();
            }
            return result;
        }

        public string Delete (int id)
        {
            string result = "Eliminado con exito....";
            try
            {
                Communication.Delete<Account>(id);
            }catch (Exception e)
            {
                result = e.Message.ToString();
            }
            return result;
        }

        public string Update (Account account)
        {
            string result = "Movimiento realizado...";
            try
            {
                Communication.Update(account);
            }catch(Exception e)
            {
                result = e.Message.ToString();
            }
            return result;
        }

        private static void Default ()
        {
            bool exist = false;
            foreach (var x in Connection.data.ReadAccount())
            {
                if (Equals(x.Code,"AdminCode") == true)
                {
                    exist = true;
                }
            }

            if (exist == false)
            {
                Connection.data.WriteAccount("Juan","AdminCode",true,0,666);
            }
        }
    }
}
