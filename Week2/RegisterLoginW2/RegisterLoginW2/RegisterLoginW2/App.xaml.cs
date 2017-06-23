﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegisterLoginW2.View;

using Xamarin.Forms;

namespace RegisterLoginW2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new RegisterLoginW2.MainPage();
            MainPage = new RegisterFormView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
