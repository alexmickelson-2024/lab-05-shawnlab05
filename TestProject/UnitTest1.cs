using MainProgram;
using static MainProgram.Program;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void TestHasWinnerVerticle1()
    {
        char [] board = new char [9] {'X', 'b','c','X','e','f','X','h','i'};
       MainProgram.Program.HasWinner(board);
        
    }

    [Fact]
    public void TestHasWinnerVerticle2()
    {
        
        char [] board = new char [9] {'a', 'X','c','d','X','f','g','X','i'};
       MainProgram.Program.HasWinner(board);

    }

    [Fact]
    public void TestHasWinnerVerticle3()
    {
        char [] board = new char [9] {'a', 'b','O','d','e','O','g','h','O'};
       MainProgram.Program.HasWinner(board);
        

    }

    [Fact]
    public void TestHasWinnerHorizontal1()
    {
        char [] board = new char [9] {'X', 'X','X','d','e','f','g','h','i'};
       MainProgram.Program.HasWinner(board);
        

    }
    [Fact]
    public void TestHasWinnerHorizontal2()
    {
        
        char [] board = new char [9] {'a', 'b','c','X','X','X','g','h','i'};
       MainProgram.Program.HasWinner(board);

    }
    [Fact]
    public void TestHasWinnerHorizontal3()
    {
        char [] board = new char [9] {'a', 'b','c','d','e','f','X','X','X'};
       MainProgram.Program.HasWinner(board);
        

    }
    [Fact]
    public void TestHasWinnerDiagonal1()
    {
        char [] board = new char [9] {'X', 'b','c','X','e','f','g','h','X'};
       MainProgram.Program.HasWinner(board);
        

    }
    [Fact]
    public void TestHasWinnerDiagonal2()
    {
        
        char [] board = new char [9] {'a', 'b','O','d','O','f','O','h','i'};
       MainProgram.Program.HasWinner(board);

    }
}