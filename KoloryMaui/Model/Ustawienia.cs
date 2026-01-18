using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Linq;

namespace KoloryMaui.Model
{
    internal static class Ustawienia
    {
   
        private static string ścieżkaPliku = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"kolory.xml");
        private static IFormatProvider formatProvider = CultureInfo.InvariantCulture;

        public static void Zapisz (this Kolor kolor)
        {
            XDocument xml = new XDocument(
                new XComment($"Zapisano: {DateTime.Now}"),
                new XElement("ustawienia",
                    new XElement("r", kolor.R.ToString(formatProvider)),
                    new XElement("g", kolor.G.ToString(formatProvider)),
                    new XElement("b", kolor.B.ToString(formatProvider))
                )
            );
            xml.Save(ścieżkaPliku);
        }
        public static Kolor Czytaj()
        {
            if (!File.Exists(ścieżkaPliku))
            {
                return Kolor.Czarny;
            }
            try
            {               
                XDocument xml = XDocument.Load(ścieżkaPliku);
                double r = double.Parse(xml.Root.Element("r").Value, formatProvider);
                double g = double.Parse(xml.Root.Element("g").Value, formatProvider);
                double b = double.Parse(xml.Root.Element("b").Value, formatProvider);
                return new Kolor(r, g, b);  
            }
            catch
            {
                return Kolor.Czarny;

            }
        }
    }
}
