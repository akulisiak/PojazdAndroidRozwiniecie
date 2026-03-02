using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.Fragment.App;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PojazdAndroidRozwiniecie.Model;

namespace PojazdAndroidRozwiniecie
{
    public class FragmentAutoForm : Fragment
    {
        EditText markaSamochoduText;
        EditText rocznikSamochoduText;
        EditText liczbaDrzwiSamochoduText;

        Button zapiszButton;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragment_auto, container, false);
            markaSamochoduText = view.FindViewById<EditText>(Resource.Id.editText1);
            rocznikSamochoduText = view.FindViewById<EditText>(Resource.Id.editText2);
            liczbaDrzwiSamochoduText = view.FindViewById<EditText>(Resource.Id.editText3);
            zapiszButton = view.FindViewById<Button>(Resource.Id.button1);
            zapiszButton.Click += ZapiszButton_Click;
            return view;
            //return base.OnCreateView(inflater, container, savedInstanceState);
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            string marka = markaSamochoduText.Text;
            ushort rocznik = ushort.Parse(rocznikSamochoduText.Text);
            int liczbaDrzwi = int.Parse(liczbaDrzwiSamochoduText.Text);
            BazaPojazdow.listPojazdow.Add(new Samochod(liczbaDrzwi, rocznik, marka));
            Activity.Finish();

        }
    }
}