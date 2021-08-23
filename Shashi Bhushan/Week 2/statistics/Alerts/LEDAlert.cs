using System;
using System.Collections.Generic;
using System.Text;

namespace AlertsLib
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows = false;
        public void Alert()
        {
                this.ledGlows = true;
        }
    }
}
