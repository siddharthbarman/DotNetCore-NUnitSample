using System;
using System.Configuration.Assemblies;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using SByteStream.Samples;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(3, calc.Add(1, 2));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(10, calc.Subtract(100, 90));
        }

        [Test]
        public void TestMultiply() 
        {
            Assert.AreEqual(6, calc.Multiply(3, 2));
        }

        
        [Test]
        public void TestDivideByZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 
            {
                calc.Divide(1, 0);
            });
        }

        private Calculator calc;
    }
}