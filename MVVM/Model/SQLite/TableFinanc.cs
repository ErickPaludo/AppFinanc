using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanc.MVVM.Model.SQLite
{
    [Table("tb_gastos")]
    public class TableFinanc
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(20), NotNull]
        public string gasto { get; set; }

        [NotNull]
        public double valor { get; set; }

        [NotNull]
        public int tipo { get; set; }

        public TableFinanc()
        {
        }
    }



}
    
