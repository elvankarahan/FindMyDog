using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMyDog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogList : ContentPage
    {
        DogsViewModel dogg;
        public DogList()
        {
            InitializeComponent();
            dogg = new DogsViewModel();
            liste.ItemsSource = dogg.Dogs2;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                liste.ItemsSource = dogg.Dogs2;
            }

            else
            {
                liste.ItemsSource = dogg.Dogs2.Where(x => x.Name.StartsWith(e.NewTextValue) || x.GroupName.StartsWith(e.NewTextValue));
            }
        }

        private async void liste_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var x = e.Item as Dog;
            //await Navigation.PushAsync(new DogInformation(x.Name, x.GroupName, x.Height, x.Weight, x.LifeSpan, x.CoverImage, x.Info));
            //new NavigationPage(new DogInformation(x.Name, x.GroupName, x.Height, x.Weight, x.LifeSpan, x.CoverImage, x.Info));
            await Navigation.PushModalAsync(new DogInformation(x.Name, x.GroupName, x.Height, x.Weight, x.LifeSpan, x.CoverImage, x.Info));
        }
    }
}