using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp1.Annotations;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class ImageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Image> _images;
        private Image _currentImage;
        
        public ObservableCollection<Image> Images
        {
            get => _images;
            set
            {
                _images = value;
                OnPropertyChanged();
            } 
        }

        public Image CurrentImage
        {
            get => _currentImage;
            set
            {
                _currentImage = value; 
                OnPropertyChanged();
            }
        }

        public ImageViewModel()
        {
            // create image array
            Images = new ObservableCollection<Image>();
            CurrentImage = null;
        }

        public void AddImageToImages(string filePathToNewImage)
        {
            Image newImage = new Image(filePathToNewImage);
            Images.Add(newImage);
            CurrentImage = newImage;
        }

        public void RemoveImageFromImages(int index)
        {
            // crappy logic to set current image when deleting
            if (index != -1)
            {
                if (_images[index] == _currentImage)
                {
                    if (_images.Count >= 2)
                    {
                        CurrentImage = _images[0];
                    }
                    else
                    {
                        CurrentImage = null;
                    }
                }
                Images.Remove(_images[index]);
            }
        }

        public void SetCurrentImage(int index)
        {
            CurrentImage = Images[index];
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}