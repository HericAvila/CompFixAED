
using CompFixx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CompFixx
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //identificando tipo de pessoa
            string r;
            Console.WriteLine("Informe se o cliente é pessoa fisica ou juridica: ");
            r = Console.ReadLine();
            while((r != "fisica") && (r != "juridica"))
            {
                Console.WriteLine("valor inválido, digite novamente: ");
                r = Console.ReadLine();
            }

            //Adicionando dados da pessoa
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
            else
            {
                Fisica pessoa = new Fisica();
                Console.WriteLine("Digite o nome do cliente: ");
                pessoa.nomePessoa = Console.ReadLine();
                Console.WriteLine(pessoa.nomePessoa);
                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = Console.ReadLine();
                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = Console.ReadLine();
                Console.WriteLine("Digite a idade do cliente: ");
                pessoa.idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o rg do cliente: ");
                pessoa.rg = Console.ReadLine();
                Console.WriteLine("Nacionalidade do cliente: ");
                pessoa.nacionalidade = Console.ReadLine();
            }

            //Identificando dispositivo
            string d;
            Console.WriteLine("Aparelho para concerto: Dispositivo Móvel (d) , Computador (c) ou Monitor (m): ");
            r = Console.ReadLine();
            while ((r != "d") && (r != "c") && (r != "m"))
            {
                Console.WriteLine("Valor inválido, digite novamente ");
                r = Console.ReadLine();
            }

            //Adicionando dados dos dispositivos
            switch (r)
            {
                case "d":
                    Console.WriteLine("Informe se é Celular-Tablet (ct) ou SmartWatch (sw): ");
                    d = Console.ReadLine();
                    while ((d != "ct") && (d != "sw"))
                    {
                        Console.WriteLine("Valor inválido, digite novamente ");
                        r = Console.ReadLine();
                    }
                    if (d == "ct")
                    {
                        Celular_tablet dispositivo = new Celular_tablet();
                        Console.WriteLine("Precisa de concerto de tela? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { dispositivo.tela = true; }
                        else { dispositivo.tela = false; }
                        Console.WriteLine("Sistema operacional do dispositivo: ");
                        dispositivo.sistemaOperacional = Console.ReadLine();
                        Console.WriteLine("Marca do dispositivo:");
                        dispositivo.marca = Console.ReadLine();
                        Console.WriteLine("Chip estragado? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { dispositivo.chip = true; }
                        else { dispositivo.chip = false; }
                        Console.WriteLine("Tipo entrada:");
                        dispositivo.tipoEntrada = Console.ReadLine();
                    }
                    if (d == "sw")
                    {
                        SmartWatch smartwatch = new SmartWatch();
                    }
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;


            }
            Console.ReadKey();
        }
    }
}
//primeiro comit
//teste