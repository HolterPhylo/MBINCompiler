namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AB148BE845ED462, NameHash = 0xE3A3166D)]
    public class GcBaseBuildingEntryGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 SubGroupName;
        [NMS(Index = 2)]
        /* 0x20 */ public int SubGroup;
    }
}
