// See https://aka.ms/new-console-template for more information
public class MPG
{
    public double calc_mpg(double miles, double gallons)
    {
        if (gallons<=0) return 0;
        return miles / gallons;
    }
}
