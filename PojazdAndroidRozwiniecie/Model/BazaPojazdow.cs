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

namespace PojazdAndroidRozwiniecie.Model
{
    internal static class BazaPojazdow
    {
        public static List<Pojazd> listPojazdow = new List<Pojazd>
        {
            new Samochod(5, 2025, "Audi", 500.0),
            new Samochod(3, 2018, "Peugeot"),
            new Samochod(5, 2020, "Kia"),
            new Motocykl(false, "Honda", 2019),
            new Motocykl(true, "WSK", 1980),
            new Motocykl(false, "Honda", 2010)
        };
    }
}