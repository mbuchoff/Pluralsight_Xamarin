﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace BethanysPieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private string value;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button myButton = FindViewById<Button>(Resource.Id.MyButton);
            myButton.Click += MyButton_Click;

        }

        private void MyButton_Click(object sender, System.EventArgs e)
        {
            var toast = Toast.MakeText(this, "A button was clicked", ToastLength.Short);
            toast.Show();

            var intent = new Intent(this, typeof(SecondActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnPause()
        {
            base.OnPause();
            value = "OnPause";

        }

        protected override void OnStart()
        {
            base.OnStart();
            value = "OnStart";


        }

        protected override void OnResume()
        {
            base.OnResume();
            value = "OnResume";

        }
    }
}