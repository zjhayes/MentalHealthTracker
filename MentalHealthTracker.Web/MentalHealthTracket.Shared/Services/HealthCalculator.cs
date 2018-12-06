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
        public int MoodAverage(int[] moods)
        {
            var average = moods.Average();
            return (int)Math.Round(average, 0);
        }

        public int MoodMax(int[] moods)
        {
            int max = 0;
 
            for(int i = 0; i < 11; i++)
            {
                if(moods[i] > moods[max])
                {
                    max = i;
                }
            }

            return max;
        }

        public int MoodMin(int[] moods)
        {
            int min = 11;

            for(int i = 10; i > 0; i--)
            {
                if(moods[i] < moods[min])
                {
                    min = i;
                }
            }

            return min;
        }

        public int MoodMode(int[] moods)
        {
            int[] moodTotals = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int mode = 0;

            for(int i = 0; i < 11; i++)
            {
                var mood = moods[i];

                moodTotals[mood]++;
            }

            for (int i = 1; i < 11; i++)
            {
                if (moodTotals[i] > moodTotals[mode])
                {
                    mode = i;
                }
            }

            return mode;
        }
    }
}
