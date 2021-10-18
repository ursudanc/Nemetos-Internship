namespace Internship_Problems
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Lew", Kata.DeclareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew"));
            Assert.AreEqual("Harry", Kata.DeclareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Harry"));
            Assert.AreEqual("Harald", Kata.DeclareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"));
            Assert.AreEqual("Harald", Kata.DeclareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald"));
            Assert.AreEqual("Harald", Kata.DeclareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"));
            Assert.AreEqual("Harald", Kata.DeclareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald"));
        }
       
      
    }
    
    
}

