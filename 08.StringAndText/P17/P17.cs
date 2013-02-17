using System;
using System.Text;
using System.Globalization;

class P17
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Enter date and time: ");
        DateTime input = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        input = input.AddHours(6.5);

        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine("In 6 hours and 30 minutes will be \"{0}\" {1:d.MM.yyyy HH:mm:ss}", input.ToString("dddd"), input);
    }
}
