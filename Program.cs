using System;
using inConv = Converter.InchCoverter;

public class Application
{
    public static void Main(string[] args)
    {

        if (args[0] == "-t")
        {
            ConverterTests test = new ConverterTests();
            test.RunTests();
        }
        else if (args[1] == "-m")
        {
            double inputValue = double.Parse(args[0]);
            Console.WriteLine(inConv.InchesToMeters(inputValue));
        }
        else if (args[1] == "-cm")
        {
            double inputValue = double.Parse(args[0]);
            Console.WriteLine(inConv.InchesToCentimeters(inputValue));
        }
        else if (args[1] == "-mm")
        {
            double inputValue = double.Parse(args[0]);
            Console.WriteLine(inConv.InchesToMillimeters(inputValue));
        }
        else
        {
            Console.WriteLine("Opps, you are using the program the wrong way!");
            Environment.Exit(0);
        }
    }
}
