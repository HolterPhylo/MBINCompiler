﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x120, GUID = 0xE30462A35350D69)]
    public class TkNGuiTextStyle : NMSTemplate
    {
        public TkNGuiTextStyleData Default;
        public TkNGuiTextStyleData Highlight;
        public TkNGuiTextStyleData Active;
    }
}
