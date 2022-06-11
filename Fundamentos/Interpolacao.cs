using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // As 3 opções abaixo resultam na mesma saída e são formas de Interpolar as variáveis
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");
        }
    }
}
