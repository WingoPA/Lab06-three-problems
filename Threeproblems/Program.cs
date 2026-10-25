/*
* Name: Peyton Wingo
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

int choice = 0;

System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");

do
{
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");
    Console.Write("Choose 1 through 5: "); choice = Convert.ToInt32(Console.ReadLine()); 
    Console.Clear();

    if(choice == 1 || choice == 4)
    {
        
        System.Console.WriteLine("Option 1:");
    }

    if(choice == 2 || choice == 4)
    {
        System.Console.WriteLine("Option 2: ");
    }

    if(choice == 3 || choice == 4)
    {
        System.Console.WriteLine("Option 3: ");
    }
} while(choice != 5);

System.Console.WriteLine("Goodbye. ");