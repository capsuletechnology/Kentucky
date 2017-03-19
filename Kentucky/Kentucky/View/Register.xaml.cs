using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.RegisterVM();    
        }

        protected override bool OnBackButtonPressed()
        {
            Repository.MainPage(new Start());
            return true;
        }
    }
}
