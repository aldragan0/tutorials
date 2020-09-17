using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class InMemoryBook : Book
    {
        private List<double> grades;

        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
        }

        public override void AddGrade(double grade)
        {
            grades.Add(grade);
            if(GradeAdded != null){
                GradeAdded(this, new EventArgs());
            }
        }

        public override event GradeAddedDelegate GradeAdded;
        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            foreach (var grade in grades)
            {
                result.AddGrade(grade);
            }
            return result;
        }
    }
}