using System;
using System.IO;

class P03
{
    static void Main()
    {
        try
        {
            string path = @"C:\Users\EvlogiHr\Desktop\Telerik\02.CSharp2\Homework\06.ExceptionHandling\P03\text.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}