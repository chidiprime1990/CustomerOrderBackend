using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CustomerOrder.Core.Utility
{
    public class Enums
    {
        public enum Gender
        {
            [Description("Male")]
            MALE=1,
            [Description("Female")]
            Female=2
        }
    }
}
