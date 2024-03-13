using monopoly.classes;

namespace monopoly.tests
{
    public class DicesTest
    {
        [Fact]
        public void TestRoll()
        {
            Dices dices = new ();
            int nb = dices.Roll();

            Assert.True(nb.GetType() == typeof(int) );

            Assert.True(nb >= 2 && nb <= 12);

            Assert.True(nb == dices.result);
        }

        [Fact]
        public void TestIsDouble()
        {
            Dices dices = new();

            dices.dice_1.Value = dices.dice_2.Value = 1;

            Assert.True(dices.Is_double());
        }
    }
}
