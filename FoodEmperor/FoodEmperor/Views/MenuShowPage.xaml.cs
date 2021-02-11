using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodEmperor.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuShowPage : ContentPage
	{
		public MenuShowPage ()
		{
			InitializeComponent ();
		}
        private async void Go_to_Menu_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
        private async void Go_to_MenuShow_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuShowPage());
        }

    }
}