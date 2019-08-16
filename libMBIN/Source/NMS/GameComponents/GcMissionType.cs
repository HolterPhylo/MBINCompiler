﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5A425D525464C797, SubGUID = 0x881C97F393A2FB50)]
    public class GcMissionType : NMSTemplate
    {
        // 0xB entries
		public enum MissionTypeEnum { SpaceCombat, GroundCombat, Research, MissingPerson, Repair, Cargo, Piracy, Photo, Feeding, Planting, Construction }
		public MissionTypeEnum MissionType;
    }
}
