using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Ditec.Zep.DSigXades.Plugins;
using Ditec.Zep.DSigXades.Forms;
using Ditec.Zep.DSigXades;
using System.IO;

namespace SIPVS_projekt1
{
    
    class Logic
    {
        private string FILE_NAME = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//output.xml";
        private string XSD_NAME = "order.xsd";
        private string NAMESPACE_URI = @"http://www.rent.movies.com/xml/order";
        private string XSL_NAME = "generate_xml.xsl";
        private Objednavka objednavka;
        private XmlSerializer serializer;
        private XmlSerializerNamespaces namespaces;
        private string fileName;

        public Logic()
        {
            objednavka = new Objednavka();
            serializer = new XmlSerializer(objednavka.GetType());
            namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, NAMESPACE_URI);
            
        }

        internal Objednavka Objednavka { get => objednavka; set => objednavka = value; }

        public void setFileName(string s)
        {
            fileName = s;
        }

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

        public void validate()
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("http://www.rent.movies.com/xml/order", XSD_NAME);
            XmlReader rd = XmlReader.Create(fileName);
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

        public void generate()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(XSL_NAME);
            xslt.Transform(fileName, "html_output.html");
            System.Diagnostics.Process.Start("html_output.html"); 
        }

        public Boolean signDocument()
        {
            XmlPlugin xmlPlugin = new XmlPlugin();
            XadesSig dsig = new XadesSig();
            string xls_string = System.IO.File.ReadAllText(XSL_NAME);
            string xml_string = System.IO.File.ReadAllText(fileName);
            string xsd_string = System.IO.File.ReadAllText(XSD_NAME);

            xmlPlugin.CreateObject2("Objednavka", "Objednavka", xml_string, xsd_string, NAMESPACE_URI, "http://www.egov.sk/mvsr/NEV/datatypes/Zapis/Ext/PodanieZiadostiOPrihlasenieImporteromSoZepUI.1.0.xsd", xls_string, "http://www.example.com/xml/sb", "HTML");
            Console.WriteLine(xmlPlugin.ErrorMessage);
            if(dsig.AddObject(xmlPlugin.CreateObject2("Objednavka", "Objednavka", xml_string, xsd_string, NAMESPACE_URI, "http://www.egov.sk/mvsr/NEV/datatypes/Zapis/Ext/PodanieZiadostiOPrihlasenieImporteromSoZepUI.1.0.xsd", xls_string, "http://www.example.com/xml/sb", "HTML")) != 0)
            {
                Console.WriteLine(dsig.ErrorMessage);
            }
            if (dsig.AddObject(xmlPlugin.CreateObject2("Objednavka1", "Objednavka", xml_string, xsd_string, NAMESPACE_URI, "http://www.egov.sk/mvsr/NEV/datatypes/Zapis/Ext/PodanieZiadostiOPrihlasenieImporteromSoZepUI.1.0.xsd", xls_string, "http://www.example.com/xml/sb", "HTML")) != 0)
            {
                Console.WriteLine(dsig.ErrorMessage);
            }

            if (dsig.Sign("signatureId", null, "urn:oid:1.3.158.36061701.1.2.3") != 0)
            {
                Console.WriteLine(dsig.ErrorMessage);
                return false;
            }
            Console.WriteLine(dsig.SignedXmlWithEnvelope);
            File.WriteAllText("PodpisanaObjednavka.xades", dsig.SignedXmlWithEnvelope);
            return true;
        }

        public bool addTimestamp()
        {
            string signedDoc =File.ReadAllText(fileName);
            Encoding unicode = Encoding.Default;
            byte[] ts = unicode.GetBytes(signedDoc);
            sk.ditec.test.TS tsref = new sk.ditec.test.TS();
            string pizdec = tsref.GetTimestamp(Convert.ToBase64String(ts));
            byte[] data = Convert.FromBase64String(pizdec);
            //string decodedString = Encoding.Default.GetString(data);

            Org.BouncyCastle.Tsp.TimeStampResponse test2 = new Org.BouncyCastle.Tsp.TimeStampResponse(data);
            Console.WriteLine(test2.GetHashCode());
            //Console.WriteLine(pizdec);
            //XNamespace entryNamespace = "http://uri.etsi.org/01903/v1.3.2#";
            //XElement doc = XElement.Load(@"PodpisanaObjednavka.xml");


            signedDoc = signedDoc.Replace("</xades:QualifyingProperties>",
                "<xades:UnsignedProperties>" +
                    "<xades:UnsignedSignatureProperties>" +

                        "<xades:SignatureTimeStamp Id = "+ "\"" + test2.GetHashCode() +"\"" + ">" +

                            "<xades:EncapsulatedTimeStamp> " + pizdec + "</xades:EncapsulatedTimeStamp>" +

                        "</xades:SignatureTimeStamp>" +

                    "</xades:UnsignedSignatureProperties>" +

                "</xades:UnsignedProperties> </xades:QualifyingProperties>");


            //Console.WriteLine(doc.GetDefaultNamespace());
            //doc = (XElement)doc.Element(entryNamespace + "DataEnvelope");
            //Console.WriteLine(doc);
            /*doc.Add(new XElement(entryNamespace + "UnsignedSignatureProperties",
                    new XElement(entryNamespace + "SignatureTimeStamp",
                        new XAttribute("Id", "Signature20140325080345213SignatureTimeStamp")),
                    new XElement(entryNamespace + "EncapsulatedTimeStamp", test2.GetEncoded())
                    ));*/

            //Org.BouncyCastle.Tsp.TimeStampRequest test = new Org.BouncyCastle.Tsp.TimeStampRequest();

            File.WriteAllText("PodpisanaObjednavkaSCasovouPeciatkou.xades", signedDoc);
            File.WriteAllText("PodpisanaObjednavkaSCasovouPeciatkou.xml", signedDoc);

            return true;
        }
    }
}
