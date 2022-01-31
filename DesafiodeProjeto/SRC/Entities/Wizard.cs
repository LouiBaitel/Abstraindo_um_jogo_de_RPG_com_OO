namespace DesafiodeProjeto.SRC.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HPminima, int HPmaxima, int MPminima, int MPmaxima) : base(Name, Level, HeroType, HPminima, HPmaxima, MPminima, MPmaxima)
        {
        }

        public override string Attack()
       {
           return this.Name + " lançou um feitiço!";
       }

       public string Attack( int Bonus)
       {
           if ( Bonus > 6)
           {
               return this.Name + " lançou um feitiço super efetivo com bônus de ataque de " + Bonus + "!";
           }
           else{
               return this.Name + " lançou um feitiço fraco com bônus de ataque de " + Bonus + "!";
           }

       }
    }
}