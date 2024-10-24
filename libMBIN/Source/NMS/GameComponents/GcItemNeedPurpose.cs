namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD494B90ACEB9A99C, NameHash = 0xDFD0F2AF)]
    public class GcItemNeedPurpose : NMSTemplate
    {
        // size: 0x6
        public enum ItemPurposeEnum : uint {
            None,
            Crafting,
            Building,
            Repairing,
            Charging,
            Paying,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ItemPurposeEnum ItemPurpose;
    }
}
