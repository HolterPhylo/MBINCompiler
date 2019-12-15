﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x300, Alignment = 0x8, GUID = 0x1A3E40CBF889AF2F, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool ForceOverridesAll;
        /* 0x047 */ public bool IsCommunityPortalOverride;
        /* 0x048 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x04C */ public float BuildingPreventionRadius;
        /* 0x050 */ public bool AlwaysShow;
        /* 0x051 */ public bool NeverShow;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x052 */ public byte[] Padding52;
        [NMS(Size = 0x20)]
        /* 0x058 */ public string PlanetLabelText;

        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
		/* 0x078 */ public EventStartTypeEnum EventStartType;
		public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
		/* 0x07C */ public EventEndTypeEnum EventEndType;
		public enum EventPriorityEnum { Regular, High }
		/* 0x080 */ public EventPriorityEnum EventPriority;

        /* 0x084 */ public bool CanEndFromOutsideMission;
        /* 0x085 */ public bool DisableMultiplayerSync;
        /* 0x086 */ public bool ReplaceEventIfAlreadyActive;

        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet, PlanetSearch }
		/* 0x088 */ public BuildingLocationEnum BuildingLocation;
		public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas, Freighter, FreighterBase,
            ExternalPlanetBase, PlanetBaseTerminal, Expedition, TutorialShelter, MPMissionFreighter, Nexus, InitialDistressSignal }
		/* 0x08C */ public BuildingTypeEnum BuildingType;
        /* 0x090 */ public GcBuildingClassification BuildingClass;
        /* 0x094 */ public bool AllowFriendBases;

		public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList }
		/* 0x098 */ public SolarSystemLocationEnum SolarSystemLocation;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x09C */ public byte[] Padding9C;

        /* 0x0A0 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x108 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x170 */ public bool ForceRestartInteraction;
        [NMS(Size = 7, Ignore = true)]
        /* 0x171 */ public byte[] Padding171;
        [NMS(Size = 0x10)]
        /* 0x178 */ public string HasReward;
        [NMS(Size = 0x20)]
        /* 0x188 */ public string NextOption;
        /* 0x1A8 */ public GcScanEventTriggers TriggerActions;
        /* 0x1C8 */ public List<NMSString0x100> UAsList;
        /* 0x1D8 */ public GcTechnologyCategory TechShopType;
        [NMS(Size = 0x20)]
        /* 0x1DC */ public string OSDMessage;
        [NMS(Size = 0x20)]
        /* 0x1FC */ public string InterstellarOSDMessage;
        [NMS(Size = 0x20)]
        /* 0x21C */ public string MarkerLabel;
        /* 0x23C */ public TkTextureResource MarkerIcon;
        /* 0x2C0 */ public float StartTime;
        /* 0x2C4 */ public float MessageTime;
        /* 0x2C8 */ public float MessageDisplayTime;
        /* 0x2CC */ public GcAudioWwiseEvents MessageAudio;
        /* 0x2D0 */ public float IconTime;
        /* 0x2D4 */ public float TooltipTime;
        /* 0x2D8 */ public bool TooltipRepeats;
        /* 0x2D9 */ public bool ShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x2DA */ public string TooltipMessage;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x2EA */ public byte[] EndPadding;
    }
}