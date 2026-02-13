using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PojazdAndroidRozwiniecie
{
    [Activity(Label = "EditMotocyklActivity")]
    public class EditMotocyklActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_edit_motocykl);
            // Create your application here
        }
    }
}