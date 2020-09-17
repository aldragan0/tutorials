using System;

namespace GradeBook
{
    public class Statistics
    {

        private int _count;
        private double _sum;

        public Statistics()
        {
            _count = 0;
            _sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public double Average
        {
            get
            {
                return _sum / _count;
            }
        }
        public double High { get; set; }

        public double Low { get; set; }

        public void AddGrade(double grade)
        {
            _sum += grade;
            _count++;
            High = Math.Max(grade, High);
            Low = Math.Min(grade, Low);
        }
    }
}