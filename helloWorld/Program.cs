using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFilme, sala, hora, data;



            Console.WriteLine("Insira o nome do filme: ");
            nomeFilme = Console.ReadLine();

            Console.WriteLine("Insira a sala: ");
            sala = Console.ReadLine();

            Console.WriteLine("Qual o horário do filme: ");
            hora = Console.ReadLine();

            Console.WriteLine("Data: ");
            data = Console.ReadLine();

            Console.WriteLine($"Seu ingresso para o filme {nomeFilme}, vai passar no dia: {data}, às {hora}, na sala {sala}");




        }
    }
}
