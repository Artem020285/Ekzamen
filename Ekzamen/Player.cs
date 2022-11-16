

namespace Ekzamen
{
    public class Player : Entity
    {
        private int _health;

        public event Action OnPlayerMove; // Событие для движения игрока

        private Coords PlaeyrCoords;

        public int Health
        {
            get => _health;
            set
            {
                if (value >= 0 || value <= 100)
                    _health = value;
            }
        }
       
        public Player(int power, int health) : base(power, health)
        {
            PlaeyrCoords = new Coords(0, 0, 0);
        }



        public int GetCoord(string coords) //Передаёт координаты игрока
        {
            switch (coords)
            {
                case "X":
                    return PlaeyrCoords.X;

                case "Y":
                    return PlaeyrCoords.Y;

                case "Z":
                    return PlaeyrCoords.Z;

                default:
                    throw new Exception("Неверное значение координаты");
            }
        }
        private void ShowCoords()   // Вывод на консоль координаты игрока
        {
            Console.WriteLine($"Игрок находиться в координатах" +
                $" {PlaeyrCoords.X} : {PlaeyrCoords.Y} : {PlaeyrCoords.Z}");
        }

        public void Move(Direction direction) // Создали enum (колекцию) напрвление директ

        {
            switch (direction)
            {
                case Direction.Forward:
                    PlaeyrCoords.Z++;
                    break;
                case Direction.Right:
                    PlaeyrCoords.X++;
                    break;
                case Direction.Left:
                    PlaeyrCoords.X--;
                    break;
                case Direction.Backward:
                    PlaeyrCoords.Z--;
                    break;

            }

            ShowCoords();
            OnPlayerMove?.Invoke();
        }
    }
}
