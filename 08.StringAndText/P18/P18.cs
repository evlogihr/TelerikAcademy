using System;

class P18
{
    static void Main()
    {
        string input = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b. "; //Console.ReadLine();
        char[] punctuation = { ' ', ',', '.', '!', '?' };

        int indexAt = input.IndexOf("@", 0);
        while (indexAt != -1)
        {
            int start = input.LastIndexOf(' ', indexAt); //find start
            int indexDot = input.IndexOf(".", indexAt);
            int end = input.IndexOf(' ', indexDot + 1);

            string identifier, host, domain;

            identifier = input.Substring(start, indexAt - start).TrimStart();
            host = input.Substring(indexAt + 1, indexDot - 1 - indexAt);
            domain = input.Substring(indexDot + 1, end - indexDot).TrimEnd(punctuation);
            
            if (indexAt != -1 && indexDot != -1 && identifier.Length > 5 && host.Length > 0 && domain.Length > 1)
            {
                Console.WriteLine("{0}@{1}.{2}", identifier, host, domain);
            }

            indexAt = input.IndexOf("@", indexAt + 1);
        }
    }
}
