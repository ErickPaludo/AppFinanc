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

        [ObservableProperty]
        private TableFinanc _dados;

        [ObservableProperty]
        private List<TableFinanc> _data;

        private SqliteService sql = SqliteService.GetInstance();



        [RelayCommand]
        private void ValueRegisterViewModel()
        {
            IsRedButtonEnabled = !IsRedButtonEnabled;
        }

        public ValueRegisterVM()
        {
   
        }

        private async Task DisplayCommand()
        {
            await sql.InitilizeAsync();
            await Refresh();
            if (Data.Count > 0)
            {
                var obj = Data[0];
                Dados = new TableFinanc
                {
                 id = obj.id,
                 gasto = obj.gasto,
                 tipo = obj.tipo,
                 valor = obj.valor,
                };
            }
        }
        private async Task Refresh()
        {
            Data = await sql.GetDataConfigAsync();
        }

    }
}
