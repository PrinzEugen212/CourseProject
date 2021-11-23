namespace CorseProject.Models
{
    public class Procedure
    {
        public string Name { get; set; }

        public double Cost { get; set; }

        public Procedure(string name, double cost) 
        {
            Name = name;
            Cost = cost;            
        }
    }
}
