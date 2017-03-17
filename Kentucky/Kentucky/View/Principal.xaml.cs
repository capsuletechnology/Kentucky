using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View
{
    public partial class Principal : ContentPage
    {
        public Principal()
        {

            InitializeComponent();
            
        }

        protected override bool OnBackButtonPressed()
        {
            return Repositorio.SairAplicativo(this);
        }
    }
}
