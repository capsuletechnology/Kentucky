using Kentucky.Helper;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kentucky.ViewModel
{
    public class LoginVM : ViewModelBase
    {
        public ICommand LoginCommand { get; set; }
        public ICommand RegistrarCommand { get; set; }
        public ICommand RecuperarCommand { get; set; }

        private string login;
        public string Login { get { return login; } set { login = value; OnPropertyChanged(); } }

        private string senha;
        public string Senha { get { return senha; } set { senha = value; OnPropertyChanged(); } }

        public LoginVM()
        {
            RegistrarCommand = new Command(Registrar);
            RecuperarCommand = new Command(RecuperarConta);
            LoginCommand = new Command(Logar);
        }
        
        async void Logar()
        {
            await Repositorio.Navegar(new View.Principal());
        }

        async void Registrar()
        {
            await Repositorio.Navegar(new View.Registro());
        }

        async void RecuperarConta()
        {
            await Repositorio.Navegar(new View.RecuperarConta());
        }
    }
}
