using System;

namespace Homework41
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Android phone1 = new Android();
            phone1.TurnOn();
            phone1.Call();
            phone1.SendSms();
            phone1.TurnOff();

            IPhone phone2 = new IPhone();
            phone2.TurnOn();
            phone2.Call();
            phone2.SendSms();
            phone2.TurnOff();

            Console.ReadLine();

        }
    }
}
