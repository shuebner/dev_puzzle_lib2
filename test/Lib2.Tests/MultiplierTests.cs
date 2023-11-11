namespace Lib2.Tests
{
    public class MultiplierTests
    {
        [Fact]
        public void Test1()
        {
            var multiplier = new Multiplier();
            int result = multiplier.Multiply(2, 3);
            Assert.Equal(6, result);
        }
    }
}