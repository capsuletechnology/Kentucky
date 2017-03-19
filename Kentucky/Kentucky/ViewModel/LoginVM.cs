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
        public ICommand RecoverCommand { get; set; }

        private string user;
        public string User { get { return user; } set { user = value; OnPropertyChanged(); } }

        private string password;
        public string Password { get { return password; } set { password = value; OnPropertyChanged(); } }

        public LoginVM()
        {
            LoginCommand = new Command(Login);
            FacebookCommand = new Command(Facebook);
            RecoverCommand = new Command(Recover);            
        }
        
        void Login()
        {
            Repository.MainPage(new MainPage());
        }

        void Facebook()
        {
            Repository.MainPage(new MainPage());
        }

        void Recover()
        {
            Repository.MainPage(new Recover());
        }
    }
}
