using System;

namespace GradeBook
{
    class Program
    {
        static void OnGradeAdded(object sender, EventArgs args){
            Console.WriteLine("A grade was added");
        }

        static void AddBookGrades(IBook book){
            book.GradeAdded += OnGradeAdded;

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
        }

        static void Main(string[] args)
        {
            IBook book = new DiskBook("Alex's Grade Book");
            AddBookGrades(book);
            var statistics = book.GetStatistics();

            Console.WriteLine($"The highest grade is {statistics.High}");
            Console.WriteLine($"The lowest grade is {statistics.Low}");
            Console.WriteLine($"The average grade is {statistics.Average:N1}");
        }
    }
}
