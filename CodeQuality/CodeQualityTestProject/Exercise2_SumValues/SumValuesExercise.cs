public class SumValuesExercise
{

    // Original exercise code
    public static int SumValues(int[] values, bool positivesOnly)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            if (positivesOnly == true)
            {
                if (values[i] >= 0)
                {
                    sum += values[i];
                }
            }
            else
            {
                sum += values[i];
            }
        }
        return sum;
    }

    // Solution 1
    // public static int SumValues(int[] values, bool positivesOnly)
    // {
    //     int sum = 0;
    //     foreach (int n in values)
    //     {
    //         if (!positivesOnly || n > 0)
    //         {
    //             sum += n;
    //         }
    //     }
    //     return sum;
    // }

    // Solution 2
    // public static int SumValues(int[] values, bool positivesOnly)
    // {
    //     return values.Where(v => !positivesOnly || v > 0).Sum();
    // }
    
}