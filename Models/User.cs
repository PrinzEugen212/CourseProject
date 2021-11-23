using System;

namespace CorseProject
{
    public class User
    {
        public User(int id, string name, string login, string password, string phone, bool isWorking, DateTime birthDate, string post)
        {
            ID = id;
            Name = name;
            Login = login;
            Password = password;
            Phone = phone;
            IsWorking = isWorking;
            BirthDate = birthDate;
            Post = post;
        }
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public bool IsWorking { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Post { get; private set; }
    }
}
