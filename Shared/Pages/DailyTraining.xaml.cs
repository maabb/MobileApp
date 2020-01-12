using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppHW.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelfDefence : ContentPage { 
   private ObservableCollection<Data> Items = new ObservableCollection<Data>()
        {
            new Data{Name="Meditation", Time="15 minutes" },
            new Data{Name="Yoga Exercises", Time="30 minutes" },
            new Data{Name="Running", Time="1 hours" },
            new Data{Name="PUSH UP", Time="25 times" },
            new Data{Name="Stretching exercises", Time="15 minutes" },




        };

        private ObservableCollection<Data> Items1 = new ObservableCollection<Data>()
        {
            new Data{Name="Saturday" }, 
            new Data{Name="Sunday" },
            new Data{Name="Monday" },
            new Data{Name="Tuesday" },
            new Data{Name="Wednesday" },
             new Data{Name="Thursday" },
            new Data{Name="Friday" },




        };

        public SelfDefence()
    {
        InitializeComponent();

        mylist.ItemsSource = Items;
          
            mylist2.ItemsSource = Items1;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Data recipe = (Data)item.BindingContext;
            Items.Remove(recipe);
        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Advance Level", "If you are an advanced trainee follow that:" +
                Environment.NewLine + "Meditation          :30 minutes"+
                Environment.NewLine + "Yoga Exercises      :1 hours" +
                Environment.NewLine + "Running Exercises   :2 hours" +
                Environment.NewLine + "PUSH UP             :70 times" +
                Environment.NewLine + "Stretching exercises:30 minutes" +
                Environment.NewLine +""   , "OK");
        }
    }
}