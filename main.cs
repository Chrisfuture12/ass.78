using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info350
{
    class main
    {
        public static int Input(){
            string inIT;
            Console.WriteLine("Choose the number for your choice: rock '1', paper '2', scissors '3'.");
            inIT = Console.ReadLine();
            int inputt = int.Parse(inIT);
            return inputt;
        }
        public static void displayHistory(string x){
            Console.WriteLine(x);
        }
        
        public static void Main()
        {
               // double bet;
                double wallet= 100;
                int countingU = 0;
                int countingC = 0;
                int [] userC = new int[7];
                int [] cmptC = new int [7];
                Random rnd = new Random();
                Game game = new Game();
            Console.WriteLine("\t Games rules: ");
            Console.WriteLine("\t A win is a win. A loss is a loss. and a tie is a loss.");
            for (int i = 0; i < 7; i++)
            {
                userC [i] = Input();
                cmptC [i] = rnd.Next(1, 4);
                    
                //win 
                if ((userC[i] == 1 && cmptC[i] == 3) || (userC[i] == 2 && cmptC[i] == 1) || (userC[i] == 3 && cmptC[i] == 2))
                {
                wallet = game.calcWin(wallet);
                    Console.WriteLine("\tYou won, Your money is now: $"+ wallet+".");
                    countingU = game.countWin(countingU);             
                } 
                //tie
                else if (userC[i] == 0){
                    break;
                }
                // lose : A tie indicated a loss.
                else 
                {
                    wallet = game.calcLose(wallet);
                    Console.WriteLine("\tYou lost, Your money is now: $"+ wallet+".");
                    countingC = game.countLose(countingC);
                }
                if (countingC == 4 || countingU ==4 || wallet <= 0){
                    Console.WriteLine("\tGameover sucka!");
                    if (countingC ==4){
                        Console.WriteLine("\tThe computer won the entire game, sucka.");
                    } else if (countingU == 4){
                        Console.WriteLine("\tYou won the entire game.");
                    }
                    break;
                }
                Console.WriteLine("\tEnd of game "+i);
                Console.WriteLine("\tComputer score: "+countingC);
                Console.WriteLine("\tUser score: "+countingU);
            } 
            Console.WriteLine();

            displayHistory("\tGame history");
            for (int i = 0; i < userC.Length; i++){
                displayHistory("\tGame "+ i +": User move: " + userC[i]+ ". Computer move: "+cmptC[i]+".");
            }
            Console.ReadKey();
        }
       
    }
}