using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyStateImpl;

namespace StrategyStateImplTests
{
    [TestClass]
    public class StreetTests
    {
        Street _street;

        [TestMethod]
        public void RunTrafficMorningStrategyTest()
        {
            // Arrange
            DateTime date = new DateTime(2019, 5, 15, 11, 10, 0);
            _street = new Street(5, 0, date);

            string expectedOutput1 = "0 ORANGE RED RED RED RED";
            string expectedOutput2 = "2 GREEN RED RED RED RED";
            string expectedOutput3 = "5 GREEN ORANGE RED RED RED";
            string expectedOutput4 = "13 ORANGE GREEN GREEN RED RED";
            string expectedOutput5 = "14 RED GREEN GREEN RED RED";
            string expectedOutput6 = "28 RED RED RED ORANGE GREEN";



            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                // Act
                _street.RunTrafficLights();

                string actualOutput = stringWriter.ToString();

                // Assert
                Assert.AreEqual(expectedOutput1, actualOutput.Substring(actualOutput.IndexOf("0 "), actualOutput.IndexOf("0 ") + 24));
                Assert.AreEqual(expectedOutput2, actualOutput.Substring(actualOutput.IndexOf("2 "), actualOutput.IndexOf("2 ") + 23));
                Assert.AreEqual(expectedOutput3, actualOutput.Substring(actualOutput.IndexOf("5 "), actualOutput.IndexOf("5 ") + 26));
                Assert.AreEqual(expectedOutput4, actualOutput.Substring(actualOutput.IndexOf("13 "), actualOutput.IndexOf("13 ") + 29));
                Assert.AreEqual(expectedOutput5, actualOutput.Substring(actualOutput.IndexOf("14 "), actualOutput.IndexOf("14 ") + 26));
                Assert.AreEqual(expectedOutput6, actualOutput.Substring(actualOutput.IndexOf("28 "), actualOutput.IndexOf("28 ") + 27));
            }
        }

        [TestMethod]
        public void RunTrafficEveneningStrategyTest()
        {
            // Arrange
            DateTime date = new DateTime(2019, 5, 16, 0, 55, 0);
            _street = new Street(5, 0, date);

            string expectedOutput1 = "0 RED RED RED RED ORANGE";
            string expectedOutput2 = "2 RED RED RED RED GREEN";
            string expectedOutput3 = "5 RED RED RED ORANGE GREEN";
            string expectedOutput4 = "13 RED RED GREEN GREEN ORANGE";
            string expectedOutput5 = "14 RED RED GREEN GREEN RED";
            string expectedOutput6 = "28 GREEN ORANGE RED RED RED";



            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                // Act
                _street.RunTrafficLights();

                string actualOutput = stringWriter.ToString();

                // Assert
                Assert.AreEqual(expectedOutput1, actualOutput.Substring(actualOutput.IndexOf("0 "), actualOutput.IndexOf("0 ") + 24));
                Assert.AreEqual(expectedOutput2, actualOutput.Substring(actualOutput.IndexOf("2 "), actualOutput.IndexOf("2 ") + 23));
                Assert.AreEqual(expectedOutput3, actualOutput.Substring(actualOutput.IndexOf("5 "), actualOutput.IndexOf("5 ") + 26));
                Assert.AreEqual(expectedOutput4, actualOutput.Substring(actualOutput.IndexOf("13 "), actualOutput.IndexOf("13 ") + 29));
                Assert.AreEqual(expectedOutput5, actualOutput.Substring(actualOutput.IndexOf("14 "), actualOutput.IndexOf("14 ") + 26));
                Assert.AreEqual(expectedOutput6, actualOutput.Substring(actualOutput.IndexOf("28 "), actualOutput.IndexOf("28 ") + 27));
            }
        }
    }
}
