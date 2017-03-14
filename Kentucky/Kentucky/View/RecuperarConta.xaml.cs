using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class RecuperarConta : ContentPage
    {
        public RecuperarConta()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Repositorio.MainPage(new Inicio());
            return true;
        }
    }
}
