using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppHW.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SportLife : ContentPage
    {
        public SportLife()
        {
            InitializeComponent();
            var call = CrossMessaging.Current.PhoneDialer;
            lgbtn1.Clicked += (s, e) => Navigation.PushAsync(new Pages.DietP1());
            lgbtn2.Clicked += (s, e) => Navigation.PushAsync(new Pages.Equipments());
            btn.Clicked += OnCall;

            async void OnCall(object sender, System.EventArgs e)
            {
                if (await this.DisplayAlert(
                    "Dial a Number",
                    "Would you like to call " ,
                    "Yes",
                    "No"))
                {
                    if (call.CanMakePhoneCall)
                        call.MakePhoneCall("55-786443");
                }

            }
        }
    }
}