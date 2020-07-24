using Humanizer;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xam.Plugins.OnDeviceCustomVision;
using Xamarin.Forms;

namespace FindMyDog
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            TakePhotoCommand = new Command(async () => await TakePhoto());
            PickPhotoCommand = new Command(async () => await PickPhoto());

        }

        private async Task TakePhoto()
        {
            Image = null;
            Tag = " ";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));

            try
            {
                _photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions { PhotoSize = PhotoSize.Medium });
                Image = ImageSource.FromStream(() => _photo.GetStream());


                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));

                var classifications = await CrossImageClassifier.Current.ClassifyImage(_photo.GetStream());
                Tag = classifications.OrderByDescending(c => c.Probability).First().Tag.Humanize();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tag)));
            }
            catch (Exception) { }

        }

        private async Task PickPhoto()
        {
            Image = null;
            Tag = " ";

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));

            try
            {
                _photo = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions { PhotoSize = PhotoSize.Medium });
                Image = ImageSource.FromStream(() => _photo.GetStream());


                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));

                var classifications = await CrossImageClassifier.Current.ClassifyImage(_photo.GetStream());
                Tag = classifications.OrderByDescending(c => c.Probability).First().Tag.Humanize();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tag)));
            }
            catch (Exception) { }
        }

        private MediaFile _photo;
        public ImageSource Image { get; private set; }
        public string Tag { get; private set; }
        public ICommand TakePhotoCommand { get; }
        public ICommand PickPhotoCommand { get; }
    }
}
