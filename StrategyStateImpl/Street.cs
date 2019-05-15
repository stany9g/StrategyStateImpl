using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyStateImpl
{
    /// <summary>
    /// The class simulates a street with sequence of traffic lights.
    /// The lights are controlled by selected strategy:
    /// MorningStrategy before 12 p.m. and EveningStrategy after to 6 a.m.
    /// </summary>
    public class Street
    {
        /// <summary>
        /// Number of traffic lights for the street
        /// </summary>
        private int _numberOfTrafficLights;

        /// <summary>
        /// Control speed of the simulation reasonable values between 0 - for unit tests to 10 - for near real world simulation
        /// </summary>
        private int _timeSpeed;

        private DateTime _currentTime;

        public Strategy Strategy { get; set; }

        public List<TrafficLight> Lights { get; set; } = new List<TrafficLight>();

        public Street(int numberOfTrafficLights, int timeSpeed, DateTime currentTime)
        {
            for(int i = 0; i < numberOfTrafficLights; i++)
            {
                Lights.Add(new TrafficLight());
            }

            _timeSpeed = timeSpeed;
            _currentTime = currentTime;
        }

        /// <summary>
        /// Select an approppriate strategy to control traffic lights and simulates clock impulses
        /// that run the traffic light logic
        /// </summary>
        public void RunTrafficLights()
        {
            // choose the appropriate strategy
            // before 12pm use morning strategy, evening strategy use in the afternoon and evening
            //  TODO - TO BE IMPLEMENTED


            for(int time = 0; time < 1000; time++)
            {
                Strategy.ControlTraffic();

                Console.Write($"{time} ");
                Console.WriteLine(ToString());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(TrafficLight light in Lights)
            {
                sb.Append($"{light.GetLightColor()} ");

            }
            return sb.ToString();
        }
    }
}
