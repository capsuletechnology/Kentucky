using Kentucky.Helper;
using Kentucky.View;
using Kentucky.View.MasterDetail;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kentucky.ViewModel
{
    public class RegistroVM : ViewModelBase
    {
        public ICommand RegistrarCommand { get; set; }
        public ICommand FacebookCommand { get; set; }

        private string email;
        public string Email { get { return email; } set { email = value; OnPropertyChanged(); } }

        private string usuario;
        public string Usuario { get { return usuario; } set { usuario = value; OnPropertyChanged(); } }

        private string senha;
        public string Senha { get { return senha; } set { senha = value; OnPropertyChanged(); } }

        private string cpf;
        public string CPF { get { return cpf; } set { cpf = value; OnPropertyChanged(); } }

        public RegistroVM()
        {
            RegistrarCommand = new Command(Registrar);
            FacebookCommand = new Command(RegistrarFacebook);
        }

        async void Registrar()
        {
            await Repositorio.Mensagem("REGISTRO", "Registrado com sucesso!", "OK");
            Repositorio.MainPage(new MainPage());
        }

        async void RegistrarFacebook()
        {
            await Repositorio.Mensagem("REGISTRO FACEBOOK", "Registrado usando Facebook com sucesso!", "OK");
            Repositorio.MainPage(new MainPage());
        }
    }
}
