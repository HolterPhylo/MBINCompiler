using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x943CBCFC43BB12A4, NameHash = 0x9C2B5AEA)]
    public class GcCostGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Text;
        [NMS(Index = 4)]
        /* 0x20 */ public List<NMSTemplate> Costs;
        [NMS(Index = 2)]
        /* 0x30 */ public int HideOptionIfCantAffordIndex;
        [NMS(Index = 1)]
        /* 0x34 */ public int TakeTextFromIndex;
        [NMS(Index = 3)]
        /* 0x38 */ public GcMissionConditionTest Test;
    }
}
