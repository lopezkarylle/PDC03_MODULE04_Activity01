﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03MODULE04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenActivity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity01());
        }
        private async void OpenActivity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity02());
        }
    }
}
