namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C76550BC2D8BBE4, NameHash = 0x712C5B47)]
    public class GcCreatureGenerationDensity : NMSTemplate
    {
        // size: 0x4
        public enum DensityEnum : uint {
            Sparse,
            Normal,
            Dense,
            VeryDense,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DensityEnum Density;
    }
}
