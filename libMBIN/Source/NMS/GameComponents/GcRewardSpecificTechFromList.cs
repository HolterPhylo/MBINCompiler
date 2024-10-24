using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF2F9A32C413D00B, NameHash = 0x56DDED8F)]
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> TechList;
        // size: 0x3
        public enum TechListRewardOrderEnum : uint {
            OneRandom,
            InOrder,
            TryAllRandom,
        }
        [NMS(Index = 2)]
        /* 0x10 */ public TechListRewardOrderEnum TechListRewardOrder;
        [NMS(Index = 1)]
        /* 0x14 */ public bool FailIfAllKnown;
    }
}
