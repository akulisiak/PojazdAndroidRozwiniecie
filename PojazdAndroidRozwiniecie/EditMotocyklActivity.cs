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
    [Activity(Label = "EditMotocyklActivity")]
    public class EditMotocyklActivity : Activity
    {
        EditText markaText;
        EditText rocznikText;
        CheckBox czyZabytkowyCheckBox;
        Button zapiszButton;
        int id;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_edit_motocykl);
            // Create your application here
            id = Intent.GetIntExtra("id", 0);
            markaText = FindViewById<EditText>(Resource.Id.editText1);
            rocznikText = FindViewById<EditText>(Resource.Id.editText2);
            czyZabytkowyCheckBox = FindViewById<CheckBox>(Resource.Id.checkBox1);
            zapiszButton = FindViewById<Button>(Resource.Id.button1);
            zapiszButton.Click += ZapiszButton_Click;

            markaText.Text = ((Motocykl)BazaPojazdow.listPojazdow[id]).marka;
            rocznikText.Text = ((Motocykl)BazaPojazdow.listPojazdow[id]).rokProdukcji.ToString();
            Motocykl m = (Motocykl)BazaPojazdow.listPojazdow[id];
            if (m.czyZabytkowy == true)
            {
                czyZabytkowyCheckBox.Checked = true;
            }
            else
            {
                czyZabytkowyCheckBox.Checked = false;
            }
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            Motocykl m = (Motocykl)BazaPojazdow.listPojazdow[id];
            m.marka = markaText.Text;
            m.rokProdukcji = ushort.Parse(rocznikText.Text);
            m.czyZabytkowy = czyZabytkowyCheckBox.Checked;
            BazaPojazdow.listPojazdow[id] = m;
            Finish();
        }
    }
}
