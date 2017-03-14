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
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/23c1dd13-333a-459e-9e23-c3784e7cb434/2016-06-02_1049.png",
                    Text = "Descubra o que outras pessoas pensam"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/6b60d27e-c1ec-4fe6-bebe-7386d545bb62/2016-06-02_1051.png",
                    Text = "Avalie, denuncie, blablablablabla"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/e8179889-8189-4acb-bac5-812611199a03/2016-06-02_1053.png",
                    Text = "Anônimos! O aplicativo dos Deuses!"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "https://lh3.ggpht.com/pnRAChD8cipTgqbipKxTFLWfodVn2zT37WGbxTUv0MybP5RoR5GwDEQGlkjwTrl40mY=w300",
                    Text = "Descubra o que outras pessoas pensam"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "http://www.anonym-url.com/images/slider3.jpg",
                    Text = "Avalie, denuncie, blablablablabla"
                },

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
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_Zkl0NyT06iPHNFI3OQh5GLGCq3392MRMMmjp5YphKNyP9BmQ0Q",
                    Text = "Anônimos! O aplicativo dos Deuses!"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "https://pbs.twimg.com/profile_images/1221265740/Anonym_400x400.jpg",
                    Text = "Descubra o que outras pessoas pensam"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "http://www.karriere.de/media/Karriere/Anonyme_Bewerbung_allvision_A.jpg",
                    Text = "Avalie, denuncie, blablablablabla"
                },

                new Model.ImagensInicio
                {
                    ImageUrl = "http://www.sumatronic.ch/images/zPlatzhalter.jpg",
                    Text = "Anônimos! O aplicativo dos Deuses!"
                }
            };
        }
    }
}
