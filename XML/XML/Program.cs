using System;
using System.Xml;
using System.IO;

namespace XML
{
    class Program
    {
        static XmlReader reader;
        static XmlReaderSettings readerSettings;

        static void Main(string[] args)
        {
            readerSettings = new XmlReaderSettings();
            readerSettings.IgnoreComments = true;
            reader = XmlReader.Create(new FileStream(@"GoodGuyBadGuy.xml", FileMode.Open), readerSettings);
        }

        static void ReadXML()
        {
            string tmp = "";
            using (reader)
            {
                while (!reader.EOF)
                {
                    reader.Read();
                    tmp += " " + reader.Name + reader.Value;
                    int attcount = reader.AttributeCount;
                    reader.MoveToNextAttribute();
                    for (int i = 0; i < attcount; i++)
                    {
                        tmp += " " + reader.Name + " " + reader.Value;
                        reader.MoveToNextAttribute();
                    }  
                }
            }
            Console.WriteLine(tmp);
        }

        static void WriteXML()
        {
            using (XmlWriter writer = XmlWriter.Create("employees.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Employees");
                    writer.WriteStartElement("Employee");
                    writer.WriteAttributeString("security", "very secure");
                    writer.WriteElementString("ID", "6476234");
                    writer.WriteString("test");
                    writer.WriteElementString("FirstName", "thomas");
                    writer.WriteElementString("LastName", "rüdiger");
                    writer.WriteElementString("Salary", "599");
                    writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
