namespace GestionTrabajadoresConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Register new IT worker");
                Console.WriteLine("2. Register new team");
                Console.WriteLine("3. Register new task (unassigned to anyone)");
                Console.WriteLine("4. List all team names");
                Console.WriteLine("5. List team members by team name");
                Console.WriteLine("6. List unassigned tasks");
                Console.WriteLine("7. List task assignments by team name");
                Console.WriteLine("8. Assign IT worker to a team as manager");
                Console.WriteLine("9. Assign IT worker to a team as technician");
                Console.WriteLine("10. Assign task to IT worker");
                Console.WriteLine("11. Unregister IT worker");
                Console.WriteLine("12. Exit");
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("What action do you want to perform?");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have chosen option 1");
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
                        Console.WriteLine("You have chosen option 7");
                        break;
                    case 8:
                        Console.WriteLine("You have chosen option 8");
                        break;
                    case 9:
                        Console.WriteLine("You have chosen option 9");
                        break;
                    case 10:
                        Console.WriteLine("You have chosen option 10");
                        break;
                    case 11:
                        Console.WriteLine("You have chosen option 11");
                        break;
                    case 12:
                        Console.WriteLine("Leaving the program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choose an option between 1 and 12");
                        break;
                }
            }
        }
    }
}
