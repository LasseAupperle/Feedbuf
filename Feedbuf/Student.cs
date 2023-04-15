using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbuf
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Studentnaam { get; set; }
        public string Wachtwoord { get; set; }
        public string Email { get; set; }

        public Student(int studentID, string studentnaam, string email, string wachtwoord)
        {
            StudentID = studentID;
            Studentnaam = studentnaam;
            Wachtwoord = wachtwoord;
            Email = email;
        }
    }
}
