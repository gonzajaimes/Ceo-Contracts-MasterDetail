using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CeoMasterDetail.Models;
using Xamarin.Forms;

namespace CeoMasterDetail.Views.Menu
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            masterpage.ListView.ItemSelected += OnItemSelected;

        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var cliente = e.SelectedItem as MenuEmpresa;
            if (cliente != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Detail)));
                masterpage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
        //private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var cliente = ClientesListView.SelectedItem as MenuEmpresa;

        //    if (cliente != null)
        //    {
        //        var mainViewModel = BindingContext as MainViewModel;
        //        if (mainViewModel != null)
        //        {
        //            mainViewModel.SelectedMenuEmpresa = cliente;
        //            this.dDetail = new NavigationPage((Page)Activator.CreateInstance(typeof(Primera)));

        //            //await Navigation.PushAsync(new NewEmployeePage(mainViewModel));
        //        }
        //    }
        //}

    }
}
