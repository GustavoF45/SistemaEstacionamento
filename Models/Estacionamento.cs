using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        public int PrecoInicial { get; set; }
        public int PrecoPorHora { get; set; }
        public int Horas { get; set; }

        public void Cadastro(){ // Métodos --> O que minha Pessoa vai fazer
            Console.WriteLine("Digite o preço inicial");
            PrecoInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço por hora");
            PrecoPorHora = int.Parse(Console.ReadLine());

            string opcao;
            string x;
            bool exibirMenu = true;
            List<string> itens = new List<string>();

            while(exibirMenu){
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("\n1 - Cadastrar placa");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Verificar cadastro de placa");
                Console.WriteLine("4 - Listar todas placas");
                Console.WriteLine("5 - Encerrar");

                opcao = Console.ReadLine();

                switch(opcao){
                case "1":
                    Console.WriteLine("Digite a placa do veículo: ");
                    x = Console.ReadLine();
                    itens.Add(x);
                    Console.WriteLine($"Seu veículo {x} foi cadastrado!");
                    break;
                case "2":
                    Console.WriteLine("Digite a placa do veículo para remoção: ");
                    x = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");
                    string y = Console.ReadLine();
                    Horas = int.Parse(y);
                    Console.WriteLine($"Seu veículo ficou estacionado {Horas} horas e o custo total ficou em {(Horas * PrecoPorHora) + PrecoInicial} reais");
                    itens.Remove(x);
                    break;
                case "3":
                    Console.WriteLine("Digite a placa do veículo para verificar se está cadastrada: ");
                    x = Console.ReadLine();
                    if(itens.Contains(x)){
                        Console.WriteLine($"Sua placa {x} está cadastrada!");
                    } else{
                        Console.WriteLine($"Sua placa {x} não está cadastrada!");
                    }
                    break;
                case "4":
                    Console.WriteLine("Lista de todas as placas cadastradas: ");
                    foreach (string item in itens){
                        Console.WriteLine(item);
                    }
                break;
                case "5":
                    Console.WriteLine("Encerrar");
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }          
        }

        Console.WriteLine("Programa Encerrado!");
        }
    }
}