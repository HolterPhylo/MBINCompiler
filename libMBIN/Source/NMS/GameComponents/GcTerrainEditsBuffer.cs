using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8926B114AFFE4B52, NameHash = 0x68A2FEED)]
    public class GcTerrainEditsBuffer : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x100)]
        /* 0x00000 */ public Vector3f[] BufferAnchors;
        [NMS(Index = 0, Size = 0x100)]
        /* 0x01000 */ public ulong[] GalacticAddresses;
        [NMS(Index = 5, Size = 0x7530)]
        /* 0x01800 */ public GcTerrainEdit[] Edits;
        [NMS(Index = 1, Size = 0x100)]
        /* 0x3C180 */ public int[] BufferSizes;
        [NMS(Index = 2, Size = 0x100)]
        /* 0x3C580 */ public byte[] BufferAges;
        [NMS(Index = 4, Size = 0x100)]
        /* 0x3C680 */ public bool[] BufferProtected;
    }
}
