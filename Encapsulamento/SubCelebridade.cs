using System;


namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herança
        protected string CorDoOlho = "Verde";

        // Mesmo projeto (Assembly)
        internal ulong NumeroCelular = 5511969817979;

        // Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Coloquial";

        //Mesma classe ou Herança no mesmo Projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Sempre vaza!";

        // private é o padrão
        readonly bool TomaMuitaCocaCola = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubClebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(TomaMuitaCocaCola);

        }

    }
}
