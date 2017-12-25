using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book {Author = "PushKin",Name ="fairtails",Price=200.0,Year=1944},
                new Book {Author = "PushKin",Name ="History",Price=200.0,Year=1000},
                new Book {Author = "PushKin",Name ="Biology",Price=200.0,Year=2000}
            };


            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("out.txt", FileMode.OpenOrCreate))
            {  
                bf.Serialize(fs, books);
            }


            List<Book> booksFromFile = new List<Book>();
            using (FileStream fs = new FileStream("out.txt", FileMode.OpenOrCreate))
            {

                booksFromFile = bf.Deserialize(fs) as List<Book>;
            }


            Book firstBook = booksFromFile.First();

            PropertyInfo bookProperty = firstBook.GetType().GetProperty("Name");
            Attribute inputName = bookProperty.GetCustomAttribute(typeof(InputLocalization)) ;
                        
            Console.WriteLine((inputName as InputLocalization).Name  + " : " +firstBook.Name);
            Console.ReadKey();
        }
    }
}
