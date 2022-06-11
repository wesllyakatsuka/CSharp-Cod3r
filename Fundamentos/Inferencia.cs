using System;
using System.Collections.Generic;
using System.Text;


namespace CSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Weslly";
            Console.WriteLine(nome);
            nome = "Amanda"; // Compilador é capaz de inferir que o tipo da var nome é string
            Console.WriteLine(nome);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
    
        }
    }
}
