using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SIPVS_projekt1
{
    public class Zakaznik
    {
        public string meno;
        public string priezvisko;
        public bool ma_kupon;

        [XmlAttribute(DataType = "string", AttributeName = "cislo_kuponu")]
        public string cislo_kuponu;

        public Zakaznik(string meno, string priezvisko, bool maKupon, string cislo_kuponu)
        {
            this.meno = meno;
            this.priezvisko = priezvisko;
            this.ma_kupon = maKupon;
            this.cislo_kuponu = cislo_kuponu;
        }
        public Zakaznik()
        {
            this.meno = "Meno nevyplnene";
            this.priezvisko = "Priezvisko nevyplnene";
            this.ma_kupon = false;
            this.cislo_kuponu = "ziadny kupon";
        }
    }
    public class Film
    {
        public string nazov;
        public int dlzka_vypozicania;
        public Film(string nazov, int dlzka_vypozicania)
        {
            this.nazov = nazov;
            this.dlzka_vypozicania = dlzka_vypozicania;
        }
        public Film()
        {
            this.nazov = "Nazov nevyplneny";
            this.dlzka_vypozicania = -1;
        }
    }

    [XmlRoot("objednavka", Namespace = "http://www.rent.movies.com/xml/order")]
    public class Objednavka
    {
        [XmlElement(DataType = "date", ElementName = "datum")]
        public DateTime datum;
        public Zakaznik zakaznik;
        [XmlArray]
        [XmlArrayItem(typeof(Film), ElementName = "film")]
        public List<Film> filmy;

        public Objednavka()
        {
            this.filmy = new List<Film>();
        }

        [XmlIgnoreAttribute]
        public DateTime Datum { get => datum; set => datum = value; }

        public void addMovie(string nazov, int dni)
        {
            filmy.Add(new Film(nazov, dni));
        }
        public void removeMovie(int index)
        {
            filmy.RemoveAt(index);
        }
        public void setCustomer(string name, string surname, bool has_coupon, string coupon_number)
        {
            zakaznik = new Zakaznik(name, surname, has_coupon, coupon_number);
        }
    }
}
