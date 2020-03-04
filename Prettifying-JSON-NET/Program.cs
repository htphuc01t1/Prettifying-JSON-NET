using System;
namespace Prettifying_JSON_NET
{
    class Program
    {
        static void Main(string[] args)
        {            
            string jsonText = System.IO.File.ReadAllText("..\\..\\json_input.txt");
            string jsonPrettifyingText = JsonHelper.FormatJson(jsonText);
            System.IO.File.WriteAllText(@"..\\..\\json_output.txt", jsonPrettifyingText);

            Console.WriteLine("Prettifying JSON string was successfully");
            Console.WriteLine("Open and check prettifying JSON string on json_output.txt file");
            Console.ReadLine();
        }
    }
}
