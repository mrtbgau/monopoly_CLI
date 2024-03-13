using monopoly.classes;

namespace monopoly.tests
{
    public class DiceTest
    {
        [Fact]
        public void Test_NumberOfFaces()
        {
            Dice dice = new();
            Assert.Equal(6, dice.NbFaces);
        }

        [Fact]
        public void Test_Roll() {
            Dice dice = new();

            int nb = dice.Roll();
            Assert.True(nb.GetType() == typeof(int));

            // Le nombre généré doit être entre 1 et le nombre de faces du dé et il est retourné
            Assert.True(nb >= 1 && nb <= dice.NbFaces);

            // Le nombre généré est bien stocké dans la propriété Value
            Assert.True(nb == dice.Value);

            // Le nombre généré est bien aléatoire
            int baseValue = dice.Roll();
            bool result = false;
            int nbRounds = 10;

            while (!result && nbRounds >= 0)
            {
                int rollValue = dice.Roll();
                nbRounds--;
                if (rollValue != baseValue)
                {
                    result = true;
                }
            }

            Assert.True(result);
        }
    }
}