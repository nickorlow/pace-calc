using System;
namespace PaceAPI
{
    /// <summary>
    /// Class to make unit conversion easy
    /// </summary>
    public static class Unit
    {
        //Metric
        public const double Meter = 1;
        public const double Kilometer = 1000;

        //Imperical
        public const double Mile = 1609.34;

        /// <summary>
        /// Convert a string to a unit
        /// </summary>
        /// <param name="unit">The string of a unit</param>
        /// <returns>Given unit that corresponds with your string</returns>
        public static double Parse(string unit)
        {
            switch (unit.ToLower())
            {
                case "m":
                case "meter":
                case "meters":
                    return Meter;

                case "km":
                case "kilometer":
                case "kilometers":
                    return Kilometer;

                case "mi":
                case "mile":
                case "miles":
                    return Mile;

                default:
                    throw new Exception("Invalid Unit");
            }
        }

        /// <summary>
        /// Convert a unit to the string representation of the unit
        /// </summary>
        /// <param name="unitInMeters">the value of the unit converted to meters</param>
        /// <returns>a string with the name of the unit</returns>
        public static string ToString(double unitInMeters)
        {
            switch (unitInMeters)
            {
                case Meter:
                    return "Meter";

                case Kilometer:
                    return "Kilometer";

                case Mile:
                    return "Mile";

                default:
                    throw new Exception("Invalid Unit");
            }
        }

        /// <summary>
        /// Convert a unit to the string representation of the unit
        /// </summary>
        /// <param name="unitInMeters">the value of the unit converted to meters</param>
        /// <returns>a string with the abbreviation of the unit</returns>
        public static string ToShortString(double unitInMeters)
        {
            switch (unitInMeters)
            {
                case Meter:
                    return "m";

                case Kilometer:
                    return "km";

                case Mile:
                    return "mi";

                default:
                    throw new Exception("Invalid Unit");
            }
        }
    }
}
