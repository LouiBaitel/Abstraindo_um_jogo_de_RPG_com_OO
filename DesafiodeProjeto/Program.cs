using DesafiodeProjeto.SRC.Entities;
using static System.Console;

namespace DesafiodeProjeto
{
    class Program
    {
        static void Main (string [] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 245, 587, 12, 45);
            Wizard jennika = new Wizard("Jennika", 47, "White Wizard", 147, 356, 248, 564);
            Ninja junji = new Ninja("Junji Ito", 45, "Ninja", 540, 780, 150, 347);

            //-------- Apresentação do personagem
            WriteLine(arus.ToString());
            WriteLine(jennika.ToString());
            WriteLine(junji.ToString());

            //------------ Ataque dos personagens
            WriteLine();
            WriteLine(arus.Attack());
            WriteLine(jennika.Attack(7));
            WriteLine(jennika.Attack(1)); //Polimorfismo
            WriteLine(junji.Attack(8));
        }

    }

}