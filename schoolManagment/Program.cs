using System;

namespace schoolManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newPerson = new Student();
            newPerson.FirstName = "Haymanot";
            newPerson.GradeLevel = (Student.GradLevels)1;
            var avg = newPerson.ComputeGradeAverage();
            Console.WriteLine("{0}{1}{2}", newPerson.FirstName,newPerson.GradeLevel,avg);
            Console.WriteLine($"{newPerson.SendMessage("Hello Students and Teachers")}");
            var engAssignment = new EnglishPaper();
            var sciAssignment = new ScienceExperiment();
            var message = " Is Haymanot tamrat birye now in the zone? True or False.";
            engAssignment.Score = 500f;
            engAssignment.MaximumScore = 700f;
            
            sciAssignment.Score = 600f;
            sciAssignment.MaximumScore = 700f;

            var printUtility = ScoreUtility.BestOfTwo(engAssignment,sciAssignment);
            Console.WriteLine($"{printUtility}");
            Console.WriteLine($"{message.countNow()[3]}");
        }
    }
}
