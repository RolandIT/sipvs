using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SIPVS_projekt1
{
    
    class Logic
    {
        private string FILE_NAME = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//output.xml";
        private Objednavka objednavka;
        private XmlSerializer serializer;

        public Logic()
        {
            objednavka = new Objednavka();
            serializer = new XmlSerializer(objednavka.GetType());
        }

        internal Objednavka Objednavka { get => objednavka; set => objednavka = value; }

        public void addMovie(string nazov, int dni)
        {
            objednavka.addMovie(nazov, dni);
        }
        public void removeMovie(int index)
        {
            objednavka.removeMovie(index);
        }
        public void setOrderDate(DateTime date)
        {
            objednavka.datum = date;
        }

        public void setCustomer(string name, string surname, bool has_coupon, string coupon_number)
        {
            objednavka.setCustomer(name, surname, has_coupon, has_coupon ? coupon_number : "");
        }
        public void saveXML()
        {
            serializer.Serialize(Console.Out, objednavka);
            System.IO.FileStream file = System.IO.File.Create(FILE_NAME);
            serializer.Serialize(file, objednavka);
            file.Close();
        }
    }
}
