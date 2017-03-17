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
    public class NovaDescobertaVM : ViewModelBase
    {
        public ICommand CommandBlue { get; set; }
        public ICommand CommandWetAsphalt { get; set; }
        public ICommand CommandPink { get; set; }
        public ICommand CommandRed { get; set; }
        public ICommand CommandYellow { get; set; }
        public ICommand CommandOrange { get; set; }
        public ICommand CommandGreen { get; set; }
        public ICommand CommandWisteria { get; set; }
        public ICommand CommandClouds { get; set; }
        public ICommand CommandAsbestos { get; set; }

        //Atributos das cores dos buttons
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

        private Color boxView;
        public Color BoxView { get { return boxView; } set { boxView = value; OnPropertyChanged(); } }
        static Model.Colors Colors = new Model.Colors();
        public NovaDescobertaVM()
        {
            Colors = new Model.Colors();
            CommandBlue = new Command(ChangeColorBlue);
            CommandWetAsphalt = new Command(ChangeColorWetAsphalt);
            CommandPink = new Command(ChangeColorPink);
            CommandRed = new Command(ChangeColorRed);
            CommandYellow = new Command(ChangeColorYellow);
            CommandOrange = new Command(ChangeColorOrange);
            CommandGreen = new Command(ChangeColorGreen);
            CommandWisteria = new Command(ChangeColorWisteria);
            CommandClouds = new Command(ChangeColorClouds);
            CommandAsbestos = new Command(ChangeColorAsbestos);

        }
        void ChangeColorBlue() => BoxView = Color.FromHex(Colors.Blue);
        void ChangeColorWetAsphalt() => BoxView = Color.FromHex(Colors.WetAsphalt);
        void ChangeColorPink() => BoxView = Color.FromHex(Colors.Pink);
        void ChangeColorRed() => BoxView = Color.FromHex(Colors.Red);
        void ChangeColorYellow() => BoxView = Color.FromHex(Colors.Yellow);
        void ChangeColorOrange() => BoxView = Color.FromHex(Colors.Orange);
        void ChangeColorGreen() => BoxView = Color.FromHex(Colors.Green);
        void ChangeColorWisteria() => BoxView = Color.FromHex(Colors.Wisteria);
        void ChangeColorClouds() => BoxView = Color.FromHex(Colors.Clouds);
        void ChangeColorAsbestos() => BoxView = Color.FromHex(Colors.Asbestos);





    }
}
