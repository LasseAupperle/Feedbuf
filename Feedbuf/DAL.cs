using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Feedbuf
{
    public class DAL
    {

        private string connectionString = "Data Source=LAPTOP-9PGT0A7T;Initial Catalog=FeedbufDB;Integrated Security=True";
        List<Feedback> Feedbacks = new List<Feedback>();

        public int addNewNotitie(Feedback feedback)
        {
            
            //SqlConnection cnn = new SqlConnection(connectionString);

            using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "INSERT INTO 'feedback' ( 'FBinhoud', 'Datumtijd', 'Uren', 'OE', 'LD', 'ACT') VALUES (@fbinhoud, @datumtijd, @uren, @oe, @ld, @act)";
                    command.Parameters.AddWithValue("@fbinhoud", feedback.FBinhoud);
                    command.Parameters.AddWithValue("@datumtijd", feedback.Datumtijd);
                    command.Parameters.AddWithValue("@uren", feedback.Uren);
                    command.Parameters.AddWithValue("@oe", feedback.OE);
                    command.Parameters.AddWithValue("@ld", feedback.LD);
                    command.Parameters.AddWithValue("@fact", feedback.ACT);

                    int newRows = command.ExecuteNonQuery();

                    cnn.Close();
                    return newRows;
                }
            }
            
        }

        public List<Feedback> ReadFeedbacks()
        {
            Feedbacks.Clear();
            //SqlConnection cnn = new SqlConnection(connectionString);

            using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT FeedbackID, FBInhoud, Akkoord, Datumtijd, Uren, OE, LD, ACT FROM Feedback";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Feedbacks.Add(new Feedback(Int32.Parse(dataReader[0].ToString())
                                                                        , dataReader[1].ToString()
                                                                        , Convert.ToBoolean(dataReader[2].ToString())
                                                                        , Convert.ToDateTime(dataReader[3].ToString())
                                                                        , Int32.Parse(dataReader[4].ToString())
                                                                        , dataReader[5].ToString()
                                                                        , dataReader[6].ToString()
                                                                        , dataReader[7].ToString()
                                                                        ));
                        }


                    }
                    cnn.Close();    
                }

            }
            return Feedbacks;
        }

        /// <summary>
        /// Create author
        /// </summary>
        /// <param name="author">author object dat nieuw is aangemaakt</param>
        /// <returns>author</returns>
        /*public Author CreateAuthor(Author author)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO author (name) VALUES (@name);";
                    command.Parameters.AddWithValue("@name", author.Name);
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT CAST(@@Identity AS INT);";
                    int id = (int)command.ExecuteScalar();
                    author.Id = id;
                    Console.WriteLine(author.Id);
                    ReadAuthors();
                }
            }
            return author;
        }
       
        /// <summary>
        /// Delete author
        /// </summary>
        /// <param name="id">author id</param>
        public void DeleteAuthorById(int id)
        {
            authors.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "DELETE author FROM author WHERE id = @id;";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }*/

    }

    /*public List<Notitie> GetNotities()
    {
        List<Notitie> Notities = new List<Notitie>();

        SqlCommand command = new SqlCommand("SELECT * FROM Notities**************", connection);

        connection.Open();
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Notitie notitie = new notitie();
            customer.Id = reader.GetInt32(0);
            customer.Name = reader.GetString(1);
            customer.Email = reader.GetString(2);

            customers.Add(customer);
        }

        reader.Close();
        connection.Close();

        return customers;
    }
    public void AddCustomer(Customer customer)
    {
        SqlCommand command = new SqlCommand("INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)", connection);
        command.Parameters.AddWithValue("@Name", customer.Name);
        command.Parameters.AddWithValue("@Email", customer.Email);

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }*/

}

