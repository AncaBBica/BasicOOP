using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Test
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void GetBookReturnDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //act


            //assert
            Assert.AreEqual("Book 1", book1.Name);
            Assert.AreEqual("Book 2", book2.Name);
        }

        [TestMethod]
        public void TwoObjectCanReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //act


            //assert
            Assert.AreSame(book1, book2);
            Assert.IsTrue(Object.ReferenceEquals(book1, book2));
        }

        [TestMethod]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "new_name");

            //act


            //assert
            Assert.AreEqual("new_name", book1.Name);
            
        }

        void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [TestMethod]
        public void CSharpIsPassedByValue()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "new_name");

            //act


            //assert
            Assert.AreEqual("Book 1", book1.Name);

        }

        void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [TestMethod]
        public void CSharpCanPassedByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "new_name");

            //act


            //assert
            Assert.AreEqual("new_name", book1.Name);

        }


        [TestMethod]
        public void Test1()
        {
            //arrange
            var x = GetInt();
            SetInt(ref x);
            //act


            //assert
            Assert.AreEqual(42, x);

        }

        private void SetInt(ref int x)
        {
            x = 42;
        }


        private int GetInt()
        {
            return 3;
        }

        void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
