using System;

class CoinStar {

  public static void Main (string[] args) {
  
  double change, Fred , M_return, F_return;
  int quarters, dimes, nickels, pennies, changequarter, changedime,changenickels, money; 
  string A;  
  
  // asking for the amount of change you have to put into the machine
    Console.WriteLine ("please enter your amount of change you're going to put into the coinstar to get the amount of cash you will recieve from a CoinStar.(in decimal top the hundreds place)");

    // converting the amount entered into an integer to be manipulated
    A = Console.ReadLine();
    change = double.Parse(A);
    Fred= change* 100;
    money = (int)Fred;
   // manipulating the integer money to find the number of each coin into the machine 
    quarters=money/25;
    changequarter = money%25;

    changedime = changequarter%10;
    dimes = changequarter/10;

    nickels = changedime/5 ;
    changenickels = changedime%5;

    pennies= changenickels;
    // taking the fee into account and calculating the money return 
    M_return = change * .109;
    F_return = change - M_return;

  
    Console.WriteLine("you have input approximately "+ quarters + " quarters," + dimes+ " dimes," + nickels+ " nickels " + pennies + " pennies.");
    Console.WriteLine("you will end up with a return of $ {0:0.00}", F_return);
    


  




  }
}