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
    public partial class Equipments : ContentPage
    {

        private List<Data> Items3 = new List<Data>()
        {
            new Data{Name="Boxing bag", Detail="For Boxing Courses (Improve your strenght )", Fimage="boxing.jfif" },
              new Data{Name="SQUAT RACK", Detail="Increase resistance by many muscles activities groups", Fimage="eq1.png" },

               new Data{Name="BARBELLS", Detail="For train rain shoulder muscles", Fimage="eq2.png" },
              new Data{Name="BENCH PRESS", Detail="Actively train the whole body.", Fimage="eq3.png" },
               new Data{Name="INCLINE BENCH PRESS", Detail="Improve chest muscles strength", Fimage="eq4.png" },
                new Data{Name="DUMBBELLS", Detail="For improve muscles strength", Fimage="eq5.png" },
            new Data{Name="LEG EXTENSION MACHINE", Detail="tarin leg muscles.", Fimage="eq6.jfif" },
              new Data{Name="HYPER EXTENSION BENCH", Detail="Maintain muscle flexibility", Fimage="eq7.png" },
              new Data{Name="FOAM ROLLER", Detail="run shoulder muscles", Fimage="eq8.png" },
              new Data{Name="KETTLEBELLS", Detail="to operate all parts of the body and increase endurance", Fimage="eq9.png" },
               new Data{Name="INDOOR CYCLE BIKE", Detail="strength enhancement and weight loss,The number of calories burned per course can range from 400 to 600.", Fimage="kttlebell.png" },
                new Data{Name="PECK DECK MACHINE", Detail="Improves chest muscles", Fimage="eq11.png" },
                 new Data{Name="Pilates ball", Detail="Used to strengthen our body and form", Fimage="top.png" },
        };

        
        public Equipments()
        {
            InitializeComponent();
            mylist3.ItemsSource = Items3;
          
           
        }

        private void mylist3_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("", "For Join to us and more information :"
                + Environment.NewLine +"This equipments belong to fitness and pitlies courses"
                + Environment.NewLine + "Call us on: 55-786443"
                + Environment.NewLine +"Or visit our website: www.SportWorld.com", "OK");
        }
    }
}