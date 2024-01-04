using Worker.Entities.Enums;

namespace Worker.Entities
{
    public class Worker
    {
        public string Name { get; set; }   
        public WorkerLevel Level { get; set; }     
        public double BaseSalary { get; set; }          
    }
} 