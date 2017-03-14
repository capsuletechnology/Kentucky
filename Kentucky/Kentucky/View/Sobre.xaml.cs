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
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Repositorio.MainPage(new MainPage());
            return true;
        }
    }
}
