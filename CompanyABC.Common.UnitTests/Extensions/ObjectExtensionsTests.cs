using CompanyABC.Common.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.Common.UnitTests.Extensions
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [Serializable]
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        [TestMethod]
        public void DeepCopy_NullArg_ExpectedBehavior()
        {
            // ARRANGE
            
            // ACT
            var actual = ObjectExtensions.DeepCopy<object>(null);

            // ASSERT
            Assert.IsNull(actual, "Expected null return.");
        }

        [TestMethod]
        public void DeepCopy_ObjectSupplied_DeepCopyOfObjectReturned()
        {
            // ARRANGE
            var instance = new Person
            {
                Name="Craig",
                Age=36
            };

            // ACT            
            var actual = instance.DeepCopy();

            // ASSERT
            Assert.AreNotSame(instance, actual, "Are different instances.");
            var expected = new Person
            {
                Name = "Craig",
                Age = 36
            };
            Assert.AreEqual(expected.Name, instance.Name, "Name [{0}] is expected.", expected.Name);
            Assert.AreEqual(expected.Age, instance.Age, "Age [{0}] is expected.", expected.Age);
        }
    }
}
