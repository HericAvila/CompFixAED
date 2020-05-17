
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
                pessoa.nomePessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Nome: " + pessoa.nomePessoa);

                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Numero: " + pessoa.numeroPessoa);

                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Endereço: " + pessoa.enderecoPessoa);

                Console.WriteLine("Razão social: ");
                pessoa.razaoSocial = (Console.ReadLine());
                ArquivoPessoa.addText("Razão Social: " + pessoa.razaoSocial);

                Console.WriteLine("CNAE: ");
                pessoa.cnae = ("CNAE: " + Console.ReadLine());
                ArquivoPessoa.addText(pessoa.cnae);

                Console.WriteLine("A empresa é uma multinacional? (sim/nao) ");
                r= Console.ReadLine();
                while ((r != "sim") && (r != "nao"))
                {
                    Console.WriteLine("Valor inválido, digite novamente ");
                    r = Console.ReadLine();
                }
                if (r == "sim"){ 
                    pessoa.multinacional = (true);
                    ArquivoPessoa.addText("Multinacional: Sim ");
                }
                else { 
                    pessoa.multinacional = false;
                    ArquivoPessoa.addText("Multinacional: Não ");
                }

                Console.WriteLine("Informe o tipo de empresa: ");
                pessoa.tipoEmpresa = (Console.ReadLine());
                ArquivoPessoa.addText("Tipo: " + pessoa.tipoEmpresa);

                Console.WriteLine("Responsável: ");
                pessoa.responsavel =(Console.ReadLine());
                ArquivoPessoa.addText("Responsavel: " + pessoa.responsavel);
            }
            else
            {
                Fisica pessoa = new Fisica();
                Console.WriteLine("Digite o nome do cliente: ");
                pessoa.nomePessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Nome: " + pessoa.nomePessoa);
                                
                Console.WriteLine("Digite o numero do cliente: ");
                pessoa.numeroPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Numero: " + pessoa.numeroPessoa);

                Console.WriteLine("Digite o endereço do cliente: ");
                pessoa.enderecoPessoa = (Console.ReadLine());
                ArquivoPessoa.addText("Endereço: " + pessoa.enderecoPessoa);

                Console.WriteLine("Digite a idade do cliente: ");
                pessoa.idade = (Console.ReadLine());
                ArquivoPessoa.addText("Idade: " + pessoa.idade);                

                Console.WriteLine("Digite o rg do cliente: ");
                pessoa.rg = (Console.ReadLine());
                ArquivoPessoa.addText("RG: " + pessoa.rg);

                Console.WriteLine("Nacionalidade do cliente: ");
                pessoa.nacionalidade = Console.ReadLine();
                ArquivoPessoa.addText("Nacionalidade: " + pessoa.nacionalidade);
                

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
                        ArquivoPessoa.addText("Celular/Tablet: ");
                        Celular_tablet dispositivo = new Celular_tablet();
                        Console.WriteLine("Precisa de concerto de tela? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { dispositivo.tela = true;  ArquivoPessoa.addText("Precisa de conserto de tela: sim"); }
                        else { dispositivo.tela = false; ArquivoPessoa.addText("Precisa de conserto de tela: nao"); }
                        Console.WriteLine("Sistema operacional do dispositivo: ");
                        dispositivo.sistemaOperacional = Console.ReadLine();
                        ArquivoPessoa.addText("Siatema operacional: "+dispositivo.sistemaOperacional);
                        Console.WriteLine("Marca do dispositivo:");
                        dispositivo.marca = Console.ReadLine();
                        ArquivoPessoa.addText("Marca: " + dispositivo.marca);
                        Console.WriteLine("Chip estragado? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { dispositivo.chip = true; ArquivoPessoa.addText("Precisa de conserto de chip: sim"); }
                        else { dispositivo.chip = false; ArquivoPessoa.addText("Precisa de conserto de chip: nao"); }
                        Console.WriteLine("Tipo entrada:");
                        dispositivo.tipoEntrada = Console.ReadLine();
                        ArquivoPessoa.addText("Tipo de entrada: "+dispositivo.tipoEntrada);
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
                        if (r == "sim") { smartwatch.tela = true; ArquivoPessoa.addText("Precisa de conserto de tela: sim"); }
                        else { smartwatch.tela = false; ArquivoPessoa.addText("Precisa de conserto de tela: nao"); }
                        Console.WriteLine("Sistema operacional do dispositivo: ");
                        smartwatch.sistemaOperacional = Console.ReadLine();
                        ArquivoPessoa.addText("Sistema operacional:"+smartwatch.sistemaOperacional);
                        Console.WriteLine("Precisa de concerto no leitor biométrico? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { smartwatch.leitorBiometrio = true; ArquivoPessoa.addText("Precisa de conserto de Leitor Biometrico: sim"); }
                        else { smartwatch.leitorBiometrio = false; ArquivoPessoa.addText("Precisa de conserto de leitor biometrico: nao"); }
                    }
                    Console.WriteLine(" \Obrigado, Retornamos com o valor. ");
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
                        ArquivoPessoa.addText("Computador: Desktop ");
                        PC computador = new PC();
                        Console.WriteLine("Modelo da placa de vídeo:");
                        computador.placaV = Console.ReadLine();
                        ArquivoPessoa.addText("Modelo da Placa de Video: "+computador.placaV);
                        Console.WriteLine("Modelo do processador:");
                        computador.processador = Console.ReadLine();
                        ArquivoPessoa.addText("Modelo do Processador: " + computador.processador);
                        Console.WriteLine("Quantidade de memória ram:");
                        computador.ram = Convert.ToInt32(Console.ReadLine());
                        ArquivoPessoa.addText("Quantidade de memoria ram: " + computador.ram);
                        Console.WriteLine("Está oxidado? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { computador.oxidacao = true; ArquivoPessoa.addText("Oxidado: sim"); }
                        else { computador.oxidacao = false; ArquivoPessoa.addText("Oxidado: nao"); }
                        Console.WriteLine("Potência da fonte:");
                        computador.fonte = Convert.ToInt32(Console.ReadLine());
                        ArquivoPessoa.addText("Potencia da fonte(W): " + computador.fonte);
                        Console.WriteLine("Problema no driver optico? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { computador.leitorOptico = true; ArquivoPessoa.addText("Problema no Driver Optico: sim"); }
                        else { computador.leitorOptico = false; ArquivoPessoa.addText("Problema no Driver Optico: nao"); }
                        Console.WriteLine("Modelo da placa mãe:");
                        computador.placaM = Console.ReadLine();
                        ArquivoPessoa.addText("Modelo da placa mae: "+computador.placaM);
                        Console.WriteLine(" \Obrigado, Retornamos com o valor. ");
                    }
                    if (d == "nb")
                    {
                        ArquivoPessoa.addText("Computador: Notebook");
                        Notebook notebook = new Notebook();
                        Console.WriteLine("Modelo da placa de vídeo:");
                        notebook.placaV = Console.ReadLine();
                        ArquivoPessoa.addText("Modelo da placa de video: "+notebook.placaV);
                        Console.WriteLine("Modelo do processador:");
                        notebook.processador = Console.ReadLine();
                        ArquivoPessoa.addText("Modelo do processador: " + notebook.processador);
                        Console.WriteLine("Quantidade de memória ram:");
                        notebook.ram = Convert.ToInt32(Console.ReadLine());
                        ArquivoPessoa.addText("Quantidade de ram: " + notebook.ram);
                        Console.WriteLine("Está oxidado? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { notebook.oxidacao = true; ArquivoPessoa.addText("Oxidado: sim"); }
                        else { notebook.oxidacao = false; ArquivoPessoa.addText("Oxidado: nao"); }
                        Console.WriteLine("Tamanho da tela no notebook:");
                        notebook.tamanhoTela = double.Parse(Console.ReadLine());
                        ArquivoPessoa.addText("Tamanho da tela: "+notebook.tamanhoTela);
                        Console.WriteLine("Bateria com problema? (sim/nao) ");
                        r = Console.ReadLine();
                        while ((r != "sim") && (r != "nao"))
                        {
                            Console.WriteLine("Valor inválido, digite novamente ");
                            r = Console.ReadLine();
                        }
                        if (r == "sim") { notebook.bateria = true; ArquivoPessoa.addText("Bateria com problema: sim"); }
                        else { notebook.bateria = false; ArquivoPessoa.addText("Bateria com problema: sim"); }
                        Console.WriteLine("Marca do notebook:");
                        notebook.marca = Console.ReadLine();
                        ArquivoPessoa.addText("Marca do notebook: "+notebook.marca);
                    }
                    Console.WriteLine(" \Obrigado, Retornamos com o valor. ");
                    break;
                case "m":
                    Monitor monitor = new Monitor();
                    Console.WriteLine("Tipo de monitor:");
                    monitor.tipo = Console.ReadLine();
                    ArquivoPessoa.addText("Tipo do monitor: " + monitor.tipo);
                    Console.WriteLine("Tamanho da tela:");
                    monitor.tamanhoTela = double.Parse(Console.ReadLine());
                    ArquivoPessoa.addText("Tamanho do monitor: " + monitor.tamanhoTela);
                    Console.WriteLine(" \Obrigado, Retornamos com o valor. ");
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