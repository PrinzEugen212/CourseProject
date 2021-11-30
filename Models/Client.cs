using System;

namespace CorseProject.Models
{
    public class Client
    {
        public int? ID { get; set; }
        public string FullName { get; private set; }
        public string Phone { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public Client(string fullName, string phone, DateTime? birthDate)
        {
            FullName = fullName;
            Phone = phone;
            BirthDate = birthDate;
        }
    }
}
