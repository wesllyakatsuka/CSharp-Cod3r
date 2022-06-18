using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996);
            Formatar(ano: 2022, mes: 6, dia: 18);

            Console.WriteLine();
            Console.WriteLine("\t Program to get Day Of the Week After Specified Days");
            Console.WriteLine("\t ==================================================================");
            Console.Write("\t Enter Days After Today : ");
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Now.AddDays(days);
            Console.WriteLine("\t Current Date : " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine("\t Date After {0} Days : {1}", days, date.ToString("dd/MM/yyyy"));
            Console.WriteLine("\t Day Of The Week On {0} : {1}", date.ToString("dd/MM/yyyy"), date.DayOfWeek);
            Console.ReadKey();
        }
    }
}
