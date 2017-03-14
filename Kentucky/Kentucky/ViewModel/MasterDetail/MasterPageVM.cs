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
        public ObservableCollection<MasterPageItem> ItensMasterPage { get; set; }

        public MasterPageVM()
        {
            ItensMasterPage = new ObservableCollection<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Descobrir",
                    TargetType = typeof(Principal)
                },

                new MasterPageItem
                {
                    Title = "Nova Descoberta",
                    TargetType = typeof(NovaDescoberta)
                },

                new MasterPageItem
                {
                    Title = "Sobre",
                    TargetType = typeof(Sobre)
                },

                new MasterPageItem
                {
                    Title = "Sair",
                    TargetType = typeof(Inicio)
                }
            };
        }
    }
}
