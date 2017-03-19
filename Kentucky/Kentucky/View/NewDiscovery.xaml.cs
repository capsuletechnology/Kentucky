using Kentucky.Helper;
using Kentucky.View.MasterDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class NewDiscovery : ContentPage
    {
        public NewDiscovery()
        {
            InitializeComponent();
            BindingContext = new ViewModel.NewDiscoveryVM();
        }

        protected override bool OnBackButtonPressed()
        {
            Repository.MainPage(new MainPage());
            return true;
        }

    }
}
