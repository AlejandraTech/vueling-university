using System;
using System.Collections.Generic;
using System.Linq;
using GestionTrabajadoresConsole.Class;
using GestionTrabajadoresConsole.Enum;
using WorkerTask = GestionTrabajadoresConsole.Class.Task; // Alias para la clase Task

namespace GestionTrabajadoresConsole
{
    internal class Program
    {
        private static List<ITWorker> workers = new List<ITWorker>();
        private static List<Team> teams = new List<Team>();
        private static List<WorkerTask> tasks = new List<WorkerTask>();
        private static int taskCounter = 1;

        private static ITWorker loggedInWorker = null;
        private static bool isAdmin = false;

        static void Main(string[] args)
        {
            Login();
            bool exit = false;

            while (!exit)
            {
                DisplayMenu();
                int option = GetValidOption(1, 12);

                switch (option)
                {
                    case 1:
                        ExecuteAction(RegisterITWorker);
                        break;
                    case 2:
                        ExecuteAction(RegisterTeam);
                        break;
                    case 3:
                        ExecuteAction(RegisterTask);
                        break;
                    case 4:
                        ExecuteAction(ListTeamNames);
                        break;
                    case 5:
                        ExecuteAction(ListTeamMembersByTeamName);
                        break;
                    case 6:
                        ListUnassignedTasks();
                        break;
                    case 7:
                        ListTaskAssignmentsByTeamName();
                        break;
                    case 8:
                        ExecuteAction(AssignITWorkerManager);
                        break;
                    case 9:
                        ExecuteAction(AssignITWorkerTechnician);
                        break;
                    case 10:
                        AssignTaskITWorker();
                        break;
                    case 11:
                        ExecuteAction(UnregisterITWorker);
                        break;
                    case 12:
                        exit = ChangeAccount();
                        break;
                    default:
                        Console.WriteLine("Please choose an option between 1 and 12.");
                        break;
                }
            }
        }

        static void Login()
        {
            while (true)
            {
                Console.WriteLine("Enter worker ID to login: ");
                int workerId = GetValidInteger();

                if (workerId == 0)
                {
                    isAdmin = true;
                    break;
                }

                loggedInWorker = workers.FirstOrDefault(w => w.Id == workerId);

                if (loggedInWorker == null)
                {
                    Console.WriteLine("This worker ID does not exist. Please try again.");
                    continue;
                }

                isAdmin = false;
                break;
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("-----------------------------------");
            if (isAdmin)
            {
                Console.WriteLine("1. Register new IT worker");
                Console.WriteLine("2. Register new team");
                Console.WriteLine("3. Register new task");
                Console.WriteLine("4. List all team names");
                Console.WriteLine("5. List team members by team name");
                Console.WriteLine("6. List unassigned tasks");
                Console.WriteLine("7. List task assignments by team name");
                Console.WriteLine("8. Assign IT worker to a team as manager");
                Console.WriteLine("9. Assign IT worker to a team as technician");
                Console.WriteLine("10. Assign task to IT worker");
                Console.WriteLine("11. Unregister IT worker");
            }
            else if (loggedInWorker?.CanBeManager() == true)
            {
                Console.WriteLine("5. List team members by team name");
                Console.WriteLine("6. List unassigned tasks");
                Console.WriteLine("7. List task assignments by team name");
                Console.WriteLine("9. Assign IT worker to a team as technician");
                Console.WriteLine("10. Assign task to IT worker");
            }
            else
            {
                Console.WriteLine("6. List unassigned tasks");
                Console.WriteLine("7. List task assignments by team name");
                Console.WriteLine("10. Assign task to yourself");
            }
            Console.WriteLine("12. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("What action do you want to perform? ");
        }

        static int GetValidOption(int min, int max)
        {
            int option;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out option) && option >= min && option <= max)
                {
                    return option;
                }
                Console.WriteLine($"Please enter a valid option between {min} and {max}.");
            }
        }

        static void ExecuteAction(Action action)
        {
            if (isAdmin || loggedInWorker?.CanBeManager() == true)
            {
                action();
            }
            else
            {
                Console.WriteLine("You don't have permissions.");
            }
        }

        static bool ChangeAccount()
        {
            Console.WriteLine("Do you want to change your account? (Y/N)");
            string changeAccount = Console.ReadLine();

            if (changeAccount.Equals("Y", StringComparison.OrdinalIgnoreCase) || changeAccount.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                loggedInWorker = null;
                isAdmin = false;
                Login();
                return false;
            }
            else
            {
                Console.WriteLine("Exiting the program...");
                return true;
            }
        }

        static void RegisterITWorker()
        {
            string name = GetInput("Enter name: ");
            string surname = GetInput("Enter surname: ");
            DateTime birthDate = GetDate("Enter birthdate (yyyy-mm-dd): ");
            int yearsOfExperience = GetValidInteger("Enter years of experience: ");

            List<string> techKnowledges = GetTechnologies();

            ITWorker newWorker = new ITWorker(name, surname, birthDate, DateTime.MaxValue, yearsOfExperience, techKnowledges, EnumLevelITWorker.Junior);
            workers.Add(newWorker);
            Console.WriteLine("IT worker registered successfully.");
        }

        static void RegisterTeam()
        {
            string teamName = GetInput("Enter team name: ");
            teams.Add(new Team(teamName));
            Console.WriteLine("Team registered successfully.");
        }

