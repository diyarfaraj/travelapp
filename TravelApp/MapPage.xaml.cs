using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelApp

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           // GetLocation();
        }

        private async void GetLocation()
        {
           var status = await CheckAndRequestLocation();
           if (status == PermissionStatus.Granted)
           {
               var location = await Geolocation.GetLocationAsync();
               
           }
        }

        private async Task<PermissionStatus>  CheckAndRequestLocation()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            if (status == PermissionStatus.Granted)
            {
                return status;
            }

            status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

            return status;

        }
    }
}