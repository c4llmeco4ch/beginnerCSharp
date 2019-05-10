using System;
public class SportsBall{
    public static void Main(string[] args){
        bool isValid = false;
        int teamA = -1;
        int teamB = -1;
        while (!isValid){
            Console.WriteLine("What was the first team\'s score? ");
            teamA = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("How about the second team\'s score? ");
            teamB = Convert.ToInt32(Console.ReadLine())
            if (!(teamA < 0 || teamB < 0)){
                isValid = true;
            }
            else{
                Console.WriteLine("Please make sure both teams have a positive (or zero) score. ");
            }
        }
        if(teamA > teamB){
            Console.WriteLine("Team A won with {0} points!", teamA);
        }
        else if(teamB > teamA){
            Console.WriteLine("Team B won with {0} points!", teamB);
        }
        else{
            Console.WriteLine("It's a tie with a score of {0} to {1}", teamA, teamB);
        }
    }
}