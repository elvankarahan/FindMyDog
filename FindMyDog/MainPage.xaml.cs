using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FindMyDog
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static int count = 0;


        public MainPage()
        {
            InitializeComponent();
            DogsViewModel doggg = new DogsViewModel();

            //GlobalVariables.dict.Add("Beagle", ("Hound Dogs", "33 - 41 cm", "9 - 11 kg", "10 - 15 Years", "Beagle.jpg", "Small, compact, and hardy, Beagles are active companions for kids and adults alike. Canines in this dog breed are merry and fun loving, but being hounds, they can also be stubborn and require patient, creative training techniques. Their noses guide them through life, and they’re never happier than when following an interesting scent. The Beagle originally was bred as a scenthound to track small game, mostly rabbits and hare. He is still used for this purpose in many countries, including the United States Its difficult to resist the appeal of a Beagles dark brown or hazel eyes, with his soft, pleading expression. They re happy, outgoing and loving — characteristics more than balanced out by their hound nature, which is inquisitive, determined, and focused on food. They aren t yappy dogs, but they do have three distinct vocalizations — a bark/growl, a baying howl, and a half-baying howl  a cross between a frantic bark and a bay. The half-howl vocalization usually is reserved for when they catch sight of quarry — or think it s time to wake the neighbors at 6 a.m.! Being pack dogs, they generally get along well with other animals and their human friends — and they think everyone is their new best friend. The most important thing to know about the Beagle is that he is a scenthound. His nose is the most important part of his anatomy and his head is always down to the ground, searching for an interesting trail to follow.Beagles have approximately 220 million scent receptors compared to the paltry 5 million or so in people, which makes them very good at picking up scents.Humorist Dave Barry once described his in-laws  Beagle as  a nose with feet. You may have seen the Beagle s nose at work at airports across the country. In 1984, the U.S. Department of Agriculture decided to use Beagles to sniff out contraband food being brought into the United States at the Los Angeles International Airport. The experiment was a huge success.Because they are small, friendly, and cute, the Beagles didn t intimidate people who are afraid of dogs, and with their super nose power, they could be trained to identify specific food articles while bypassing those that weren t contraband.Today, members of the  Beagle Brigade  patrol the baggage - claim areas at more than 20 international airports and other points of entry into the United States. Although they ve branched out into other fields of work, Beagles remain superb hunters of small game. The National Beagle Club s Institute Farm hosts AKC - sanctioned field trials where breeders with packs are put to the test in the field.Many other countries have similar activities for hunting Beagles. Because of their small size and gentle temperament, Beagles can do well in apartments if their people are willing to walk them on lead several times a day in all kinds of weather. They need plenty of exercise, about an hour a day if possible.If left alone and unexercised, Beagles can become destructive."));

            //GlobalVariables.dict.Add("Norfolk terrier", ("Hound Dogs", "33 - 41 cm", "9 - 11 kg", "10 - 15 Years", "AfghanHound.jpg", "Small, compact, and hardy, Beagles are active companions for kids and adults alike. Canines in this dog breed are merry and fun loving, but being hounds, they can also be stubborn and require patient, creative training techniques. Their noses guide them through life, and they’re never happier than when following an interesting scent. The Beagle originally was bred as a scenthound to track small game, mostly rabbits and hare. He is still used for this purpose in many countries, including the United States Its difficult to resist the appeal of a Beagles dark brown or hazel eyes, with his soft, pleading expression. They re happy, outgoing and loving — characteristics more than balanced out by their hound nature, which is inquisitive, determined, and focused on food. They aren t yappy dogs, but they do have three distinct vocalizations — a bark/growl, a baying howl, and a half-baying howl  a cross between a frantic bark and a bay. The half-howl vocalization usually is reserved for when they catch sight of quarry — or think it s time to wake the neighbors at 6 a.m.! Being pack dogs, they generally get along well with other animals and their human friends — and they think everyone is their new best friend. The most important thing to know about the Beagle is that he is a scenthound. His nose is the most important part of his anatomy and his head is always down to the ground, searching for an interesting trail to follow.Beagles have approximately 220 million scent receptors compared to the paltry 5 million or so in people, which makes them very good at picking up scents.Humorist Dave Barry once described his in-laws  Beagle as  a nose with feet. You may have seen the Beagle s nose at work at airports across the country. In 1984, the U.S. Department of Agriculture decided to use Beagles to sniff out contraband food being brought into the United States at the Los Angeles International Airport. The experiment was a huge success.Because they are small, friendly, and cute, the Beagles didn t intimidate people who are afraid of dogs, and with their super nose power, they could be trained to identify specific food articles while bypassing those that weren t contraband.Today, members of the  Beagle Brigade  patrol the baggage - claim areas at more than 20 international airports and other points of entry into the United States. Although they ve branched out into other fields of work, Beagles remain superb hunters of small game. The National Beagle Club s Institute Farm hosts AKC - sanctioned field trials where breeders with packs are put to the test in the field.Many other countries have similar activities for hunting Beagles. Because of their small size and gentle temperament, Beagles can do well in apartments if their people are willing to walk them on lead several times a day in all kinds of weather. They need plenty of exercise, about an hour a day if possible.If left alone and unexercised, Beagles can become destructive."));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var tag = DogTag.Text;
            if (tag != null && tag != " ")
            {
                GlobalVariables.dict.TryGetValue(tag, out (string GroupName, string Height, string Weight, string LifeSpan, string CoverImage, string Info) pair);
                await App.Current.MainPage.Navigation.PushModalAsync(new DogInformation(tag, pair.GroupName, pair.Height, pair.Weight, pair.LifeSpan, pair.CoverImage, pair.Info), true);
            }
            else
            {
                string message = "Pick or Take a Photo!";
                string alright = "All Right Already!";
                DependencyService.Get<IMessage>().ShortAlert(message);
                count++;
                if (count > 4)
                {
                    DependencyService.Get<IMessage>().ShortAlert(alright);
                    count = 0;
                }
            }
        }

        private async void tempo_Clicked(object sender, EventArgs e)
        {

            await App.Current.MainPage.Navigation.PushModalAsync(new DogList());
        }
    }
}
