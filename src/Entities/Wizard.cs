namespace dio_abstracao_rpg.src.Entities
{
public class Wizard : Hero
    { 
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " atacou com magia!";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6){
                return this.Name + " atacou com magia elemental, dano crítico! Bonus de " + bonus + " pontos!";    
            } else {
                return this.Name + " atacou com magia, mas o oponente é imune ao elemento... Bonus de " + bonus + " pontos.";
            }
        }
    }
}