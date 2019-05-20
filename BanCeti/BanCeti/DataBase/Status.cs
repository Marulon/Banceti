using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BanCeti.DataBase
{
    [Table("status")]
    public class Status
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Date { get; set; }
        [MaxLength(120)]
        public string Movement { get; set; }
        
    }
}
