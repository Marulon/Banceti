using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BanCeti.DataBase
{
    [Table("account")]
    public class Account
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50), Unique]
        public string Code { get; set; }
        public bool AdminAccess { get; set; }
        public int Money { get; set; }
        public int Pin { get; set; }
    }
}
