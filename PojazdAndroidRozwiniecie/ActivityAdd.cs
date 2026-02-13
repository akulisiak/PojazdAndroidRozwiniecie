using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PojazdAndroidRozwiniecie.Model;
using PojazdAndroidRozwiniecie.Model;
using PojazdAndroidRozwiniecie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PojazdAndroid
{
    [Activity(Label = "Activity1")]
    public class AddActivity : Activity
    {
        RadioButton samochodRadioButton;
        RadioButton motocyklRadioButton;

        LinearLayout samochodLinearLayout;
        LinearLayout motocyklLinearLayout;

        EditText markaSamochoduText;
        EditText rocznikSamochoduText;
        EditText liczbaDrzwiSamochoduText;

        EditText markaMotocykluText;
        EditText rocznikMotocykluText;
        CheckBox czyZabytkowy;

        Button zapiszButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add);

            samochodLinearLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout3);
            motocyklLinearLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout4);

            samochodRadioButton = FindViewById<RadioButton>(Resource.Id.radioButton1);
            samochodRadioButton.Click += SamochodRadioButton_Click;

            motocyklRadioButton = FindViewById<RadioButton>(Resource.Id.radioButton2);
            motocyklRadioButton.Click += MotocyklRadioButton_Click;

            markaSamochoduText = FindViewById<EditText>(Resource.Id.editText1);
            rocznikSamochoduText = FindViewById<EditText>(Resource.Id.editText2);
            liczbaDrzwiSamochoduText = FindViewById<EditText>(Resource.Id.editText3);

            markaMotocykluText = FindViewById<EditText>(Resource.Id.editText4);
            rocznikMotocykluText = FindViewById<EditText>(Resource.Id.editText5);
            czyZabytkowy = FindViewById<CheckBox>(Resource.Id.checkBox1);

            zapiszButton = FindViewById<Button>(Resource.Id.button1);
            zapiszButton.Click += ZapiszButton_Click;
        }

        private void SamochodRadioButton_Click(object sender, EventArgs e)
        {
            motocyklLinearLayout.Visibility = ViewStates.Gone;
            samochodLinearLayout.Visibility = ViewStates.Visible;
        }

        private void MotocyklRadioButton_Click(object sender, EventArgs e)
        {
            samochodLinearLayout.Visibility = ViewStates.Gone;
            motocyklLinearLayout.Visibility = ViewStates.Visible;
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            if (samochodRadioButton.Checked)
            {
                string marka = markaSamochoduText.Text;
                ushort rocznik = ushort.Parse(rocznikSamochoduText.Text);
                int liczbaDrzwi = int.Parse(liczbaDrzwiSamochoduText.Text);
                BazaPojazdow.listaPojazdow.Add(new Samochod(liczbaDrzwi, marka, rocznik));
            }
            else
            {
                string marka = markaMotocykluText.Text;
                ushort rocznik = ushort.Parse(rocznikMotocykluText.Text);
                bool czyZabytkowy = this.czyZabytkowy.Checked;
                BazaPojazdow.listaPojazdow.Add(new Motocykl(czyZabytkowy, marka, rocznik));
            }
            Finish();
        }
    }
}