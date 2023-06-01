using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E38E0DD7771276C, NameHash = 0x56A2461EC4620A47)]
    public class GcCostInteractionMissionState : NMSTemplate
    {
        /* 0x00 */ public GcInteractionMissionState RequiredState;
        /* 0x08 */ public NMSString0x20A CantAffordLocID;
        /* 0x28 */ public NMSString0x20A CanAffordLocID;
        /* 0x48 */ public bool AlsoAcceptMaintenanceDone;
        /* 0x49 */ public bool TestThisInteraction;
        /* 0x4C */ public GcInteractionType ThisInteractionClassInMyBuilding;
    }
}