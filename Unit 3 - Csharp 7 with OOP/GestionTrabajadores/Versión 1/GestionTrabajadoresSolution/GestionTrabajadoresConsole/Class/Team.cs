using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTrabajadoresConsole.Class
{
    internal class Team
    {
        public string Name { get; set; }
        public ITWorker Manager { get; set; }
        public List<ITWorker> Technians { get; set; } = new List<ITWorker>();

        public Team(string name)
        {
            Name = name;
        }

        public void AssignManager(ITWorker manager)
        {
            if (!manager.CanBeManager())
            {
                throw new Exception("The worker must be Senior level to be a manager.");
            }
            Manager = manager;
        }

        public void AddTechnician(ITWorker technician)
        {
            Technians.Add(technician);
        }
    }
}
