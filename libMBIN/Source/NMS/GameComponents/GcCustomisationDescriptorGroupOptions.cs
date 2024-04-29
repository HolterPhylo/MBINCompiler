using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87BB36D55F7D0082, NameHash = 0x57CBFDF164E923E9)]
    public class GcCustomisationDescriptorGroupOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GroupTitle;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcCustomisationDescriptorGroupOption> DescriptorGroupOptions;
        [NMS(Index = 3)]
        /* 0x30 */ public List<NMSString0x10> PrerequisiteGroup;
        [NMS(Index = 1)]
        /* 0x40 */ public bool FirstOptionIsEmpty;
    }
}
