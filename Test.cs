using inConv = Converter.InchCoverter;

public class ConverterTests
{
    public void RunTests()
    {
        double expected = 2.54;
        Test(expected, inConv.InchesToCentimeters(1));

        expected = 25.4;
        Test(expected, inConv.InchesToMillimeters(1));

        expected = 0.0254;
        Test(expected, inConv.InchesToMeters(1));
    }

    void Test(double expected, double actual, string description = "Test")
    {

        if (expected == actual)
        {
            Console.WriteLine($"🟢 {description}");
        }
        else
        {
            Console.WriteLine($"🔴 {description}, expected {expected}, recieved {actual}");
        }
    }
}



