using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompFixx.Arquivo
{
    class ArquivoPessoa
    {
        public static void puxaNome() 
        {
            string aux = Console.ReadLine();
            string path = @"C:\Users\Heric\source\repos\CompFixx\CompFixx\bin\Debug\File.txt";
            
            if (!File.Exists(path))
            {
                
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(" ");

                }
            }

        }
        public static void addText()
        {
            string aux = Console.ReadLine();
            string path = @"C:\Users\Heric\source\repos\CompFixx\CompFixx\bin\Debug\" + aux + ".txt";
            
            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(aux+"   ");
                
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
            
    }
}
