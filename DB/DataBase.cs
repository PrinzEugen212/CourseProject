using CorseProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CorseProject
{
    public static class DataBase
    {
        private static readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VetClinic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void AddAnimal(Animal animal)
        {
            string sqlExpression = "Insert Into Animals (Name, Gender, Type, Breed, Age, Photo, Client) values(@name, @gender, @type, @breed, @age, @photo, @clientID)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@name", animal.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@gender", animal.Gender));
                sqlCommand.Parameters.Add(new SqlParameter("@type", animal.Type));
                sqlCommand.Parameters.Add(new SqlParameter("@breed", animal.Breed));
                sqlCommand.Parameters.Add(new SqlParameter("@age", animal.Age));
                sqlCommand.Parameters.Add(new SqlParameter("@photo", animal.Photo));
                sqlCommand.Parameters.Add(new SqlParameter("@clientID", animal.ClientID));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static void AddVisit(Visit visit)
        {
            string sqlExpression = "Insert Into Visits (IDVisit, IDEmployee, Date, Diagnosis, Assigment) values(@idVisit, @idEmployee, @date, @diagnosis, @assigment)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@idVisit", visit.IDAnimal));
                sqlCommand.Parameters.Add(new SqlParameter("@idEmployee", visit.IDEmployee));
                sqlCommand.Parameters.Add(new SqlParameter("@date", visit.Date));
                sqlCommand.Parameters.Add(new SqlParameter("@diagnosis", visit.Diagnosis));
                sqlCommand.Parameters.Add(new SqlParameter("@assigment", visit.Assigment));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static void AddClient(Client client)
        {
            string sqlExpression = "Insert Into Clients (FullName, BirthDate, Phone) values(@fullName, @birthDate, @phone)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@fullName", client.FullName));
                sqlCommand.Parameters.Add(new SqlParameter("@birthDate", client.BirthDate));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", client.Phone));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static User GetUser(string login)
        {
            string sqlExpression = "SELECT * From Employees Where Login = @login";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@login", login));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    User user = new User((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4], (bool)reader[5], (DateTime)reader[6], (string)reader[7]);
                    sqlConnection.Close();
                    return user;
                }
            }

            throw new Exception("user not found");
        }

        public static List<string> GetAnimalsAndClients()
        {
            string sqlExpression = "SELECT Animals.Name, Animals.ID, Clients.FullName FROM Animals, Clients Where Animals.Client = Clients.ID";
            List<string> animals = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    animals.Add($"{(string)reader["Name"]}, хозяин: {(string)reader["FullName"]}, id:{reader["ID"]}");
                }
            }
            return animals;
        }
        public static List<string> GetClients()
        {
            string sqlExpression = "SELECT FullName from Clients";
            List<string> clients = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    clients.Add((string)reader["FullName"]);
                }
            }
            return clients;
        }
    }
}
