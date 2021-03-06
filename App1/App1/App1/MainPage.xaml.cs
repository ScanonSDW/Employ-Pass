﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        async private void Intro_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new Introduction());
        }

        async private void Step_1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_1());
        }

        async private void Step_2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_2());
        }

        async private void Step_3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_3());
        }

        async private void Step_4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_4());
        }

        async private void Step_5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_5());
        }

        async private void Preping_a_CV_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_6());
        }

        async private void Application_Forms_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_7());
        }

        async private void Preparation_for_Interview_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Step_8());
        }

        async private void Employability_Skills_Framework_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Template());
        }
    }
}
