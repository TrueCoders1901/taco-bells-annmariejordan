using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);


            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            // TODO:  Find the two Taco Bells that are the furthest from one another.
            double farthestDistance = 0;
            ITrackable tacoBell1 = null;
            ITrackable tacoBell2 = null;

            foreach (ITrackable location in locations)
            {
                GeoCoordinate loc1 = new GeoCoordinate();
                GeoCoordinate loc2 = new GeoCoordinate();

                loc1.Latitude = location.Location.Latitude;
                loc1.Longitude = location.Location.Longitude;

                foreach (ITrackable location2 in locations)
                {
                    loc2.Latitude = location2.Location.Latitude;
                    loc2.Longitude = location2.Location.Longitude;


                    double distance = loc1.GetDistanceTo(loc2);
                    if (distance > farthestDistance)
                    {
                        farthestDistance = distance;
                        tacoBell1 = location;
                        tacoBell2 = location2;
                    }

                }
            }
                Console.WriteLine(tacoBell1.Name + "and" + tacoBell2.Name + " are the farthest from each other at " + farthestDistance + ".");
                Console.ReadLine();
            // HINT:  You'll need two nested forloops
        }
    }
}