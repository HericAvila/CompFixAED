using CompFixx.Arquivo;
using CompFixx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompFixx
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string r;
            Console.WriteLine("Informe se o cliente é pessoa fisica ou juridica: ");
            r = Console.ReadLine();
            while((r != "fisica") && (r != "juridica"))
            {
                Console.WriteLine("valor inválido, digite novamente: ");
                r = Console.ReadLine();
            }

           //  CriarArquivo();
        }
    }
}
//primeiro comit