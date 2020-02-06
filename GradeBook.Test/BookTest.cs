using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Test
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new InMemoryBook("");
            book.AddGrade(23.4);
            book.AddGrade(43.5);
            book.AddGrade(76.8);
            
            //act
            var result = book.GetStatistics();

            //assert
            Assert.AreEqual(23.4, result.Low);
            Assert.AreEqual(76.8, result.High);
            Assert.AreEqual(47.9, result.Average);
        }
    }
}
