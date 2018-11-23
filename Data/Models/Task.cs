using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesforceCore.Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string AssignedTo { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public TaskType Type { get; set; }
    }
}