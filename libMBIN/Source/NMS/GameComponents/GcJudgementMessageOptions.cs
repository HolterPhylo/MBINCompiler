namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8ED76BBC5E9E0941, NameHash = 0x2F83F7D4)]
    public class GcJudgementMessageOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x80 MessageInSettlement;
        [NMS(Index = 1)]
        /* 0x080 */ public NMSString0x80 MessageInSettlementSystem;
        [NMS(Index = 2)]
        /* 0x100 */ public NMSString0x80 MessageOutOfSettlementSystem;
    }
}
