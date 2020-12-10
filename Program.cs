using System;
using POO_Polimorfismo_Sobreposicao.classes;

namespace POO_Polimorfismo_Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero zero = new Zero();
            MegaMan mega = new MegaMan();

            Console.WriteLine("Player 1");
            Console.WriteLine($"Habilidades disponiveis: {mega.Buster}");
            Console.WriteLine($"Velocidade: {mega.Velocidade + 1}");
            Console.WriteLine($"Força do Pulo: {mega.ForcaDoPulo}");
            Console.WriteLine($"Mega vai {mega.Correr()}");
            Console.WriteLine($"Mega vai {mega.Pular()}");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Player 2");
            Console.WriteLine($"Habilidades disponiveis: {zero.Sword}");
            Console.WriteLine($"Velocidade: {zero.Velocidade}");
            Console.WriteLine($"Força do Pulo: {zero.ForcaDoPulo + 1}");
            Console.WriteLine($"Zero vai {zero.Correr()}");
            Console.WriteLine($"Zero vai {zero.Pular()}");

        }//MAIN
    }
}
