using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyStateImpl;
using System.IO;

namespace StrategyStateImplTests
{

    [TestClass]
    public class MorningStrategyTests
    {
        Street _street;
        Strategy _strategy;

        [TestInitialize]
        public void TestMethod1()
        {
            _street = new Street(5, 0, DateTime.Now);
            _strategy = new MorningStrategy();
        }

        [TestMethod]
        public void ControlTrafficGreeWaveFromLeftToRightTest1()
        {
            // Arrange

            string expectedState = "ORANGE RED RED RED RED ";

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

        [TestMethod]
        public void ControlTrafficGreenWaveFromLeftToRightTest2()
        {
            // Arrange

            string expectedState = "ORANGE RED RED RED RED ";

            // Assert
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                // Act
                _strategy.ControlTraffic();
                _strategy.ControlTraffic();

                string actualOutput = stringWriter.ToString();

                Assert.AreEqual(expectedState, _street.ToString());

            }
        }


        [TestMethod]
        public void ControlTrafficGreenWaveFromLeftToRightTest3()
        {
            // Arrange

            string expectedState = "GREEN RED RED RED RED ";

            // Assert
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                // Act
                _strategy.ControlTraffic();
                _strategy.ControlTraffic();
                _strategy.ControlTraffic();

                string actualOutput = stringWriter.ToString();

                Assert.AreEqual(expectedState, _street.ToString());

            }
        }
    }
}
