using CorseProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CorseProject.DB
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
        public static void AddVisit(Visit visit, List<Disease> diseases, List<Procedure> procedures)
        {
            string sqlExpression = "Insert Into Visits (IDAnimal, IDEmployee, Date) values(@idAnimal, @idEmployee, @date) SELECT scope_identity()";
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@idAnimal", visit.IDAnimal));
                sqlCommand.Parameters.Add(new SqlParameter("@idEmployee", visit.IDEmployee));
                sqlCommand.Parameters.Add(new SqlParameter("@date", visit.Date));
                id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            sqlExpression = "Insert Into Diagnosis (IDVisit, IDDisease) values(@id, (Select ID from Diseases where Name = @name))";
            foreach (var disease in diseases)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand.Parameters.Add(new SqlParameter("@name", disease.Name));
                    sqlCommand.ExecuteNonQuery();
                }
            }
            sqlExpression = "Insert Into PerformedProcedures (IDVisit, IDProcedure) values(@id, (Select ID from ProceduresList where Name = @name))";
            foreach (var procedure in procedures)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                    sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand.Parameters.Add(new SqlParameter("@name", procedure.Name));
                    sqlCommand.ExecuteNonQuery();
                }
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
        public static void AddDisease(Disease disease)
        {
            string sqlExpression = "Insert Into Diseases (Name) values(@name)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@name", disease.Name));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static void AddProcedure(Procedure procedure)
        {
            string sqlExpression = "Insert Into ProceduresList (Name,Cost) values(@name,@cost)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@name", procedure.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@cost", procedure.Cost));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static DataSet GetTable(string tableName)
        {
            string sqlExpression = $"Select * From @table";
            DataSet dataSet;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@table", tableName));
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, sqlConnection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                sqlConnection.Close();
            }
            return dataSet;
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
        public static List<Disease> GetDiseases()
        {
            string sqlExpression = "SELECT * from Diseases";
            List<Disease> diseases = new List<Disease>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    diseases.Add(new Disease((string)reader["Name"]));
                }
            }
            return diseases;
        }

        public static List<Procedure> GetProcedures()
        {
            string sqlExpression = "SELECT * from ProceduresList";
            List<Procedure> procedures = new List<Procedure>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    procedures.Add(new Procedure((string)reader["Name"], (double)reader["Cost"]));
                }
            }
            return procedures;
        }
        public static int GetEmployeeID(string name)
        {
            string sqlExpression = "SELECT ID from Employees where Name=@name";
            int id = -1;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@name", name));

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    id = (int)reader[0];
                }
            }
            if (id == -1)
            {
                throw new Exception("Пользователь не найден");
            }
            return id;
        }
    }
}
