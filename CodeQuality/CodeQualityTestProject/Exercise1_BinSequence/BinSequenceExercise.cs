public class BinSequenceExercise
{

    // Original exercise code
    public static bool IsBinarySequence(int[] seq)
    {
        int i;
        for (i = 0; i < seq.Length; i++)
        {
            if (seq[i] > -1 && seq[i] < 2)
            {
                continue;
            }
            else
            {
                break;
            }
        }
        if (i == seq.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Solution 1
    // public static bool IsBinarySequence(int[] seq)
    // {
    //     foreach (int n in seq)
    //     {
    //         if (!IsBinaryDigit(n))
    //         {
    //             return false;
    //         }
    //     }
    //     return true;
    // }

    // private static bool IsBinaryDigit(int n)
    // {
    //     return n == 0 || n == 1;
    // }

    // Solution 2
    // public static bool IsBinarySequence(int[] seq)
    // {
    //     return seq.All(IsBinaryDigit);
    // }

}