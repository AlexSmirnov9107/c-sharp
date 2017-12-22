using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace HomeWork16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> news = new List<Item>();
            XmlDocument doc = new XmlDocument();
            doc.Load("habrahabr.ru.xml");
            var root = doc.DocumentElement.GetElementsByTagName("item");
            foreach (XmlElement item in root )
            {
                
                news.Add(new Item {
                    
                    Title = item.GetElementsByTagName("title")[0].InnerText,
                    Description = item.GetElementsByTagName("description")[0].InnerText,
                    Link = item.GetElementsByTagName("link")[0].InnerText,
                    Guid = item.GetElementsByTagName("guid")[0].InnerText,
                    PubDate = item.GetElementsByTagName("pubDate")[0].InnerText

                });
            }

            XmlDocument docStudents = new XmlDocument();
            XmlElement students = docStudents.CreateElement("students");
            XmlElement student = docStudents.CreateElement("student");
            student.SetAttribute("name", "Alex");
            student.SetAttribute("LastName", "Sm");
            students.AppendChild(student);

            student = docStudents.CreateElement("student");
            student.SetAttribute("name", "mikhail");
            student.SetAttribute("LastName", "sm");
            students.AppendChild(student);

            docStudents.AppendChild(students);
            docStudents.Save("Students.xml");

        }
    }
}
