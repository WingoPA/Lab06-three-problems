/*
* Name: Peyton Wingo
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/


// The Menu

using System.ComponentModel;
using System.Reflection.Metadata;

int choice = 0;
int score = 0;
int numb = 0;

int numOne;
int numTwo;
int numThree;
int winnings = 0;

string rollAgain; 

Random rng = new Random(4000);

int[] scores = new int[5];
int total = 0;
int highest = scores[0];
int passingCount = 0;

do
{
    System.Console.WriteLine("");
    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");

    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");
    Console.Write("Choose 1 through 5: "); 
    choice = Convert.ToInt32(Console.ReadLine()); 
   
    
    //Grade checker
    if(choice == 1 || choice == 4)
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        Console.Write("Score: "); 
        score = Convert.ToInt32(Console.ReadLine());

        
        while(score >= 0 || score <= 100)
        {
            while(score < 0 || score > 100)
        {
            System.Console.WriteLine("A score must be between 0 and 100");
            Console.Write("Score: "); 
            score = Convert.ToInt32(Console.ReadLine());
        }
            if(score >= 90)
            {
             System.Console.WriteLine(score.ToString() + " earns an A");   
            }else if(score >= 80)
            {
            System.Console.WriteLine(score.ToString() + " earns a B");  
            }else if(score >= 70)
            {
            System.Console.WriteLine(score.ToString() + " earns a C");  
            }else if(score >= 60)
            {
            System.Console.WriteLine(score.ToString() + " earns a D ");  
            }else if(score < 60)
            {
            System.Console.WriteLine(score.ToString() + " earns an F ");  
            }

            break;
        }
    }

    // The Dice Table
    if(choice == 2 || choice == 4)
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("=== Exercirse 2: The Dice Table ===");
        do
        {
            numOne = rng.Next(1, 7);
            numTwo = rng.Next(1, 7);
            numThree = numOne + numTwo;

            numb++;
            Console.Write("Roll " + numb + ": " + numOne + " and " + numTwo + ", total " + numThree);

            if(numOne == 1 && numTwo == 1)
            {
                Console.Write(" Snake eyes");
            }else if(numOne  == numTwo)

            {
                Console.Write(" Doubles");
            }

            if(numThree == 7 || numThree == 11)
            {
                Console.Write(" A winner.");
            }


            Console.Write(" Roll again? (y/n): " );
            rollAgain = Console.ReadLine().ToLower();

            if(numThree == 7)
            {
                winnings++;
            }

        }while(rollAgain == "y" );

        
        System.Console.WriteLine("You rolled " + numb + " times and won " + winnings);
        numb = 0;
    }
    // The score report
    if(choice == 3 || choice == 4)
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("=== Exercise 3: The Score Report ===");
        for(int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach(int  scored in scores)
        {
            total += scored;

            if(scored > highest)
            {
                highest = scored;
            }

            if(scored >= 60)
            {
                passingCount++;
            }
        }

        double average = (double)total / scores.Length;

        System.Console.WriteLine("");
        System.Console.WriteLine("Scores entered: " + scores.Length.ToString());
        System.Console.WriteLine($"Total: {total}");
        System.Console.WriteLine($"Average: {average:F1}");
        System.Console.WriteLine($"Highest: {highest}");
        System.Console.WriteLine($"Passing: {passingCount} of 5");
    }
} while(choice != 5);
System.Console.WriteLine("");
System.Console.WriteLine("Goodbye. ");