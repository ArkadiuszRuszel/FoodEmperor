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
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private async void Go_to_Menu_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
        private async void Go_to_MenuShow_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuShowPage());
        }
        private async void Go_to_ContactPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage());
        }
        private async void Go_to_AccountPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountPage());
        }
        private async void Go_to_SearchPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }
        private async void Go_to_PromotionsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PromotionsPage());
        }

    }
}