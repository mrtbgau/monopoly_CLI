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
    }
}
