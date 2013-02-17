using System;
using System.IO;
using System.Text.RegularExpressions;

class P12
{
    static void Main()
    {
        try
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            {
                using (StreamWriter output = new StreamWriter("../../output.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        string expression = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";
                        output.WriteLine(Regex.Replace(line, expression, ""));
                    }
                }
            }
        }
        catch (FileLoadException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (ObjectDisposedException ode)
        {
            Console.WriteLine(ode.Message);
        }
        catch (OutOfMemoryException oome)
        {
            Console.WriteLine(oome.Message);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (RegexMatchTimeoutException rmte)
        {
            Console.WriteLine(rmte.Message);
        }
    }
}
