using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using WpfApp1.ViewModels;
using Image = WpfApp1.Models.Image;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageViewModel _viewModel;
        
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ImageViewModel();
            DataContext = _viewModel;
        }

        private void AddImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                _viewModel.AddImageToImages(filename);
            }
        }
        
        private void ClickListItem(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                _viewModel.CurrentImage = item as Image;
            }
        }

        private void ClickToRemove_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.RemoveImageFromImages(ImagesListView.Items.IndexOf(ImagesListView.SelectedItem));
        }
    }
}