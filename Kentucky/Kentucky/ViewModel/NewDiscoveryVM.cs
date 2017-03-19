using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Kentucky.Helper;

namespace Kentucky.ViewModel
{
    public class NewDiscoveryVM : ViewModelBase
    {
        public ICommand BlueCommand { get; set; }
        public ICommand WetAsphaltCommand { get; set; }
        public ICommand PinkCommand { get; set; }
        public ICommand RedCommand { get; set; }
        public ICommand YellowCommand { get; set; }
        public ICommand OrangeCommand { get; set; }
        public ICommand GreenCommand { get; set; }
        public ICommand WisteriaCommand { get; set; }
        public ICommand CloudsCommand { get; set; }
        public ICommand AsbestosCommand { get; set; }

        public Color ColorBlue { get; } = Color.FromHex(Colors.Blue);
        public Color ColorWetAsphalt { get; } = Color.FromHex(Colors.WetAsphalt);
        public Color ColorPink { get; } = Color.FromHex(Colors.Pink);
        public Color ColorRed { get; } = Color.FromHex(Colors.Red);
        public Color ColorYellow { get; } = Color.FromHex(Colors.Yellow);
        public Color ColorOrange { get; } = Color.FromHex(Colors.Orange);
        public Color ColorGreen { get; } = Color.FromHex(Colors.Green);
        public Color ColorWisteria { get; } = Color.FromHex(Colors.Wisteria);
        public Color ColorClouds { get; } = Color.FromHex(Colors.Clouds);
        public Color ColorAsbestos { get; } = Color.FromHex(Colors.Asbestos);

        private Color box;
        public Color Box { get { return box; } set { box = value; OnPropertyChanged(); } }

        static Model.Colors Colors = new Model.Colors();

        public NewDiscoveryVM()
        {
            Colors = new Model.Colors();
            BlueCommand = new Command(ChangeColorBlue);
            WetAsphaltCommand = new Command(ChangeColorWetAsphalt);
            PinkCommand = new Command(ChangeColorPink);
            RedCommand = new Command(ChangeColorRed);
            YellowCommand = new Command(ChangeColorYellow);
            OrangeCommand = new Command(ChangeColorOrange);
            GreenCommand = new Command(ChangeColorGreen);
            WisteriaCommand = new Command(ChangeColorWisteria);
            CloudsCommand = new Command(ChangeColorClouds);
            AsbestosCommand = new Command(ChangeColorAsbestos);
        }

        void ChangeColorBlue() => Box = Color.FromHex(Colors.Blue);
        void ChangeColorWetAsphalt() => Box = Color.FromHex(Colors.WetAsphalt);
        void ChangeColorPink() => Box = Color.FromHex(Colors.Pink);
        void ChangeColorRed() => Box = Color.FromHex(Colors.Red);
        void ChangeColorYellow() => Box = Color.FromHex(Colors.Yellow);
        void ChangeColorOrange() => Box = Color.FromHex(Colors.Orange);
        void ChangeColorGreen() => Box = Color.FromHex(Colors.Green);
        void ChangeColorWisteria() => Box = Color.FromHex(Colors.Wisteria);
        void ChangeColorClouds() => Box = Color.FromHex(Colors.Clouds);
        void ChangeColorAsbestos() => Box = Color.FromHex(Colors.Asbestos);
    }
}
