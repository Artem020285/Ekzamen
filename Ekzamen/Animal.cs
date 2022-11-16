namespace Ekzamen
{
    public abstract class Animal : Entity
    {
        public Animal(int power, int health) : base(power, health)
        {
        }
    }
    public class Rabbit : Animal
    {
        public Rabbit(int power, int health) : base(power, health)
        {
        }
    }
    public class Fox : Animal
    {
        public Fox(int power, int health) : base(power, health) { }
    }
    public class Wolf : Animal
    {
        public Wolf(int power, int health) : base(power, health) { }
    }
}