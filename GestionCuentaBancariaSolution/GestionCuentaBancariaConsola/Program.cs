﻿// See https://aka.ms/new-console-template for more information
bool exit = false;
decimal balance = 10;
bool isNumber;

while (!exit)
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1. Money income");
    Console.WriteLine("2. Money outcome");
    Console.WriteLine("3. List all movements");
    Console.WriteLine("4. List incomes");
    Console.WriteLine("5. List outcomes");
    Console.WriteLine("6. Show current money");
    Console.WriteLine("7. Exit");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("What action do you want to perform?");

    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            decimal numberIncome;
            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Money deposit - Please enter an amount:");
                String income = Console.ReadLine();
                isNumber = decimal.TryParse(income, out numberIncome);

                if (isNumber)
                {
                    if (numberIncome <= 0)
                    {
                        Console.WriteLine("Error! The value must be a positive number and cannot be 0.");
                    }
                    else
                    {
                        Console.WriteLine("You have successfully entered: " + numberIncome);
                        balance += numberIncome;
                        Console.WriteLine("The current balance is: " + balance);
                    }
                }
                else
                {
                    Console.WriteLine("Error! Please enter a valid numerical value.");
                }
            } while (!isNumber || numberIncome <= 0);

            break;
        case 2:
            Console.WriteLine("You have chosen option 2");
            break;
        case 3:
            Console.WriteLine("You have chosen option 3");
            break;
        case 4:
            Console.WriteLine("You have chosen option 4");
            break;
        case 5:
            Console.WriteLine("You have chosen option 5");
            break;
        case 6:
            Console.WriteLine("You have chosen option 6");
            break;
        case 7:
            Console.WriteLine("Exiting the program...");
            exit = true;
            break;
        default:
            Console.WriteLine("Choose an option between 1 and 7");
            break;
    }
}