﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x1DFBCEEAFDE9D7C6, Alignment = 0x8, NameHash = 0x269AA19701CADAB8)]
    public class GcActionTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate Trigger;
        /* 0x50 */ public List<NMSTemplate> Action;
    }
}
