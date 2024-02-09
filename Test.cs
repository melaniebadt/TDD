//Test Functions 
using InchConverter = Converter.InchCoverter;

void Test <T> ( T expected, T actual, string description = "Test")
{
    if ( expected.Equals(actual))
    {
        Console.WriteLine($"🟢 {description}");  
    }
    else
    {
        Console.WriteLine($"🔴 {description}, expected {expected}, recieved {actual}");
    }
}


