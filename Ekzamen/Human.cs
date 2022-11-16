

namespace Ekzamen
{
    public abstract class Human : Entity
    {
        public Human(int power, int health) : base(power, health)
        {
        }
    }
    public class ForestKiller : Human
    {
        public ForestKiller(int power, int health) : base(power, health) { }
    }
    public class Vampire : Human
    {
        public Vampire(int power, int health) : base(power, health) { }
    }
    public class Werewolf : Human
    {
        public Werewolf(int power, int health) : base(power, health) { }
    }
}
