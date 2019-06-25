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
            Assert.Equal(expectedDifficulty, actualDiffculty);
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
            Assert.Equal(expectedDifficulty, actualDiffculty);
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
            ride5.Route = route;
            member.Add(ride5);
            Difficulty expectedDifficulty = Difficulty.Normal;

            //Act
            Difficulty actualDiffculty = member.RideLevel;

            //Assert
            Assert.Equal(expectedDifficulty, actualDiffculty);
        }

        [Fact]
        public void GetRideLevel_ReturnsNormalWith11Rides()
        {
            //Arrange
            Member member = new Member();
            BikeRoute route = new BikeRoute();
            route.Difficulty = Difficulty.Easy;
            for (int i = 0; i < 11; i++)
            {
                Ride ride = new Ride();
                ride.Route = route;
                member.Add(ride);
            }
            Difficulty expectedDifficulty = Difficulty.Normal;

            //Act
            Difficulty actualDiffculty = member.RideLevel;

            //Assert
            Assert.Equal(expectedDifficulty, actualDiffculty);
        }

        [Fact]
        public void GetRideLevel_ReturnsNormalWith12Rides4IsNormal()
        {
            Member member = new Member();
            BikeRoute route1 = new BikeRoute();
            BikeRoute route2 = new BikeRoute();
            route1.Difficulty = Difficulty.Easy;
            route2.Difficulty = Difficulty.Normal;
            for (int i = 0; i < 8; i++)
            {
                Ride ride = new Ride();
                ride.Route = route1;
                member.Add(ride);
            }
            for (int i = 0; i < 4; i++)
            {
                Ride ride = new Ride();
                ride.Route = route2;
                member.Add(ride);
            }
            Difficulty expectedDifficulty = Difficulty.Normal;

            //Act
            Difficulty actualDiffculty = member.RideLevel;

            //Assert
            Assert.Equal(expectedDifficulty, actualDiffculty);
        }

        [Fact]
        public void GetRideLevel_ReturnsHardWith12Rides5IsNormal()
        {
            Member member = new Member();
            BikeRoute route1 = new BikeRoute();
            BikeRoute route2 = new BikeRoute();
            route1.Difficulty = Difficulty.Easy;
            route2.Difficulty = Difficulty.Normal;
            for (int i = 0; i < 7; i++)
            {
                Ride ride = new Ride();
                ride.Route = route1;
                member.Add(ride);
            }
            for (int i = 0; i < 5; i++)
            {
                Ride ride = new Ride();
                ride.Route = route2;
                member.Add(ride);
            }
            Difficulty expectedDifficulty = Difficulty.Hard;

            //Act
            Difficulty actualDiffculty = member.RideLevel;

            //Assert
            Assert.Equal(expectedDifficulty, actualDiffculty);
        }

        [Fact]
        public void GetRideLevel_ReturnsHardWith30Rides9IsNormal()
        {
            Member member = new Member();
            BikeRoute route1 = new BikeRoute();
            BikeRoute route2 = new BikeRoute();
            BikeRoute route3 = new BikeRoute();
            route1.Difficulty = Difficulty.Easy;
            route2.Difficulty = Difficulty.Normal;
            route3.Difficulty = Difficulty.Hard;
            for (int i = 0; i < 7; i++)
            {
                Ride ride = new Ride();
                ride.Route = route1;
                member.Add(ride);
            }
            for (int i = 0; i < 9; i++)
            {
                Ride ride = new Ride();
                ride.Route = route2;
                member.Add(ride);
            }
            for (int i = 0; i < 14; i++)
            {
                Ride ride = new Ride();
                ride.Route = route3;
                member.Add(ride);
            }
            Difficulty expectedDifficulty = Difficulty.Hard;

            //Act
            Difficulty actualDiffculty = member.RideLevel;

            //Assert
            Assert.Equal(expectedDifficulty, actualDiffculty);
        }
    }
}
