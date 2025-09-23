

namespace cw3.nwdxunit;

public class NWDTests
{

    [Fact]
    public void If_8_and_12_then_4()
    {
        //arrange
        int a = 8;
        int b = 12;
        int expected = 4;
        //act
        var nwd = new cw3.nwdclasslib.Nwd();
        int result = nwd.Calculate(a, b);
        //assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void If_0_and_12_then_12()
    {
        //arrange
        int a = 0;
        int b = 12;
        int expected = 12;
        //act
        var nwd = new cw3.nwdclasslib.Nwd();
        int result = nwd.Calculate(a, b);
        //assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void If_minus8_and_12_then_4()
    {
        //arrange
        int a = -8;
        int b = 12;
        int expected = 4;
        //act
        var nwd = new cw3.nwdclasslib.Nwd();
        int result = nwd.Calculate(a, b);
        //assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void If_minus8_and_minus12_then_4()
    {
        //arrange
        int a = -8;
        int b = -12;
        int expected = 4;
        //act
        var nwd = new cw3.nwdclasslib.Nwd();
        int result = nwd.Calculate(a, b);
        //assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void If_0_and_0_then_0()
    {
        //arrange
        int a = 0;
        int b = 0;
        int expected = 0;
        //act
        var nwd = new cw3.nwdclasslib.Nwd();
        int result = nwd.Calculate(a, b);
        //assert
        Assert.Equal(expected, result);
    }
}
