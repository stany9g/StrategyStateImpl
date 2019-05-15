using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyStateImpl;

namespace StrategyStateImplTests
{
    [TestClass]
    public class TrafficLightTests
    {
        TrafficLight _light;

        [TestInitialize]
        public void Init()
        {
            _light = new TrafficLight();
        }

        [TestMethod]
        public void SetStopStateRedTest()
        {
            // Arrange
            Color expectedColor = Color.RED;

            // Act
            _light.SetState(new Stop(_light));

            // Assert
            Assert.AreEqual(expectedColor, _light.GetLightColor());
        }

        [TestMethod]
        public void SetPrepareStateOrangeTest()
        {
            // Arrange
            Color expectedColor = Color.ORANGE;

            // Act
            _light.SetState(new Prepare(_light));

            // Assert
            Assert.AreEqual(expectedColor, _light.GetLightColor());
        }

        [TestMethod]
        public void SetGoStateGreenTest()
        {
            // Arrange
            Color expectedColor = Color.GREEN;

            // Act
            _light.SetState(new Go(_light));

            // Assert
            Assert.AreEqual(expectedColor, _light.GetLightColor());
        }

        [TestMethod]
        public void TimeLapseColorChangeByPeriodTest()
        {
            // Arrange
            _light.SetState(new Prepare(_light));

            // Act
            for(int i = 0; i < (int)LightPeriod.ORANGE_LIGHT_PERIOD; i++)
            {
                _light.TimeLapseTick();
            }

            // Assert
            Assert.AreEqual(Color.GREEN, _light.GetLightColor());

            // Act
            for (int i = 0; i < (int)LightPeriod.GREEN_LIGHT_PERIOD; i++)
            {
                _light.TimeLapseTick();
            }

            // Assert
            Assert.AreEqual(Color.ORANGE, _light.GetLightColor());

            // Act
            for (int i = 0; i < (int)LightPeriod.ORANGE_LIGHT_PERIOD; i++)
            {
                _light.TimeLapseTick();
            }

            // Assert
            Assert.AreEqual(Color.RED, _light.GetLightColor());
        }
    }
}
