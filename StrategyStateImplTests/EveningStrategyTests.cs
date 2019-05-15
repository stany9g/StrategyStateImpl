using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyStateImpl;
using System.IO;

namespace StrategyStateImplTests
{

    [TestClass]
    public class EveningStrategyTests
    {
        Street _street;
        Strategy _strategy;

        [TestInitialize]
        public void TestMethod1()
        {
            _street = new Street(5, 0, DateTime.Now);
            _strategy = new EveningStrategy(_street);
        }

        [TestMethod]
        public void ControlTrafficGreeWaveFromLeftToRightTest1()
        {
            // Arrange

            string expectedState = "RED RED RED RED ORANGE ";

            // Assert
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                // Act
                _strategy.ControlTraffic();

                string actualOutput = stringWriter.ToString();

                Assert.AreEqual(expectedState, _street.ToString());

            }
        }

    }
}
