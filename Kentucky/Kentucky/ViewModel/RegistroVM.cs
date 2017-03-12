using Kentucky.Helper;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kentucky.ViewModel
{
    public class RegistroVM : ViewModelBase
    {
        public ICommand RegistrarCommand { get; set; }
        public ICommand CancelarCommand { get; set; }

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
            CancelarCommand = new Command(Cancelar);
        }

        async void Registrar()
        {
            await Repositorio.Mensagem("REGISTRO", "Registrado com sucesso!", "OK");
            await Repositorio.Voltar();
        }

        async void Cancelar()
        {
            await Repositorio.Voltar();
        }
    }
}
