namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC260E47D1BCCA39, NameHash = 0xC03D7C3C7D972C1E)]
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x80 Message;
    }
}
