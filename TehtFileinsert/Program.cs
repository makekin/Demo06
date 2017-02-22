using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TehtFileinsert
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Ananas\Source\Repos\Demo06\TehtFileinsert\bin\Debug\test.txt";
            
            if (!File.Exists(path))
            {
                // Luodaan tiedopsto
                using (StreamWriter sw = File.CreateText(path))
                {}
            }

            // lisaa filun loppuun stringin
            using (StreamWriter sw = File.AppendText(path))
            {
                string somestring = "";
                do

                {
                    somestring = Console.ReadLine();
                    sw.WriteLine(somestring);
                }
                while (somestring != "");
                    
              
            }

            // printtaa koko roskan
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
