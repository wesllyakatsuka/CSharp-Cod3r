using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            Console.WriteLine("-------- Tipos númericos ------------");
            int inteiro = 10;
            double quebrado = inteiro; //Não haverá perda e houve uma conversão implícita
            Console.WriteLine(quebrado);
         
            double nota = 9.7;
            int notaTruncada = (int) nota; //Preciso fazer o Cast para deixar claro que sou ciente da perda
            Console.WriteLine(notaTruncada); // 9  o valor que estiver após o ponto é ignorado

            Console.WriteLine("-----------  Tipos caracteres  --------------");
            Console.Write("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString); //Retorna erro. Não consegue converter string em inteiro
            Console.WriteLine($"Resultado {idadeInteiro}");

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); //TryParse converte em 0 caso venha uma string
            Console.WriteLine($"Resultado {numero1}");

            //Esse bloco abaixo é o mesmo que o bloco de cima em versão otimizada
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado {numero2}");


        }
    }
}
