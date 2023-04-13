using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuf
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string FBinhoud { get; set; }
        public bool Akkoord { get; set; }
        
       
        public int Uren { get; set; }
        public string OE { get; set; }
        public string LD { get; set; }
        public string ACT { get; set; }
        public int StudentID { get; set; }

        public DAL dal = new DAL();

        public Feedback()
        {

        }
        public Feedback(int feedbackId, string fBinhoud, bool akkoord, int uren, string oe, string ld, string act, int StduentID)
        {
            FeedbackId = feedbackId;
            FBinhoud = fBinhoud;
            Akkoord = akkoord;
            
            Uren = uren;
            OE = oe;
            LD = ld;
            ACT = act;
            StudentID = StduentID;
        }
        /*public List<Feedback> ReadFeedbacks()
        {
            return dal.ReadFeedbacks();
        }
        public Feedback CreateStudent(Feedback feedback)
        {
            return DAL.CreateFeedbacks();
        }
        public STUDENT CreateUsername(STUDENT Username)
        {
            return dal.CreateStudent(Username);
        }
        public void DeleteStudentById(int id)
        {
            dal.DeleteStudentById(id);
        }*/
    }

}
