namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24ADD8EC8EA3B9D, NameHash = 0x2A4439CA)]
    public class GcTextStyleOutline : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour OutlineColour;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector2f OutlineOffset;
    }
}
