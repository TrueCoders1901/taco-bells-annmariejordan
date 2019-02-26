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
            TacoParser tacoparser = new TacoParser
            


            //Act
            ITrackable trackable 

            //Assert
            Assert.NotNull(actual);
            Assert.NotNull(actual.name);
            Assert.Contains("Taco Bell", actual.Name);
            Assert. 
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
