namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEC52895DF3E843E, NameHash = 0x5F94477E)]
    public class GcMessageRequestTakeOff : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Delay;
        [NMS(Index = 1)]
        /* 0x4 */ public bool ImmediatelyDissolveNPC;
    }
}
