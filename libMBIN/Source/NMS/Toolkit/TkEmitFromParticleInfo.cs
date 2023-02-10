namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE137E9E7731980D3, NameHash = 0x56A47F95DD76DC72)]
    public class TkEmitFromParticleInfo : NMSTemplate
    {
        /* 0x0 */ public int OtherEmitterIndex;
        // size: 0x2
        public enum EmissionRateTypeEnum {
            PerParticle,
            Distance,
        }
        /* 0x4 */ public EmissionRateTypeEnum EmissionRateType;
    }
}
