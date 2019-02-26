using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Theory]
        [InlineData("0,0, test name")]
        [InlineData("32.571331,-85.499655, Taco Bell Auburn")]
        [InlineData("34.073638, -84.677017, Taco Bell Acworth")]
        public void ShouldParse(string str)
        {
            //arrange
            TacoParser tacoparser = new TacoParser();

            //Act
            ITrackable trackable = tacoparser.Parse(str);

            //Assert
            Assert.NotNull(trackable);
           
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("34.073638, -84.677017")]
        public void ShouldFailParse(string str)
        {
            //arrange
            TacoParser tacoparser = new TacoParser();

            //Act
            ITrackable trackable = tacoparser.Parse(str);

            //Assert
            Assert.Null(trackable);
        }
    }
}
