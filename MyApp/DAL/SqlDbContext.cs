using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DAL
{
    public class SqlDbContext
    {
        string connectionString =
            "Data Source=LocalHost;Initial Catalog=Persons;Integrated Security=true;";
        public List<Contact> GetContacts()
        {
            var result = new List<Contact>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var queryString = "SELECT Id, FirstName, LastName, Email, Phone, Age, PrivateNumber FROM Users";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var contact = new Contact
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Age = Convert.ToInt32(reader["Age"].ToString()),
                            PrivateNumber = reader["PrivateNumber"].ToString()

                        };
                        result.Add(contact);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;
        }
        public Contact GetContactById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var queryString = $"SELECT Id, FirstName, LastName, Email, Phone, Age, PrivateNumber FROM Users WHERE Id = {id}";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;

                //command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var contact = new Contact
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Age = Convert.ToInt32(reader["Age"].ToString()),
                            PrivateNumber = reader["PrivateNumber"].ToString()
                        };
                        reader.Close();
                        return contact;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public void AddContact(Contact contact)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var queryString = $"INSERT INTO Users (FirstName, LastName, Email, Phone, Age, PrivateNumber) VALUES (N'{contact.FirstName}', N'{contact.LastName}', '{contact.Email}', '{contact.Phone}' , '{contact.Age}', '{contact.PrivateNumber}')";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void UpdateConatact(Contact contact, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var queryString = $"UPDATE Users SET FirstName = N'{contact.FirstName}', LastName = N'{contact.LastName}', Email = '{contact.Email}', Phone = '{contact.Phone}', Age = '{contact.Age}', PrivateNumber = '{contact.PrivateNumber}' WHERE Id = '{id}'";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        public bool DeleteConatact(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var queryString = $"DELETE FROM Users WHERE Id = {id}";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public List<Contact> SearchContact(string searchname, string searchlastname, string searchphone, string searchemail, string searchprivatenumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int count = 0;
                var result = new List<Contact>();
                var queryString = $"SELECT Id, FirstName, LastName, Email, Phone, Age, PrivateNumber FROM Users WHERE ";
                if (!string.IsNullOrEmpty(searchname))
                {
                    var searchnamestring = " ";
                    if (count > 0)
                    {
                        searchnamestring = $" AND FirstName LIKE N'%{searchname}%'";
                    }
                    else
                    {
                        searchnamestring = $" FirstName LIKE N'%{searchname}%'";
                    }
                    count++;
                    
                    queryString = queryString + searchnamestring;
                }
                if (!string.IsNullOrEmpty(searchlastname))
                {
                    var searchlastnamestring = " ";
                    if (count > 0)
                    {
                        searchlastnamestring = $" AND LastName LIKE N'%{searchlastname}%'";
                    }
                    else
                    {
                        searchlastnamestring = $" LastName LIKE N'%{searchlastname}%'";
                    }
                    count++;
                    
                    queryString = queryString + searchlastnamestring;
                }
                if (!string.IsNullOrEmpty(searchphone))
                {
                    var searchphonestring = " ";
                    if (count > 0)
                    {
                        searchphonestring = $" AND Phone LIKE N'%{searchphone}%'";
                    }
                    else
                    {
                        searchphonestring = $" Phone LIKE N'%{searchphone}%'";
                    }
                    count++;
                    
                    queryString = queryString + searchphonestring;
                }
                if (!string.IsNullOrEmpty(searchemail))
                {
                    var searchemailstring = " ";
                    if (count > 0)
                    {
                        searchemailstring = $" AND Email LIKE N'%{searchemail}%'";
                    }
                    else
                    {
                        searchemailstring = $" Email LIKE N'%{searchemail}%'";
                    }
                    count++;
                    queryString = queryString + searchemailstring;
                }
                if (!string.IsNullOrEmpty(searchprivatenumber))
                {
                    var searchprivatenumberstring = " ";
                    if (count > 0)
                    {
                        searchprivatenumberstring = $" OR PrivateNumber LIKE N'%{searchprivatenumber}%'";
                    }
                    else
                    {
                        searchprivatenumberstring = $" PrivateNumber LIKE N'%{searchprivatenumber}%'";
                    }
                    count++;
                    queryString = queryString + searchprivatenumberstring;
                }

                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var contact = new Contact
                        {
                            Id = Convert.ToInt32(reader["Id"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Age = Convert.ToInt32(reader["Age"].ToString()),
                            PrivateNumber = reader["PrivateNumber"].ToString()

                        };
                        result.Add(contact);
                    }
                    reader.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
