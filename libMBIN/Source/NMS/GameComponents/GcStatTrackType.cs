namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F6CF06B2016958, NameHash = 0xCCBEF4F753544A3F)]
    public class GcStatTrackType : NMSTemplate
    {
        // size: 0x4
        public enum StatTrackTypeEnum {
            Set,
            Add,
            Max,
            Min,
        }
        /* 0x0 */ public StatTrackTypeEnum StatTrackType;
    }
}
