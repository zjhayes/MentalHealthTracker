
namespace MentalHealthTracket.Shared.Services.Interfaces
{
    public interface IHealthCalculator
    {
        int MoodAverage(int[] moods);
        int MoodMode(int[] moods);
        int MoodMax(int[] moods);
        int MoodMin(int[] moods);
    }
}
