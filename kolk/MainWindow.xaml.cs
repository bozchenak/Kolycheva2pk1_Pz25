﻿using System;
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

namespace kolk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "7";
        }
        private void press8Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "8";
        }
        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "9";
        }
        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "4";
        }
        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "5";
        }
        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "6";
        }
        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "1";
        }
        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "2";
        }
        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "3";
        }
        private void press0Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "0";
        }
        private void press10Button_Click(object sender, RoutedEventArgs e) //сложение
        {
            infoTextBlock.Text += "+";
        }
        private void press11Button_Click(object sender, RoutedEventArgs e) //сложение
        {
            infoTextBlock.Text += "-";
        }
        private void press12Button_Click(object sender, RoutedEventArgs e) //сложение
        {
            infoTextBlock.Text += "*";
        }
        private void press14Button_Click(object sender, RoutedEventArgs e) //сложение
        {
            infoTextBlock.Text += "/";
        }
        private void press13Button_Click(object sender, RoutedEventArgs e) //сложение
        {

        }
        

    }
}
