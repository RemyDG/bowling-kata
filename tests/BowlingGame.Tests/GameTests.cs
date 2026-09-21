using Xunit;

namespace BowlingGame.Tests;

public class GameTests
{
    [Fact]
    public void Test()
    {
        var rolls = new int[20];
        var game = new Game();

        Assert.Equal(0, game.Score(rolls));
    }
    
    // À toi de continuer !
}
