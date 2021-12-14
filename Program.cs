using System;
using static System.Console;

namespace ManipString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Write("Escreva uma Frase/Palavra : ");
            string nome = ReadLine().ToLower();
            Write("Digite a letra que deseja trocar: ");
            string letra = ReadLine().ToLower();
            Write("Digite a letra que deseja colocar no lugar: ");
            string NovaLetra = ReadLine().ToLower();
            WriteLine("--------------------------------------------");
            
            if(nome.Contains(letra))
            {
               WriteLine($"Frase/Palavra  antes de trocar a letra: {nome}");  
               nome = nome.Replace(letra, NovaLetra);
               WriteLine($"Frase/Palavra depois de trocar a letra: {nome}");
            }
            
            else
            {
                    WriteLine("Não há nenhuma letra nessa frase");
            }
            WriteLine("--------------------------------------------");

        }
    }
}
