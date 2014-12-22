using System;
using System.Collections.Generic;
using NUnit.Framework;
using Core;

namespace UnitTests
{
    [TestFixture]
    class AnalyzerTests
    {
        Analyzer analyzer;

        [SetUp]
        public void Setup()
        {
            List<Token> tokens = new List<Token>() 
            { 
                new Token { Name = "fizz", Denominator = 3 },
                new Token { Name = "fazz", Denominator = 4 }, 
                new Token { Name = "buzz", Denominator = 5 }
            };

            this.analyzer = new Analyzer(tokens);
        }

        [Test]
        public void ShouldReturnFizzFor3()
        {
            String result = analyzer.Analyze(3);
            String expected = "3fizz";
            Assert.That(result == expected, String.Format("Expected {0}; Actual {1}",expected, result));
        }

        [Test]
        public void ShouldReturnBuzzFor5()
        {
            String result = analyzer.Analyze(5);
            String expected = "5buzz";
            Assert.That(result == expected, String.Format("Expected {0}; Actual {1}", expected, result));
        }

        [Test]
        public void ShouldReturnFizzBuzzFor15()
        {
            String result = analyzer.Analyze(15);
            String expected = "15fizzbuzz";
            Assert.That(result == expected, String.Format("Expected {0}; Actual {1}", expected, result));
        }

        [Test]
        public void ShouldReturnFizzFazzfor12()
        {
            String result = analyzer.Analyze(12);
            String expected = "12fizzfazz";
            Assert.That(result == expected, String.Format("Expected {0}; Actual {1}", expected, result));
        }

        [Test]
        public void ShouldReturnFizzFazzBuzzfor0()
        {
            String result = analyzer.Analyze(0);
            String expected = "0fizzfazzbuzz";
            Assert.That(result == expected, String.Format("Expected {0}; Actual {1}", expected, result));
        }

        [Test]
        public void ShouldReturnFizzBuzzforNegative15()
        {
            String result = analyzer.Analyze(-15);
            String expected = "-15fizzbuzz";
            Assert.That(result == expected, String.Format("Expected {0}; Actual {1}", expected, result));
        }
    }
}
