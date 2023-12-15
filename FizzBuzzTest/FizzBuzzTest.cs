using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace FizzBuzzTest;

[TestFixture]
public class FizzBuzzTest
{
    [Test]
    public void PrintFizzBuzz_Input1_Return1()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(1), Is.EqualTo("1"));
    }

    [Test]
    public void PrintFizzBuzz_Input3_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(3), Is.EqualTo("Fizz"));
    }

    [Test]
    public void PrintFizzBuzz_Input5_ReturnBuzz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(5), Is.EqualTo("Buzz"));
    }

    [Test]
    public void PrintFizzBuzz_Input6_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(6), Is.EqualTo("Fizz"));
    }

    [Test]
    public void PrintFizzBuzz_Input9_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(9), Is.EqualTo("Fizz"));
    }

    [Test]
    public void PrintFizzBuzz_Input10_ReturnBuzz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(10), Is.EqualTo("Buzz"));
    }

    [Test]
    public void PrintFizzBuzz_Input12_ReturnFizz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(12), Is.EqualTo("Fizz"));
    }

    [Test]
    public void PrintFizzBuzz_Input15_ReturnFizzBuzz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(15), Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void PrintFizzBuzz_Input30_ReturnFizzBuzz()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(30), Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void PrintFizzBuzz_Input11_Return11()
    {
        Assert.That(FizzBuzz.FizzBuzz.PrintFizzBuzz(11), Is.EqualTo("11"));
    }
}