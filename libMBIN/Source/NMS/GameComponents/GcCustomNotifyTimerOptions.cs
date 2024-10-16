namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5FE30CE02B2FD5B, NameHash = 0xFF7F6CF0)]
    public class GcCustomNotifyTimerOptions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float NotifyDisplayTime;
        [NMS(Index = 2)]
        /* 0x4 */ public float NotifyPauseTime;
        [NMS(Index = 0)]
        /* 0x8 */ public bool HasCustomNotifyTimer;
    }
}
