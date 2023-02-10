using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace EasyDnsChanger
{
    public class SaveLoadData
    {
        string filePath = "dnslist";
        const string MSG_ADMINERROR = "Please run application as administrator";

        /// <summary>
        /// creating dnslist file with default values 
        /// </summary>
        public void Create_File()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    StreamWriter ns = new StreamWriter(filePath);
                    ns.Write(@"<?xml version=""1.0""?>
<ArrayOfDNSItemClass xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <DNSItemClass>
    <Name>Google</Name>
    <DNS1>8.8.8.8</DNS1>
    <DNS2>8.8.4.4</DNS2>
  </DNSItemClass>
  <DNSItemClass>
    <Name>Cloudflare</Name>
    <DNS1>1.1.1.1</DNS1>
    <DNS2>1.0.0.1</DNS2>
  </DNSItemClass>
  <DNSItemClass>
    <Name>OpenDNS</Name>
    <DNS1>208.67.220.220</DNS1>
    <DNS2>208.67.222.222</DNS2>
  </DNSItemClass>
  <DNSItemClass>
    <Name>Electro</Name>
    <DNS1>78.157.42.100</DNS1>
    <DNS2>78.157.42.101</DNS2>
  </DNSItemClass>
  <DNSItemClass>
    <Name>Shekan</Name>
    <DNS1>178.22.122.100</DNS1>
    <DNS2>185.51.200.2</DNS2>
  </DNSItemClass>
</ArrayOfDNSItemClass>");
                    ns.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(MSG_ADMINERROR);
            }
        }

        /// <summary>
        /// Saving a list of dns to file
        /// </summary>
        /// <param name="DnsList">List of DNSItemClass</param>
        /// <returns></returns>
        public bool Save_Data(List<DNSItemClass> DnsList)
        {
            bool res = SerializeObject(DnsList);
            return res;

        }

        /// <summary>
        /// Saving a single dns in to file
        /// </summary>
        /// <param name="SingleDnsItem">single dns with DNSItemClass type</param>
        /// <returns></returns>
        public bool Save_Data(DNSItemClass SingleDnsItem)
        {
            try
            {
                List<DNSItemClass> allDNS = Load_Data();
                if (allDNS == null) { allDNS = new List<DNSItemClass>(); }
                bool exists = allDNS.Where(tmp => tmp == SingleDnsItem).Any();
                if (exists) { return true; }
                allDNS.Add(SingleDnsItem);
                bool res=Save_Data(allDNS);
                return res;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// saving unclassified dns to file
        /// </summary>
        /// <param name="DnsName">DNS Name</param>
        /// <param name="DNS1">Primary DNS value</param>
        /// <param name="DNS2">Secondary DNS Value</param>
        /// <returns></returns>
        public bool Save_Data(string DnsName,string DNS1,string DNS2)
        {
            DNSItemClass newDNS = new DNSItemClass();
            newDNS.Name=DnsName;    
            newDNS.DNS1 = DNS1;
            newDNS.DNS2 = DNS2;
            bool res = Save_Data(newDNS);
            return res;
        }

        /// <summary>
        /// Delete a single DNS with type of DNSItemClass from file
        /// </summary>
        /// <param name="SingleDnsItem">single dns with DNSItemClass type</param>
        /// <returns></returns>
        public bool Delete_DNS(DNSItemClass SingleDnsItem)
        {
            List<DNSItemClass> allDNS = Load_Data();
            allDNS.Remove(SingleDnsItem);
            bool res = Save_Data(allDNS);
            return res;
        }

        /// <summary>
        /// Delete a single unclassified DNS from file
        /// </summary>
        /// <param name="DnsName">DNS Name</param>
        /// <param name="DNS1">Primary DNS value</param>
        /// <param name="DNS2">Secondary DNS Value</param>
        /// <returns></returns>
        public bool Delete_DNS(string DnsName, string DNS1, string DNS2)
        {
            List<DNSItemClass> allDNS = Load_Data();
            DNSItemClass target = allDNS.Where(tmp => tmp.Name == DnsName && tmp.DNS1 == DNS1 && tmp.DNS2 == DNS2).First();
            allDNS.Remove(target);
            bool res = Save_Data(allDNS);
            return res;
        }

        /// <summary>
        /// Edit a single DNS with type of DNSItemClass
        /// </summary>
        /// <param name="OldDNS">Target DNS to edit with type of DNSItemClass</param>
        /// <param name="DnsName">DNS new Name</param>
        /// <param name="DNS1">Primary DNS new value</param>
        /// <param name="DNS2">Secondary DNS new Value</param>
        /// <returns></returns>
        public bool Edit_DNS(DNSItemClass OldDNS, string DnsName, string DNS1, string DNS2)
        {
            List<DNSItemClass> allDNS = Load_Data();
            if (allDNS == null) { allDNS = new List<DNSItemClass>(); }
            for (int i = 0; i < allDNS.Count; i++)
            {
                if (allDNS[i]==OldDNS)
                {
                    allDNS[i].Name = DnsName;
                    allDNS[i].DNS1 = DNS1;  
                    allDNS[i].DNS2 = DNS2;
                    break;
                }
            }
            bool res = Save_Data(allDNS);
            return res;
        }

        /// <summary>
        /// Edit a single unclassified DNS
        /// </summary>
        /// <param name="OldDnsName">Target DNS Name</param>
        /// <param name="OldDNS1">Target Primary DNS Value</param>
        /// <param name="OldDNS2">Target Secondary DNS Value</param>
        /// <param name="DnsName">DNS new Name</param>
        /// <param name="DNS1">Primary DNS new value</param>
        /// <param name="DNS2">Secondary DNS new Value</param>
        /// <returns></returns>
        public bool Edit_DNS(string OldDnsName, string OldDNS1, string OldDNS2, string DnsName, string DNS1, string DNS2)
        {
            List<DNSItemClass> allDNS = Load_Data();
            if (allDNS == null) { allDNS = new List<DNSItemClass>(); }
            for (int i = 0; i < allDNS.Count; i++)
            {
                if (allDNS[i].Name == OldDnsName && allDNS[i].DNS1 == OldDNS1 && allDNS[i].DNS2 == OldDNS2)
                {
                    allDNS[i].Name = DnsName;
                    allDNS[i].DNS1 = DNS1;
                    allDNS[i].DNS2 = DNS2;
                    break;
                }
            }
            bool res = Save_Data(allDNS);
            return res;
        }

        /// <summary>
        /// Get all DNS from file in a List of DNSItemClass
        /// </summary>
        /// <returns>List of DNSItemClass</returns>
        public List<DNSItemClass> Load_Data()
        {
            List<DNSItemClass> res = DeSerializeObject<List<DNSItemClass>>();
            return res;
        }

        /// <summary>
        /// Serialize DNS list as xml and save it to file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <returns></returns>
        public bool SerializeObject<T>(T serializableObject)
        {
            if (serializableObject == null) { return false; }
            try
            {
                if (!File.Exists(filePath))
                {
                    StreamWriter ns = new StreamWriter(filePath, true);
                    ns.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(MSG_ADMINERROR);
            }
            
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(filePath);
                    stream.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(MSG_ADMINERROR);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Read all DNS from file and DeSerialize it as list of DNSItemClass
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>List of DNSItemClass</returns>
        public T DeSerializeObject<T>()
        {
            T objectOut = default(T);
            try
            {
                string attributeXml = string.Empty;

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(MSG_ADMINERROR);
            }

            return objectOut;
        }
    }
}
