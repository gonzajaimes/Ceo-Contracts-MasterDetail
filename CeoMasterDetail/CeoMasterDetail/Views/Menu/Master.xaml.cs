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

      public Master ()
		{
			InitializeComponent ();
           
		}
       
               
    }
}