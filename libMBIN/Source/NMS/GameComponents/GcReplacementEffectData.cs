namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9DAD52BAE1B52A0, NameHash = 0x44BD38B)]
    public class GcReplacementEffectData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 ReplaceWith;
    }
}
