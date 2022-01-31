namespace DesafiodeProjeto.SRC.Entities
{
    public abstract class Hero
    {
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? HeroType { get; set; }
        public int HPminima { get; set; }
        public int HPmaxima { get; set; }
        public int MPminima { get; set; }
        public int MPmaxima { get; set; }

        public Hero(string Name, int Level, string HeroType, int HPminima, int HPmaxima, int MPminima, int MPmaxima)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPminima = HPminima;
            this.HPmaxima = HPmaxima;
            this.MPminima = MPminima;
            this.MPmaxima = MPmaxima;
        }

        public override string ToString ()
        {
            return "Olá, meu nome é " + this.Name + ", possuo nível " + this.Level + " e meu tipo é " + this.HeroType + "." + "\n HP: " + HPminima + "/" + HPmaxima + 
            "\n MP: " + MPminima + "/" + MPmaxima;
        }
        
        public virtual string Attack()
        {
            return this.Name + " atacou com sua espada!";
        }
    }
}