using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string url = "https://example.com"; // Replace with your desired URL

        LaunchWebsite(url);
    }

    static void LaunchWebsite(string url)
    {
        try
        {
            Process.Start(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while launching the website:");
            Console.WriteLine(ex.Message);
        }
    }
}
