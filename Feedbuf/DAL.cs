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

        private static string connectionString = "Data Source=LAPTOP-9PGT0A7T;Initial Catalog=FeedbufDB;Integrated Security=True";
        List<Feedback> Feedbacks = new List<Feedback>();

        public static int addNewNotitie(Feedback feedback)
        {
            using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "INSERT INTO Feedback (FBINHOUD, UREN, OE, LD, ACT, STUDENTID, DOCENTID, AKKOORD) VALUES (@fbinhoud, @uren, @oe, @ld, @act, @studentid, @docentid, @akkoord)";
                    command.Parameters.AddWithValue("@fbinhoud", feedback.FBinhoud);
                    command.Parameters.AddWithValue("@uren", feedback.Uren);
                    command.Parameters.AddWithValue("@oe", feedback.OE);
                    command.Parameters.AddWithValue("@ld", feedback.LD);
                    command.Parameters.AddWithValue("@act", feedback.ACT);
                    command.Parameters.AddWithValue("@studentid", feedback.StudentID);
                    command.Parameters.AddWithValue("@docentid", feedback.DocentID);
                    command.Parameters.AddWithValue("@akkoord", feedback.Akkoord);

                    int newRows = command.ExecuteNonQuery();

                    cnn.Close();
                    return newRows;
                }
            }
        }

        public List<Feedback> ReadFeedbacks()
        {
            Feedbacks.Clear();
            using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT FeedbackID, FBInhoud, Akkoord, Uren, OE, LD, ACT, StudentID, DocentID FROM Feedback";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Feedbacks.Add(new Feedback(Int32.Parse(dataReader[0].ToString())
                                                                        , dataReader[1].ToString()
                                                                        , Convert.ToBoolean(dataReader[2].ToString())
                                                                        , Int32.Parse(dataReader[3].ToString())
                                                                        , dataReader[4].ToString()
                                                                        , dataReader[5].ToString()
                                                                        , dataReader[6].ToString()
                                                                        , Int32.Parse(dataReader[7].ToString())
                                                                        , Int32.Parse(dataReader[8].ToString())
                                                                        ));
                        }
                    }
                    cnn.Close();
                }

            }
            return Feedbacks;
        }

        //internal int veranderNotitite(int notitieID)
        //{
           /* using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE feedback SET column value WHERE feedback.feedbackid = @notitieID";
                    command.Parameters.AddWithValue("@notitieID", notitieID);
                    //werkt niet vraag docent



                    int result = command.ExecuteNonQuery();

                    cnn.Close();
                    return result;
                }
            }*/
        //}

        internal int verwijderNotitie(int notitieID)
        {
            using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "DELETE FROM feedback WHERE feedback.feedbackid = @notitieID";
                    command.Parameters.AddWithValue("@notitieID", notitieID);


                    int result = command.ExecuteNonQuery();

                    cnn.Close();
                    return result;
                }
            }
        }
        public List<Student> Students = new List<Student>();
        public List<Student> ReadStudents()
        {
            Students.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = cnn.ConnectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT * FROM STUDENT";

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Students.Add(new Student(Int32.Parse(dataReader[0].ToString())
                                                                 , dataReader[1].ToString()
                                                                 , dataReader[2].ToString()
                                                                 , dataReader[3].ToString()
                                                                 
                                                                 ));
                        }
                    }
                }
            }
            return Students;    
        }
        public List<Student> Readstudentsdocenten()
        {
            Students.Clear();
            //SqlConnection cnn = new SqlConnection(connectionString);

            using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT StudentID, Studentnaam, Email, Wachtwoord FROM Student";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Students.Add(new Student(Int32.Parse(dataReader[0].ToString())
                                                                        , dataReader[1].ToString()
                                                                        , dataReader[2].ToString()
                                                                        , dataReader[3].ToString()
                                                                        ));
                        }


                    }
                    cnn.Close();
                }

            }
            return Students;
        }
        public List<Feedback> ReadFeedbacksFromStudents(int StudentID)
        {
            List<Feedback> returnthese = new List<Feedback>();
            using (SqlConnection cnn = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT FeedbackID, FBInhoud, Akkoord, Uren, OE, LD, ACT, StudentID, DocentID FROM Feedback WHERE StudentID = @studentid";
                    command.Parameters.AddWithValue("studentid", StudentID);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Feedbacks.Add(new Feedback(Int32.Parse(dataReader[0].ToString())
                                                                        , dataReader[1].ToString()
                                                                        , Convert.ToBoolean(dataReader[2].ToString())
                                                                        , Int32.Parse(dataReader[3].ToString())
                                                                        , dataReader[4].ToString()
                                                                        , dataReader[5].ToString()
                                                                        , dataReader[6].ToString()
                                                                        , Int32.Parse(dataReader[7].ToString())
                                                                        , Int32.Parse(dataReader[8].ToString())
                                                                        ));
                        }
                    }
                        

                     
                        int result = command.ExecuteNonQuery();

                    cnn.Close();
                    return returnthese;
                }
            }
            

        }

    }
}

