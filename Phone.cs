using System;

namespace Homework41
{
    abstract class Phone
    {
        public abstract void Call();
        public abstract void SendSms();
        public abstract void TurnOff();

        public void TurnOn()
        {
            Console.WriteLine("Happy to see you!");

        }
     
    }

    class Android : Phone
    {
        public override void Call()
        {
            Console.WriteLine("Call on Android");
        }

        public override void SendSms()
        {
            Console.WriteLine("sms from Android");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Good night! Your Android");
        }
    }

    class IPhone : Phone
    {
        public override void Call()
        {
            Console.WriteLine("Call on iPhone");
        }

        public override void SendSms()
        {
            Console.WriteLine("sms from iPhone");
        }

        public override void TurnOff()
        {
            Console.WriteLine("I don't want to sleep, your iPhone");
        }
    }

}