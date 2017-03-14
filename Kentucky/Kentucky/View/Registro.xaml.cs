using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.RegistroVM();    
        }

        protected override bool OnBackButtonPressed()
        {
            Repositorio.MainPage(new Inicio());
            return true;
        }
    }
}
