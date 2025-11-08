using BreathFirstSearch;

namespace BFSGridApp.Tests;

[TestClass]
public class GridBFSTests
{
    [TestMethod]
    public void Test_SimplePath_ShouldReturn4()
    {
        var grid = new[]
        {
            new[] { 0, 1, 0 },
            new[] { 0, 0, 0 },
            new[] { 1, 0, 0 }
        };

        var solver = new BFS();
        var result = solver.ShortestPath(grid);

        Assert.Equals(4, result);
    }

    [TestMethod]
    public void Test_NoPath_ShouldReturnMinus1()
    {
        var grid = new[]
        {
            new[] { 0, 1, 1 },
            new[] { 1, 1, 1 },
            new[] { 1, 1, 0 }
        };

        var solver = new BFS();
        var result = solver.ShortestPath(grid);

        Assert.Equals(-1, result);
    }

    [TestMethod]
    public void Test_AlreadyAtDestination_ShouldReturn0()
    {
        var grid = new[]
        {
            new[] { 0 }
        };

        var solver = new BFS();
        var result = solver.ShortestPath(grid);

        Assert.Equals(0, result);
    }

    [TestMethod]
    public void Test_StartBlocked_ShouldReturnMinus1()
    {
        var grid = new[]
        {
            new[] { 1, 0 },
            new[] { 0, 0 }
        };

        var solver = new BFS();
        var result = solver.ShortestPath(grid);

        Assert.Equals(-1, result);
    }

    [TestMethod]
    public void Test_EndBlocked_ShouldReturnMinus1()
    {
        var grid = new[]
        {
            new[] { 0, 0 },
            new[] { 0, 1 }
        };

        var solver = new BFS();
        var result = solver.ShortestPath(grid);

        Assert.Equals(-1, result);
    }
}