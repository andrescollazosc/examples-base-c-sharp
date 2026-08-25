namespace even_odd_pairs.Tests
{
    [TestFixture]
    public class EvenOddPairsTest
    {
        [Test]
        public void WhenExecuteHasEvenOddPairsIfNumberOfElementsIsOddReturnFalse()
        {
            //Arrange
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            
            //Act
            var result = EvenOddPairs.HasEvenOddPairs(numbers);
            
            //Assert
            Assert.False(result);
        }

        [Test]
        public void WhenExecuteHasEvenOddPairsIfEvenAndOddArePairsReturnTrue() {
            //Arrange
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            //Act
            var result = EvenOddPairs.HasEvenOddPairs(numbers);

            //Assert
            Assert.True(result);
        }

        [Test]
        public void WhenExecuteHasEvenOddPairsIfEvenAndOddAreNotPairsReturnFalse()
        {
            //Arrange
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 7 };

            //Act
            var result = EvenOddPairs.HasEvenOddPairs(numbers);

            //Assert
            Assert.False(result);
        }
    }
}
