using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC62A020A9D565D46, NameHash = 0x3E0D2E6A5C1DE7AD)]
    public class GcSentinelSpawnSequenceGroup : NMSTemplate
    {
        /* 0x00 */ public GcSentinelSpawnSequence ExtremeSequence;
        /* 0x10 */ public GcSentinelSpawnSequence Sequence;
    }
}
