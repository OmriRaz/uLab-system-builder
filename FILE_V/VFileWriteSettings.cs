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
        public const string WRITES_SWITCH = @"  input           [3:0]           SW,";
        public const string WRITES_BUTTON = @"  input           [1:0]           BUTTON,";
        public const string WRITES_SEVENSEG = 
@"    output          [6:0]           HEX0,
      output          [6:0]           HEX1,
      output          [6:0]           HEX2,";

        public const string WRITES_LED = @"  output          [7:0]           LED,";
    }
}
