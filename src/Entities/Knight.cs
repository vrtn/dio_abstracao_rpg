namespace dio_abstracao_rpg.src.Entities
{
public class Knight:Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

    public override string Attack()
        {
            return this.Name + " atacou com sua espada! ";
        }
    }
}