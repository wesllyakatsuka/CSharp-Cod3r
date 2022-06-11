using System;
using System.Globalization;

namespace CSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Olá, me chamo: {nome}, tenho {idade} anos de idade e meu salário é: {salario}.");
        }
    }
}
