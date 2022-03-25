using FluentAssertions;
using FluentAssertions.Execution;
using MikeFoden.Starter.Library;
using Xunit;

namespace MikeFoden.Starter.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var testVal = new Class1("test");
        
        using (new AssertionScope())
        {
            testVal.DefaultValue.Should().Be("test");
        }
    }
}