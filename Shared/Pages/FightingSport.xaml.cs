using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppHW.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FightingSport : ContentPage
    {
        private List<DataF> ItemsF = new List<DataF>()
        {
            new DataF{Name="Karate", Detail="Karate means empty hand . This form of warfare originated on Japan's island of Okinawa. Karate is now generally a general term for all groups of Japanese martial arts. Karate handles offensive and defensive movements and avoids grappling and wrestling. Students are taught to strike fast and powerful blows almost anywhere in the body, including dangerous kicks with the legs. Karate also consists of hard and soft styles. Some schools teach  full contact  karate, where their students use protective equipment to soften the blows of real combat."
            , Fimage="SD"},



        };



        public FightingSport()
        {
            InitializeComponent();
          

        }
    }
}