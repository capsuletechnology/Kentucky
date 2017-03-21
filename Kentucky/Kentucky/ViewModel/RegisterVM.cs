using Kentucky.Helper;
using Kentucky.View;
using Kentucky.View.MasterDetail;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kentucky.ViewModel
{
    public class RegisterVM : ViewModelBase
    {
        public ICommand RegisterCommand { get; set; }
        public ICommand FacebookCommand { get; set; }
        
        private string fullName;
        public string FullName { get { return fullName; } set { fullName = value; OnPropertyChanged(); } }

        private string phone;
        public string Phone { get { return phone; } set { phone = value; OnPropertyChanged(); } }

        private string nickname;
        public string Nickname { get { return nickname; } set { nickname = value; OnPropertyChanged(); } }

        private string email;
        public string Email { get { return email; } set { email = value; OnPropertyChanged(); } }

        private string user;
        public string User { get { return user; } set { user = value; OnPropertyChanged(); } }

        private string password;
        public string Password { get { return password; } set { password = value; OnPropertyChanged(); } }

        public RegisterVM()
        {
            RegisterCommand = new Command(Register);
            FacebookCommand = new Command(Facebook);
        }

        async void Register()
        {
            //await Repository.Message("Senha Criptografada", Password + "\n\n" + Repository.Encrypt(Password), "OK");
            await Repository.Message("REGISTRO", "Registrado com sucesso!", "OK");
            Repository.MainPage(new MainPage());
        }

        async void Facebook()
        {
            //await Repository.Message("Senha Criptografada", Password + "\n\n" + Repository.Encrypt(Password), "OK");
            await Repository.Message("REGISTRO FACEBOOK", "Registrado usando Facebook com sucesso!", "OK");
            Repository.MainPage(new MainPage());
        }
    }
}
