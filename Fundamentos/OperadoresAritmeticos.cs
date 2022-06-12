using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Calculando preço com desconto
            var preco = 1000.0; //Não foi declarado propositalmente o tipo de dados por conta da inferência
            var imposto = 355; //Por inferência o compilador entende que o tipo é int
            var desconto = 0.1; //Outro exemplo de inferência

            double total = preco + imposto; //Salvando em um tipo double a soma de um double com int
            var totalComDesconto = total - (total * desconto); //Os parênteses é apenas para explicitar já que * tem precedência matemática
            Console.WriteLine("O preço final é {0}", totalComDesconto); //Uma alternativa de interpolação

            // Calculando IMC
            double peso = 140.0;
            double altura = 1.74;
            double imc = peso / Math.Pow(altura, 2); // mesma coisa que: imc = peso / (altura * altura)
            Console.WriteLine("IMC é " + imc);

            // Identifica se número é par ou ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine($"{par} / 2 tem resto {par % 2}");
            Console.WriteLine($"{impar} / 2 tem resto {impar % 2}");
        }
    }
}
