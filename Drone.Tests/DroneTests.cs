using Xunit;
using Drone;

namespace Drone.Tests;

public class UnitTest1
{
    [Fact]
    public void StartTest()
    {
        var drone = new Drone();
        var result = drone.Start(6, 7, 5);
        Assert.Equal(10.488088481701515, result);
    }

    [Fact]
    public void NewPositionTest()
    {
        double[] arrayA = [5, 7, 8];
        double[] arrayB = [3, 8, 2];
        
        var drone = new Drone();
        var result = drone.NewPosition(arrayA, arrayB);
        Assert.Equal([2, 15, 6], result);
    }

    [Fact]
    public void ShortestPathTest()
    {
        var drone = new Drone();
        var result = drone.ShortestPath(4, 6, 7);
        var result2 = drone.ShortestPath(1, 4, 8);
        Assert.Equal(2, result);
    }
}
