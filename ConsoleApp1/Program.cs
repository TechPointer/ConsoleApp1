using System; 
    public class Program
{
    public static readonly string CTCPDelimiterString = "\x0001";
    public static readonly char CTCPDelimiterChar = '\x0001';

    public static void Main()
    {
        string text = "!sampletext";

        Console.Write("  Using a char: ");
        if (text.StartsWith(CTCPDelimiterChar) && text.EndsWith(CTCPDelimiterChar))
        {
            Console.WriteLine("got CTCP delimiters");
        }
        else
        {
            Console.WriteLine("did not get CTCP delimiters");
        }

        Console.Write("Using a string: ");
        if (text.StartsWith(CTCPDelimiterString) && text.EndsWith(CTCPDelimiterString))
        {
            Console.WriteLine("got CTCP delimiters");
        }
        else
        {
            Console.WriteLine("did not get CTCP delimiters");
        }
    }
}