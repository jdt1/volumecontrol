using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Volume.Resources;


namespace Volume
{
    public partial class MainPage : PhoneApplicationPage
    {
        public string harder = "http://192.168.0.5/?status=harder";
        public string zachter = "http://192.168.0.5/?status=zachter";
        public string nogharder = "http://192.168.0.5/?status=nogharder";
        public string nogzachter = "http://192.168.0.5/?status=nogzachter";
        public static Random rnd = new Random();
        
        public MainPage()
        {
            InitializeComponent();
        }

        // harder
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri(harder + random()));
        }

        // zachter
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri(zachter + random()));
        }

        // veel harder
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri(nogharder + random()));
        }

        // veel zachter
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri(nogzachter + random()));            
        }

        public static string random()
        {
            String result = "";
            for (int l = 0; l < rnd.Next(1, 500); l++)
            {
                result += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ?"[rnd.Next(0, 52)];
            }
            return result;
        }

     }
}