using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42322DE55DF9A6AA, NameHash = 0x8A37C4A2)]
    public class GcRewardSpecificShip : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 1)]
        /* 0x158 */ public GcCharacterCustomisationData Customisation;
        [NMS(Index = 0)]
        /* 0x1B0 */ public GcResourceElement ShipResource;
        [NMS(Index = 9)]
        /* 0x1F8 */ public NMSString0x20A NameOverride;
        [NMS(Index = 2)]
        /* 0x218 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 4)]
        /* 0x230 */ public int CostAmount;
        [NMS(Index = 5)]
        /* 0x234 */ public GcCurrency CostCurrency;
        [NMS(Index = 13)]
        /* 0x238 */ public GcModelViews ModelViewOverride;
        [NMS(Index = 8)]
        /* 0x23C */ public GcInventoryLayoutSizeType OverrideSizeType;
        [NMS(Index = 6)]
        /* 0x240 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 12)]
        /* 0x244 */ public bool FormatAsSeasonal;
        [NMS(Index = 10)]
        /* 0x245 */ public bool IsGift;
        [NMS(Index = 11)]
        /* 0x246 */ public bool IsRewardShip;
        [NMS(Index = 7)]
        /* 0x247 */ public bool UseOverrideSizeType;
    }
}
