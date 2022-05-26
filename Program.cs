using System;

namespace HomeTask
{
    class Program
    {

        public delegate void Operation();
        public static void Exit()
        {
            Console.WriteLine("Bye bye!");
            Environment.Exit(0);
        }
        public static void NewGame() => Console.WriteLine("You have started new game!");
        public static void LoadGame() => Console.WriteLine("You are loading the game");
        public static void Rulse() => Console.WriteLine("\"Some Rules\"");
        public static void AboutAuthor() => Console.WriteLine("This game was created in 1989 by Mickel Tomphson...no more info..");

        static void Main()
        {
            Console.WriteLine("What do you want?:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Read Rulse");
            Console.WriteLine("4 - About");
            Console.WriteLine("0 - Exit");
            Operation operation;
            while (true)
            {
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        operation = NewGame;
                        operation();
                        break;
                    case 2:
                        operation = LoadGame;
                        operation();
                        break;
                    case 3:
                        operation = Rulse;
                        operation();
                        break;
                    case 4:
                        operation = AboutAuthor;
                        operation();
                        break;
                    default:
                        operation = Exit;
                        operation();
                        break;
                }
            }
        }
    }
}