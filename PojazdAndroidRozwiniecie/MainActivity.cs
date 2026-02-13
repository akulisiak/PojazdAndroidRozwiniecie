using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using PojazdAndroidRozwiniecie.Model;
using PojazdAndroidRozwiniecie;
using System.Collections.Generic;
using PojazdAndroidRozwiniecie.Model;

namespace WypozyczalniaAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        List<string> listaNazw = new List<string>();
        ListView pojazdyListView;
        ImageButton addButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            pojazdyListView = FindViewById<ListView>(Resource.Id.listView1);
            addButton = FindViewById<ImageButton>(Resource.Id.imageButton1);
            foreach (Pojazd pojazd in BazaPojazdow.listPojazdow)
            {
                listaNazw.Add(pojazd.OpisShort());
            }
            pojazdyListView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, listaNazw);
            pojazdyListView.ItemLongClick += PojazdyListView_ItemLongClick;
            addButton.Click += AddButton_Click;
        }

        private void PojazdyListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            PopupMenu popup = new PopupMenu(this, e.View);
            popup.Inflate(Resource.Menu.context_menu);

            popup.MenuItemClick += (s, args) =>
            {
                if (args.Item.ItemId == Resource.Id.menu_delete)
                {
                    //implementacja usunięcia elemntu z listy
                    Toast.MakeText(this, "Usunięto", ToastLength.Short).Show();
                    //odświeżenie listy
                }
                else if (args.Item.ItemId == Resource.Id.menu_edit)
                {
                    //uruchomienie aktywności edytującej obiekt (należy przekazać id pojazdu)
                    //odświeżenie listy (OnResume())
                }
                else if (args.Item.ItemId == Resource.Id.menu_settings)
                {
                    //uruchomienie aktyności, która pozwala edytować koszt wynajmu aut i dodatkowe opłaty
                    //odświeżenie listy (OnResume())
                }
            };

            popup.Show();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AddActivity));
            StartActivity(intent);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}