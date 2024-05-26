using FizzBuzz.Models;
using FluentAssertions;

namespace FizzBuzzTests;

/*
 * As the tests get more specific, the production code gets more generic
 * The two streams of code move in opposite directions along the generality axis until no new  * failing test can be written.
 */
public class FizzBuzzTests
{
    [Fact]
    public void ShouldReturn1IfNumberIs1()
    {
        string result = FizzBuzzGame.Play(1, 1);

        result.Should().Be("1");
    }

    [Fact]
    public void ShouldReturn2IfNumberIs2()
    {
        string result = FizzBuzzGame.Play(2, 2);

        result.Should().Be("2");
    }

    [Fact]
    public void ShouldReturnFizzIfNumberIs3()
    {
        string result = FizzBuzzGame.Play(3, 3);

        result.Should().Be("Fizz");
    }

    [Fact]
    public void ShouldReturnFizzIfNumberIs6()
    {
        string result = FizzBuzzGame.Play(6, 6);

        result.Should().Be("Fizz");
    }

    [Fact]
    public void ShouldReturnBuzzIfNumberIs5()
    {
        string result = FizzBuzzGame.Play(5, 5);

        result.Should().Be("Buzz");
    }

    [Fact]
    public void ShouldReturnBuzzIfNumberIs10()
    {
        string result = FizzBuzzGame.Play(10, 10);

        result.Should().Be("Buzz");
    }

    [Fact]
    public void ShouldReturnFizzBuzzIfNumberIs15()
    {
        string result = FizzBuzzGame.Play(15, 15);

        result.Should().Be("FizzBuzz");
    }

    [Fact]
    public void ShouldReturnFizzBuzzIfNumberIs30()
    {
        string result = FizzBuzzGame.Play(30, 30);

        result.Should().Be("FizzBuzz");
    }

    [Fact]
    public void ShouldReturn12IfNumbersAre1To2()
    {
        string result = FizzBuzzGame.Play(1, 2);

        result.Should().Be("12");
    }

    [Fact]
    public void ShouldReturn12FizzIfNumbersAre1To3()
    {
        string result = FizzBuzzGame.Play(1, 3);

        result.Should().Be("12Fizz");
    }

    [Fact]
    public void ShouldReturn12Fizz4BuzzIfNumbersAre1To5()
    {
        string result = FizzBuzzGame.Play(1, 5);

        result.Should().Be("12Fizz4Buzz");
    }

    [Fact]
    public void ShouldReturn12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzzIfNumbersAre1To15()
    {
        string result = FizzBuzzGame.Play(1, 15);

        result.Should().Be("12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz");
    }
}
