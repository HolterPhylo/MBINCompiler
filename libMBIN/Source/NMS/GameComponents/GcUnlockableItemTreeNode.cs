using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DB47AF9459842C4, NameHash = 0xB6094F57F9EFA01D)]
    public class GcUnlockableItemTreeNode : NMSTemplate
    {
        /* 0x00 */ public List<GcUnlockableItemTreeNode> Children;
        /* 0x10 */ public NMSString0x10 Unlockable;
    }
}
