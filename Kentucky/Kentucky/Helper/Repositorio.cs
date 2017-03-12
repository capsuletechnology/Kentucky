using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kentucky.Helper
{
    public class Repositorio
    {
        public static async Task Navegar(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public static async Task Voltar()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public static async Task Mensagem(string titulo, string mensagem, string confirmar)
        {
            await Application.Current.MainPage.DisplayAlert(titulo, mensagem, confirmar);
        }
    }
}
