using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B0A9C15621B7CA5, NameHash = 0xDF74971999421442)]
    public class GcCustomisationDescriptorGroupSet : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool GroupsAreMutuallyExclusive;
        /* 0x18 */ public NMSString0x10 RequiresGroup;
        /* 0x28 */ public List<GcCustomisationDescriptorGroup> DescriptorGroups;
    }
}
