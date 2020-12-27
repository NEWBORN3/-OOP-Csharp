using System;

namespace schoolManagment 
{
    public class Teacher : Person{
       public string Subject { get; set; }

       public override float ComputeGradeAverage() {
           return 4f;
       }
    }
}