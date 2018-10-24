//using MultiTarget.Plataforms;
using MultiTarget.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MultiTarget
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await (BindingContext as MainViewModel).InitializeAsync(null);

            //var teste = Plataform.Teste.Test;

            //await DisplayAlert("Rodando", teste, "Ok");
        }
    }
}
