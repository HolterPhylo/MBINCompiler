namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B2F34AC849F0C90, NameHash = 0xD6FECE29)]
    public class GcHUDComponent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        // size: 0x5
        public enum AlignEnum : uint {
            Center,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight,
        }
        [NMS(Index = 5)]
        /* 0x10 */ public AlignEnum Align;
        [NMS(Index = 4)]
        /* 0x14 */ public int Height;
        [NMS(Index = 1)]
        /* 0x18 */ public int PosX;
        [NMS(Index = 2)]
        /* 0x1C */ public int PosY;
        [NMS(Index = 3)]
        /* 0x20 */ public int Width;
    }
}
