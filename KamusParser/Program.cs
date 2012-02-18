using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Kamus
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            // Create an XmlReader
            using (XmlReader reader = XmlReader.Create("KBBI/KBBI.xml"))
            {
               
                bool yespage= false;
               do
                {
                    try
                    {
                        yespage = reader.ReadToFollowing("page");
                        Console.WriteLine(reader.GetAttribute("number"));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }while(yespage);



            }

            Console.ReadLine();
        }
    }
}
