using System;
using System.Globalization;

namespace CSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 15,2
            Console.WriteLine(valor.ToString("C")); //R$15,8  C=Currency, trás o tipo monetário do PC
            Console.WriteLine(valor.ToString("P")); //1.517,50% Multiplica por 100 e adiciona o símbolo %
            Console.WriteLine(valor.ToString("#.##")); // 15,18

            CultureInfo cultura = new CultureInfo("en-US"); // Formata em U$
        
            Console.WriteLine(valor.ToString("C2", cultura)); //$15.18 
            Console.WriteLine(valor.ToString("C6", cultura)); //$15.175000

            CultureInfo culturaBR = new CultureInfo("pt-BR"); // Formata em R$
            Console.WriteLine(valor.ToString("C2", culturaBR)); //R$15.18 

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //0000000256 - Completa o valor até 10 casas
            Console.WriteLine(inteiro.ToString("D5")); //00256 - Completa o valor até 5 casas
        }
    }
}
