using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var dragonHealth=100;
            var playerDamage=random.Next(0,101);
            var dragonKill = 0;
            Boolean playing = true;
            Boolean fighting = false;
            var take=0;
            var kill=0;
            var escape = 0;

            while (playing)
            {
                dragonHealth = 100;
                playerDamage = random.Next(0, 101);
                dragonKill = 0;
                playing = true;
                fighting = false;
                take = 0;
                kill = 0;
                escape = 0;
                Console.WriteLine("You have come upon a cave. As you stumble inside, you are captured by the gold hidden within. Suddenly, you hear a loud breathing and realize there is a dragon next to you. What will you do!");
                Console.WriteLine("Run, Take, or Kill");
                string ansQ1 = Console.ReadLine();
                ansQ1.ToLower();
                if (ansQ1 == "run")
                {
                    escape = random.Next(0, 3);
                    if (escape == 0)
                    {
                        Console.WriteLine("The dragon woke up and ate you!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else if (escape == 1)
                    {
                        Console.WriteLine("The dragon woke up but you got away!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("The dragon stayed sound asleep and you got away!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
                if (ansQ1 == "take")
                {
                    take = random.Next(0, 3);
                    if (take == 0)
                    {
                        Console.WriteLine("The dragon woke up and ate you!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else if (take == 1)
                    {
                        Console.WriteLine("The dragon woke up but you got away with the gold!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("The dragon stayed sound asleep and you got away with the gold!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
                if (ansQ1 == "kill")
                {
                    fighting = true;
                    kill = random.Next(0, 2);
                    while (fighting)
                    {
                        if(kill==0)kill = random.Next(0, 2);
                        if (kill == 0)
                        {
                            Console.WriteLine("The dragon kept sleeping!");
                            playerDamage = random.Next(0, 101);
                            dragonHealth -= playerDamage;
                            Console.WriteLine("You did " + playerDamage + " damage to the dragon!");
                        }
                        else if (kill == 1)
                        {
                            Console.WriteLine("The dragon woke up!");
                            playerDamage = random.Next(0, 101);
                            dragonHealth -= playerDamage;
                            Console.WriteLine("You did " + playerDamage + " damage to the dragon!");
                            dragonKill = random.Next(0, 2);
                        }
                        if (dragonHealth <= 0 && dragonKill == 1)
                        {
                            Console.WriteLine("Both you and the dragon have slain each other!");
                            fighting = false;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else if (dragonHealth <= 0 && dragonKill == 0)
                        {
                            Console.WriteLine("You have killed the dragon and taken the Gold!");
                            fighting = false;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else if (dragonKill == 1)
                        {
                            Console.WriteLine("The dragon ate you!");
                            fighting = false;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
