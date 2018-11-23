using System;

namespace SalesforceCore.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CustomerNeedsBy { get; set; }
        
    }
}