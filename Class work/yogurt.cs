
using System;

class MainClass {
    public static void Main () {

    double Discount , Tip , total , saletax, Yogurt, toppings;
    string Disc_string, Tip_string, Q_toppings, Q_Yogurt;

    Console.WriteLine ("welcome to Yoville! How many ounces of yogurt are you purchasing today?");
    Q_Yogurt = Console.ReadLine();
    Yogurt = double.Parse(Q_Yogurt);

    Console.WriteLine("Would you like to add any toppings? They're only 50 cents each.");
    Q_toppings = Console.ReadLine();
    toppings = double.Parse(Q_toppings);

    Console.WriteLine("Before we calculate your total please input the percent of any coupon discounts that you have as a whole number. ex. 20");
    Disc_string = Console.ReadLine();
    Discount = double.Parse(Disc_string);

    Console.WriteLine("Would you like to leave a tip?(enter as a number ex. 5.50");
    Tip_string = Console.ReadLine();
    Tip = double.Parse(Tip_string);

    saletax = .725;
    total = ((toppings*.5) + (Yogurt*.17)*saletax)*Discount; 

    Console.WriteLine("Thank you! Your Savings today are " + Discount);
    Console.WriteLine("Yogurt Cost: {0:0.00} " , Yogurt*.17);   
    Console.WriteLine("Toppings Cost: {0:0.00} " , toppings*.5);
    Console.WriteLine("Sales tax: "+ saletax);
    Console.WriteLine("Tip: "+ Tip);
    Console.WriteLine("Total= " + total + "$");
    Console.WriteLine("Thank You and Please Come Again!")
  }
}