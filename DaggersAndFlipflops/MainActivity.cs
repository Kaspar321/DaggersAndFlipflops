﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace DaggersAndFlipflops
{
    [Activity(Label = "DaggersAndFlipflops", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            // kui loed oled gay
            SetContentView(Resource.Layout.Main);
        }
    }
}

