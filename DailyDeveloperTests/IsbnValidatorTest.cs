using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyDeveloper01;

namespace DailyDeveloperTests
{
    [TestClass]
    public class IsbnValidatorTest
    {
        [TestMethod]
        public void Bvt1()
        {
            string isbnString = "0-7475-3269-9";
            IsbnValidator validator = new IsbnValidator();
            bool result = IsbnValidator.IsValidISBN(isbnString);
            Console.WriteLine("Result = {0}", result);
        }
    }
}
