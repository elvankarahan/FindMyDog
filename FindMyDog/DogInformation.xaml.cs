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
    public partial class DogInformation : ContentPage
    {
        public DogInformation(String tag, String GroupName, String Height, String Weight, String LifeSpan, String CoverImage, String Info)
        {
            InitializeComponent();
            this.FindByName<Label>("GroupName").Text = GroupName;
            this.FindByName<Label>("Height").Text = Height;
            this.FindByName<Label>("Weight").Text = Weight;
            this.FindByName<Label>("LifeSpan").Text = LifeSpan;
            this.FindByName<Image>("DogImage").Source = CoverImage;
            this.FindByName<Label>("DogInfo").Text = Info;
            this.FindByName<Label>("DogName").Text = tag;
        }
    }
}