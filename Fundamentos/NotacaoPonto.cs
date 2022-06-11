using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            // uso da interrogação utiliza o conceito de navegação segura prosseguindo apenas se for true
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
