using AppFinanc.MVVM.Model.SQLite;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinanc.MVVM.ModelViews
{
    public partial class CreditoVM : ObservableObject
    {
        [ObservableProperty]
        private bool _isRedButtonEnabled;

        private SqliteService sql;

        public CreditoVM()
        {
            sql = SqliteService.GetInstance();
        }
    }
}
