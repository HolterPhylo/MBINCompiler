namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x474D5FA6C924B281, NameHash = 0xECA62875)]
    public class GcVehicleType : NMSTemplate
    {
        // size: 0x7
        public enum VehicleTypeEnum : uint {
            Buggy,
            Bike,
            Truck,
            WheeledBike,
            Hovercraft,
            Submarine,
            Mech,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public VehicleTypeEnum VehicleType;
    }
}
