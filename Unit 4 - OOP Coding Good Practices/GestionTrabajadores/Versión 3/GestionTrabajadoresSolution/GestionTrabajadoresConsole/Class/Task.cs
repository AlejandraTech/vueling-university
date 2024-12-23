using GestionTrabajadoresConsole.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTrabajadoresConsole.Class
{
    internal class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Technology { get; set; }
        public EnumStatusTask Status { get; set; } = EnumStatusTask.ToDo;
        public int? IdWorker { get; set; }

        public Task(int id, string description, string technology)
        {
            Id = id;
            Description = description;
            Technology = technology;
            Status = EnumStatusTask.ToDo;
        }

        public bool CanBeAssignedTo(ITWorker worker)
        {
            return Status != EnumStatusTask.Done && worker.TechKnowledges.Contains(Technology);
        }

        public void AssignToWorker(int workerId)
        {
            IdWorker = workerId;
            Status = EnumStatusTask.Doing;
        }
    }
}
