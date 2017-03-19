using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class Recover : ContentPage
    {
        public Recover()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Repository.MainPage(new Login());
            return true;
        }
    }
}