        static void RegisterTask()
        {
            string description = GetInput("Enter task description: ");
            string technology = GetInput("Enter technology for the task: ");
            WorkerTask newTask = new WorkerTask(taskCounter++, description, technology);
            tasks.Add(newTask);
            Console.WriteLine("Task registered successfully.");
        }

        static void ListTeamNames()
        {
            Console.WriteLine("Teams:");
            foreach (var team in teams)
            {
                Console.WriteLine("- " + team.Name);
            }
        }

        static void ListTeamMembersByTeamName()
        {
            string teamName = GetInput("Enter team name: ");
            Team team = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                Console.WriteLine("Team not found.");
                return;
            }

            if (isAdmin || (loggedInWorker != null && team.Manager?.Id == loggedInWorker.Id))
            {
                Console.WriteLine($"Team {team.Name} members:");
                Console.WriteLine($"Manager: {team.Manager?.Name ?? "No manager assigned"}");
                foreach (var technician in team.Technians)
                {
                    Console.WriteLine($"- Technician: {technician.Name}");
                }
            }
            else
            {
                Console.WriteLine("You don't have permission to view this team.");
            }
        }

        static void ListUnassignedTasks()
        {
            Console.WriteLine("Unassigned Tasks:");
            var unassignedTasks = tasks.Where(t => t.IdWorker == null).ToList();
            if (!unassignedTasks.Any())
            {
                Console.WriteLine("No unassigned tasks.");
                return;
            }
            foreach (var task in unassignedTasks)
            {
                Console.WriteLine($"- Task ID: {task.Id}, Description: {task.Description}, Technology: {task.Technology}");
            }
        }

        static void ListTaskAssignmentsByTeamName()
        {
            string teamName = GetInput("Enter team name to view task assignments: ");
            Team team = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                Console.WriteLine("Team not found.");
                return;
            }

            var assignedTasks = tasks
                .Where(t => t.IdWorker != null && team.Technians.Any(w => w.Id == t.IdWorker))
                .ToList();

            if (!assignedTasks.Any())
            {
                Console.WriteLine("No tasks assigned to this team's members.");
            }
            else
            {
                foreach (var task in assignedTasks)
                {
                    ITWorker worker = workers.FirstOrDefault(w => w.Id == task.IdWorker);
                    Console.WriteLine($"- Task ID: {task.Id}, Description: {task.Description}, Assigned to: {worker?.Name ?? "Unknown"}");
                }
            }
        }

        static void AssignITWorkerManager()
        {
            string teamName = GetInput("Enter team name: ");
            Team team = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));
            if (team == null)
            {
                Console.WriteLine("Team not found.");
                return;
            }

            int workerId = GetValidInteger("Enter worker ID to assign as manager: ");
            ITWorker worker = workers.FirstOrDefault(w => w.Id == workerId);
            if (worker == null || !worker.CanBeManager())
            {
                Console.WriteLine("Invalid worker or the worker cannot be assigned as a manager.");
                return;
            }

            team.AssignManager(worker);
            Console.WriteLine($"{worker.Name} assigned as manager to team {team.Name}.");
        }

        static void AssignITWorkerTechnician()
        {
            string teamName = GetInput("Enter team name: ");
            Team team = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));
            if (team == null)
            {
                Console.WriteLine("Team not found.");
                return;
            }

            int workerId = GetValidInteger("Enter worker ID to assign as technician: ");
            ITWorker worker = workers.FirstOrDefault(w => w.Id == workerId);
            if (worker == null)
            {
                Console.WriteLine("Invalid worker ID.");
                return;
            }

            team.AddTechnician(worker);
            Console.WriteLine($"{worker.Name} assigned as technician to team {team.Name}.");
        }

        static void AssignTaskITWorker()
        {
            int taskId = GetValidInteger("Enter task ID to assign: ");
            WorkerTask task = tasks.FirstOrDefault(t => t.Id == taskId);

            if (task == null)
            {
                Console.WriteLine("Task not found.");
                return;
            }

            if (task.CanBeAssignedTo(loggedInWorker))
            {
                task.AssignToWorker(loggedInWorker.Id);
                Console.WriteLine($"Task {taskId} assigned to {loggedInWorker.Name}.");
            }
            else
            {
                Console.WriteLine("You cannot be assigned this task.");
            }
        }

        static void UnregisterITWorker()
        {
            int workerId = GetValidInteger("Enter worker ID to unregister: ");
            ITWorker worker = workers.FirstOrDefault(w => w.Id == workerId);
            if (worker == null)
            {
                Console.WriteLine("Worker not found.");
                return;
            }

            workers.Remove(worker);
            Console.WriteLine("Worker unregistered successfully.");
        }

        static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static DateTime GetDate(string prompt)
        {
            DateTime date;
            while (true)
            {
                Console.Write(prompt);
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    return date;
                }
                Console.WriteLine("Invalid date format. Please try again.");
            }
        }

        static int GetValidInteger(string prompt = "Enter an integer: ")
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        static List<string> GetTechnologies()
        {
            List<string> techKnowledges = new List<string>();
            Console.WriteLine("Enter technologies (type 'done' to finish):");

            while (true)
            {
                string tech = Console.ReadLine();
                if (tech.Equals("done", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                techKnowledges.Add(tech);
            }

            return techKnowledges;
        }
    }
}
