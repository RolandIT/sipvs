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
using System.Security.Cryptography.Xml;

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

            Org.BouncyCastle.Tsp.TimeStampResponse test2 = new Org.BouncyCastle.Tsp.TimeStampResponse(data);
            Console.WriteLine(test2.GetHashCode());

            signedDoc = signedDoc.Replace("</xades:QualifyingProperties>",
                "<xades:UnsignedProperties>" +
                    "<xades:UnsignedSignatureProperties>" +

                        "<xades:SignatureTimeStamp Id = "+ "\"" + test2.GetHashCode() +"\"" + ">" +

                            "<xades:EncapsulatedTimeStamp> " + pizdec + "</xades:EncapsulatedTimeStamp>" +

                        "</xades:SignatureTimeStamp>" +

                    "</xades:UnsignedSignatureProperties>" +

                "</xades:UnsignedProperties> </xades:QualifyingProperties>");

            File.WriteAllText("PodpisanaObjednavkaSCasovouPeciatkou.xades", signedDoc);
            File.WriteAllText("PodpisanaObjednavkaSCasovouPeciatkou.xml", signedDoc);

            return true;
        }

        public void overPodpisy()
        {
            string[] podpisy_nazov = Directory.GetFiles("./priklady/");
            string[] valid_signature_scheme = {
                "http://www.w3.org/2000/09/xmldsig#dsa-sha1",
                "http://www.w3.org/2000/09/xmldsig#rsa-sha1",
                "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256",
                "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384",
                "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512"};
            string[] valid_digital_fingerprint = {
                "http://www.w3.org/2000/09/xmldsig#sha1",
                "http://www.w3.org/2001/04/xmldsig-more#sha224",
                "http://www.w3.org/2001/04/xmlenc#sha256",
                "http://www.w3.org/2001/04/xmldsig-more#sha384",
                "http://www.w3.org/2001/04/xmlenc#sha512"};
            string canonicalizationMethod = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
            string[] valid_Transforms = {
                "http://www.w3.org/2000/09/xmldsig#base64",
                "http://www.w3.org/TR/2001/REC-xml-c14n-20010315"};
            string signature_ID = "";

            foreach (string docfile in podpisy_nazov)
            {
                bool signatureOK = true;
                string signature_error_msg = "";
                XmlDocument doc = new XmlDocument();
                doc.Load(docfile);
                XmlElement root = doc.DocumentElement;
                if (root.GetAttribute("xmlns:xzep") == "" || root.GetAttribute("xmlns:ds") == "")
                {
                    Console.WriteLine(docfile + ": koreňový element musí obsahovať atribúty xmlns:xzep a xmlns:ds podľa profilu XADES_ZEP. ");
                    continue;
                }

                XmlNodeList nodes = doc.SelectNodes("//*");
                foreach (XmlNode x in nodes)
                {
                    if (x.Name.Equals("ds:SignatureMethod") && signatureOK == true)
                    {
                        if (!valid_signature_scheme.Contains(x.Attributes[0].Value)){
                            signatureOK = false;
                            signature_error_msg = " ds:SignatureMethod musi obsahovať URI niektorého z podporovaných algoritmov podľa profilu XAdES_ZEP";
                        } 
                    }
                    if (x.Name.Equals("ds:CanonicalizationMethod") && signatureOK == true)
                    {
                        if (!x.Attributes[0].Value.Equals(canonicalizationMethod))
                        {
                            signatureOK = false;
                            signature_error_msg = " ds:CanonicalizationMethod musi obsahovať URI niektorého z podporovaných algoritmov podľa profilu XAdES_ZEP";
                        }
                    }
                    if (x.Name.Equals("ds:Transform") && signatureOK == true)
                    {
                        if (x.Attributes.Count == 0 || !valid_Transforms.Contains(x.Attributes[0].Value))
                        {
                            signatureOK = false;
                            signature_error_msg = " ds:Transforms musi obsahovať URI niektorého z podporovaných algoritmov podľa profilu XAdES_ZEP";
                        }
                    }
                    if (x.Name.Equals("ds:DigestMethod") && signatureOK == true)
                    {
                        if (!valid_digital_fingerprint.Contains(x.Attributes[0].Value))
                        {
                            signatureOK = false;
                            signature_error_msg = " ds:DigestMethod musi obsahovať URI niektorého z podporovaných algoritmov podľa profilu XAdES_ZEP";
                        }
                    }
                }
                if (!signatureOK)
                {
                    Console.WriteLine(docfile + signature_error_msg);
                    continue;
                }

                //CORE VALIDATION
                XmlNamespaceManager xNS = new XmlNamespaceManager(doc.NameTable);
                xNS.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
                XmlElement xSignature = root;
                //verify signature
                if(xSignature.SelectSingleNode(@"//ds:KeyInfo/ds:X509Data/ds:X509Certificate", xNS) == null)
                {
                    Console.WriteLine(docfile + " chybne ds:KeyInfo/ds:X509Data/ds:X509Certificate");
                    continue;
                }
                byte[] signatureCertificate = Convert.FromBase64String(xSignature.SelectSingleNode(@"//ds:KeyInfo/ds:X509Data/ds:X509Certificate", xNS).InnerText);
                byte[] signature = Convert.FromBase64String(xSignature.SelectSingleNode(@"//ds:SignatureValue", xNS).InnerText);
                XmlNode signedInfoN = xSignature.SelectSingleNode(@"//ds:SignedInfo", xNS);
                string signedInfoTransformAlg = xSignature.SelectSingleNode(@"//ds:SignedInfo/ds:CanonicalizationMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;
                string signedInfoSignatureAlg = xSignature.SelectSingleNode(@"//ds:SignedInfo/ds:SignatureMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;

                XmlDsigC14NTransform t = new XmlDsigC14NTransform();
                t.Algorithm = signedInfoTransformAlg;

                XmlDocument toCanonicalize = new XmlDocument();
                toCanonicalize.LoadXml(signedInfoN.OuterXml);
                t.LoadInput(toCanonicalize);




                MemoryStream ms = (MemoryStream)t.GetOutput(typeof(Stream));
                StreamReader reader = new StreamReader(ms);
                string text = reader.ReadToEnd();

                byte[] objSignedInfoNew = Encoding.ASCII.GetBytes(text);

                string errMsg;
                bool res = verifySign(signatureCertificate, signature, objSignedInfoNew, signedInfoSignatureAlg, out errMsg);

	            if(!res)
	            {
                    Console.WriteLine(docfile + " overenie hodnoty podpisu ds:SignatureValue a referencií v ds:SignedInfo zlyhalo");
                    continue;
                }

                foreach (XmlNode x in nodes)
                {
                    if (x.Name.Equals("ds:Signature") && signatureOK == true)
                    {
                        signature_ID = x.Attributes[0].Value;
                        if (!(x.Attributes.Count == 2 && x.Attributes[0].Name == "Id" && x.Attributes[1].Name == "xmlns:ds"))
                        {
                            signatureOK = false;
                            signature_error_msg = " CHYBA ds:Signature - overenie ostatných elementov profilu XAdES_ZEP, ktoré prináležia do špecifikácie XML Signature";
                        }
                    }
                    if (x.Name.Equals("ds:SignatureValue") && signatureOK == true)
                    {
                        if (!(x.Attributes.Count == 1 && x.Attributes[0].Name == "Id"))
                        {
                            signatureOK = false;
                            signature_error_msg = " CHYBA ds:SignatureValue - overenie ostatných elementov profilu XAdES_ZEP, ktoré prináležia do špecifikácie XML Signature";
                        }
                    }
                    if (x.Name.Equals("ds:KeyInfo") && signatureOK == true)
                    {
                        if (!(x.Attributes[0].Name == "Id"))
                        {
                            signatureOK = false;
                            signature_error_msg = " CHYBA ds:KeyInfo - overenie ostatných elementov profilu XAdES_ZEP, ktoré prináležia do špecifikácie XML Signature";
                        }
                        foreach (XmlNode child in x.ChildNodes)
                        {
                            if (child.Name.Equals("ds:X509Data"))
                            {
                                int pocitadlo = 0;
                                foreach (XmlNode subchild in child.ChildNodes)
                                {
                                    if (subchild.Name.Equals("ds:X509Certificate"))
                                        pocitadlo += 1;
                                    if (subchild.Name.Equals("ds:X509IssuerSerial"))
                                        pocitadlo += 1;
                                    if (subchild.Name.Equals("ds:X509SubjectName"))
                                        pocitadlo += 1;
                                }
                                if (pocitadlo < 3) {
                                    Console.WriteLine("pocitadlo " + pocitadlo);
                                    signatureOK = false;
                                    signature_error_msg = " CHYBA ds:KeyInfo - overenie ostatných elementov profilu XAdES_ZEP, ktoré prináležia do špecifikácie XML Signature";
                                }
                            }
                        }
                    }
                    if (x.Name.Equals("ds:SignatureProperties") && signatureOK == true)
                    {
                        if (!(x.Attributes[0].Name == "Id"))
                        {
                            signatureOK = false;
                            signature_error_msg = " CHYBA ds:SignatureProperties - overenie ostatných elementov profilu XAdES_ZEP, ktoré prináležia do špecifikácie XML Signature";
                        }
                        int pocitadlo = 0;
                        foreach (XmlNode child in x.ChildNodes) {
                            if (child.Name.Equals("ds:SignatureProperty"))
                            {
                                if (child.Attributes[0].Value.Equals("#" + signature_ID))
                                {
                                    foreach (XmlNode subchild in child.ChildNodes)
                                    {
                                        if (subchild.Name.Equals("xzep:SignatureVersion"))
                                            pocitadlo += 1;
                                        if (subchild.Name.Equals("xzep:ProductInfos"))
                                            pocitadlo += 1;
                                    }
                                }
                            }
                        }
                        if (pocitadlo < 2)
                        {
                            signatureOK = false;
                            signature_error_msg = " CHYBA ds:SignatureProperties - overenie ostatných elementov profilu XAdES_ZEP, ktoré prináležia do špecifikácie XML Signature";
                        }
                    }
                }
                if (!signatureOK)
                {
                    Console.WriteLine(docfile + signature_error_msg);
                    continue;
                }

                //Zo signed info vybrat vsetky reference elementy, dereferencovat(?) uri a kanalizovat, zahashovat, porovnat
                //
                XmlNodeList references = signedInfoN.SelectNodes(@"//ds:Reference", xNS);
                foreach(XmlNode refNode in references){
                    XmlDsigC14NTransform transform = new XmlDsigC14NTransform();
                    transform.Algorithm = refNode.SelectSingleNode(@"//ds:Transform", xNS).Attributes.GetNamedItem("Algorithm").Value;

                    Reference reference = new Reference();
                    reference.DigestMethod = refNode.SelectSingleNode(@"//ds:DigestMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;
                    reference.Uri = refNode.Attributes.GetNamedItem("URI").Value;
                    reference.AddTransform(transform);


                    Console.WriteLine(refNode.SelectSingleNode(@"//ds:DigestValue", xNS).InnerText);
                    byte[] digestValue = Convert.FromBase64String(refNode.SelectSingleNode(@"//ds:DigestValue", xNS).InnerText);

                    // TODO: Calculate hash from the fucking reference bullshit and compare with Digest in xml

                    /*if (!digestValue.Equals()){
                        Console.WriteLine(docfile + " Reference's " + reference.Uri + " Digest values do not match\n");
                    }*/

                }

                Console.WriteLine(docfile + " OK");
            }
        }

        private bool verifySign(byte[] certificateData, byte[] signature, byte[] data, string digestAlg, out string errorMessage)
        {
            try
            {
                Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo ski = Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(certificateData)).SubjectPublicKeyInfo;
                Org.BouncyCastle.Crypto.AsymmetricKeyParameter pk = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(ski);

                string algStr = ""; //signature alg

                //find digest
                switch (digestAlg)
                {
                    case "http://www.w3.org/2000/09/xmldsig#rsa-sha1":
                        algStr = "sha1";
                        break;
                    case "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256":
                        algStr = "sha256";
                        break;
                    case "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384":
                        algStr = "sha384";
                        break;
                    case "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512":
                        algStr = "sha512";
                        break;
                }

                //find encryption
                switch (ski.AlgorithmID.ObjectID.Id)
                {
                    case "1.2.840.10040.4.1": //dsa
                        algStr += "withdsa";
                        break;
                    case "1.2.840.113549.1.1.1": //rsa
                        algStr += "withrsa";
                        break;
                    default:
                        errorMessage = "verifySign 5: Unknown key algId = " + ski.AlgorithmID.ObjectID.Id;
                        return false;
                }

                errorMessage = "verifySign 8: Creating signer: " + algStr;
                Org.BouncyCastle.Crypto.ISigner verif = Org.BouncyCastle.Security.SignerUtilities.GetSigner(algStr);
                verif.Init(false, pk);
                verif.BlockUpdate(data, 0, data.Length);
                bool res = verif.VerifySignature(signature);
                if (!res)
                {
                    errorMessage = "verifySign 9: VerifySignature=false: dataB64=" + Convert.ToBase64String(data) + Environment.NewLine + Environment.NewLine + "signatureB64=" + Convert.ToBase64String(signature) + Environment.NewLine + Environment.NewLine + "certificateDataB64=" + Convert.ToBase64String(certificateData);
                }

                return res;

            }
            catch (Exception ex)
            {
                errorMessage = "verifySign 10: " + ex.ToString();
                return false;
            }
        }

    }
}
