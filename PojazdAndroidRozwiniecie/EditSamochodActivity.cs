using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PojazdAndroidRozwiniecie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PojazdAndroidRozwiniecie
{
    [Activity(Label = "EditSamochodActivity")]
    public class EditSamochodActivity : Activity
    {
        EditText markaText;
        EditText rocznikText;
        EditText liczbaDrzwiText;
        Button zapiszButton;
        int id;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_edit_samochod);
            // Create your application here
            id = Intent.GetIntExtra("id", 0);
            markaText = FindViewById<EditText>(Resource.Id.editText1);
            rocznikText = FindViewById<EditText>(Resource.Id.editText2); 
            liczbaDrzwiText = FindViewById<EditText>(Resource.Id.editText3);
            zapiszButton = FindViewById<Button>(Resource.Id.button1);
            zapiszButton.Click += ZapiszButton_Click;

            markaText.Text = ((Samochod)BazaPojazdow.listPojazdow[id]).marka;
            rocznikText.Text = ((Samochod)BazaPojazdow.listPojazdow[id]).rokProdukcji.ToString();
            liczbaDrzwiText.Text = ((Samochod)BazaPojazdow.listPojazdow[id]).liczbaDrzwi.ToString();
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            Samochod s = (Samochod)BazaPojazdow.listPojazdow[id];
            s.marka = markaText.Text;
            s.rokProdukcji = ushort.Parse(rocznikText.Text);
            s.liczbaDrzwi = int.Parse(liczbaDrzwiText.Text);
            Finish();
        }
    }
}