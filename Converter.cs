namespace Converter
{
    class InchCoverter
    {
        const double meters = 0.0254;
        const double centimeters = 2.54;
        const double millimeters = 25.4;


        public static double InchesToMeters(double inches)
        {
            return inches * meters;
        }
        public static double InchesToCentimeters(double inches)
        {
            return inches * centimeters;
        }
        public static double InchesToMillimeters(double inches)
        {
            return inches * millimeters;
        }
    }
}