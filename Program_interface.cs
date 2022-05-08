using System;

namespace Homework42
{
    interface IPhone
    {
        void Call();
        void SendSms();
        void TurnOff();

    }


    class Android : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Call on Android");
        }

        public void SendSms()
        {
            Console.WriteLine("sms from Android");
        }

        public void TurnOff()
        {
            Console.WriteLine("Good night! Your Android");
        }
    }

    class Iphone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Call on iPhone");
        }

        public void SendSms()
        {
            Console.WriteLine("sms from iPhone");
        }

        public void TurnOff()
        {
            Console.WriteLine("I don't want to sleep, your iPhone");
        }
    }

    internal class Program2
    {

        static void Main(string[] args)
        {
            Android phone1 = new Android();
            phone1.Call();
            phone1.SendSms();
            phone1.TurnOff();

            Iphone phone2 = new Iphone();
            phone2.Call();
            phone2.SendSms();
            phone2.TurnOff();

            Console.ReadLine();

        }
    }
}
