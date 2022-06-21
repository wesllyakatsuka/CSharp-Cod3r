using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count); // conta o tamanho em Coleções. Equivale ao "Array.Lenght"

            Console.WriteLine(fila.Dequeue()); // deleta o elemento da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); // esse Queue não usa o Generics do "using System.Collections.Generic;"
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); // Como "item" está em minuúsculo não reconhece o "Item" da linha 31
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}