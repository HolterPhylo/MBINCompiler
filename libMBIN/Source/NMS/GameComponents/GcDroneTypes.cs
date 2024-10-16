namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x889DD9771C5E2DD0, NameHash = 0x9748B93C)]
    public class GcDroneTypes : NMSTemplate
    {
        // size: 0x3
        public enum DroneTypeEnum : uint {
            Patrol,
            Combat,
            Corrupted,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DroneTypeEnum DroneType;
    }
}
