﻿using System;
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

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("-----------------------------------");
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
                Console.WriteLine("12. Exit");
                Console.WriteLine("-----------------------------------");
                Console.Write("What action do you want to perform? ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        RegisterITWorker();
                        break;
                    case 2:
                        RegisterTeam();
                        break;
                    case 3:
                        RegisterTask();
                        break;
                    case 4:
                        ListTeamNames();
                        break;
                    case 5:
                        ListTeamMembersByTeamName();
                        break;
                    case 6:
                        ListUnassignedTasks();
                        break;
                    case 7:
                        ListTaskAssignmentsByTeamName();
                        break;
                    case 8:
                        AssignITWorkerManager();
                        break;
                    case 9:
                        AssignITWorkerTechnician();
                        break;
                    case 10:
                        AssignTaskITWorker();
                        break;
                    case 11:
                        UnregisterITWorker();
                        break;
                    case 12:
                        Console.WriteLine("Exiting the program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please choose an option between 1 and 11.");
                        break;
                }
            }
        }

        static void RegisterITWorker()
        {
            string name = GetInput("Enter name: ");
            string surname = GetInput("Enter surname: ");
            DateTime birthDate = GetDate("Enter birthdate (yyyy-mm-dd): ");
            int yearsOfExperience = int.Parse(GetInput("Enter years of experience: "));

            List<string> techKnowledges = new List<string>();
            Console.WriteLine("Enter known technologies (type 'done' to finish): ");
            while (true)
            {
                string tech = Console.ReadLine();
                if (tech.ToLower() == "done") break;
                techKnowledges.Add(tech);
            }

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
            if (team != null)
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
                Console.WriteLine("Team not found.");
            }
        }

        static void ListUnassignedTasks()
        {
            Console.WriteLine("Unassigned Tasks:");
            foreach (var task in tasks.Where(t => t.IdWorker == null))
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
            if (team != null)
            {
                int workerId = int.Parse(GetInput("Enter worker ID to assign as manager: "));
                ITWorker worker = workers.FirstOrDefault(w => w.Id == workerId);
                if (worker != null && worker.CanBeManager())
                {
                    team.AssignManager(worker);
                    Console.WriteLine($"Worker {worker.Name} assigned as manager of team {team.Name}.");
                }
                else
                {
                    Console.WriteLine("Worker cannot be assigned as manager.");
                }
            }
            else
            {
                Console.WriteLine("Team not found.");
            }
        }

        static void AssignITWorkerTechnician()
        {
            string teamName = GetInput("Enter team name: ");
            Team team = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));
            if (team != null)
            {
                int workerId = int.Parse(GetInput("Enter worker ID to assign as technician: "));
                ITWorker worker = workers.FirstOrDefault(w => w.Id == workerId);
                if (worker != null)
                {
                    team.AddTechnician(worker);
                    Console.WriteLine($"Worker {worker.Name} assigned as technician in team {team.Name}.");
                }
                else
                {
                    Console.WriteLine("Worker not found.");
                }
            }
            else
            {
                Console.WriteLine("Team not found.");
            }
        }

        static void AssignTaskITWorker()
        {
            int taskId = int.Parse(GetInput("Enter task ID to assign: "));
            WorkerTask task = tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                int workerId = int.Parse(GetInput("Enter worker ID to assign the task: "));
                ITWorker worker = workers.FirstOrDefault(w => w.Id == workerId);
                if (worker != null && task.CanBeAssignedTo(worker))
                {
                    task.AssignToWorker(worker.Id);
                    Console.WriteLine($"Task '{task.Description}' assigned to worker {worker.Name}.");
                }
                else
                {
                    Console.WriteLine("Cannot assign task to this worker.");
                }
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        static void UnregisterITWorker()
        {
            int workerId = int.Parse(GetInput("Enter worker ID to unregister: "));
            ITWorker worker = workers.FirstOrDefault(w => w.Id == workerId);
            if (worker != null)
            {
                foreach (var team in teams)
                {
                    team.Technians.Remove(worker);
                    if (team.Manager == worker)
                    {
                        team.Manager = null;
                        Console.WriteLine($"Worker {worker.Name} removed as manager from team {team.Name}.");
                    }
                }
                workers.Remove(worker);
                Console.WriteLine($"Worker {worker.Name} unregistered successfully.");
            }
            else
            {
                Console.WriteLine("Worker not found.");
            }
        }

        static string GetInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static DateTime GetDate(string message)
        {
            DateTime date;
            do
            {
                Console.Write(message);
            } while (!DateTime.TryParse(Console.ReadLine(), out date));
            return date;
        }
    }
}
