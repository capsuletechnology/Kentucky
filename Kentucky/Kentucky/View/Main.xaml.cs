using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
            BindingContext = new ViewModel.MainVM();
        }

        protected override bool OnBackButtonPressed()
        {
            return Repository.ExitApplication(this);
        }
    }
}
