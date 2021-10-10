using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SIPVS_projekt1
{
    
    class Logic
    {
        private string FILE_NAME = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//output.xml";
        private string XSD_NAME = "order.xsd";
        private Objednavka objednavka;
        private XmlSerializer serializer;
        private XmlSerializerNamespaces namespaces;

        public Logic()
        {
            objednavka = new Objednavka();
            serializer = new XmlSerializer(objednavka.GetType());
            namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, "http://www.rent.movies.com/xml/order");
            
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
            serializer.Serialize(Console.Out, objednavka, namespaces);
            System.IO.FileStream file = System.IO.File.Create(FILE_NAME);
            serializer.Serialize(file, objednavka, namespaces);
            file.Close();
        }

        public void validate(string path)
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("http://www.rent.movies.com/xml/order", XSD_NAME);
            XmlReader rd = XmlReader.Create(path);
            XDocument doc = XDocument.Load(rd);
            rd.Close();
            doc.Validate(schema, ValidationEventHandler);
   
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(e.Message);
                
            }
        }

    }
}
