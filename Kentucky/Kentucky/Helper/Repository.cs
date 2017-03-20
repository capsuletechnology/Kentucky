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

        public double RatingPost(double countLikes, double countFavs, double countReports)
        {
            double x;
            x = ((countLikes * 6.366382) + (countFavs * 12.28076) - (countReports * 8.716538)) / 27.36368;
            if(x <= 0)
                return 0;
            return x;
        }
    }
}
