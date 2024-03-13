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
            Dice dice1 = new();
            Dice dice2 = new();

            Assert.True(dice1.Value == dice2.Value);
        }
    }
}
