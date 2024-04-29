namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD4B0C2941D1655B, NameHash = 0x720D90D0F7901AA2)]
    public class GcMissionSequenceWaitForWarps : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x80 Message;
    }
}
