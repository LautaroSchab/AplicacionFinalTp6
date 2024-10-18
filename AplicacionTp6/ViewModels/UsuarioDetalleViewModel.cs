using AplicacionTp6.Models;
using AplicacionTp6.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTp6.ViewModels
{
    public partial class UsuarioDetalleViewModel: BaseViewModel
    {
        [ObservableProperty]
        Usuario usuario;

        [RelayCommand]
        private async Task GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        [RelayCommand]
        public async Task GoToCrearLista()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UsuarioCrearPage());
        }


        [RelayCommand]
        public async Task GoToEditarLista()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EditarUsuarioPage());
        }
        
    }
}
