using System.Xml.Serialization;
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
    [Fact]
    public void CanChangeName()

    {
        var rocket = new RocketShip("Original1");


        // change the name
        rocket.SetName("Changed1");

        // observe the newly changed value
        rocket.GetName().Should().Be("Changed1");
    }

    [Fact]
    public void CannotMakeNameNull()
    {
        void makeRocketWithNullName()
        {
            var rocket = new RocketShip(null);
        }

        FluentActions.Invoking(makeRocketWithNullName)
        .Should()
        .Throw<Exception>();
    }

    [Fact]
    public void RocketWithNoNumberThrowsExecption()
    {
        void MakeRocketWithoutNumber()
        {
            var rocket = new RocketShip("NoNumber");
        }

        FluentActions.Invoking(MakeRocketWithoutNumber)
        .Should()
        .Throw<Exception>();

    }
    [Fact]
    public void ShipCannotHaveNegativeFins()
    {
   var ship = new RocketShip("Name1");
   ship.SetNumberOfFins(3);
   ship.GetNumberOfFins().Should().Be(3);

    }

}