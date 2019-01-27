using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info350
{
    class Game
    {
        
        double bet;
        int count; 
        

        public Game(){
            bet = 10;
            count = 1;
        }

        public double calcWin(double wallet)
        {   
            wallet += bet;
            return wallet;
        }
        public double calcLose(double wallet){
            wallet -= bet;
            return wallet;
        }
        public int countWin(int counterU ){
            counterU+=count; 
            return counterU;
        }
        public int countLose(int counterC){
            counterC+=count;
            return counterC;
        }

       /* gamewinner(){

        } 

        gameHistory(){

        }*/
    }
}