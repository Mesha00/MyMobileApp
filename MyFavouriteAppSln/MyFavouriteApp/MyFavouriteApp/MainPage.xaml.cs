using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFavouriteApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(3000);
            var whatsappPage = new WhatsAppPage();
            whatsappPage.BackgroundColor = Color.White;
            await Navigation.PushAsync(whatsappPage);


            //var navPage = new NavigationPage(new MainPage());
            //navPage.BarBackgroundColor = Color.White;
            //MainPage = navPage;



        }
    }
}
