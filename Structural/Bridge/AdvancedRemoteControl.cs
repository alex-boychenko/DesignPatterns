using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            //other stuff here
        }


        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }
    }
}
