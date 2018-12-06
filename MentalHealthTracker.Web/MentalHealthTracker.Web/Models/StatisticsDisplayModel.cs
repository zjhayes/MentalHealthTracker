
using MentalHealthTracket.Shared.Services;

namespace MentalHealthTracker.Web.Models
{
    public class StatisticsDisplayModel
    {
        public int Average
        {
            get
            {
                /*HealthCalculator calc = new HealthCalculator();
                int average = calc.MoodAverage();*/
                return 2;//Average;
            }
            set { Average = value; }
        }
        public int Mode
        {
            get { return Mode; }
            set { Mode = value; }
        }
        public int Minimum
        {
            get { return Minimum; }
            set { Minimum = value; }
        }
        public int Maximum
        {
            get { return Maximum; }
            set { Maximum = value; }
        }
    }
}