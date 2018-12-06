using MentalHealthTracker.Domain;
using MentalHealthTracker.Shared.Orchestrators;
using MentalHealthTracker.Shared.ViewModels;
using MentalHealthTracket.Shared.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MentalHealthTracket.Shared.Services
{
    public class HealthCalculator : IHealthCalculator
    {
        public int MoodAverage()
        {
            MentalContext _mentalContext = new MentalContext();
            var entries = _mentalContext.Entries;

            List<int> moods = new List<int>();

            foreach(var entry in entries)
            {
                moods.Add((int)entry.Mood);
            }

            var average = moods.Average();
            return (int)Math.Round(average, 0);
        }

        public int MoodMax()
        {
            throw new NotImplementedException();
        }

        public int MoodMin()
        {
            throw new NotImplementedException();
        }

        public int MoodMode()
        {
            throw new NotImplementedException();
        }
    }
}
