using System;
using dio_abstracao_rpg.src.Entities;

namespace dio_abstracao_rpg
{
class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",23,"Knight");
            Wizard jennica = new Wizard("Jennica",22,"White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(20));
            Console.WriteLine(jennica.Attack(2));
        }
    }
}
