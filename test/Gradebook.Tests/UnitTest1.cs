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
            book.AddGrade(99.1);
            book.AddGrade(56.9);
            book.AddGrade(88.3);
            book.AddGrade(65.7);

            // act
            var average = book.GetAverage();
            var low = book.GetLowestGrade();
            var high = book.GetHighestGrade();
            var stats = book.GetStats();

            // assert
            Assert.Equal("77.50", average);
            Assert.Equal("56.90", low);
            Assert.Equal("99.10", high);
            Assert.Equal("77.50", stats.Average);
            Assert.Equal("56.90", stats.Low);
            Assert.Equal("99.10", stats.High);
        }
    }
}
