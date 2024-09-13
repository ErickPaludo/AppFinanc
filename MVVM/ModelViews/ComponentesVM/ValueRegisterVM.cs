using AppFinanc.MVVM.Model.SQLite;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppFinanc.MVVM.ModelViews.ComponentesVM
{
    public partial class ValueRegisterVM : ObservableObject
    {
        [ObservableProperty]
        private bool _isRedButtonEnabled;

        private SqliteService sql;

        [RelayCommand]
        private void ValueRegisterViewModel()
        {
            IsRedButtonEnabled = !IsRedButtonEnabled;
            sql.InitilizeAsync();
        }

        public ValueRegisterVM()
        {
            sql = SqliteService.GetInstance();
        }


    }
}
