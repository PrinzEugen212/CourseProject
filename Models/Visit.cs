using System;
using System.Collections.Generic;
using System.Text;

namespace CorseProject.Models
{
    public class Visit
    {
        public int IDAnimal { get; private set; }
        public int IDEmployee { get; private set; }
        public DateTime Date { get; private set; }
        public string Diagnosis { get; private set; }
        public string Assigment { get; private set; }

        public Visit(int idAnimal, int idEmployee, DateTime date, string diagnosis, string assigment)
        {
            IDAnimal = idAnimal;
            IDEmployee = idEmployee;
            Date = date;
            Diagnosis = diagnosis;
            Assigment = assigment;
        }
    }
}
