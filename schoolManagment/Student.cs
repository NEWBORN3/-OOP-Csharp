using System;
using System.Collections.Generic;
using System.Text;
namespace schoolManagment {

    public class Student : Person  
    {
        public enum GradLevels { Junior, Senior, Sopmore};
        public GradLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage() {
            return 3.8f;
        }        

        public override string SendMessage(string message) {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("");
            sb.AppendLine("From a Student");
            return sb.ToString();
        }
    }
}