using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.BindingContext = new ViewModel.LoginVM();
        }
        
        protected override bool OnBackButtonPressed()
        {
            Repository.MainPage(new Start());
            return true;
        }
    }
}
