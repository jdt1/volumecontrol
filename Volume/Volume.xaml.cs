using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;

namespace PhoneApp1

{
    public partial class MainPage : PhoneApplicationPage{
        public string harder  = "http://192.168.0.5/?status=harder";
        public string zachter = "http://192.168.0.5/?status=zachter";
        public string random = "";
        public static Random rnd = new Random();
        
        public MainPage(){
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e){
           InitializeComponent();
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri(harder + random));
            random = "";
            for(int l = 0; l < rnd.Next(1,500);l++){
                random = random + "?";   
            } 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri(zachter + random));
            random = "";
            for (int l = 0; l < rnd.Next(1, 500); l++)
            {
                random = random + "?";
            }
        }       
    }   
}