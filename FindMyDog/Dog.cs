using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FindMyDog
{
    public class Dog : ObservableObject, INotifyPropertyChanged
    {
        private string _name;
        private string _groupName;
        private string _height;
        private string _weight;
        private string _lifeSpan;
        private string _coverImage;
        private string _info;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }


        public string GroupName
        {
            get { return _groupName; }
            set { SetProperty(ref _groupName, value); }
        }


        public string Height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }


        public string Weight
        {
            get { return _weight; }
            set { SetProperty(ref _weight, value); }
        }


        public string LifeSpan
        {
            get { return _lifeSpan; }
            set { SetProperty(ref _lifeSpan, value); }
        }


        public string CoverImage
        {
            get { return _coverImage; }
            set { SetProperty(ref _coverImage, value); }
        }


        public string Info
        {
            get { return _info; }
            set { SetProperty(ref _info, value); }
        }
    }
}
