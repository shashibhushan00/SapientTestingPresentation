using System;
using System.Collections.Generic;
using System.Text;

namespace AlertsLib
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent = false;
        public void Alert()
        {
                this.emailSent = true; 
        }
    }
}
