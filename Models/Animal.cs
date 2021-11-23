namespace CorseProject.Models
{
    public class Animal
    {
        public int ClientID { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string Type { get; private set; }
        public string Breed { get; private set; }
        public double Age { get; private set; }
        public string Photo { get; private set; }
        public Animal(int clientId, string name, string gender, string type, string breed, double age, string photo)
        {
            ClientID = clientId;
            Name = name;
            Gender = gender;
            Type = type;
            Breed = breed;
            Age = age;
            Photo = photo;
        }
    }
}
