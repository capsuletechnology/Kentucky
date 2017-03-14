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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.BindingContext = new ViewModel.InicioVM();
        }

        protected override bool OnBackButtonPressed()
        {
            return Repositorio.SairAplicativo(this);
        }
    }
}
