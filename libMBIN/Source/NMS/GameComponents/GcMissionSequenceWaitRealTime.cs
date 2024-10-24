namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74E83885235838C0, NameHash = 0x21D74CB6)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 DisplayStat;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x30 */ public ulong Time;
        [NMS(Index = 2)]
        /* 0x38 */ public float Randomness;
        [NMS(Index = 5)]
        /* 0x3C */ public bool StatFromNow;
        [NMS(Index = 4)]
        /* 0x3D */ public bool TakeDisplayStatTargetFromSeasonData;
    }
}
