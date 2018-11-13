using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Yamato", 23432, "Steven King", 2002);
            Book book1 = new Book("Sergenant", 211323, "Kylie Jener", 2005);
            Book book2 = new Book("Mileneo", 32414, "Arthur Pirozhkov", 2012);
            Console.WriteLine("You created an object");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using(FileStream file=new FileStream("Book", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, book);
                binaryFormatter.Serialize(file, book1);
                binaryFormatter.Serialize(file, book2);
                Console.WriteLine("Serialization Finished");
            }
            using (FileStream fille=new FileStream("Book", FileMode.OpenOrCreate))
            {
                Book book3 = (Book)binaryFormatter.Deserialize(fille);
                Console.WriteLine("Deserializaqtion has been completed");
                Console.WriteLine(book3.Name, book3.Cost, book3.Author, book3.Year);
                    
            }
            Console.ReadLine();

            var Attributes = (MyAttributes[])typeof(Book).GetCustomAttributes(typeof(MyAttributes), true);
            if (Attributes.Length > 0)
            {
                var myAttributes = Attributes[0];
                string val = "myAttributes";
            }
        }
    }
}
