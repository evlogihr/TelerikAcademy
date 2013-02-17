using System;

class P05
{
    static void Main()
    {
        DateTime[] holidays = new DateTime[] //oficial BG holidays for 2013
        {
            new DateTime(2013, 1, 1),
            new DateTime(2013, 3, 3),
            new DateTime(2013, 5, 1),
            new DateTime(2013, 5, 2),
            new DateTime(2013, 5, 3),
            new DateTime(2013, 5, 4),
            new DateTime(2013, 5, 5),
            new DateTime(2013, 5, 6),
            new DateTime(2013, 5, 24),
            new DateTime(2013, 10, 6),
            new DateTime(2013, 10, 22),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31),
            new DateTime(2014, 1, 1),
        };

        string format = string.Format("d.M.yyyy"); 
        Console.Write("enter end date in format {0}: ", format);
        DateTime end = DateTime.ParseExact(Console.ReadLine(), format, System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat);

        int count = 0;
        for (DateTime start = DateTime.Today; start <= end; start = start.AddDays(1))
        {
            if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
            {
                bool ifHoliday = false;
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (holidays[i] == start)
                    {
                        ifHoliday = true;
                    }
                }
                if (!ifHoliday)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("workdays form {0} to {1} are {2} days", DateTime.Today.ToString(format), end.ToString(format), count);
    }
}
