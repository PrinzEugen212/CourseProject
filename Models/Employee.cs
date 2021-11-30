using System;
using System.Collections.Generic;
using System.Text;

namespace CorseProject.Models
{
    public class Employee
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsWorking { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Post { get; set; }
        public string Speciality { get; set; }

        public Employee(string name, string login, string password, string phone, bool isWorking, DateTime? birthDate, string post, string speciality)
        {
            Name = name;
            Login = login;
            Password = password;
            Phone = phone;
            IsWorking = isWorking;
            BirthDate = birthDate;
            Post = post;
            Speciality = speciality;
        }
    }
}
