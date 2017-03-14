using Kentucky.Helper;
using Kentucky.View;
using Kentucky.View.MasterDetail;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kentucky.ViewModel
{
    public class LoginVM : ViewModelBase
    {
        public ICommand LoginCommand { get; set; }
        public ICommand FacebookCommand { get; set; }
        public ICommand RecuperarCommand { get; set; }

        private string login;
        public string Login { get { return login; } set { login = value; OnPropertyChanged(); } }

        private string senha;
        public string Senha { get { return senha; } set { senha = value; OnPropertyChanged(); } }

        public LoginVM()
        {
            LoginCommand = new Command(Logar);
            FacebookCommand = new Command(EntrarFacebook);
            RecuperarCommand = new Command(RecuperarConta);            
        }
        
        void Logar()
        {
            Repositorio.MainPage(new MainPage());
        }

        void EntrarFacebook()
        {
            Repositorio.MainPage(new MainPage());
        }

        void RecuperarConta()
        {
            Repositorio.MainPage(new RecuperarConta());
        }
    }
}
