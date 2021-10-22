using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Internship_Problem_3
{
    [TestFixture]
    class UnitTest
    {
        Evaluator Evaluator { get; set; } = new Evaluator();
        [Test]
        [TestCase("1 - 1", ExpectedResult =0)]
        [TestCase("1 + 1", ExpectedResult =2)]
        [TestCase("1 - 1", ExpectedResult = 0)]
        [TestCase("1* 1",ExpectedResult =1)]
        [TestCase("1 /1",ExpectedResult =1)]
        public double TestEvaluation(string expresion)
        {
            return Evaluator.Evaluate(expresion);
        }

    }
}
