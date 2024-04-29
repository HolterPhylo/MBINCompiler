using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3AA69B9921BBF2F, NameHash = 0xE41D8EA9BE5AA4F8)]
    public class GcPetBehaviourTraitModifier : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public float CooldownModifierMax;
        [NMS(Index = 5)]
        /* 0x04 */ public float CooldownModifierMin;
        [NMS(Index = 0)]
        /* 0x08 */ public GcCreaturePetTraits Trait;
        [NMS(Index = 2)]
        /* 0x0C */ public float TraitMax;
        [NMS(Index = 1)]
        /* 0x10 */ public float TraitMin;
        [NMS(Index = 4)]
        /* 0x14 */ public float WeightModifierMax;
        [NMS(Index = 3)]
        /* 0x18 */ public float WeightModifierMin;
    }
}
