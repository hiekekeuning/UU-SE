public class SumValuesUnitTests
{

    [Fact]
    public void Sum_PositiveOnly_ContainsNegative()
    {
        int result = SumValuesExercise.SumValues(new int[] { 1, 2, 3, 4, -5 }, true);
        Assert.Equal(10, result);
    }

    [Fact]
    public void Sum_AllValues_EvenNumbers()
    {
        int result = SumValuesExercise.SumValues(new int[] { 2, -4, 6, 8 }, false);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Sum_PositiveOnly_MultiplesFive()
    {
        int result = SumValuesExercise.SumValues(new int[] { -10, 0, 5, 15 }, true);
        Assert.Equal(20, result);
    }

    [Fact]
    public void Sum_AllValues_PrimeNumbers()
    {
        int result = SumValuesExercise.SumValues(new int[] { 2, 3, 5, -7, 11 }, false);
        Assert.Equal(14, result);
    }

    [Fact]
    public void Sum_PositiveOnly_ContainsOnlyNegatives()
    {
        int result = SumValuesExercise.SumValues(new int[] { -9, -6, -5, -3, -2 }, true);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_AllValues_ContainsOnlyNegatives()
    {
        int result = SumValuesExercise.SumValues(new int[] { -9, -6, -5, -3, -2 }, false);
        Assert.Equal(-25, result);
    }
    
}