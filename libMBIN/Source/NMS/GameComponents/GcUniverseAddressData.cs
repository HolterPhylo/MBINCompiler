using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B776334BDA3BFE8, NameHash = 0x49FD8C968D7B338D)]
    public class GcUniverseAddressData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcGalacticAddressData GalacticAddress;
        [NMS(Index = 0)]
        /* 0x14 */ public int RealityIndex;
    }
}
