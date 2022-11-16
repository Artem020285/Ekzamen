using System.Diagnostics;
using System.Numerics;
using System;

namespace Ekzamen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();

            Console.WriteLine("<<<<<<<<<<<<<<<<<<< ИГРА ОХОТНИК >>>>>>>>>>>>>>>>>>>>\n\n");
            Console.WriteLine("Вы находитесь в лесу, вам предстоит нелёгкий путь домой," +
                "вам могут повстречаться различные животные и твари.\n" +
                "Они захотят вас укусить, сьесть - но у вас есть сила которую вы можете " +
                "воспользовать при случаюх нападения.\n" +
                "Но так как вы в начале пути хочу вам подкинуть немного здоровья, если ответите " +
                "правильно на загадку!\n");
            Console.WriteLine("********************************************************\n");
            Console.WriteLine("Стоит частокол,\r\nНо живой весь он" +
                ",\r\nЗаблудиться в нём легко,\r\nВыход всюду у него.\r\n");
            
            Console.WriteLine("********************************************************\n");
            Console.WriteLine("У вас есть три попытки!");
            int numm = 3;
            bool isTrueWord = false;

            while (numm > 0 && !isTrueWord)
            {
                string clue = Console.ReadLine();
                if (clue == "Forest" || clue == "forest" || clue == "Лес" || clue == "лес")
                {
                    Console.WriteLine("Ура!\n Я вас поздравляю у вас 100 баллов здоровья!\n");
                    isTrueWord = true;
                    Console.WriteLine("У вас отличный шанс на победу, предлагаю вам " +
                        "три направления пути - вперёд, влево, вправо(выбор курсором)");
                    Player player = new Player(40, 100); 
                   Game game = new Game(player);
                    game.Come(player); 

                }
                else
                    Console.WriteLine("Неправельный ответ\n");

                numm--;

            }


            //Player player = new Player(20, 7);
            //Rabbit rabbit = new Rabbit(6);
            //player.Attack(rabbit);
            TimeSpan ts = myStopwatch.Elapsed;
            myStopwatch.Stop();
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("Общие количество времени затраченое на игру - " + elapsedTime);
            Console.ReadKey();
            
        }
    }
}