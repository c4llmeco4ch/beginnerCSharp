using System;
public class GuessingGame{
    public static void Main(string[] args){
        int high = 100;
        int low = 0;
        int guess = 50;
        bool isCorrect = false;
        while(!isCorrect){
            Console.WriteLine("My guess is {0}", guess);
            Console.WriteLine("Is my guess correct (c), too high (h), or too low (l)? ");
            switch(Console.ReadLine()){
                case "c":
                    isCorrect = !isCorrect;
                    Console.WriteLine("Yay!");
                    break;
                case "h":
                    high = guess - 1;
                    guess = Calculate(low, high);
                    break;
                case "l":
                    low = guess + 1;
                    guess = Calculate(low, high);
                    break;
                default:
                    Console.WriteLine("Invalid Input, please use \"c\", \"h\", or \"l\".");
                    break;
            }
        }
    }

    public static int Calculate(int l, int h){
        return Convert.ToInt32(Math.Floor((decimal)((l + h) / 2)));
    }
}