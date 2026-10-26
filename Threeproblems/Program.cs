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


System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");

do
{
    System.Console.WriteLine("");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");
    Console.Write("Choose 1 through 5: "); 
    choice = Convert.ToInt32(Console.ReadLine()); 
    Console.Clear();
    
//Grade checker
    if(choice == 1 || choice == 4)
    {
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
            System.Console.WriteLine("");
            break;
        }
    }

    // The Dice Table
    if(choice == 2 || choice == 4)
    {
        System.Console.WriteLine("=== Exercirse 2: The Dice Table ===");
        do
        {
            numOne = rng.Next(1, 7);
            numTwo = rng.Next(1, 7);
            numThree = numOne + numTwo;

            numb++;
            Console.Write("Roll " + numb + ": " + numOne + " and " + numTwo + ", total " + numThree);
            Console.Write(" Roll again? (y/n): " );
            rollAgain = Console.ReadLine().ToLower();

            if(numThree == 7)
            {
                winnings++;
            }

        }while(rollAgain == "y" );

        
        System.Console.WriteLine("You rolled " + numb + " times and won " + winnings);
    }

    if(choice == 3 || choice == 4)
    {
        System.Console.WriteLine("Option 3: ");
    }
} while(choice != 5);

System.Console.WriteLine("Goodbye. ");