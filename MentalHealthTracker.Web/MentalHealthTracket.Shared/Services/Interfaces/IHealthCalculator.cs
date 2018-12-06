
namespace MentalHealthTracket.Shared.Services.Interfaces
{
    public interface IHealthCalculator
    {
        int MoodAverage();
        int MoodMode();
        int MoodMax();
        int MoodMin();
    }
}
