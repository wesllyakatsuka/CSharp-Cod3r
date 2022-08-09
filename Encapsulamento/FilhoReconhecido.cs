using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
   public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("     Class FilhoReconhecido...");
            Console.WriteLine("         Classe FilhoReconhecido - Método MeusAcessos()");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
          //Console.WriteLine(TomaMuitaCocaCola);
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
