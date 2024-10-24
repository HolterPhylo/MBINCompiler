namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37BC2185F97E0294, NameHash = 0xA50EBF75)]
    public class GcSentinelTypes : NMSTemplate
    {
        // size: 0xB
        public enum SentinelTypeEnum : uint {
            PatrolDrone,
            CombatDrone,
            MedicDrone,
            SummonerDrone,
            CorruptedDrone,
            Quad,
            SpiderQuad,
            SpiderQuadMini,
            Mech,
            Walker,
            FriendlyDrone,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelTypeEnum SentinelType;
    }
}
