﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContentPageLab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnPage1.Clicked += (s, e) =>
              {
                  //設定這個頁面的主要頁面來源
                  App.Current.MainPage = new Page1();
              };
            btnNaviPage1.Clicked += async (s, e) =>
              {
                  // 這裡會閃退，為什麼?
                  await Navigation.PushAsync(new Page1());
              };
        }
    }
}
