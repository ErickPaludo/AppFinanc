using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppFinanc.MVVM.Model.SQLite.TableFinanc;

namespace AppFinanc.MVVM.Model.SQLite
{
    public interface ISqliteService
    {
        public Task InitilizeAsync();
        public Task<List<TableFinanc>> GetDataConfigAsync();
        Task<TableFinanc> GetData(int dados);
        Task<int> AddData(TableFinanc dados);
        Task<int> UpdateData(TableFinanc dados);
        Task<int> DeleteData(TableFinanc dados);
    }
}
