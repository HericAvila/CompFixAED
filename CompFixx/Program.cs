
using CompFixx.Arquivo;
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
            ArquivoPessoa.criar();
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
                ArquivoPessoa.addText(pessoa.nomePessoa);


                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = Console.ReadLine();
                ArquivoPessoa.addText(pessoa.numeroPessoa);

                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = Console.ReadLine();
                ArquivoPessoa.addText(pessoa.enderecoPessoa);

                Console.WriteLine("Razão social: ");
                pessoa.razaoSocial = Console.ReadLine();
                ArquivoPessoa.addText(pessoa.razaoSocial);

                Console.WriteLine("CNAE: ");
                pessoa.cnae = Console.ReadLine();
                ArquivoPessoa.addText(pessoa.cnae+"\n Multinacional: ");

                Console.WriteLine("A empresa é uma multinacional? (sim/nao) ");
                r= Console.ReadLine();
                while ((r != "sim") && (r != "nao"))
                {
                    Console.WriteLine("Valor inválido, digite novamente ");
                    r = Console.ReadLine();
                }
                if (r == "sim"){ 
                    pessoa.multinacional = (true);
                    ArquivoPessoa.addbool(pessoa.multinacional);
                }
                else { 
                    pessoa.multinacional = false;
                    ArquivoPessoa.addbool(pessoa.multinacional);
                }

                Console.WriteLine("Informe o tipo de empresa: ");
                pessoa.tipoEmpresa = Console.ReadLine();
                ArquivoPessoa.addText(pessoa.tipoEmpresa);

                Console.WriteLine("Responsável: ");
                pessoa.responsavel = ("Responsavel: "+Console.ReadLine());
                ArquivoPessoa.addText(pessoa.responsavel);
            }
            else
            {
                Fisica pessoa = new Fisica();
                Console.WriteLine("Digite o nome do cliente: ");
                pessoa.nomePessoa = ("Nome: "+Console.ReadLine());
                ArquivoPessoa.addText(pessoa.nomePessoa);

                //Console.WriteLine(pessoa.nomePessoa);
                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = ("Numero: "+Console.ReadLine());
                ArquivoPessoa.addText(pessoa.numeroPessoa);

                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = ("Endereço: "+Console.ReadLine());
                ArquivoPessoa.addText(pessoa.enderecoPessoa+"\nIdade: ");

                Console.WriteLine("Digite a idade do cliente: ");
                pessoa.idade = Convert.ToInt32(Console.ReadLine());
                ArquivoPessoa.addint(pessoa.idade);                

                Console.WriteLine("Digite o rg do cliente: ");
                pessoa.rg = ("RG: "+Console.ReadLine());
                ArquivoPessoa.addText(pessoa.rg);

                Console.WriteLine("Nacionalidade do cliente: ");
                pessoa.nacionalidade = Console.ReadLine();
                ArquivoPessoa.addText(pessoa.nacionalidade);
                

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
                        d = Console.ReadLine();
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
                        Console.WriteLine("Precisa de concerto de tela? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { smartwatch.tela = true; }
                        else { smartwatch.tela = false; }
                        Console.WriteLine("Sistema operacional do dispositivo: ");
                        smartwatch.sistemaOperacional = Console.ReadLine();
                        Console.WriteLine("Precisa de concerto no leitor biométrico? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { smartwatch.leitorBiometrio = true; }
                        else { smartwatch.leitorBiometrio = false; }
                    }
                    Console.WriteLine(" Obrigado, Retornanamos com o valor. ");
                    break;
                case "c":
                    Console.WriteLine("Informe se é PC (pc) ou noteboook (nb): ");
                    d = Console.ReadLine();
                    while ((d != "pc") && (d != "nb"))
                    {
                        Console.WriteLine("Valor inválido, digite novamente ");
                        d = Console.ReadLine();
                    }
                    if (d == "pc")
                    {
                        PC computador = new PC();
                        Console.WriteLine("Modelo da placa de vídeo:");
                        computador.placaV = Console.ReadLine();
                        Console.WriteLine("Modelo do processador:");
                        computador.processador = Console.ReadLine();
                        Console.WriteLine("Quantidade de memória ram:");
                        computador.ram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Está oxidado? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { computador.oxidacao = true; }
                        else { computador.oxidacao = false; }
                        Console.WriteLine("Potência da fonte:");
                        computador.fonte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Problema no driver optico? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { computador.leitorOptico = true; }
                        else { computador.leitorOptico = false; }
                        Console.WriteLine("Modelo da placa mãe:");
                        computador.placaM = Console.ReadLine();
                        Console.WriteLine(" Obrigado, Retornanamos com o valor. ");
                    }
                    if (d == "nb")
                    {
                        Notebook notebook = new Notebook();
                        Console.WriteLine("Modelo da placa de vídeo:");
                        notebook.placaV = Console.ReadLine();
                        Console.WriteLine("Modelo do processador:");
                        notebook.processador = Console.ReadLine();
                        Console.WriteLine("Quantidade de memória ram:");
                        notebook.ram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Está oxidado? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { notebook.oxidacao = true; }
                        else { notebook.oxidacao = false; }
                        Console.WriteLine("Tamanho da tela no notebook:");
                        notebook.tamanhoTela = double.Parse(Console.ReadLine());
                        Console.WriteLine("Bateria com problema? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { notebook.bateria = true; }
                        else { notebook.bateria = false; }
                        Console.WriteLine("Marca do notebook:");
                        notebook.marca = Console.ReadLine();
                    }
                    Console.WriteLine(" Obrigado, Retornanamos com o valor. ");
                    break;
                case "m":
                    Monitor monitor = new Monitor();
                    Console.WriteLine("Tipo de monitor:");
                    monitor.tipo = Console.ReadLine();
                    Console.WriteLine("Tamanho da tela:");
                    monitor.tamanhoTela = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Obrigado, Retornanamos com o valor. ");
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