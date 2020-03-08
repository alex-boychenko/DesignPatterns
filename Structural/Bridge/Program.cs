using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl(new SonyTV());
            remoteControl.TurnOn();
            remoteControl.TurnOff();

            var advancedRemoteControl = new AdvancedRemoteControl(new SamsungTV());
            advancedRemoteControl.TurnOn();
            advancedRemoteControl.TurnOff();
            advancedRemoteControl.SetChannel(1);

            Console.ReadKey();
        }
    }
}
