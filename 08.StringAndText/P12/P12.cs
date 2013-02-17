using System;

class P12
{
    static void Main()
    {
        string input = "http://www.devbg.org/forum/index.php "; //Console.ReadLine();

        string protocol, server, resource;
        int start = 0, end = 0;

        end = input.IndexOf(':');
        protocol = input.Substring(start, end);

        start = input.IndexOf('/', input.IndexOf('/') + 1) + 1;
        end = input.IndexOf('/', start);
        server = input.Substring(start, end - start);

        resource = input.Substring(end);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}
