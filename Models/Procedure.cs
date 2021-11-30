namespace CorseProject.Models
{
    public class Procedure
    {
        public int? ID { get; set; }
        public string Name { get; set; }

        public Procedure(string name) 
        {
            Name = name;          
        }
    }
}
