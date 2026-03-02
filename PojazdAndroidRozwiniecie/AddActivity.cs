using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PojazdAndroidRozwiniecie.Model;
using PojazdAndroidRozwiniecie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.Fragment.App;
using Google.Android.Material.BottomNavigation;

namespace PojazdAndroid
{
    [Activity(Label = "Activity1")]
    public class AddActivity : FragmentActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add);
            LoadFragment(new FragmentAutoForm());
            BottomNavigationView nav = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView1);
            nav.NavigationItemSelected += Nav_NavigationItemSelected;
        }

        private void Nav_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            int id = e.Item.ItemId;
            if (id == Resource.Id.auto_item)
            {
                LoadFragment(new FragmentAutoForm());
            }
            else
            {
                LoadFragment(new FragmentMotoForm());
            }
        }

        private void LoadFragment(AndroidX.Fragment.App.Fragment fragment)
        {
            var transaction = SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frameLayout1, fragment);
            transaction.Commit();
        }
    }
}