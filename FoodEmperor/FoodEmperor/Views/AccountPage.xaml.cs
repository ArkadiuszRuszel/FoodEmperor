using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodEmperor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
        }
        private async void Go_to_MenuShow_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuShowPage());
        }
        private async void Go_to_AccountDetailsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountDetailsPage());
        }
    }
}