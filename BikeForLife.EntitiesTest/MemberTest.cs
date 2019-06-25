using BikeForLife.Entities;
using System;
using Xunit;

namespace BikeForLife.EntitiesTest
{
    public class MemberTest
    {
        [Fact]
        public void GetRideLevel_ReturnsEasyWith0Rides()
        {
            //Arrange
            Member member = new Member();
            Difficulty expectedDifficulty = Difficulty.Easy;

            //Act
            Difficulty actualDiffculty = member.RideLevel;

            //Assert
            Assert.Equal(actualDiffculty, expectedDifficulty);
        }

        [Fact]
        public void GetRideLevel_ReturnsEasyWith4Rides()
        {
            //Arrange
            Member member = new Member();
            Ride ride1 = new Ride();
            BikeRoute route = new BikeRoute();
            route.Difficulty = Difficulty.Easy;
            ride1.Route = route;
            member.Add(ride1);
            Ride ride2 = new Ride();
            ride2.Route = route;
            member.Add(ride2);
            Ride ride3 = new Ride();
            ride3.Route = route;
            member.Add(ride3);
            Ride ride4 = new Ride();
            ride4.Route = route;
            member.Add(ride4);
            Difficulty expectedDifficulty = Difficulty.Easy;

            //Act
            Difficulty actualDiffculty = member.RideLevel;

            //Assert
            Assert.Equal(actualDiffculty, expectedDifficulty);
        }

        [Fact]
        public void GetRideLevel_ReturnsNormalWith5Rides()
        {
            //Arrange
            Member member = new Member();
            Ride ride1 = new Ride();
            BikeRoute route = new BikeRoute();
            route.Difficulty = Difficulty.Easy;
            ride1.Route = route;
            member.Add(ride1);
            Ride ride2 = new Ride();
            ride2.Route = route;
            member.Add(ride2);
            Ride ride3 = new Ride();
            ride3.Route = route;
            member.Add(ride3);
            Ride ride4 = new Ride();
            ride4.Route = route;
            member.Add(ride4);
            Ride ride5 = new Ride();
            member.Add(ride5);
            //Act

            //Assert

        }

    }
}
