using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbuf
{
    internal class Docent
    {
        public int DocentID { get; set; }
        public string Docentnaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }

        public Docent(int docentID, string docentnaam, string email, string wachtwoord)
        {
            DocentID = docentID;
            Docentnaam = docentnaam;
            Email = email;
            Wachtwoord = wachtwoord;
        }
    }
}
