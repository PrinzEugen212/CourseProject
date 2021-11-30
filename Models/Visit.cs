using System;

namespace CorseProject.Models
{
    public class Visit
    {
        public int? ID { get; set; }
        public int IDAnimal { get; private set; }
        public int IDEmployee { get; private set; }
        public int IDClient { get; private set; }
        public DateTime Date { get; private set; }

        public Visit(int idAnimal, int idEmployee, int idClient, DateTime date)
        {
            IDAnimal = idAnimal;
            IDEmployee = idEmployee;
            IDClient = idClient;
            Date = date;
        }
    }
}
