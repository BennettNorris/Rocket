using FluentAssertions;
using SnowSpaceLogic;
namespace SnowSpaceTests;

public class UnitTest1
{
    [Fact]
    public void WhenRocketTakesOffItDoesNotGoBoom()
    {
        // Arrange
        var rocket = new RocketShip("Ship22");

        // Act
        string result = rocket.TakeOff();
        //assert

        result.Should().NotBe("Boom!");

    }
    [Fact]
    public void DoomedRocketExlodes()
    {
        // Arrange
        var rocket = new RocketShip("Doomed");
        // act
        var result = rocket.TakeOff();
        // assert
        result.Should().Be("Boom!");
    }
}