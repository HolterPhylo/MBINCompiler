namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBAC537230555C840, NameHash = 0x56A51859)]
    public class TkCameraWanderData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float CamWanderAmplitude;
        [NMS(Index = 1)]
        /* 0x4 */ public float CamWanderPhase;
        [NMS(Index = 0)]
        /* 0x8 */ public bool CamWander;
    }
}
