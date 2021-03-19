using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using WpfApp1.Annotations;

namespace WpfApp1.Models
{
    public class Image : INotifyPropertyChanged
    {
        private string _filePath;
        private BitmapImage _bmpImage;

        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        public BitmapImage BmpImage
        {
            get => _bmpImage;
            set => _bmpImage = value;
        }

        public Image(string filePath)
        {
            FilePath = filePath;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filePath);
            bitmap.EndInit();
            BmpImage = bitmap;

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}