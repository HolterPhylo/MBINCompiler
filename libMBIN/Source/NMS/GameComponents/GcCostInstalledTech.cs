namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3249B6EDEA2DB6E4, NameHash = 0x6016931)]
    public class GcCostInstalledTech : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x6
        public enum InventoryToCheckEnum : uint {
            All,
            Suit,
            Ship,
            Weapon,
            Freighter,
            Buggy,
        }
        [NMS(Index = 3)]
        /* 0x10 */ public InventoryToCheckEnum InventoryToCheck;
        [NMS(Index = 1)]
        /* 0x14 */ public float MinChargePercent;
        [NMS(Index = 2)]
        /* 0x18 */ public bool BurnCharge;
    }
}
