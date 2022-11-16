

using System.Numerics;

namespace Ekzamen
{
    public class Game
    {
        private Player _player;

        public Game(Player player)
        {
            _player = player;
            _player.OnPlayerMove += MeetingPoint;
        }

        public void MeetingPoint()
        {
            Rabbit rabbit = new Rabbit(10, 20);
            Fox fox = new Fox(20, 40);
            Wolf wolf = new Wolf(30, 50);
            ForestKiller forestKiller = new ForestKiller(40, 60);
            Vampire vampire = new Vampire(70, 80);
            Werewolf werewolf = new Werewolf(90, 90);

            int plaeyrX = _player.GetCoord("X");
            int plaeyrZ = _player.GetCoord("Z");

            if (plaeyrX == 1 && plaeyrZ == 1)
            {
                Console.WriteLine("Вы встретили Кролика");
                _player.Attack(rabbit);
            }

            else if (plaeyrX == -2 && plaeyrZ == 3)
            {
                Console.WriteLine("Вы встретили Вампира");
                _player.Attack(vampire);
            }

            else if (plaeyrX == 0 && plaeyrZ == 4)
            {
                Console.WriteLine("Вы встретили Лису");
                _player.Attack(fox);
            }

            else if (plaeyrX == -5 && plaeyrZ == 2)
            {
                Console.WriteLine("Вы встретили Волка");
                _player.Attack(wolf);
            }

            else if (plaeyrX == 3 && plaeyrZ == 0)
            {
                Console.WriteLine("Вы встретили Лесного убийцу");
                _player.Attack(forestKiller);
            }

            else if (plaeyrX == 5 && plaeyrZ == 6)
            {
                Console.WriteLine("Вы встретили Оборотня");
                _player.Attack(werewolf);
            }


        }
       

        public void Come(Player player)
        {
           
            bool Stop = false;
            while (player.Power > 0 && !Stop)
            {
                ConsoleKey pressedKey = Console.ReadKey().Key;
                switch (pressedKey)
                {
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Идём вправо");
                        player.Move(Direction.Right);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  *      ***     *     ***     * ");
                        Console.WriteLine(" ***    * * *   ***   * * *   *** ");
                        Console.WriteLine("*****     *    *****    *    ***** ");
                        Console.ResetColor();
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Идём влево");
                        player.Move(Direction.Left);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  *      ***     *     ***     * ");
                        Console.WriteLine(" ***    * * *   ***   * * *   *** ");
                        Console.WriteLine("*****     *    *****    *    ***** ");
                        Console.ResetColor();
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Идём вперед");
                        player.Move(Direction.Forward);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  *      ***     *     ***     * ");
                        Console.WriteLine(" ***    * * *   ***   * * *   *** ");
                        Console.WriteLine("*****     *    *****    *    ***** ");
                        Console.ResetColor();
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Идём назад");
                        player.Move(Direction.Backward);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  *      ***     *     ***     * ");
                        Console.WriteLine(" ***    * * *   ***   * * *   *** ");
                        Console.WriteLine("*****     *    *****    *    ***** ");
                        Console.ResetColor();
                        break;
                     default:
                        Stop = true;
                        Console.WriteLine("Конец игре!\nНадеюсь вам понравилось!");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("                  ***** ");
                        Console.WriteLine("               *          *");
                        Console.WriteLine("             *   **   **   *");
                        Console.WriteLine("            *               *");
                        Console.WriteLine("            *    *     *    *");
                        Console.WriteLine("             *    *****    *");
                        Console.WriteLine("               *          *  ");
                        Console.WriteLine("                  *****");
                        Console.ResetColor();
                        break ;
                }
                

            }

        }
    }
}
