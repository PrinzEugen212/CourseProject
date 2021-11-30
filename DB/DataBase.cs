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
            string sqlExpression = "Insert Into Visits (IDAnimal, IDEmployee, IDClient, Date) values(@idAnimal, @idEmployee, @idClient, @date) SELECT scope_identity()";
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@idAnimal", visit.IDAnimal));
                sqlCommand.Parameters.Add(new SqlParameter("@idEmployee", visit.IDEmployee));
                sqlCommand.Parameters.Add(new SqlParameter("@idClient", visit.IDClient));
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
            string sqlExpression = "Insert Into ProceduresList (Name) values(@name)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@name", procedure.Name));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static void AddEmployee(Employee employee)
        {
            string sqlExpression = "Insert Into Employees (Name, Login, Password, Phone, IsWorking, BirthDate, Post, Speciality) values(@name, @login, @password, @phone, @isWorking, @birthDate, @post, @speciality)";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@name", employee.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@login", employee.Login));
                sqlCommand.Parameters.Add(new SqlParameter("@password", employee.Password));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", employee.Phone));
                sqlCommand.Parameters.Add(new SqlParameter("@isWorking", employee.IsWorking));
                sqlCommand.Parameters.Add(new SqlParameter("@birthDate", employee.BirthDate));
                sqlCommand.Parameters.Add(new SqlParameter("@post", employee.Post));
                sqlCommand.Parameters.Add(new SqlParameter("@speciality", employee.Speciality));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static DataSet GetTableByName(string tableName)
        {
            switch (tableName)
            {
                case "Visits": return GetTable(tableName);
                case "Animals": return GetTable(tableName);
                case "Clients": return GetTable(tableName);
                case "Diseases": return GetTable(tableName);
                case "Employees": return GetTable(tableName);
                case "ProceduresList": return GetTable(tableName);
                default:
                    return null;
            }
        }
        private static DataSet GetTable(string tableName)
        {
            string sqlExpression = $"Select * From {tableName}";
            DataSet dataSet;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, sqlConnection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                sqlConnection.Close();
            }
            return dataSet;
        }
        public static Employee GetEmployee(string login)
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
                    login = reader["Login"].ToString() != string.Empty ? reader["Login"].ToString() : "";
                    string password = reader["Password"].ToString() != string.Empty ? reader["Password"].ToString() : "";
                    string phone = reader["Phone"].ToString() != string.Empty ? reader["Phone"].ToString() : "не указан";
                    DateTime? dateTime = null;
                    if (reader["BirthDate"].ToString() != string.Empty)
                    {
                        dateTime = (DateTime?)reader["BirthDate"];
                    }
                    string speciality = reader["Speciality"].ToString() != string.Empty ? reader["Speciality"].ToString() : "не указана";
                    Employee user = new Employee((string)reader["Name"], login, password, phone, (bool)reader["IsWorking"], dateTime, (string)reader["Post"], speciality) { ID = (int)reader["ID"] };
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
        public static List<string> GetAnimalAndClient(int animalID)
        {
            string sqlExpression = "SELECT Animals.Name, Animals.ID, Clients.FullName FROM Animals, Clients Where Animals.ID = @id and Animals.Client = Clients.ID";
            List<string> animals = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", animalID));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    animals.Add($"{(string)reader["Name"]}, хозяин: {(string)reader["FullName"]}, id:{reader["ID"]}");
                }
            }
            return animals;
        }
        public static List<Client> GetClients()
        {
            string sqlExpression = "SELECT * from Clients";
            List<Client> clients = new List<Client>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string phone = reader["Phone"].ToString() != string.Empty ? (string)reader["Phone"] : string.Empty;
                    DateTime? birthDate = null;
                    if (reader["BirthDate"].ToString() != string.Empty)
                    {
                        birthDate = (DateTime)reader["BirthDate"];
                    }
                    clients.Add(new Client((string)reader["FullName"], phone, birthDate) { ID = (int)reader["ID"] });
                }
            }
            return clients;
        }
        public static Client GetClient(int id)
        {
            string sqlExpression = "SELECT * from Clients Where ID = @id";
            Client client = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string phone = reader["Phone"].ToString() != string.Empty ? (string)reader["Phone"] : string.Empty;
                    DateTime? birthDate = null;
                    if (reader["BirthDate"].ToString() != string.Empty)
                    {
                        birthDate = (DateTime)reader["BirthDate"];
                    }
                    client = new Client((string)reader["FullName"], phone, birthDate) { ID = (int)reader["ID"] };
                }
            }
            return client;
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
        public static List<Disease> GetDiseases(int idVisit)
        {
            string sqlExpression = "SELECT Name from Diseases Where ID IN (Select Diagnosis.IDDisease From Diagnosis Where Diagnosis.IDVisit = @idVisit)";
            List<Disease> diseases = new List<Disease>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@idVisit", idVisit));
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
                    procedures.Add(new Procedure((string)reader["Name"]));
                }
            }
            return procedures;
        }
        public static List<Procedure> GetProcedures(int idVisit)
        {
            string sqlExpression = "SELECT Name, Cost from ProceduresList Where ID IN (Select PerformedProcedures.IDProcedure From PerformedProcedures Where PerformedProcedures.IDVisit = @idVisit)";
            List<Procedure> procedures = new List<Procedure>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@idVisit", idVisit));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    procedures.Add(new Procedure((string)reader["Name"]));
                }
            }
            return procedures;
        }
        public static Animal GetAnimal(int ID)
        {
            string sqlExpression = "SELECT * FROM Animals Where ID = @id";
            Animal animal = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", ID));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    animal = new Animal((int)reader["Client"], (string)reader["Name"], (string)reader["Gender"], (string)reader["Type"], (string)reader["Breed"], (double)reader["Age"], (string)reader["Photo"]) { ID = (int)reader["ID"] };
                }
            }
            return animal;
        }
        public static Visit GetLastVisit(int idEmployee)
        {
            string sqlExpression = "Select * From Visits Where Date = (Select MAX(Date) From Visits Where IDEmployee = @idEmployee)";
            int idVisit;
            Visit visit = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@idEmployee", idEmployee));

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    visit = new Visit((int)reader["IDAnimal"], (int)reader["IDEmployee"], (int)reader["IDClient"], (DateTime)reader["Date"]) { ID = (int)reader["ID"] };
                    idVisit = (int)reader["ID"];
                }
            }
            return visit;
        }
        public static void EditAnimal(Animal animal)
        {
            if (animal.ID == null)
            {
                throw new Exception("Null value of ID");
            }
            string sqlExpression = "UPDATE Animals SET (Name, Gender, Type, Breed, Age, Photo, Client) VALUES(@name, @gender, @type, @breed, @age, @photo, @clientID) WHERE ID = @ID";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@ID", animal.ID));
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
        public static void EditVisit(Visit visit, List<Disease> diseases, List<Procedure> procedures)
        {
            if (visit.ID == null)
            {
                return;
            }
            string sqlExpression = "Update Visits (IDAnimal, IDEmployee, IDClient, Date) Set(@idAnimal, @idEmployee, @idClient, @date) Where ID = @id";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@idAnimal", visit.IDAnimal));
                sqlCommand.Parameters.Add(new SqlParameter("@idEmployee", visit.IDEmployee));
                sqlCommand.Parameters.Add(new SqlParameter("@idClient", visit.IDClient));
                sqlCommand.Parameters.Add(new SqlParameter("@date", visit.Date));
                sqlCommand.Parameters.Add(new SqlParameter("@id", visit.ID));
                sqlCommand.ExecuteNonQuery();
            }
            if (diseases.Count == 0)
            {
                sqlExpression = "Delete * FROM Diagnosis WHERE IDVisit = @idVisit";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                    sqlCommand.Parameters.Add(new SqlParameter("@id", visit.ID));
                    sqlCommand.ExecuteNonQuery();
                }
                sqlExpression = "Insert Into Diagnosis (IDVisit, IDDisease) values(@id, (Select ID from Diseases where Name = @name))";
                foreach (var disease in diseases)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                        sqlCommand.Parameters.Add(new SqlParameter("@id", visit.ID));
                        sqlCommand.Parameters.Add(new SqlParameter("@name", disease.Name));
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }

            if (procedures.Count == 0)
            {
                sqlExpression = "Delete * FROM PerformedProcedures WHERE IDVisit = @idVisit";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                    sqlCommand.Parameters.Add(new SqlParameter("@id", visit.ID));
                    sqlCommand.ExecuteNonQuery();
                }
                sqlExpression = "Insert Into PerformedProcedures (IDVisit, IDProcedure) values(@id, (Select ID from ProceduresList where Name = @name))";
                foreach (var procedure in procedures)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                        sqlCommand.Parameters.Add(new SqlParameter("@id", visit.ID));
                        sqlCommand.Parameters.Add(new SqlParameter("@name", procedure.Name));
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }

        }
        public static void EditClient(Client client)
        {
            if (client.ID == null)
            {
                throw new Exception("Null value of ID");
            }
            string sqlExpression = "UPDATE Clients SET (FullName, BirthDate, Phone) VALUES (@fullName, @birthDate, @phone) WHERE ID = @ID";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@ID", client.ID));
                sqlCommand.Parameters.Add(new SqlParameter("@fullName", client.FullName));
                sqlCommand.Parameters.Add(new SqlParameter("@birthDate", client.BirthDate));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", client.Phone));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static void EditDisease(Disease disease)
        {
            if (disease.ID == null)
            {
                throw new Exception("Null value of ID");
            }
            string sqlExpression = "UPDATE Diseases SET (Name) values(@name) WHERE ID=@ID";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@ID", disease.ID));
                sqlCommand.Parameters.Add(new SqlParameter("@name", disease.Name));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static void EditProcedure(Procedure procedure)
        {
            if (procedure.ID == null)
            {
                throw new Exception("Null value of ID");
            }
            string sqlExpression = "UPDATE ProceduresList SET (Name) VALUES (@name) WHERE ID = @ID";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@ID", procedure.ID));
                sqlCommand.Parameters.Add(new SqlParameter("@name", procedure.Name));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public static void EditEmployee(Employee employee)
        {
            if (employee.ID == null)
            {
                throw new Exception("Null value of ID");
            }
            string sqlExpression = "UPDATE Employees SET(Name, Login, Password, Phone, IsWorking, BirthDate, Post, Speciality) VALUES (@name, @login, @password, @phone, @isWorking, @birthDate, @post, @speciality) WHERE ID = @ID";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@ID", employee.ID));
                sqlCommand.Parameters.Add(new SqlParameter("@name", employee.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@login", employee.Login));
                sqlCommand.Parameters.Add(new SqlParameter("@password", employee.Password));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", employee.Phone));
                sqlCommand.Parameters.Add(new SqlParameter("@isWorking", employee.IsWorking));
                sqlCommand.Parameters.Add(new SqlParameter("@birthDate", employee.BirthDate));
                sqlCommand.Parameters.Add(new SqlParameter("@post", employee.Post));
                sqlCommand.Parameters.Add(new SqlParameter("@speciality", employee.Speciality));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
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
