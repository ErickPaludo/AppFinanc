using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanc.MVVM.Model.SQLite
{
    public class SqliteService : ISqliteService
    {
        private SQLiteAsyncConnection _dbConnection;
        private static SqliteService _instance;

        public static SqliteService GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SqliteService();
            }
            return _instance;
        }

        public async Task InitilizeAsync()
        {
            await SetUpDb();
        }
        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dpPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.db3");
                _dbConnection = new SQLiteAsyncConnection(dpPath);
                await _dbConnection.CreateTableAsync<TableFinanc>();
            }
        }

        public async Task<int> AddData(TableFinanc data)
        {
            return await _dbConnection.InsertAsync(data);
        }

        public async Task<int> DeleteData(TableFinanc data)
        {
            return await _dbConnection.DeleteAsync(data);
        }

        public async Task<int> UpdateData(TableFinanc data)
        {
                return await _dbConnection.UpdateAsync(data);
        }

        public async Task<List<TableFinanc>> GetDataConfigAsync()
        {
            return await _dbConnection.Table<TableFinanc>().ToListAsync();
        }
        public async Task<TableFinanc> GetData(int id)
        {
            return await _dbConnection.Table<TableFinanc>().FirstOrDefaultAsync(x => x.id == id);
        }


    }
}

