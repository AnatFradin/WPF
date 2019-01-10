using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Hello 1st WPF application";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void MainWindow_OnMouseMove(object sender, MouseEventArgs e)
        {
            // this -> is the mouth
            Title = e.GetPosition(this).ToString();
        }

        private void CLoseButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Close application");
            this.Close();
        }

        private void Open_File_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.ShowDialog();
        }

        private void Save_File_OnClick_File_OnClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.ShowDialog();
        }

        private void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
       //     MessageBox.Show($"Hello <{nameTextBlock.Text}>");
        }

        private void SayHalloBTN_OnClick(object sender, RoutedEventArgs e)
        {
       //     MessageBox.Show($"Well... Hello <{UsersName.Text}>");
        }

        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bye Bye");
            this.Close();
        }

        private void Button7_OnClick(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }
    }
}
