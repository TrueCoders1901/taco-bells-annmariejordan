using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
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
        public void ShouldFailParse(string str)
        {
            //Arrange


            //Act


            //Assert

        }
    }
}
