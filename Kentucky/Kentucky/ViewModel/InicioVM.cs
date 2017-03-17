using Kentucky.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kentucky.ViewModel
{
    public class InicioVM : ViewModelBase
    {
        public ICommand EntrarCommand { get; set; }
        public ICommand RegistrarCommand { get; set; }

        public ObservableCollection<Model.ImagensInicio> ImagensInicio { get; set; }

        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }

        public InicioVM()
        {
            EntrarCommand = new Command(Entrar);
            RegistrarCommand = new Command(Registrar);

            CarregarImagens();  
        }

        void Entrar()
        {
            Repositorio.MainPage(new View.Login());
        }

        void Registrar()
        {
            Repositorio.MainPage(new View.Registro());
        }

        void CarregarImagens()
        {
            ImagensInicio = new ObservableCollection<Model.ImagensInicio>
            {
                
                new Model.ImagensInicio
                {
                    ImageUrl = "https://a2-images.myspacecdn.com/images03/31/cd82c385d96c4b77903485f486389870/300x300.jpg",
                    Text = "Anônimos! O aplicativo dos Deuses!"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "http://www.sthlminc.com/wp-content/uploads/2015/10/anonym.jpg",
                    Text = "Descubra o que outras pessoas pensam"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "https://pbs.twimg.com/profile_images/728303368871903232/kyFqCkcD.jpg",
                    Text = "Avalie, denuncie, blablablablabla"
                }
            };
        }
    }
}
