namespace HalloStandardLib.Tests
{
    public class CalcTests
    {
        [Fact]
        public void Sum_3_and_4_results_7()
        {
            var calc = new Calc();

            var result = calc.Sum(3, 4);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Sum_0_and_0_results_0()
        {
            var calc = new Calc();

            var result = calc.Sum(0, 0);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Sum_MAX_and_1_throws_OverflowExcpetion()
        {
            var calc = new Calc();

            Action act = () => calc.Sum(int.MaxValue, 1);

            Assert.Throws<OverflowException>(act);
        }

        public void CallSum()
        {
            var calc = new Calc();
            calc.Sum(int.MaxValue, 1);
        }
    }
}