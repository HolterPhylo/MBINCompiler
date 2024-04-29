using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF374E6D81C80365, NameHash = 0x252EDF07EC993BBF)]
    public class GcYearlyRecurrence : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int RecurrenceDay;
        [NMS(Index = 1)]
        /* 0x04 */ public int RecurrenceHour;
        [NMS(Index = 0)]
        /* 0x08 */ public int RecurrenceMinute;
        [NMS(Index = 3)]
        /* 0x0C */ public GcMonth RecurrenceMonth;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x80 DebugText;
    }
}
