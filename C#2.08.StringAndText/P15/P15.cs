using System;

class P15
{
    static void Main()
    {
        string input = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        string output = input.Replace(@"<a href=""", "[URL=");
        output = output.Replace(@""">", "]");
        output = output.Replace(@"</a>", "[/URL]");

        Console.WriteLine(output);
    }
}
