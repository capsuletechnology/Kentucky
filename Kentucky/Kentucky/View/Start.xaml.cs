using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class Start : ContentPage
    {
        public Start()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.BindingContext = new ViewModel.StartVM();
        }

        protected override bool OnBackButtonPressed()
        {
            return Repository.ExitApplication(this);
        }
    }
}
