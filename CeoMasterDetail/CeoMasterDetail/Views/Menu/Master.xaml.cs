using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CeoMasterDetail.Models;
using CeoMasterDetail.ViewModels;
using CeoMasterDetail.Views.DetailViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CeoMasterDetail.Views.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public ListView ListView
        {
            get
            {
                return ClientesListView;
            }

        }

        //      public List<MasterMenuItem> items;

        public Master ()
		{
			InitializeComponent ();
           // SetItems();
		}
       

        //void SetItems ()
        //{
        //    items = new List<MasterMenuItem>
        //    {
        //        new MasterMenuItem("Primera", "icon.png", Color.White, typeof(Primera)),
        //        new MasterMenuItem("Segunda", "icon.png", Color.White, typeof(Segunda))
        //    };
        //    ListView.ItemsSource = items;
        //}
    }
}