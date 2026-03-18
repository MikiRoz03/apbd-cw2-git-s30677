public class StatisticsHelper
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static double Average(int[] values)
    {
        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }
        return (double)sum / values.Length;
    }

    public static int Max(int[] values)
    {
        int max = values[0];

        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }
        return max;
    }
}
