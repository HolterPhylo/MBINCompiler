using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AE19368948E649F, NameHash = 0xE99625D7)]
    public class GcStormProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcWeatherColourModifiers ColourModifiers;
        [NMS(Index = 1)]
        /* 0x2A0 */ public GcFogProperties Fog;
        [NMS(Index = 3, Size = 0x6, EnumType = typeof(GcHazardModifiers.HazardModifierEnum))]
        /* 0x470 */ public Vector2f[] HazardModifiers;
        [NMS(Index = 0)]
        /* 0x4A0 */ public float Weighting;
    }
}
