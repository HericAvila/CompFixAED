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
            if (r == "juridica"){
                Juridica pessoa = new Juridica();
                Console.WriteLine("Digite o nome do cliente: ");
                pessoa.nomePessoa = Console.ReadLine();
                Console.WriteLine(pessoa.nomePessoa);
                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = Console.ReadLine();
                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = Console.ReadLine();
                Console.WriteLine("Razão social: ");
                pessoa.razaoSocial = Console.ReadLine();
                Console.WriteLine("CNAE: ");
                pessoa.cnae = Console.ReadLine();
                Console.WriteLine("A empresa é uma multinacional? (sim/nao) ");
                r= Console.ReadLine();
                while ((r != "sim") && (r != "nao"))
                {
                    Console.WriteLine("Valor inválido, digite novamente ");
                    r = Console.ReadLine();
                }
                if (r == "sim") { pessoa.multinacional = true; }
                else { pessoa.multinacional = false; }
                Console.WriteLine("Informe o tipo de empresa: ");
                pessoa.tipoEmpresa = Console.ReadLine();
                Console.WriteLine("Responsável: ");
                pessoa.responsavel = Console.ReadLine();
            }

            //  CriarArquivo();
            Console.ReadKey();
        }
    }
}
//primeiro comit