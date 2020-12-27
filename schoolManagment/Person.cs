using System;
using System.Collections.Generic;
using System.Text;

namespace schoolManagment
{
   public abstract class Person
    {
        public string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }

        public abstract float ComputeGradeAverage();

        public virtual string SendMessage(string message) {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent On {0:D} at {0:t}",DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine("");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}
