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
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }
        private async void Find_Us(object sennder, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if(location == null) 
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    { 
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                        });
                }
                if (location == null)
                    LocationLabel.Text = "Brak zasięgu GPS";
                else
                    LocationLabel.Text = $"{location.Latitude} {location.Longitude}";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Coś poszło nie tak: {ex.Message}");
            }
        }
    }
}