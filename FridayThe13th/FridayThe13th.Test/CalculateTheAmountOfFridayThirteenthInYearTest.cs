using FridayThe13th.App;
using Xunit;

namespace FridayThe13th.Test
{
    public class CalculateTheAmountOfFridayThirteenthInYearTest
    {
        [Theory]
        [InlineData(1999, 2000, "8/13/1999 10/13/2000")]
        [InlineData(2010, 2011, "8/13/2010 5/13/2011")]
        [InlineData(2012, 2013, "1/13/2012 4/13/2012 7/13/2012 9/13/2013 12/13/2013")]
        public void FridayTheThirteenthsTest(int Start, int End , string expected)
        {
            //Arrange
            ICalculateTheAmountOfFridayThirteenthInYear fridayTheThirteenths = new CalculateTheAmountOfFridayThirteenthInYear();

            //Act
            var actual = fridayTheThirteenths.FridayTheThirteenths(Start, End);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
