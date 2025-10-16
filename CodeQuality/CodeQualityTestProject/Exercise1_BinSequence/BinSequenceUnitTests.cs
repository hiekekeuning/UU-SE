public class BinSequenceUnitTests
{
    
    [Fact]
    public void BinSequence_ContainsThree()
    {
        bool result = BinSequenceExercise.IsBinarySequence(new int[] { 0, 1, 1, 0, 1, 3, 0 });
        Assert.False(result);
    }

    [Fact]
    public void BinSequence_ContainsFive()
    {
        bool result = BinSequenceExercise.IsBinarySequence(new int[] { 0, 1, 1, 0, 1, 0, 5 });
        Assert.False(result);
    }

    [Fact]
    public void BinSequence_ContainsTwo()
    {
        bool result = BinSequenceExercise.IsBinarySequence(new int[] { 2, 0, 1, 1, 0, 1, 0 });
        Assert.False(result);
    }

    [Fact]
    public void BinSequence_ContainsNegative()
    {
        bool result = BinSequenceExercise.IsBinarySequence(new int[] { 0, -1, 1, 1, 0, 1, 0 });
        Assert.False(result);
    }

    [Fact]
    public void BinSequence_AllZeros()
    {
        bool result = BinSequenceExercise.IsBinarySequence(new int[] { 0, 0, 0, 0, 0, 0, 0 });
        Assert.True(result);
    }

    [Fact]
    public void BinSequence_AllOnes()
    {
        bool result = BinSequenceExercise.IsBinarySequence(new int[] { 1, 1, 1, 1, 1, 1, 1 });
        Assert.True(result);
    }

    [Fact]
    public void BinSequence_MixedZerosAndOnes()
    {
        bool result = BinSequenceExercise.IsBinarySequence(new int[] { 1, 0, 1, 1, 0, 0, 1 });
        Assert.True(result);
    }

}