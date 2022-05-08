using System;
using System.IO;

namespace Homework4344
{
    enum StatusCode
    {
        OK = 200,
        Created = 201,
        Unauthorized = 401,
        Forbidden = 403,
        ServerError = 500
    }


    static class Program
    {

        public static int Status(this StatusCode s1)
        {
            switch (s1)
            {
                case StatusCode.OK:
                    return (int)StatusCode.OK;
                case StatusCode.Created:
                    return (int)StatusCode.Created;
                case StatusCode.Unauthorized:
                    return (int)StatusCode.Unauthorized;
                case StatusCode.Forbidden:
                    return (int)StatusCode.Forbidden;
                case StatusCode.ServerError:
                    return (int)StatusCode.ServerError;
                default:
                    return 0;
            }
        }

        public static string ReadText(string path)
        {
            string text = "";
            if (File.Exists(path))
            {
                text = File.ReadAllText(path);

            }
            else
            {

                text = "File was not found";
            }
            Console.WriteLine("Read test: " + text);
            return text;
        }

        public static void WriteText(string text)
        {
            string writeText = $"I will run test on {text}" + "\n";
           if (text == "File was not found")
            {
                Console.WriteLine("Output File was not created");
            }
            else if (!File.Exists("output.txt"))
            {
                File.WriteAllText("output.txt", writeText);
                Console.WriteLine("New Output File was created");

            }
            else
            {
                File.AppendAllText("output.txt", writeText);
                Console.WriteLine("Output File was updated");
            }
        }



        static void Main(string[] args)
        {

            StatusCode code1 = StatusCode.Forbidden;
            Console.WriteLine($"Status Code: {code1.Status()} {code1} ");

            string text = ReadText("input.txt");
            WriteText(text);

            Console.ReadLine();

        }
    }
}
