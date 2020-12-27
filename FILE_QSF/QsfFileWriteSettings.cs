using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLab_system_builder
{
    public class QsfFileWriteSettings
    {
        public const string WRITES_GENERAL_PROJECT_NAME = "set_global_assignment -name TOP_LEVEL_ENTITY ";
        public const string WRITES_GENERAL_DATETIME = "set_global_assignment -name PROJECT_CREATION_TIME_DATE "; // "17:22:40  DECEMBER 21, 2020"
        public const string WRITES_GENERAL = @"set_global_assignment -name FAMILY ""MAX 10""
set_global_assignment -name DEVICE 10M08SCU169C8G
set_global_assignment -name ORIGINAL_QUARTUS_VERSION 20.1.0
set_global_assignment -name LAST_QUARTUS_VERSION ""20.1.0 Lite Edition""
set_global_assignment -name PROJECT_OUTPUT_DIRECTORY output_files
set_global_assignment -name MIN_CORE_JUNCTION_TEMP 0
set_global_assignment -name MAX_CORE_JUNCTION_TEMP 85
set_global_assignment -name DEVICE_FILTER_PACKAGE UFBGA
set_global_assignment -name DEVICE_FILTER_PIN_COUNT 169
set_global_assignment -name DEVICE_FILTER_SPEED_GRADE 8
set_global_assignment -name ERROR_CHECK_FREQUENCY_DIVISOR 256
set_global_assignment -name VERILOG_FILE top.v
set_global_assignment -name PARTITION_NETLIST_TYPE SOURCE -section_id Top
set_global_assignment -name PARTITION_FITTER_PRESERVATION_LEVEL PLACEMENT_AND_ROUTING -section_id Top
set_global_assignment -name PARTITION_COLOR 16764057 -section_id Top
";

        public const string WRITES_CLOCK =
@"#======================
#CLOCK
#======================
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to CLK_50
set_location_assignment PIN_H6 -to MAX10_CLK1_50

";

        public const string WRITES_SEG7 =
@"#============================================================
# SEG7
#============================================================

#IO Voltage definitions

set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[0]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[1]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[2]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[3]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[4]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[5]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[6]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX0[7]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[0]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[1]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[2]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[3]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[4]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[5]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[6]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX1[7]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[0]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[1]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[2]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[3]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[4]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[5]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[6]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to HEX2[7]

#IO Pin Assignments

set_location_assignment PIN_J12 -to HEX0[0]
set_location_assignment PIN_J13 -to HEX0[1]
set_location_assignment PIN_K13 -to HEX0[2]
set_location_assignment PIN_K12 -to HEX0[3]
set_location_assignment PIN_L13 -to HEX0[4]
set_location_assignment PIN_M13 -to HEX0[5]
set_location_assignment PIN_L12 -to HEX0[6]

set_location_assignment PIN_L11 -to HEX1[0]
set_location_assignment PIN_M10 -to HEX1[1]
set_location_assignment PIN_M9 -to HEX1[2]
set_location_assignment PIN_L10 -to HEX1[3]
set_location_assignment PIN_K10 -to HEX1[4]
set_location_assignment PIN_H13 -to HEX1[5]
set_location_assignment PIN_K11 -to HEX1[6]

set_location_assignment PIN_F9 -to HEX2[0]
set_location_assignment PIN_F10 -to HEX2[1]
set_location_assignment PIN_F12 -to HEX2[2]
set_location_assignment PIN_F13 -to HEX2[3]
set_location_assignment PIN_M11 -to HEX2[4]
set_location_assignment PIN_M12 -to HEX2[5]
set_location_assignment PIN_N12 -to HEX2[6]

";
        public const string WRITES_BUTTON =
@"#======================
#BUTTON
#======================
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to BUTTON[0]
set_location_assignment PIN_B9 -to BUTTON[0]
";
        public const string WRITES_LED =
@"#============================================================
# LED
#============================================================
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[0]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[1]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[2]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[3]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[4]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[5]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[6]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to LED[7]


set_location_assignment PIN_N4 -to LED[0]
set_location_assignment PIN_M5 -to LED[1]
set_location_assignment PIN_N5 -to LED[2]
set_location_assignment PIN_N6 -to LED[3]
set_location_assignment PIN_N7 -to LED[4]
set_location_assignment PIN_M7 -to LED[5]
set_location_assignment PIN_N8 -to LED[6]
set_location_assignment PIN_M8 -to LED[7]


";
        public const string WRITES_SWITCHES =
@"#============================================================
# SW
#============================================================
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to SW[0]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to SW[1]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to SW[2]
set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to SW[3]

set_location_assignment PIN_M2 -to SW[0]
set_location_assignment PIN_N2 -to SW[1]
set_location_assignment PIN_N3 -to SW[2]
set_location_assignment PIN_M4 -to SW[3]

";

        public const string WRITES_GPIO =
@"#============================================================
# GPIO, GPIO connect to GPIO Default
#============================================================
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[0]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[1]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[2]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[3]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[4]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[5]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[6]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[7]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[8]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[9]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[10]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[11]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[12]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[13]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[14]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[15]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[16]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[17]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[18]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[19]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[20]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[21]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[22]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[23]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[24]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[25]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[26]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[27]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[28]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[29]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[30]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[31]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[32]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[33]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[34]
#set_instance_assignment -name IO_STANDARD ""3.3-V LVTTL"" -to GPIO[35]
#set_location_assignment PIN_V10 -to GPIO[0]
#set_location_assignment PIN_W10 -to GPIO[1]
#set_location_assignment PIN_V9 -to GPIO[2]
#set_location_assignment PIN_W9 -to GPIO[3]
#set_location_assignment PIN_V8 -to GPIO[4]
#set_location_assignment PIN_W8 -to GPIO[5]
#set_location_assignment PIN_V7 -to GPIO[6]
#set_location_assignment PIN_W7 -to GPIO[7]
#set_location_assignment PIN_W6 -to GPIO[8]
#set_location_assignment PIN_V5 -to GPIO[9]
#set_location_assignment PIN_W5 -to GPIO[10]
#set_location_assignment PIN_AA15 -to GPIO[11]
#set_location_assignment PIN_AA14 -to GPIO[12]
#set_location_assignment PIN_W13 -to GPIO[13]
#set_location_assignment PIN_W12 -to GPIO[14]
#set_location_assignment PIN_AB13 -to GPIO[15]
#set_location_assignment PIN_AB12 -to GPIO[16]
#set_location_assignment PIN_Y11 -to GPIO[17]
#set_location_assignment PIN_AB11 -to GPIO[18]
#set_location_assignment PIN_W11 -to GPIO[19]
#set_location_assignment PIN_AB10 -to GPIO[20]
#set_location_assignment PIN_AA10 -to GPIO[21]
#set_location_assignment PIN_AA9 -to GPIO[22]
#set_location_assignment PIN_Y8 -to GPIO[23]
#set_location_assignment PIN_AA8 -to GPIO[24]
#set_location_assignment PIN_Y7 -to GPIO[25]
#set_location_assignment PIN_AA7 -to GPIO[26]
#set_location_assignment PIN_Y6 -to GPIO[27]
#set_location_assignment PIN_AA6 -to GPIO[28]
#set_location_assignment PIN_Y5 -to GPIO[29]
#set_location_assignment PIN_AA5 -to GPIO[30]
#set_location_assignment PIN_Y4 -to GPIO[31]
#set_location_assignment PIN_AB3 -to GPIO[32]
#set_location_assignment PIN_Y3 -to GPIO[33]
#set_location_assignment PIN_AB2 -to GPIO[34]
#set_location_assignment PIN_AA2 -to GPIO[35]

";
    }
}
