using System.Collections.Generic;
using E_Commerce.Domain.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_Commerce.Domain.Tests
{
    [TestClass]
    public class ValueObjectTests
    {
        [TestMethod]
        public void Equals_GivenDifferentValues_ShouldReturnFalse()
        {
            var point1 = new Point(1, 2);
            var point2 = new Point(2, 1);

            Assert.IsFalse(point1.Equals(point2));         
        }

        [TestMethod]
        public void Equals_GivenMatchingValues_ShouldReturnTrue()
        {
            var point1 = new Point(1, 2);
            var point2 = new Point(1, 2);

            Assert.IsTrue(point1.Equals(point2));
        }


        private class Point : ValueObject
        {
            public int X { get; set; }
            public int Y { get; set; }

            private Point()
            {

            }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            protected override IEnumerable<object> GetAtomicValues()
            {
                yield return X;
                yield return Y;
            }
        }
    }
}
