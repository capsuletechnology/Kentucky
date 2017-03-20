using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentucky.ViewModel
{
    public class MainVM : Helper.ViewModelBase
    {
        Helper.Repository _repository;
        private string rating;
        public string Rating { get { return rating; } set { rating = value; OnPropertyChanged(); } }

        public MainVM()
        {
            _repository = new Helper.Repository();
            Rating = string.Format("{0:0.0}",_repository.RatingPost(21, 5, 7));
            

        }
    }
}
