namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FE7E2875D6EC834, NameHash = 0x976E7F19)]
    public class GcRewardMissionOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 ForceLocalMissionSelection;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Reward;
    }
}
