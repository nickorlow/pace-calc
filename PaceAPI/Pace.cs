using System;
using System.Collections.Generic;


namespace PaceAPI
{
    public class Pace
    {
        public List<TimeSpan> Paces { get; protected set; }
        public List<double> Distances { get; protected set; }
        public List<double> Units { get; protected set; }

        /// <summary>
        /// Object that stores the time it would take in order to cover the distances in the Distances List (pace)
        /// </summary>
        /// <param name="time">the time it takes to cover the distance paramater</param>
        /// <param name="distance">the distance travelled in the time paramater</param>
        /// <param name="unit">the unit of the distance paramater, represented by it's conversion to meters i.e 1 Mile = 1609.34 meters</param>
        public Pace(TimeSpan time, double distance, double unit)
        {
            InitLists();

            Paces.Add(time);
            Distances.Add(distance * unit);
            Units.Add(unit);
            CalculatePresetPaces();
        }

        private void CalculatePresetPaces()
        {
            List<double> distances = new List<double> { 100, 200, 400, 600, 800, 1000, 1600, 1, 3200, 2, 5 };
            List<double> units = new List<double> { Unit.Meter, Unit.Meter, Unit.Meter, Unit.Meter, Unit.Meter, Unit.Meter, Unit.Meter, Unit.Mile, Unit.Meter, Unit.Mile, Unit.Kilometer };

            for (int i = 0; i < distances.Count; i++)
                CalculatePace(distances[i], units[i]);
        }

        /// <summary>
        /// Calculates a the time it would take to run the distance given
        /// </summary>
        /// <param name="distance">the distance covered</param>
        /// <param name="unit">the unit of the distance variable</param>
        /// <returns>the time (in seconds) it would take to run the distance at the pace</returns>
        public TimeSpan CalculatePace(double distance, double unit = Unit.Meter)
        {
            double rootSeconds = Paces[0].TotalSeconds;
            double rootDistance = Distances[0];
            double distanceInMeters = (distance * unit);
            double paceInSeconds = distanceInMeters / (rootDistance / rootSeconds);

            Paces.Add(TimeSpan.FromSeconds(paceInSeconds));
            Distances.Add(distance);
            Units.Add(unit);

            return TimeSpan.FromSeconds(paceInSeconds);
        }

        /// <summary>
        /// Initalizes the properties with empty lists of the correct type
        /// </summary>
        private void InitLists()
        {
            Paces = new List<TimeSpan>();
            Distances = new List<double>();
            Units = new List<double>();
        }
    }
}
