using System;

namespace randomNumber1
{
    class Program
    {
        static int SafeNumberInput()
        {

            
            int input;
            while (true)
            {
                Console.WriteLine("Gissa ett tal mellan 1-100: ");
                if (int.TryParse(Console.ReadLine(), out input) == true)
                    break;
                Console.WriteLine("Var vänlig bara siffor tack!");
                
                
            }

            return input;
        }

        static void Play(int randomNumber)
        {
            
            int amountOfTimes = 1;
            
            while (true)
            {
                int input = SafeNumberInput();
                    if (input < randomNumber)
                    {
                        Console.WriteLine($"Gisnning {amountOfTimes}: Talet är större");
                        

                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine($"Gisnning {amountOfTimes}; Talet är mindre"); 

                    }
                    else if (input==randomNumber)
                    {
                        Console.WriteLine($"Rätt! du gissade rätt på {amountOfTimes} försök");
                        break;
                    }


                amountOfTimes++;
                
            }

        }

        static bool End()
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine("Vill du spela igen? Ja/Nej?");
                string choice = Console.ReadLine().ToLower();

                if (choice == "ja")
                {
                    break;
                }
                else if (choice == "nej")
                {
                    Console.WriteLine("Nu är spelet slut");
                    result = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Var snäll och svara med Ja eller Nej");
                }
            }

            return result;
        }

        
        static void Main(string[] args)
        {
            bool endGame = false;
            while (endGame == false)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 100);

                Play(randomNumber);
                endGame = End();
            }
       

            
        }
        
            
        
    }
}
