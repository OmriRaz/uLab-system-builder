using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLab_system_builder
{
    public class VFileWriteSettings
    {
        public const string WRITES_MODULE = "module ";
        public const string WRITES_CLOCK = "\tinput\t\t\t\t\tCLK_50";
        public const string WRITES_SWITCH = "\tinput\t\t[3:0]\t\tSW";
        public const string WRITES_BUTTON = "\tinput\t\t[1:0]\t\tBUTTON";
        public const string WRITES_SEVENSEG = "\toutput\t\t[6:0]\t\tHEX0,\n"
    + "\toutput\t\t[6:0]\t\tHEX1,\n"
    + "\toutput\t\t[6:0]\t\tHEX2";
        public const string WRITES_SEVENSEG_NO_COMMAS = "\toutput\t\t[6:0]\t\tHEX0,\n"
    + "\toutput\t\t[6:0]\t\tHEX1,\n"
    + "\toutput\t\t[6:0]\t\tHEX2";

        public const string WRITES_LED = "\toutput\t\t[7:0]\t\tLED";
        public const string WRITES_GPIO = "\t//inout\t\t[35:0]\t\tGPIO";
        public const string WRITES_END_LINE = @"

);
endmodule";
    }
}
