using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            static void Run()
            {
                var option = GetInt("1.add role\n 2.attak");
                switch (option)
                {
                    case 1:
                        {
                            int roleSpeed=0;
                            var roleType = GetInt("1.hero 2.enemy 3.nokhodi");
                            var roleName = GetString("what is the name?");
                            var rolePower = GetInt("what is the power?");
                            if (roleType==1)
                            {
                                 roleSpeed = GetInt("what is the speed?");
                            }
                           
                            Game.AddHero(roleType, roleName, roleSpeed, rolePower);
                            break;
                        }
                    case 2:
                        {
                            var fightar = GetString("what is the fighter name?");
                            var defender = GetString("what is the deffender name?");
                            Game.Attack(fightar, defender);
                            break;
                        }
                }
            }
            static string GetString(string message)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine()!;
                return value;
            }

            static int GetInt(string message)
            {
                Console.WriteLine(message);
                int value = int.Parse(Console.ReadLine()!);
                return value;
            }
        }
    }
}
