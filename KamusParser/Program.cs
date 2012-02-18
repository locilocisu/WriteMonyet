using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Text;

namespace Kamus
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            // Create an XmlReader
            using (XmlReader reader = XmlReader.Create("C:\\Users\\locilocisu\\Dropbox\\Kamus Besar Bahasa Indonesia.xml"))
            {
                int i = 0;
                while (i < 30000)
                {
                    reader.ReadToFollowing("text ");
                    reader.MoveToAttribute("left");
                    string leftPx = reader.Value;
                    reader.MoveToAttribute("font");
                    string fontSize = reader.Value;
                    if (fontSize.Equals("13") && (leftPx.Equals("378") || leftPx.Equals("86") || leftPx.Equals("162")))
                    {
                        reader.MoveToElement();
                        if (reader.ReadToDescendant("b"))
                        {
                            Console.WriteLine(reader.ReadElementContentAsString());
                        }
                        
                    }

                    i++;
                }
                
            }

           Console.ReadLine();
        }
    }
}
