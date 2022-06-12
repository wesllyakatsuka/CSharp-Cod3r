using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            //Atribuição por valor
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;
            Console.WriteLine(num1);

            int a = 1;
            int b = a;
            a++; // a = a + 1;
            b--; // b = b - 1;
            Console.WriteLine($"a: {a} b: {b}");

           /*
            // Atribuição por referência
            dynamic c = new System.Dynamic.ExpondoObject();
            c.nome = "Porta";

            dynamic d = c;
            d.nome = "Janela";
            Console.WriteLine(c.nome);
           */
        }
    }
}
