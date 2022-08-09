using System;
using Encapsulamento;

namespace CSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade 
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("     Class FilhoNaoReconhecido...");
            Console.WriteLine("         Classe FilhoNaoReconhecido - Método MeusAcessos()");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(TomaMuitaCocaCola);
            Console.WriteLine("-------------------------------------------------");
        }
    }



    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("     Class AmigoDistante...");
            Console.WriteLine("         Classe AmigoDistante - Método MeusAcessos()");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            //Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(TomaMuitaCocaCola);
            Console.WriteLine("-------------------------------------------------");
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            


            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
