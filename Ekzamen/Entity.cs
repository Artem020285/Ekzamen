using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Ekzamen
{
    public abstract class Entity
    {
        public int Power { get; }
        public int Health { get; set; }
      
        public event Action? OnEntityDead;
        public event Action<Entity, int>? OnDamageGatted;
        public Entity(int power, int health)
        {
            Power = power;
            Health = health;
            OnDamageGatted += GateDamage;
        }

        public void Attack(Entity enemy)
        {
            enemy.OnDamageGatted?.Invoke(this, Power); // передаём в событие значения через метод инвок
        }

        private void GateDamage(Entity source, int power) 
        {
            if (this != source)
            {
                Health -= power;
                if (source.Health > 0)
                {
                    Console.WriteLine($"Сущность получил урон." +
                        $"Его здоровье {Health} ");
                }

            }
            else
                OnEntityDead.Invoke();
        }
        public void Dead()
        {
            Console.WriteLine($"Игрок умер!");
            OnDamageGatted -= GateDamage;
        }

    }
}
