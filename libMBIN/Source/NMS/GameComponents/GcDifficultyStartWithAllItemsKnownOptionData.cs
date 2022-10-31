using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA0393053C9A7301, NameHash = 0xBE7C831F4A1A69E6)]
    public class GcDifficultyStartWithAllItemsKnownOptionData : NMSTemplate
    {
        /* 0x000 */ public GcKnownThingsPreset InitialKnownThings;
        /* 0x060 */ public GcInventoryContainer InitialShipInventory;
        /* 0x1B8 */ public GcInventoryContainer InitialWeaponInventory;
    }
}