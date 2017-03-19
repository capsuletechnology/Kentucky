using Kentucky.Helper;
using Kentucky.Model;
using Kentucky.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Kentucky.ViewModel.MasterDetail
{
    public class MasterPageVM : ViewModelBase
    {
        public ObservableCollection<MPItem> ItensMasterPage { get; set; }

        public MasterPageVM()
        {
            ItensMasterPage = new ObservableCollection<MPItem>
            {
                new MPItem
                {
                    Title = "Descobrir",
                    TargetType = typeof(Main)
                },

                new MPItem
                {
                    Title = "Nova Descoberta",
                    TargetType = typeof(NewDiscovery)
                },

                new MPItem
                {
                    Title = "Sobre",
                    TargetType = typeof(About)
                },

                new MPItem
                {
                    Title = "Sair",
                    TargetType = typeof(Start)
                }
            };
        }
    }
}
