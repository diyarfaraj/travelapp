using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_OnClicked(object sender, EventArgs e)
        {
            bool email = !string.IsNullOrEmpty(emailEntry.Text);
            bool password = !string.IsNullOrEmpty(passwordEntry.Text );

            if (!email || !password)
            {
                //do not navigate
            }
            else
            {
                Navigation.PushAsync(new HomePage());

            }

        }
    }
}