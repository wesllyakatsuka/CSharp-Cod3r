﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 5.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            } else
            {
                Console.WriteLine("Recuperação...");
            }
        }
    }
}
