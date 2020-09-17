using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookWithGrades_GetBookStatistics_ComputedValuesMatchExpected()
        {
            // arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var statistics = book.GetStatistics();

            //assert
            Assert.Equal(85.6, statistics.Average, 1);
            Assert.Equal(90.5, statistics.High);
            Assert.Equal(77.3, statistics.Low);
        }
    }
}
