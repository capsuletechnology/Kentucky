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
    public class StartVM : ViewModelBase
    {
        public ICommand EnterCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public ObservableCollection<Model.Image> _Image { get; set; }

        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }

        public StartVM()
        {
            EnterCommand = new Command(Enter);
            RegisterCommand = new Command(Register);

            LoadImages();
        }

        void Enter()
        {
            Repository.MainPage(new View.Login());
        }

        void Register()
        {
            Repository.MainPage(new View.Register());
        }

        void LoadImages()
        {
            _Image = new ObservableCollection<Model.Image>
            {

                new Model.Image
                {
                    ImageUrl = "https://a2-images.myspacecdn.com/images03/31/cd82c385d96c4b77903485f486389870/300x300.jpg",
                    Text = "Anônimos! O aplicativo dos Deuses!"
                },

                new Model.Image
                {
                    ImageUrl = "http://www.sthlminc.com/wp-content/uploads/2015/10/anonym.jpg",
                    Text = "Descubra o que outras pessoas pensam"
                },

                new Model.Image
                {
                    ImageUrl = "https://pbs.twimg.com/profile_images/728303368871903232/kyFqCkcD.jpg",
                    Text = "Avalie, denuncie, blablablablabla"
                }
            };
        }
    }
}
