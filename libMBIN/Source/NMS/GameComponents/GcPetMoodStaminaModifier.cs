using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA52BBC83F42B06F3, NameHash = 0x1164F47B)]
    public class GcPetMoodStaminaModifier : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcCreaturePetMood Mood;
        [NMS(Index = 2)]
        /* 0x04 */ public float MoodMax;
        [NMS(Index = 1)]
        /* 0x08 */ public float MoodMin;
        [NMS(Index = 4)]
        /* 0x0C */ public float StaminaDrainModifierMax;
        [NMS(Index = 3)]
        /* 0x10 */ public float StaminaDrainModifierMin;
        [NMS(Index = 6)]
        /* 0x14 */ public float StaminaRechargeModifierMax;
        [NMS(Index = 5)]
        /* 0x18 */ public float StaminaRechargeModifierMin;
    }
}
