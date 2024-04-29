using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E1D03F58EC72035, NameHash = 0xD08C5A93AECF92B1)]
    public class GcHUDImageData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 0)]
        /* 0x10 */ public GcHUDComponent Data;
        [NMS(Index = 1)]
        /* 0x38 */ public NMSString0x80 Image;
    }
}
