using System;
using System.IO;

namespace GradeBook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name) {
            _filename = $"./{Name}.txt";
        }

        public override event GradeAddedDelegate GradeAdded;

        private readonly string _filename;

        public override void AddGrade(double grade)
        {
            using (var gradeFile = File.AppendText(_filename))
            {
                gradeFile.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            using(var grades = File.OpenText(_filename)){
                String line;
                while((line = grades.ReadLine()) != null){
                    if(Double.TryParse(line, out var grade)){
                        statistics.AddGrade(grade);
                    }
                }
            }
            return statistics;
        }
    }
}