using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var statistics = book.GetStatistics();

            //assert
            Assert.Equal(statistics.Average, 85.6, 1);
            Assert.Equal(statistics.High, 90.5);
            Assert.Equal(statistics.Low, 77.3);
        }
    }
}
