using System;

namespace CorseProject.Models
{
    public class Visit
    {
        public int IDAnimal { get; private set; }
        public int IDEmployee { get; private set; }
        public DateTime Date { get; private set; }

        public Visit(int idAnimal, int idEmployee, DateTime date)
        {
            IDAnimal = idAnimal;
            IDEmployee = idEmployee;
            Date = date;
        }
    }
}
