using monopoly.classes;

namespace monopoly.tests
{
    public class DiceTest
    {
        [Fact]
        public void NumberOfFaces_Equal()
        {
            Dice dice = new();
            Assert.Equal(6, dice.NbFaces);
        }
    }
}