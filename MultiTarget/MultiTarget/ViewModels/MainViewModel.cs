using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MultiTarget.ViewModels
{
    sealed class MainViewModel : BaseViewModel
    {
        public override async Task InitializeAsync(object[] args)
        {
            var teste = Plataform.Teste.Test;
            await DisplayAlert("Aviso",teste);
        }
    }
}
