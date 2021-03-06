﻿using Kentucky.Helper;
using Kentucky.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Kentucky.View.MasterDetail
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MPItem;
            if (item != null)
            {
                if (item.TargetType.Name.Equals("Start"))
                    Application.Current.MainPage = new NavigationPage(new Start());
                else
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                    masterPage.ListView.SelectedItem = null;
                    IsPresented = false;
                }
            }
        }
    }
}
