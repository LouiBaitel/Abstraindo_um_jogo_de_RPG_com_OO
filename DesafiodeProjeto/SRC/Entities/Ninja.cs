namespace DesafiodeProjeto.SRC.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HPminima, int HPmaxima, int MPminima, int MPmaxima) : base(Name, Level, HeroType, HPminima, HPmaxima, MPminima, MPmaxima)
        {
        }

        public string Attack( int Bonus)
        {
            if ( Bonus > 6)
            {
                return this.Name + " lançou um ataque sombrio super efetivo com bônus de " + Bonus + "!";
            }
            else{
                return this.Name + " lançou um ataque sombrio fraco com bônus de " + Bonus + "!";
            }

       }
    }
}