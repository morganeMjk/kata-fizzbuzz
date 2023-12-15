namespace FizzBuzz;

public static class FizzBuzz
{
    public static string PrintFizzBuzz(int numberToConvert)
    {
        if (numberToConvert % 3 == 0 && numberToConvert % 5 == 0) return "FizzBuzz";
        if (numberToConvert % 3 == 0) return "Fizz";
        else if (numberToConvert % 5 == 0) return "Buzz";

        var numberString = numberToConvert.ToString();

        return numberString;
    }
}