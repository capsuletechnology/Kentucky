using Kentucky.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kentucky.Helper
{
    public class Repository
    {
        public static void MainPage(Page page)
        {
            Application.Current.MainPage = page;
        }

        public static async Task Navigation(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public static async Task NavigationBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public static async Task Message(string title, string message, string confirm)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, confirm);
        }

        public static string Encrypt(string input)
        {
            return DependencyService.Get<ICreateMD5>().GenerateHash(input);
        }

        public static bool ExitApplication(Page page)
        {
            Task<bool> question = page.DisplayAlert("SAIR DO APLICATIVO", "Deseja sair do aplicativo?", "Sim", "Não");
            question.ContinueWith(task =>
            {
                if (task.Result) { DependencyService.Get<ICloseApplication>().closeApplication(); }
            });
            return true;
        }
    }
}
