using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40F083738B45014, NameHash = 0xD1618D63DA15668C)]
    public class GcAudioAreaTriggerComponentData : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents EventEnter;
        /* 0x4 */ public GcAudioWwiseEvents EventExit;
        /* 0x8 */ public float EnterDistance;
        /* 0xC */ public float ExitDistance;
    }
}
