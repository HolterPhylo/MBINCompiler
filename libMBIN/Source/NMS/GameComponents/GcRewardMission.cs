namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29D4A8170C511221, NameHash = 0x3025318B)]
    public class GcRewardMission : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A AlreadyActiveFailureMessage;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Mission;
        [NMS(Index = 3)]
        /* 0x30 */ public bool FailRewardIfMissionActive;
        [NMS(Index = 2)]
        /* 0x31 */ public bool Restart;
        [NMS(Index = 1)]
        /* 0x32 */ public bool SetAsSelected;
    }
}
