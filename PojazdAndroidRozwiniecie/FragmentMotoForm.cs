using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using AndroidX.Fragment.App;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PojazdAndroidRozwiniecie.Model;

namespace PojazdAndroidRozwiniecie
{
    public class FragmentMotoForm : Fragment
    {
        EditText markaMotocykluText;
        EditText rocznikMotocykluText;
        CheckBox czyZabytkowy;

        Button zapiszButton;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.fragment_motocykl, container, false);
            markaMotocykluText = view.FindViewById<EditText>(Resource.Id.editText1);
            rocznikMotocykluText = view.FindViewById<EditText>(Resource.Id.editText2);
            czyZabytkowy = view.FindViewById<CheckBox>(Resource.Id.checkBox1);
            zapiszButton = view.FindViewById<Button>(Resource.Id.button1);
            return view;

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            string marka = markaMotocykluText.Text;
            ushort rocznik = ushort.Parse(rocznikMotocykluText.Text);
            bool czyZabytkowy = this.czyZabytkowy.Checked;
            BazaPojazdow.listPojazdow.Add(new Motocykl(czyZabytkowy, marka, rocznik));
            Activity.Finish();

        }
    }
}