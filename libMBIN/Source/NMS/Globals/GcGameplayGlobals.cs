using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xD4B1834543F15204, NameHash = 0x2524086B)]
    public class GcGameplayGlobals : NMSTemplate
    {
        [NMS(Index = 485)]
        /* 0x0000 */ public GcShipHUDTargetData HUDTarget;
        [NMS(Index = 429)]
        /* 0x0110 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        [NMS(Index = 437)]
        /* 0x0160 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        [NMS(Index = 438)]
        /* 0x01B0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        [NMS(Index = 434)]
        /* 0x0200 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        [NMS(Index = 435)]
        /* 0x0250 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        [NMS(Index = 433)]
        /* 0x02A0 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        [NMS(Index = 436)]
        /* 0x02F0 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        [NMS(Index = 430)]
        /* 0x0340 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        [NMS(Index = 427)]
        /* 0x0390 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        [NMS(Index = 440)]
        /* 0x03E0 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        [NMS(Index = 439)]
        /* 0x0430 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        [NMS(Index = 428)]
        /* 0x0480 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        [NMS(Index = 431)]
        /* 0x04D0 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        [NMS(Index = 426)]
        /* 0x0520 */ public GcScanEffectData BaseBuildingValidScanEffect;
        [NMS(Index = 432)]
        /* 0x0570 */ public GcScanEffectData BaseBuildingVisionScanEffect;
        [NMS(Index = 228)]
        /* 0x05C0 */ public GcScanEffectData BinocularScanEffect;
        [NMS(Index = 117)]
        /* 0x0610 */ public GcScanEffectData BinocularSelectedEffect;
        [NMS(Index = 425)]
        /* 0x0660 */ public GcScanEffectData BlankScanEffect;
        [NMS(Index = 419)]
        /* 0x06B0 */ public GcScanEffectData BuildingScanEffect;
        [NMS(Index = 422)]
        /* 0x0700 */ public GcScanEffectData CreatureScanEffect;
        [NMS(Index = 242)]
        /* 0x0750 */ public GcScanEffectData DeconstructEffect;
        [NMS(Index = 243)]
        /* 0x07A0 */ public GcScanEffectData HitEffect;
        [NMS(Index = 244)]
        /* 0x07F0 */ public GcScanEffectData HitEffectCritical;
        [NMS(Index = 421)]
        /* 0x0840 */ public GcScanEffectData HUDShipScanEffect;
        [NMS(Index = 423)]
        /* 0x0890 */ public GcScanEffectData ObjectsScanEffect;
        [NMS(Index = 418)]
        /* 0x08E0 */ public GcScanEffectData PassiveScanEffect;
        [NMS(Index = 622)]
        /* 0x0930 */ public GcScanEffectData ShipBuilderNullScanEffect;
        [NMS(Index = 621)]
        /* 0x0980 */ public GcScanEffectData ShipBuilderScanEffect;
        [NMS(Index = 620)]
        /* 0x09D0 */ public GcScanEffectData ShipSalvageScanEffect;
        [NMS(Index = 420)]
        /* 0x0A20 */ public GcScanEffectData TargetShipScanEffect;
        [NMS(Index = 424)]
        /* 0x0A70 */ public GcScanEffectData VRGhostScanEffect;
        [NMS(Index = 227)]
        /* 0x0AC0 */ public Colour BinocularScanTargetColour;
        [NMS(Index = 118)]
        /* 0x0AD0 */ public Colour BinocularSelectedColour;
        [NMS(Index = 119)]
        /* 0x0AE0 */ public Colour BinocularSelectedUnknownColour;
        [NMS(Index = 91)]
        /* 0x0AF0 */ public Colour BulletTraceLineColour;
        [NMS(Index = 247)]
        /* 0x0B00 */ public Vector3f CommunicatorShipSpawnOffset;
        [NMS(Index = 481)]
        /* 0x0B10 */ public Colour HUDDamageSplatPainColour;
        [NMS(Index = 480)]
        /* 0x0B20 */ public Colour HUDDamageSplatShieldColour;
        [NMS(Index = 175)]
        /* 0x0B30 */ public Colour OverHeatBarColour;
        [NMS(Index = 174)]
        /* 0x0B40 */ public Colour OverHeatColour;
        [NMS(Index = 518)]
        /* 0x0B50 */ public Colour PainColour;
        [NMS(Index = 566)]
        /* 0x0B60 */ public Colour PlayerAmbientSpotLightColour;
        [NMS(Index = 200)]
        /* 0x0B70 */ public Colour RefinerColour1A;
        [NMS(Index = 201)]
        /* 0x0B80 */ public Colour RefinerColour1B;
        [NMS(Index = 202)]
        /* 0x0B90 */ public Colour RefinerColour1C;
        [NMS(Index = 203)]
        /* 0x0BA0 */ public Colour RefinerColour1D;
        [NMS(Index = 464)]
        /* 0x0BB0 */ public Colour ScannerColour1;
        [NMS(Index = 465)]
        /* 0x0BC0 */ public Colour ScannerColour2;
        [NMS(Index = 564)]
        /* 0x0BD0 */ public Colour TorchColour;
        [NMS(Index = 0)]
        /* 0x0BE0 */ public GcDiscoveryTrimSettings DiscoveryTrimSettings;
        [NMS(Index = 1)]
        /* 0x0D08 */ public GcScanToRevealComponentData CaveGraveRevealData;
        [NMS(Index = 105, Size = 0x5)]
        /* 0x0D58 */ public NMSString0x10[] SalvageTechList;
        [NMS(Index = 106, Size = 0x5)]
        /* 0x0DA8 */ public NMSString0x10[] SalvageTechListMultiTool;
        [NMS(Index = 102, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0DF8 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Index = 103, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0E38 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Index = 104, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0E78 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Index = 101, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0EB8 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Index = 635)]
        /* 0x0EF8 */ public NMSString0x20A CommunicatorFireteamNexusExitDialog;
        [NMS(Index = 636)]
        /* 0x0F18 */ public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog;
        [NMS(Index = 650)]
        /* 0x0F38 */ public TkModelResource WeaponSpawnAltObject;
        [NMS(Index = 649)]
        /* 0x0F50 */ public TkModelResource WeaponSpawnObject;
        [NMS(Index = 593)]
        /* 0x0F68 */ public VariableSizeString BaseBuildingTable;
        [NMS(Index = 404)]
        /* 0x0F78 */ public NMSString0x10 BeaconScan;
        [NMS(Index = 393)]
        /* 0x0F88 */ public NMSString0x10 BioShipTerrainResource;
        [NMS(Index = 29)]
        /* 0x0F98 */ public NMSString0x10 BuildersWordReward;
        [NMS(Index = 259)]
        /* 0x0FA8 */ public List<GcScanEffectData> CommunicatorEffectTable;
        [NMS(Index = 408)]
        /* 0x0FB8 */ public NMSString0x10 DebugScanPlanet;
        [NMS(Index = 409)]
        /* 0x0FC8 */ public NMSString0x10 DebugScanSpace;
        [NMS(Index = 531)]
        /* 0x0FD8 */ public NMSString0x10 DefaultAnim;
        [NMS(Index = 407)]
        /* 0x0FE8 */ public NMSString0x10 DistressSignalScan;
        [NMS(Index = 70)]
        /* 0x0FF8 */ public NMSString0x10 FreeShipSlotID;
        [NMS(Index = 69)]
        /* 0x1008 */ public NMSString0x10 FreeSuitSlotID;
        [NMS(Index = 71)]
        /* 0x1018 */ public NMSString0x10 FreeWeapSlotID;
        [NMS(Index = 183)]
        /* 0x1028 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        [NMS(Index = 182)]
        /* 0x1038 */ public List<NMSString0x10> HyperdriveAccess;
        [NMS(Index = 580)]
        /* 0x1048 */ public VariableSizeString InitialDebrisScene;
        [NMS(Index = 592)]
        /* 0x1058 */ public VariableSizeString LegacyBaseBuildingTable;
        [NMS(Index = 129)]
        /* 0x1068 */ public NMSString0x10 MissionSurveyBugsID;
        [NMS(Index = 128)]
        /* 0x1078 */ public NMSString0x10 MissionSurveyWormID;
        [NMS(Index = 65)]
        /* 0x1088 */ public NMSString0x10 NexusRecipeCostType;
        [NMS(Index = 406)]
        /* 0x1098 */ public NMSString0x10 ObservatoryScan;
        [NMS(Index = 361)]
        /* 0x10A8 */ public List<float> PirateEarlySpawnChances;
        [NMS(Index = 27)]
        /* 0x10B8 */ public NMSString0x10 PirateMissionPrimaryReward;
        [NMS(Index = 28)]
        /* 0x10C8 */ public NMSString0x10 PirateMissionSecondReward;
        [NMS(Index = 405)]
        /* 0x10D8 */ public NMSString0x10 RadioTowerScan;
        [NMS(Index = 391)]
        /* 0x10E8 */ public NMSString0x10 ResourceDirtSubstanceID;
        [NMS(Index = 495)]
        /* 0x10F8 */ public VariableSizeString ResourceParticleFile;
        [NMS(Index = 107)]
        /* 0x1108 */ public List<NMSString0x10> SalvageProdsList;
        [NMS(Index = 108)]
        /* 0x1118 */ public List<NMSString0x10> SalvageSubstancesList;
        [NMS(Index = 392)]
        /* 0x1128 */ public NMSString0x10 SandwormTerrainResource;
        [NMS(Index = 410)]
        /* 0x1138 */ public NMSString0x10 ShipScan;
        [NMS(Index = 401)]
        /* 0x1148 */ public NMSString0x10 ToolScan;
        [NMS(Index = 402)]
        /* 0x1158 */ public NMSString0x10 ToolScanHardMode;
        [NMS(Index = 411)]
        /* 0x1168 */ public NMSString0x10 VisualScan;
        [NMS(Index = 403)]
        /* 0x1178 */ public NMSString0x10 WaypointScan;
        [NMS(Index = 417)]
        /* 0x1188 */ public List<GcZoomData> ZoomLevels;
        [NMS(Index = 595)]
        /* 0x1198 */ public ulong NPCWorkerInteractionCooldown;
        [NMS(Index = 399)]
        /* 0x11A0 */ public GcResourceCollectEffect AsteroidResourceCollect;
        [NMS(Index = 363)]
        /* 0x11D4 */ public GcExperienceTimers FlybyTimers;
        [NMS(Index = 358)]
        /* 0x11F4 */ public GcExperienceTimers FreighterTimers;
        [NMS(Index = 359)]
        /* 0x1214 */ public GcExperienceTimers PlanetPirateTimers;
        [NMS(Index = 365)]
        /* 0x1234 */ public GcExperienceTimers PoliceTimers;
        [NMS(Index = 355)]
        /* 0x1254 */ public GcExperienceTimers SentinelTimersLow;
        [NMS(Index = 356)]
        /* 0x1274 */ public GcExperienceTimers SentinelTimersNormal;
        [NMS(Index = 364)]
        /* 0x1294 */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Index = 360)]
        /* 0x12B4 */ public GcExperienceTimers SpacePirateTimers;
        [NMS(Index = 647, Size = 0x7)]
        /* 0x12D4 */ public int[] AlienShipEvolveCosts;
        [NMS(Index = 366, Size = 0x7, EnumType = typeof(GcProceduralTechnologyData.QualityEnum))]
        /* 0x12F0 */ public int[] FreighterTechQualityWeightings;
        [NMS(Index = 529)]
        /* 0x130C */ public GcTracerData BulletTracer;
        [NMS(Index = 530)]
        /* 0x1324 */ public GcTracerData ShipTracer;
        [NMS(Index = 309, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x133C */ public float[] ChanceOfPirateFreighterBattleOnWarpToSystem;
        [NMS(Index = 30, Size = 0x3, EnumType = typeof(GcMissionDifficulty.MissionDifficultyEnum))]
        /* 0x134C */ public float[] MissionSubstanceDifficultyMultipliers;
        [NMS(Index = 284, Size = 0x3)]
        /* 0x1358 */ public int[] PirateInterestLevels;
        [NMS(Index = 285, Size = 0x3)]
        /* 0x1364 */ public int[] PirateInterestLevelsSurvival;
        [NMS(Index = 289, Size = 0x3)]
        /* 0x1370 */ public int[] PoliceInterestLevels;
        [NMS(Index = 290, Size = 0x3)]
        /* 0x137C */ public int[] PoliceInterestLevelsSurvival;
        [NMS(Index = 652)]
        /* 0x1388 */ public Vector2f FrigateFlybyTimer;
        [NMS(Index = 478)]
        /* 0x1390 */ public Vector2f HUDDamageSize;
        [NMS(Index = 479)]
        /* 0x1398 */ public Vector2f HUDDamageSplatSize;
        [NMS(Index = 609)]
        /* 0x13A0 */ public GcPortalData Portal;
        [NMS(Index = 12)]
        /* 0x13A8 */ public Vector2f SaveContextTransferShipCostScaleNanites;
        [NMS(Index = 11)]
        /* 0x13B0 */ public Vector2f SaveContextTransferShipCostScaleUnits;
        [NMS(Index = 10)]
        /* 0x13B8 */ public Vector2f SaveContextTransferWeaponCostScaleNanites;
        [NMS(Index = 9)]
        /* 0x13C0 */ public Vector2f SaveContextTransferWeaponCostScaleUnits;
        [NMS(Index = 344)]
        /* 0x13C8 */ public float AggressiveSentinelProbability;
        [NMS(Index = 345)]
        /* 0x13CC */ public float AggressiveSentinelProbabilitySurvival;
        [NMS(Index = 597)]
        /* 0x13D0 */ public float AirLockDoorRange;
        [NMS(Index = 90)]
        /* 0x13D4 */ public float AlienPodThreshold1;
        [NMS(Index = 89)]
        /* 0x13D8 */ public float AlienPodThreshold2;
        [NMS(Index = 234)]
        /* 0x13DC */ public float AllRecipesKnownNanitesMax;
        [NMS(Index = 233)]
        /* 0x13E0 */ public float AllRecipesKnownNanitesMin;
        [NMS(Index = 122)]
        /* 0x13E4 */ public float AngleFromBaseComputerWhenTeleporting;
        [NMS(Index = 371)]
        /* 0x13E8 */ public float AsteroidCarveRadius;
        [NMS(Index = 369)]
        /* 0x13EC */ public float AsteroidHitForce;
        [NMS(Index = 379)]
        /* 0x13F0 */ public int AsteroidResourceReducer;
        [NMS(Index = 209)]
        /* 0x13F4 */ public int AsteroidScanMaxShown;
        [NMS(Index = 211)]
        /* 0x13F8 */ public float AsteroidScanRange;
        [NMS(Index = 210)]
        /* 0x13FC */ public float AsteroidScanTime;
        [NMS(Index = 370)]
        /* 0x1400 */ public float AsteroidTorqueForce;
        [NMS(Index = 665)]
        /* 0x1404 */ public float AtlasGunCurrencyConversion;
        [NMS(Index = 208)]
        /* 0x1408 */ public float AtmosphereEntryErrorTime;
        [NMS(Index = 205)]
        /* 0x140C */ public float AtmosphereEntryFadeTimeFactor;
        [NMS(Index = 206)]
        /* 0x1410 */ public float AtmosphereEntryOffset;
        [NMS(Index = 204)]
        /* 0x1414 */ public float AtmosphereEntryTime;
        [NMS(Index = 124)]
        /* 0x1418 */ public float AutoTranslateWordChance;
        [NMS(Index = 637)]
        /* 0x141C */ public float BackgroundSpaceEncounterCheckTimer;
        [NMS(Index = 527)]
        /* 0x1420 */ public float BarrelOffset;
        [NMS(Index = 594)]
        /* 0x1424 */ public float BaseBuildingHoverTimeToKnowPart;
        [NMS(Index = 441)]
        /* 0x1428 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        [NMS(Index = 164)]
        /* 0x142C */ public float BaseLaserHeatTime;
        [NMS(Index = 397)]
        /* 0x1430 */ public float BeaconInteractRange;
        [NMS(Index = 221)]
        /* 0x1434 */ public float BinocCreatureScanTime;
        [NMS(Index = 219)]
        /* 0x1438 */ public float BinocMinScanTime;
        [NMS(Index = 220)]
        /* 0x143C */ public float BinocScanTime;
        [NMS(Index = 218)]
        /* 0x1440 */ public float BinocTimeBeforeScan;
        [NMS(Index = 226)]
        /* 0x1444 */ public float BinocularScanTargetFadeTime;
        [NMS(Index = 217)]
        /* 0x1448 */ public float BinocularScanTargetHeightRange;
        [NMS(Index = 223)]
        /* 0x144C */ public float BinocularScanTargetInitialFadeTime;
        [NMS(Index = 225)]
        /* 0x1450 */ public float BinocularScanTargetLineWidth;
        [NMS(Index = 216)]
        /* 0x1454 */ public float BinocularScanTargetMinHeight;
        [NMS(Index = 224)]
        /* 0x1458 */ public float BinocularScanTargetScaler;
        [NMS(Index = 587)]
        /* 0x145C */ public float BlackHoleJumpVoxelDist;
        [NMS(Index = 588)]
        /* 0x1460 */ public float BlackHoleJumpVoxelVariation;
        [NMS(Index = 583)]
        /* 0x1464 */ public float BonusChildTypeElementsAdd;
        [NMS(Index = 584)]
        /* 0x1468 */ public float BonusChildTypeElementsMultiply;
        [NMS(Index = 581)]
        /* 0x146C */ public float BonusSameTypeElementsAdd;
        [NMS(Index = 582)]
        /* 0x1470 */ public float BonusSameTypeElementsMultiply;
        [NMS(Index = 2)]
        /* 0x1474 */ public int BugFiendCap;
        [NMS(Index = 374)]
        /* 0x1478 */ public float BuildingBeamDistance;
        [NMS(Index = 236)]
        /* 0x147C */ public float BuildingPlayerBaseIconOffset;
        [NMS(Index = 92)]
        /* 0x1480 */ public float BulletTraceLineWidth;
        [NMS(Index = 37)]
        /* 0x1484 */ public float CargoShieldStrength;
        [NMS(Index = 120)]
        /* 0x1488 */ public float CockpitScale;
        [NMS(Index = 58)]
        /* 0x148C */ public float CombatLevelBaseValueBoltcaster;
        [NMS(Index = 62)]
        /* 0x1490 */ public float CombatLevelBaseValueCannon;
        [NMS(Index = 63)]
        /* 0x1494 */ public float CombatLevelBaseValueGrenade;
        [NMS(Index = 60)]
        /* 0x1498 */ public float CombatLevelBaseValueRailgun;
        [NMS(Index = 59)]
        /* 0x149C */ public float CombatLevelBaseValueShotgun;
        [NMS(Index = 61)]
        /* 0x14A0 */ public float CombatLevelBaseValueSMG;
        [NMS(Index = 57)]
        /* 0x14A4 */ public float CombatLevelBestWeaponBias;
        [NMS(Index = 64)]
        /* 0x14A8 */ public float CombatLevelSClassValue;
        [NMS(Index = 535)]
        /* 0x14AC */ public float CombatSpeedReadoutMultiplier;
        [NMS(Index = 377)]
        /* 0x14B0 */ public int CommonProductEffectiveness;
        [NMS(Index = 254)]
        /* 0x14B4 */ public float CommunicatorCargoScanDroneAtOffsetFallback;
        [NMS(Index = 255)]
        /* 0x14B8 */ public float CommunicatorCargoScanDronePitch;
        [NMS(Index = 256)]
        /* 0x14BC */ public float CommunicatorCargoScanDroneRoll;
        [NMS(Index = 250)]
        /* 0x14C0 */ public float CommunicatorCargoScanDroneScale;
        [NMS(Index = 251)]
        /* 0x14C4 */ public float CommunicatorCargoScanDroneScaleFallback;
        [NMS(Index = 252)]
        /* 0x14C8 */ public float CommunicatorCargoScanDroneUpOffset;
        [NMS(Index = 253)]
        /* 0x14CC */ public float CommunicatorCargoScanDroneUpOffsetFallback;
        [NMS(Index = 257)]
        /* 0x14D0 */ public float CommunicatorCargoScanDroneYaw;
        [NMS(Index = 258)]
        /* 0x14D4 */ public float CommunicatorFadeTime;
        [NMS(Index = 246)]
        /* 0x14D8 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Index = 245)]
        /* 0x14DC */ public float CommunicatorSpawnOffset;
        [NMS(Index = 249)]
        /* 0x14E0 */ public float CommunicatorSpawnRotation;
        [NMS(Index = 248)]
        /* 0x14E4 */ public float CommunicatorSpawnScale;
        [NMS(Index = 613)]
        /* 0x14E8 */ public float CorruptSentinelProbability;
        [NMS(Index = 333)]
        /* 0x14EC */ public float CreatureMinScanTime;
        [NMS(Index = 332)]
        /* 0x14F0 */ public float CreatureScanAngle;
        [NMS(Index = 331)]
        /* 0x14F4 */ public float CreatureScanStickyDecay;
        [NMS(Index = 156)]
        /* 0x14F8 */ public int CreaturesToBaitForTutorial;
        [NMS(Index = 157)]
        /* 0x14FC */ public int CreaturesToFeedForTutorial;
        [NMS(Index = 338)]
        /* 0x1500 */ public int CritDamage;
        [NMS(Index = 237)]
        /* 0x1504 */ public float CriticalHitMultiplier;
        [NMS(Index = 339)]
        /* 0x1508 */ public float CritScale;
        [NMS(Index = 619)]
        /* 0x150C */ public float DeadPlanetGravityFactor;
        [NMS(Index = 372)]
        /* 0x1510 */ public int DeathMoneyPenalty;
        [NMS(Index = 444)]
        /* 0x1514 */ public GcBuildingClassification DebugScanForceBuildingType;
        [NMS(Index = 646)]
        /* 0x1518 */ public float DerelictPulseEncounterAtmosphericEffectChance;
        [NMS(Index = 271)]
        /* 0x151C */ public float DestroyEffectHeight;
        [NMS(Index = 272)]
        /* 0x1520 */ public float DestroyEffectMaxScale;
        [NMS(Index = 123)]
        /* 0x1524 */ public float DistanceFromBaseComputerWhenTeleporting;
        [NMS(Index = 396)]
        /* 0x1528 */ public float DockNodeBuyRadius;
        [NMS(Index = 279)]
        /* 0x152C */ public int EarlyPiratesToBeKilled;
        [NMS(Index = 341)]
        /* 0x1530 */ public float EmergencyBuildingScanEventDistance;
        [NMS(Index = 342)]
        /* 0x1534 */ public float EmergencyBuildingScanEventTime;
        [NMS(Index = 273)]
        /* 0x1538 */ public float EventTargetSpeed;
        [NMS(Index = 469)]
        /* 0x153C */ public float ExcitingNearRange;
        [NMS(Index = 467)]
        /* 0x1540 */ public float ExcitingViewAngle;
        [NMS(Index = 468)]
        /* 0x1544 */ public float ExcitingViewRange;
        [NMS(Index = 575)]
        /* 0x1548 */ public float ExplosionForce;
        [NMS(Index = 576)]
        /* 0x154C */ public float ExplosionForceMaxForceRadius;
        [NMS(Index = 574)]
        /* 0x1550 */ public float ExplosionRadiusMultiplier;
        [NMS(Index = 610)]
        /* 0x1554 */ public int FourthRaceSpawnPercentage;
        [NMS(Index = 296)]
        /* 0x1558 */ public float FreighterBattleRadius;
        [NMS(Index = 308)]
        /* 0x155C */ public float FreighterCargoPodHealthFraction;
        [NMS(Index = 307)]
        /* 0x1560 */ public float FreighterFuelRodHealthFraction;
        [NMS(Index = 357)]
        /* 0x1564 */ public int FreighterStartPecent;
        [NMS(Index = 586)]
        /* 0x1568 */ public float GoalGapVoxelDist;
        [NMS(Index = 98)]
        /* 0x156C */ public int GPSRandomChangeTimeBuilderCorruption;
        [NMS(Index = 96)]
        /* 0x1570 */ public int GPSRandomChangeTimeMid;
        [NMS(Index = 97)]
        /* 0x1574 */ public int GPSRandomChangeTimeNarrow;
        [NMS(Index = 95)]
        /* 0x1578 */ public int GPSRandomChangeTimeWide;
        [NMS(Index = 239)]
        /* 0x157C */ public float GrabPlayerCooldownTime;
        [NMS(Index = 525)]
        /* 0x1580 */ public float GunDownAngle;
        [NMS(Index = 522)]
        /* 0x1584 */ public float GunOffsetAggressiveX;
        [NMS(Index = 523)]
        /* 0x1588 */ public float GunOffsetAggressiveY;
        [NMS(Index = 524)]
        /* 0x158C */ public float GunOffsetAggressiveZ;
        [NMS(Index = 519)]
        /* 0x1590 */ public float GunOffsetX;
        [NMS(Index = 520)]
        /* 0x1594 */ public float GunOffsetY;
        [NMS(Index = 521)]
        /* 0x1598 */ public float GunOffsetZ;
        [NMS(Index = 526)]
        /* 0x159C */ public float GunUpAngle;
        [NMS(Index = 278)]
        /* 0x15A0 */ public int HardModeTechDamageHighPercent;
        [NMS(Index = 276)]
        /* 0x15A4 */ public int HardModeTechDamageMidNum;
        [NMS(Index = 277)]
        /* 0x15A8 */ public int HardModeTechDamageMidPercent;
        [NMS(Index = 165)]
        /* 0x15AC */ public float HeatAlertTime;
        [NMS(Index = 166)]
        /* 0x15B0 */ public float HeatDamageBoost;
        [NMS(Index = 170)]
        /* 0x15B4 */ public float HeatMaxPowerPoint;
        [NMS(Index = 167)]
        /* 0x15B8 */ public float HeatWidthBoost;
        [NMS(Index = 168)]
        /* 0x15BC */ public float HeatWidthBoostAlt;
        [NMS(Index = 238)]
        /* 0x15C0 */ public float HitEffectMinTime;
        [NMS(Index = 528)]
        /* 0x15C4 */ public float HitOffset;
        [NMS(Index = 186)]
        /* 0x15C8 */ public float HmdInteractionRangeMinDistance;
        [NMS(Index = 185)]
        /* 0x15CC */ public float HmdInteractionRangeMinRange;
        [NMS(Index = 187)]
        /* 0x15D0 */ public float HmdInteractionRangeMultiplier;
        [NMS(Index = 293)]
        /* 0x15D4 */ public float HoursBetweenBattles;
        [NMS(Index = 591)]
        /* 0x15D8 */ public float HoursBetweenMiniStation;
        [NMS(Index = 414)]
        /* 0x15DC */ public float HoverTimeToScan;
        [NMS(Index = 415)]
        /* 0x15E0 */ public float HoverTimeToScanCreatures;
        [NMS(Index = 416)]
        /* 0x15E4 */ public int HoverVisiblePointsNeeded;
        [NMS(Index = 477)]
        /* 0x15E8 */ public float HUDArrowPrimaryScaler;
        [NMS(Index = 482)]
        /* 0x15EC */ public float HUDDamageOffset;
        [NMS(Index = 484)]
        /* 0x15F0 */ public float HUDDamageRadius;
        [NMS(Index = 483)]
        /* 0x15F4 */ public float HUDDamageScaler;
        [NMS(Index = 487)]
        /* 0x15F8 */ public float HUDLabelAngle;
        [NMS(Index = 488)]
        /* 0x15FC */ public float HUDLabelAngleOffset;
        [NMS(Index = 489)]
        /* 0x1600 */ public float HUDLabelOffsetX;
        [NMS(Index = 490)]
        /* 0x1604 */ public float HUDLabelOffsetY;
        [NMS(Index = 491)]
        /* 0x1608 */ public float HUDLabelOffsetZ;
        [NMS(Index = 492)]
        /* 0x160C */ public float HUDLabelScale;
        [NMS(Index = 486)]
        /* 0x1610 */ public float HUDLabelTime;
        [NMS(Index = 476)]
        /* 0x1614 */ public float HUDLockOnAudioTime;
        [NMS(Index = 512)]
        /* 0x1618 */ public float HUDReticuleMoveAim;
        [NMS(Index = 511)]
        /* 0x161C */ public float HUDReticuleMoveBack;
        [NMS(Index = 505)]
        /* 0x1620 */ public float HUDScaleAdd;
        [NMS(Index = 510)]
        /* 0x1624 */ public float HUDScaleFarTarget;
        [NMS(Index = 509)]
        /* 0x1628 */ public float HUDScaleMax;
        [NMS(Index = 507)]
        /* 0x162C */ public float HUDScaleMin;
        [NMS(Index = 508)]
        /* 0x1630 */ public float HUDScaleMinAim;
        [NMS(Index = 506)]
        /* 0x1634 */ public float HUDScaleRadius;
        [NMS(Index = 466)]
        /* 0x1638 */ public float HUDStoreFlashTime;
        [NMS(Index = 56)]
        /* 0x163C */ public float IllegalTechProductTradingMod;
        [NMS(Index = 53)]
        /* 0x1640 */ public float InfestedPlanetDeepSpaceFlybyMultiplier;
        [NMS(Index = 72)]
        /* 0x1644 */ public float InitialLocationProtectionRadiusMultiplier;
        [NMS(Index = 265)]
        /* 0x1648 */ public float InteractionAttractTime;
        [NMS(Index = 585)]
        /* 0x164C */ public float InteractionComponentUpdateDistance;
        [NMS(Index = 266)]
        /* 0x1650 */ public float InteractionDescriptionTextTime;
        [NMS(Index = 264)]
        /* 0x1654 */ public float InteractionMessageModuleDisplayTime;
        [NMS(Index = 261)]
        /* 0x1658 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        [NMS(Index = 262)]
        /* 0x165C */ public float InteractionMinTimeBetweenStickOptionHighlights;
        [NMS(Index = 267)]
        /* 0x1660 */ public float InteractionMinTimeForResponseText;
        [NMS(Index = 269)]
        /* 0x1664 */ public GcInteractionType InteractionOverrideFrom;
        [NMS(Index = 270)]
        /* 0x1668 */ public GcInteractionType InteractionOverrideTo;
        [NMS(Index = 572)]
        /* 0x166C */ public float InteractionPickupAngle;
        [NMS(Index = 573)]
        /* 0x1670 */ public float InteractionPickupRadius;
        [NMS(Index = 263)]
        /* 0x1674 */ public float InteractionStickOptionStrength;
        [NMS(Index = 542)]
        /* 0x1678 */ public float InteractionTorchFoV;
        [NMS(Index = 543)]
        /* 0x167C */ public float InteractionTorchStrength;
        [NMS(Index = 589)]
        /* 0x1680 */ public float JumpToCenterFuelCost;
        [NMS(Index = 578)]
        /* 0x1684 */ public float LaserExplosionForce;
        [NMS(Index = 579)]
        /* 0x1688 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Index = 577)]
        /* 0x168C */ public float LaserExplosionForceRadius;
        [NMS(Index = 13)]
        /* 0x1690 */ public int LaserRechargeHintThresholdEarly;
        [NMS(Index = 14)]
        /* 0x1694 */ public int LaserRechargeHintThresholdLate;
        [NMS(Index = 596)]
        /* 0x1698 */ public float LightStrength;
        [NMS(Index = 471)]
        /* 0x169C */ public float LineWidth;
        [NMS(Index = 472)]
        /* 0x16A0 */ public float LockOffFactor;
        [NMS(Index = 346)]
        /* 0x16A4 */ public float LowSentinelProbability;
        [NMS(Index = 347)]
        /* 0x16A8 */ public float LowSentinelProbabilitySurvival;
        [NMS(Index = 503)]
        /* 0x16AC */ public float MapFOV;
        [NMS(Index = 500)]
        /* 0x16B0 */ public float MapHeight;
        [NMS(Index = 501)]
        /* 0x16B4 */ public float MapOffset;
        [NMS(Index = 504)]
        /* 0x16B8 */ public float MapRadius;
        [NMS(Index = 502)]
        /* 0x16BC */ public float MapTargetOffset;
        [NMS(Index = 75)]
        /* 0x16C0 */ public int MaxActiveWeatherHazardGifts;
        [NMS(Index = 121)]
        /* 0x16C4 */ public float MaxDistanceForLadderTeleport;
        [NMS(Index = 353)]
        /* 0x16C8 */ public int MaxDronesAggressive;
        [NMS(Index = 354)]
        /* 0x16CC */ public int MaxDronesAggressiveSurvival;
        [NMS(Index = 349)]
        /* 0x16D0 */ public int MaxDronesLow;
        [NMS(Index = 350)]
        /* 0x16D4 */ public int MaxDronesLowSurvival;
        [NMS(Index = 351)]
        /* 0x16D8 */ public int MaxDronesNormal;
        [NMS(Index = 352)]
        /* 0x16DC */ public int MaxDronesNormalSurvival;
        [NMS(Index = 79)]
        /* 0x16E0 */ public float MaxMeteorSurfaceAngle;
        [NMS(Index = 260)]
        /* 0x16E4 */ public int MaxNumMissionsFromMissionGiver;
        [NMS(Index = 196)]
        /* 0x16E8 */ public int MaxNumSameGroupTech;
        [NMS(Index = 235)]
        /* 0x16EC */ public float MaxPossibleShipDamagePotential;
        [NMS(Index = 373)]
        /* 0x16F0 */ public int MaxResourceCrystalBlobSize;
        [NMS(Index = 618)]
        /* 0x16F4 */ public float MaxRespawnOnGroundHeight;
        [NMS(Index = 494)]
        /* 0x16F8 */ public float MaxSpawnTime;
        [NMS(Index = 462)]
        /* 0x16FC */ public float MaxStandingTechDiscount;
        [NMS(Index = 110)]
        /* 0x1700 */ public int MaxTorpedoesInFlight;
        [NMS(Index = 15)]
        /* 0x1704 */ public int MeleeHintThresholdEarly;
        [NMS(Index = 16)]
        /* 0x1708 */ public int MeleeHintThresholdLate;
        [NMS(Index = 325)]
        /* 0x170C */ public float MissileApproachTime;
        [NMS(Index = 319)]
        /* 0x1710 */ public float MissileBrakeForceMax;
        [NMS(Index = 318)]
        /* 0x1714 */ public float MissileBrakeForceMin;
        [NMS(Index = 321)]
        /* 0x1718 */ public float MissileBrakeTime;
        [NMS(Index = 317)]
        /* 0x171C */ public float MissileForceMax;
        [NMS(Index = 316)]
        /* 0x1720 */ public float MissileForceMin;
        [NMS(Index = 322)]
        /* 0x1724 */ public float MissileHitRadius;
        [NMS(Index = 311)]
        /* 0x1728 */ public float MissileLockTime;
        [NMS(Index = 315)]
        /* 0x172C */ public float MissileMaxSpeed;
        [NMS(Index = 310)]
        /* 0x1730 */ public float MissileMaxTurnAngle;
        [NMS(Index = 324)]
        /* 0x1734 */ public float MissileMinCircleTime;
        [NMS(Index = 323)]
        /* 0x1738 */ public float MissileOffset;
        [NMS(Index = 312)]
        /* 0x173C */ public float MissileReloadTime;
        [NMS(Index = 314)]
        /* 0x1740 */ public float MissileRotateMax;
        [NMS(Index = 313)]
        /* 0x1744 */ public float MissileRotateMin;
        [NMS(Index = 326)]
        /* 0x1748 */ public float MissileRotateSpeed;
        [NMS(Index = 320)]
        /* 0x174C */ public float MissileThreatTime;
        [NMS(Index = 232)]
        /* 0x1750 */ public float MissionEventAllowResetDistance;
        [NMS(Index = 139)]
        /* 0x1754 */ public float MissionSurveyAutoScanDistance;
        [NMS(Index = 140)]
        /* 0x1758 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        [NMS(Index = 135)]
        /* 0x175C */ public float MissionSurveyBeginScanPercentageEvent;
        [NMS(Index = 134)]
        /* 0x1760 */ public float MissionSurveyBeginScanPercentageScannable;
        [NMS(Index = 146)]
        /* 0x1764 */ public float MissionSurveyInShipArrivedDistance;
        [NMS(Index = 130)]
        /* 0x1768 */ public float MissionSurveyMarkerAutoHideTime;
        [NMS(Index = 144)]
        /* 0x176C */ public float MissionSurveyMaxAngleOffset;
        [NMS(Index = 126)]
        /* 0x1770 */ public float MissionSurveyMaxGuidanceDistance;
        [NMS(Index = 127)]
        /* 0x1774 */ public float MissionSurveyMaxGuidanceDistanceWorms;
        [NMS(Index = 132)]
        /* 0x1778 */ public float MissionSurveyMaxScanAngle;
        [NMS(Index = 133)]
        /* 0x177C */ public float MissionSurveyMaxScanAngleScannableComp;
        [NMS(Index = 145)]
        /* 0x1780 */ public float MissionSurveyMaxSignalConeAngle;
        [NMS(Index = 138)]
        /* 0x1784 */ public float MissionSurveyRevealWithoutScanDistance;
        [NMS(Index = 131)]
        /* 0x1788 */ public float MissionSurveyScanRangeMultiplier;
        [NMS(Index = 136)]
        /* 0x178C */ public float MissionSurveyScanSpeed;
        [NMS(Index = 137)]
        /* 0x1790 */ public float MissionSurveyScanSpeedScannableComp;
        [NMS(Index = 142)]
        /* 0x1794 */ public float MissionSurveySonarMaxPulseSpeed;
        [NMS(Index = 141)]
        /* 0x1798 */ public float MissionSurveySonarMinPulseSpeed;
        [NMS(Index = 143)]
        /* 0x179C */ public float MissionSurveySonarPulseSpeedBandCount;
        [NMS(Index = 513)]
        /* 0x17A0 */ public float MouseSensitivity;
        [NMS(Index = 514)]
        /* 0x17A4 */ public float MouseSensitivityShip;
        [NMS(Index = 515)]
        /* 0x17A8 */ public float MouseSensitivityVehicle;
        [NMS(Index = 115)]
        /* 0x17AC */ public float MultidimensionalFadeTime;
        [NMS(Index = 335)]
        /* 0x17B0 */ public float NewDiscoveryDisplayTime;
        [NMS(Index = 66)]
        /* 0x17B4 */ public int NexusRecipeCostNaniteMultiplier;
        [NMS(Index = 348)]
        /* 0x17B8 */ public float NonAggressiveLushSurvivalProbabability;
        [NMS(Index = 611)]
        /* 0x17BC */ public int NonDominantRaceSpawnPercentage;
        [NMS(Index = 612)]
        /* 0x17C0 */ public int NonDominantRaceSpawnPercentagePirate;
        [NMS(Index = 463)]
        /* 0x17C4 */ public float NonNaturalCostMul;
        [NMS(Index = 163)]
        /* 0x17C8 */ public float NormalModeHeatBonus;
        [NMS(Index = 7)]
        /* 0x17CC */ public float NPCNavNodeSearchUpDistScaling;
        [NMS(Index = 25)]
        /* 0x17D0 */ public float NPCWaitWhenRevealedTime;
        [NMS(Index = 340)]
        /* 0x17D4 */ public int NumMissionsPerSolarSystem;
        [NMS(Index = 473)]
        /* 0x17D8 */ public float OffscreenFadeDistance;
        [NMS(Index = 474)]
        /* 0x17DC */ public float OffscreenMinDot;
        [NMS(Index = 171)]
        /* 0x17E0 */ public float OverheatDecay;
        [NMS(Index = 169)]
        /* 0x17E4 */ public float OverheatGenerosity;
        [NMS(Index = 516)]
        /* 0x17E8 */ public float PainTime;
        [NMS(Index = 73)]
        /* 0x17EC */ public float PartyPlanetSearchDistance;
        [NMS(Index = 654)]
        /* 0x17F0 */ public int PersonalInventoryMinHeightMax;
        [NMS(Index = 653)]
        /* 0x17F4 */ public int PersonalInventoryMinWidthMax;
        [NMS(Index = 656)]
        /* 0x17F8 */ public int PersonalTechInventoryMinHeightMax;
        [NMS(Index = 655)]
        /* 0x17FC */ public int PersonalTechInventoryMinWidthMax;
        [NMS(Index = 362)]
        /* 0x1800 */ public float PirateEarlySpawnTime;
        [NMS(Index = 111)]
        /* 0x1804 */ public float PirateFreighterBattleNoTargetLeaderTime;
        [NMS(Index = 300)]
        /* 0x1808 */ public float PirateFreighterBeginFleeHealthFraction;
        [NMS(Index = 297)]
        /* 0x180C */ public int PirateFreighterFrigateCountForReinforce;
        [NMS(Index = 303)]
        /* 0x1810 */ public float PirateFreighterRewardDelayTime;
        [NMS(Index = 305)]
        /* 0x1814 */ public float PirateFreighterRewardDelayTimeEscaped;
        [NMS(Index = 304)]
        /* 0x1818 */ public float PirateFreighterRewardMessageDelayTime;
        [NMS(Index = 306)]
        /* 0x181C */ public float PirateFreighterRewardMessageDelayTimeEscaped;
        [NMS(Index = 299)]
        /* 0x1820 */ public float PirateFreighterWarpChargeTime;
        [NMS(Index = 298)]
        /* 0x1824 */ public float PirateFreighterWarpChargeTimeToAddPerBrokenEngine;
        [NMS(Index = 43)]
        /* 0x1828 */ public float PirateGroundAccelerator;
        [NMS(Index = 44)]
        /* 0x182C */ public float PirateGroundInventoryAccelerator;
        [NMS(Index = 282)]
        /* 0x1830 */ public float PirateInterestDistance;
        [NMS(Index = 283)]
        /* 0x1834 */ public float PirateInterestDistanceMPMission;
        [NMS(Index = 281)]
        /* 0x1838 */ public int PirateInterestOverride;
        [NMS(Index = 42)]
        /* 0x183C */ public float PirateRaidAccelerator;
        [NMS(Index = 280)]
        /* 0x1840 */ public int PlanetPirateFlybyMaxRepeatCounter;
        [NMS(Index = 565)]
        /* 0x1844 */ public float PlayerAmbientSpotLightIntensity;
        [NMS(Index = 567)]
        /* 0x1848 */ public float PlayerAmbientSpotLightOffsetY;
        [NMS(Index = 568)]
        /* 0x184C */ public float PlayerAmbientSpotLightOffsetZ;
        [NMS(Index = 50)]
        /* 0x1850 */ public float PoliceAcceleratorNoCargoNormal;
        [NMS(Index = 51)]
        /* 0x1854 */ public float PoliceAcceleratorNoCargoSkipScanOdds;
        [NMS(Index = 49)]
        /* 0x1858 */ public float PoliceAcceleratorNoCargoWealthy;
        [NMS(Index = 46)]
        /* 0x185C */ public float PoliceAcceleratorPulseExtra;
        [NMS(Index = 47)]
        /* 0x1860 */ public int PoliceAcceleratorSmugglingItemsMax;
        [NMS(Index = 48)]
        /* 0x1864 */ public float PoliceAcceleratorSmugglingMulMax;
        [NMS(Index = 45)]
        /* 0x1868 */ public float PoliceAcceleratorStationLockOn;
        [NMS(Index = 287)]
        /* 0x186C */ public float PoliceInterestDistance;
        [NMS(Index = 288)]
        /* 0x1870 */ public float PoliceInterestDistanceMPMission;
        [NMS(Index = 286)]
        /* 0x1874 */ public int PoliceInterestOverride;
        [NMS(Index = 605)]
        /* 0x1878 */ public int ProductItemStockDecayTime;
        [NMS(Index = 606)]
        /* 0x187C */ public int ProductItemStockReplenishTime;
        [NMS(Index = 343)]
        /* 0x1880 */ public float ProjectileLightIntensity;
        [NMS(Index = 470)]
        /* 0x1884 */ public float ProjectileSpeedBoost;
        [NMS(Index = 639)]
        /* 0x1888 */ public float PulseEncounterChance;
        [NMS(Index = 643)]
        /* 0x188C */ public float PulseEncounterChanceBlue;
        [NMS(Index = 642)]
        /* 0x1890 */ public float PulseEncounterChanceGreen;
        [NMS(Index = 641)]
        /* 0x1894 */ public float PulseEncounterChanceRed;
        [NMS(Index = 640)]
        /* 0x1898 */ public float PulseEncounterChanceStandard;
        [NMS(Index = 638)]
        /* 0x189C */ public float PulseEncounterCheckTimer;
        [NMS(Index = 644)]
        /* 0x18A0 */ public float PulseEncounterStopPower;
        [NMS(Index = 645)]
        /* 0x18A4 */ public float PulseEncounterStopSpeed;
        [NMS(Index = 378)]
        /* 0x18A8 */ public int RareProductEffectiveness;
        [NMS(Index = 376)]
        /* 0x18AC */ public int RareSubstanceEffectiveness;
        [NMS(Index = 178)]
        /* 0x18B0 */ public int RefinerProductsMadeInTime;
        [NMS(Index = 180)]
        /* 0x18B4 */ public int RefinerProductsMadeInTimeSurvival;
        [NMS(Index = 179)]
        /* 0x18B8 */ public int RefinerSubsMadeInTime;
        [NMS(Index = 181)]
        /* 0x18BC */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Index = 387)]
        /* 0x18C0 */ public int ResourceCommonMaxAmount;
        [NMS(Index = 386)]
        /* 0x18C4 */ public int ResourceCommonMinAmount;
        [NMS(Index = 385)]
        /* 0x18C8 */ public int ResourceCommonReducer;
        [NMS(Index = 390)]
        /* 0x18CC */ public int ResourceDirtMaxAmount;
        [NMS(Index = 389)]
        /* 0x18D0 */ public int ResourceDirtMinAmount;
        [NMS(Index = 388)]
        /* 0x18D4 */ public int ResourceDirtReducer;
        [NMS(Index = 384)]
        /* 0x18D8 */ public int ResourceMaxAmount;
        [NMS(Index = 383)]
        /* 0x18DC */ public int ResourceMinAmount;
        [NMS(Index = 498)]
        /* 0x18E0 */ public int ResourceParticleMaxNum;
        [NMS(Index = 499)]
        /* 0x18E4 */ public int ResourceParticleMinNum;
        [NMS(Index = 496)]
        /* 0x18E8 */ public float ResourceParticleSpeed;
        [NMS(Index = 497)]
        /* 0x18EC */ public float ResourceParticleSpread;
        [NMS(Index = 382)]
        /* 0x18F0 */ public int ResourceReducer;
        [NMS(Index = 35)]
        /* 0x18F4 */ public int RocketLockerFuelUse;
        [NMS(Index = 629)]
        /* 0x18F8 */ public float SalvageShipExplodeShipDistance;
        [NMS(Index = 625)]
        /* 0x18FC */ public float SalvageShipExplodeSpeed;
        [NMS(Index = 624)]
        /* 0x1900 */ public float SalvageShipHeightOffset;
        [NMS(Index = 630)]
        /* 0x1904 */ public float SalvageShipOneRevolutionTime;
        [NMS(Index = 623)]
        /* 0x1908 */ public float SalvageShipPitch;
        [NMS(Index = 628)]
        /* 0x190C */ public float SalvageShipShowShipDistance;
        [NMS(Index = 626)]
        /* 0x1910 */ public float SalvageShipShowShipSpeed;
        [NMS(Index = 627)]
        /* 0x1914 */ public float SalvageShipShowShipSpeedSwitching;
        [NMS(Index = 100)]
        /* 0x1918 */ public int SalvageSubstanceValueThreshold;
        [NMS(Index = 99)]
        /* 0x191C */ public float SalvageValueAsProds;
        [NMS(Index = 632)]
        /* 0x1920 */ public float SalvageWeaponHeightOffset;
        [NMS(Index = 634)]
        /* 0x1924 */ public float SalvageWeaponMaxSize;
        [NMS(Index = 631)]
        /* 0x1928 */ public float SalvageWeaponPitch;
        [NMS(Index = 633)]
        /* 0x192C */ public float SalvageWeaponScale;
        [NMS(Index = 334)]
        /* 0x1930 */ public float ScanAngle;
        [NMS(Index = 400)]
        /* 0x1934 */ public float ScanAngleCutoff;
        [NMS(Index = 230)]
        /* 0x1938 */ public float ScannableComponentMarkerOffset;
        [NMS(Index = 231)]
        /* 0x193C */ public float ScannableComponentPlaceMarkerOffset;
        [NMS(Index = 451)]
        /* 0x1940 */ public float ScannerAnalyzeFXRate;
        [NMS(Index = 229)]
        /* 0x1944 */ public float ScannerIconsClumpRadius;
        [NMS(Index = 448)]
        /* 0x1948 */ public float ScannerMarkerFadeTime;
        [NMS(Index = 450)]
        /* 0x194C */ public float ScannerPhysicsProbeAABBSize;
        [NMS(Index = 449)]
        /* 0x1950 */ public float ScannerSmallMarkerFadeTime;
        [NMS(Index = 452)]
        /* 0x1954 */ public float ScannerSubstanceTimePerTrigger;
        [NMS(Index = 453)]
        /* 0x1958 */ public float ScannerTuningA;
        [NMS(Index = 454)]
        /* 0x195C */ public float ScannerTuningB;
        [NMS(Index = 455)]
        /* 0x1960 */ public float ScannerTuningC;
        [NMS(Index = 456)]
        /* 0x1964 */ public float ScannerTuningD;
        [NMS(Index = 457)]
        /* 0x1968 */ public float ScannerTuningResourceOffset1;
        [NMS(Index = 458)]
        /* 0x196C */ public float ScannerTuningResourceOffset2;
        [NMS(Index = 459)]
        /* 0x1970 */ public float ScannerTuningSmoothStepAmount;
        [NMS(Index = 460)]
        /* 0x1974 */ public float ScannerTuningTrailingEdge;
        [NMS(Index = 327)]
        /* 0x1978 */ public float ScanStartTimeDelayMinDist;
        [NMS(Index = 328)]
        /* 0x197C */ public float ScanStartTimeDelayRange;
        [NMS(Index = 329)]
        /* 0x1980 */ public float ScanStartTimeDistanceDelayTime;
        [NMS(Index = 330)]
        /* 0x1984 */ public float ScanStickyDecay;
        [NMS(Index = 22)]
        /* 0x1988 */ public float ScanToRevealDelayOverride;
        [NMS(Index = 26)]
        /* 0x198C */ public float ScanToRevealVFXBaseScalingSize;
        [NMS(Index = 617)]
        /* 0x1990 */ public float ScrapDroneProbability;
        [NMS(Index = 184)]
        /* 0x1994 */ public float SeasonalMessageModuleAttractDistanceMul;
        [NMS(Index = 367)]
        /* 0x1998 */ public int SentinelsHigh;
        [NMS(Index = 368)]
        /* 0x199C */ public int SentinelsLow;
        [NMS(Index = 4)]
        /* 0x19A0 */ public float ShipBuilderInteractionBuildEffectTime;
        [NMS(Index = 5)]
        /* 0x19A4 */ public float ShipBuilderInteractionDissolveEffectTime;
        [NMS(Index = 93)]
        /* 0x19A8 */ public float ShipBulletTraceLineWidth;
        [NMS(Index = 601)]
        /* 0x19AC */ public float ShipDisplayDamageMultiplier;
        [NMS(Index = 398)]
        /* 0x19B0 */ public float ShipInteractRadius;
        [NMS(Index = 52)]
        /* 0x19B4 */ public float ShipInterestAcceleratorInAsteroidField;
        [NMS(Index = 658)]
        /* 0x19B8 */ public int ShipInventoryMinHeightMax;
        [NMS(Index = 657)]
        /* 0x19BC */ public int ShipInventoryMinWidthMax;
        [NMS(Index = 54)]
        /* 0x19C0 */ public float ShipMiningMul;
        [NMS(Index = 445)]
        /* 0x19C4 */ public float ShipScanOffset;
        [NMS(Index = 446)]
        /* 0x19C8 */ public float ShipScanOffsetGap;
        [NMS(Index = 67)]
        /* 0x19CC */ public float ShipScanPlanetRechargeMultiplier;
        [NMS(Index = 68)]
        /* 0x19D0 */ public float ShipScanSpaceRechargeMultiplier;
        [NMS(Index = 660)]
        /* 0x19D4 */ public int ShipTechInventoryMinHeightMax;
        [NMS(Index = 659)]
        /* 0x19D8 */ public int ShipTechInventoryMinWidthMax;
        [NMS(Index = 199)]
        /* 0x19DC */ public float ShootableAggroForgetTime;
        [NMS(Index = 198)]
        /* 0x19E0 */ public float ShootableAggroMinStartTime;
        [NMS(Index = 197)]
        /* 0x19E4 */ public float ShootableArmourHighlightHitTime;
        [NMS(Index = 571)]
        /* 0x19E8 */ public float SimpleInteractionMessageTime;
        [NMS(Index = 569)]
        /* 0x19EC */ public float SimpleInteractionPickupAngle;
        [NMS(Index = 570)]
        /* 0x19F0 */ public float SimpleInteractionPickupRadius;
        [NMS(Index = 55)]
        /* 0x19F4 */ public float SmugglerSellingMarkup;
        [NMS(Index = 295)]
        /* 0x19F8 */ public float SpaceBattleAnyHostileShipsRadius;
        [NMS(Index = 301)]
        /* 0x19FC */ public int SpaceBattleMaxTorpedosTargetingLeaderShip;
        [NMS(Index = 302)]
        /* 0x1A00 */ public int SpaceBattleMaxTorpedosTargetingNonLeaderShip;
        [NMS(Index = 294)]
        /* 0x1A04 */ public float SpaceBattleRadius;
        [NMS(Index = 291)]
        /* 0x1A08 */ public float SpaceCombatRadius;
        [NMS(Index = 534)]
        /* 0x1A0C */ public float SpaceSpeedReadoutMultiplier;
        [NMS(Index = 648)]
        /* 0x1A10 */ public float SpawnerWeaponRange;
        [NMS(Index = 274)]
        /* 0x1A14 */ public int SpecialMiningAmount;
        [NMS(Index = 275)]
        /* 0x1A18 */ public float SpecialMiningTime;
        [NMS(Index = 34)]
        /* 0x1A1C */ public float SpecialTechSlotBonus;
        [NMS(Index = 533)]
        /* 0x1A20 */ public float SpeedReadoutMultiplier;
        [NMS(Index = 81)]
        /* 0x1A24 */ public float StormBonusJetpackMod;
        [NMS(Index = 85)]
        /* 0x1A28 */ public GcPlayerHazardType StormBonusJetpackWeather;
        [NMS(Index = 84)]
        /* 0x1A2C */ public float StormBonusMiningAmountMod;
        [NMS(Index = 88)]
        /* 0x1A30 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        [NMS(Index = 83)]
        /* 0x1A34 */ public float StormBonusMiningHeatMod;
        [NMS(Index = 87)]
        /* 0x1A38 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        [NMS(Index = 82)]
        /* 0x1A3C */ public float StormBonusSprintMod;
        [NMS(Index = 86)]
        /* 0x1A40 */ public GcPlayerHazardType StormBonusSprintWeather;
        [NMS(Index = 80)]
        /* 0x1A44 */ public float StormGravityChangeTime;
        [NMS(Index = 607)]
        /* 0x1A48 */ public int SubstanceItemStockDecayTime;
        [NMS(Index = 608)]
        /* 0x1A4C */ public int SubstanceItemStockReplenishTime;
        [NMS(Index = 147)]
        /* 0x1A50 */ public float SurveyBeginScanPercentage;
        [NMS(Index = 155)]
        /* 0x1A54 */ public float SurveyMaxDistance;
        [NMS(Index = 149)]
        /* 0x1A58 */ public float SurveyScanMaxSpeed;
        [NMS(Index = 148)]
        /* 0x1A5C */ public float SurveyScanMinSpeed;
        [NMS(Index = 152)]
        /* 0x1A60 */ public float SurveySonarMaxPulseSpeed;
        [NMS(Index = 154)]
        /* 0x1A64 */ public float SurveySonarMiddleRangeMax;
        [NMS(Index = 153)]
        /* 0x1A68 */ public float SurveySonarMiddleRangeMin;
        [NMS(Index = 151)]
        /* 0x1A6C */ public float SurveySonarMinPulseSpeed;
        [NMS(Index = 150)]
        /* 0x1A70 */ public float SurveySonarPulseSpeedBandCount;
        [NMS(Index = 241)]
        /* 0x1A74 */ public float TapInteractionDecay;
        [NMS(Index = 240)]
        /* 0x1A78 */ public float TapInteractionIncreaseAmount;
        [NMS(Index = 38)]
        /* 0x1A7C */ public float TechDamageChanceShieldedMax;
        [NMS(Index = 40)]
        /* 0x1A80 */ public float TechDamageChanceShieldLevelMax;
        [NMS(Index = 39)]
        /* 0x1A84 */ public float TechDamageChanceShieldLevelMin;
        [NMS(Index = 41)]
        /* 0x1A88 */ public float TechDamageChanceToSelectPrimary;
        [NMS(Index = 78)]
        /* 0x1A8C */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        [NMS(Index = 116)]
        /* 0x1A90 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Index = 214)]
        /* 0x1A94 */ public float TerrainResourceCompassRange;
        [NMS(Index = 213)]
        /* 0x1A98 */ public float TerrainResourceScanRange;
        [NMS(Index = 212)]
        /* 0x1A9C */ public float TerrainResourceScanTime;
        [NMS(Index = 413)]
        /* 0x1AA0 */ public float TimeToDisplayScanResults;
        [NMS(Index = 536)]
        /* 0x1AA4 */ public int TorchCookieIndex;
        [NMS(Index = 539)]
        /* 0x1AA8 */ public int TorchDimCookieIndex;
        [NMS(Index = 540)]
        /* 0x1AAC */ public float TorchDimFoV;
        [NMS(Index = 541)]
        /* 0x1AB0 */ public float TorchDimStrength;
        [NMS(Index = 562)]
        /* 0x1AB4 */ public float TorchFollowCameraPitch;
        [NMS(Index = 563)]
        /* 0x1AB8 */ public float TorchFollowCameraTime;
        [NMS(Index = 537)]
        /* 0x1ABC */ public float TorchFoV;
        [NMS(Index = 557)]
        /* 0x1AC0 */ public float TorchHandOffsetX;
        [NMS(Index = 558)]
        /* 0x1AC4 */ public float TorchHandOffsetY;
        [NMS(Index = 559)]
        /* 0x1AC8 */ public float TorchHandOffsetZ;
        [NMS(Index = 548)]
        /* 0x1ACC */ public float TorchOffsetX;
        [NMS(Index = 549)]
        /* 0x1AD0 */ public float TorchOffsetY;
        [NMS(Index = 551)]
        /* 0x1AD4 */ public float TorchOffsetZ;
        [NMS(Index = 550)]
        /* 0x1AD8 */ public float TorchOffsetZMin;
        [NMS(Index = 556)]
        /* 0x1ADC */ public float TorchOffsetZMinSpeed;
        [NMS(Index = 555)]
        /* 0x1AE0 */ public float TorchOffsetZSpeedRange;
        [NMS(Index = 561)]
        /* 0x1AE4 */ public float TorchRotation;
        [NMS(Index = 552)]
        /* 0x1AE8 */ public float TorchStaffOffsetY;
        [NMS(Index = 554)]
        /* 0x1AEC */ public float TorchStaffOffsetZ;
        [NMS(Index = 553)]
        /* 0x1AF0 */ public float TorchStaffOffsetZMin;
        [NMS(Index = 538)]
        /* 0x1AF4 */ public float TorchStrength;
        [NMS(Index = 109)]
        /* 0x1AF8 */ public float TorpedoCooldown;
        [NMS(Index = 113)]
        /* 0x1AFC */ public float TorpedoCooldownRandomExtra;
        [NMS(Index = 112)]
        /* 0x1B00 */ public float TorpedoInitialWait;
        [NMS(Index = 114)]
        /* 0x1B04 */ public float TorpedoLaunchWarning;
        [NMS(Index = 380)]
        /* 0x1B08 */ public int TunnelStatReducer;
        [NMS(Index = 17)]
        /* 0x1B0C */ public float TurretAITargetingDistanceFactor;
        [NMS(Index = 21)]
        /* 0x1B10 */ public float TurretAITargetingFocusPlayerFactor;
        [NMS(Index = 20)]
        /* 0x1B14 */ public float TurretAITargetingLastHitFactor;
        [NMS(Index = 18)]
        /* 0x1B18 */ public float TurretAITargetingPitchAngleFactor;
        [NMS(Index = 19)]
        /* 0x1B1C */ public float TurretAITargetingYawAngleFactor;
        [NMS(Index = 544)]
        /* 0x1B20 */ public float UndergroundTorchFoV;
        [NMS(Index = 545)]
        /* 0x1B24 */ public float UndergroundTorchFoVFar;
        [NMS(Index = 546)]
        /* 0x1B28 */ public float UndergroundTorchStrength;
        [NMS(Index = 547)]
        /* 0x1B2C */ public float UndergroundTorchStrengthFar;
        [NMS(Index = 74)]
        /* 0x1B30 */ public float UnderwaterLightningDamageDistanceMultiplier;
        [NMS(Index = 94)]
        /* 0x1B34 */ public float VehicleAllIconScanTime;
        [NMS(Index = 662)]
        /* 0x1B38 */ public int VehicleInventoryMinHeightMax;
        [NMS(Index = 661)]
        /* 0x1B3C */ public int VehicleInventoryMinWidthMax;
        [NMS(Index = 614)]
        /* 0x1B40 */ public float ViciousSentinelProbability;
        [NMS(Index = 615)]
        /* 0x1B44 */ public float ViciousStormProbability;
        [NMS(Index = 616)]
        /* 0x1B48 */ public float ViciousWeatherProbability;
        [NMS(Index = 381)]
        /* 0x1B4C */ public float VoxelAsteroidResourceChance;
        [NMS(Index = 292)]
        /* 0x1B50 */ public int WarpsBetweenBattles;
        [NMS(Index = 590)]
        /* 0x1B54 */ public int WarpsBetweenMiniStation;
        [NMS(Index = 337)]
        /* 0x1B58 */ public float WaterLandingDamageMultiplier;
        [NMS(Index = 375)]
        /* 0x1B5C */ public float WaypointScanTime;
        [NMS(Index = 664)]
        /* 0x1B60 */ public int WeaponInventoryMinHeightMax;
        [NMS(Index = 663)]
        /* 0x1B64 */ public int WeaponInventoryMinWidthMax;
        [NMS(Index = 77)]
        /* 0x1B68 */ public float WeatherHazardGiftLifeTime;
        [NMS(Index = 76)]
        /* 0x1B6C */ public float WeatherHazardGiftMaxDistance;
        [NMS(Index = 412)]
        /* 0x1B70 */ public float ZoomFindBuildingRange;
        [NMS(Index = 395)]
        /* 0x1B74 */ public NMSString0x20 DepotResource;
        [NMS(Index = 394)]
        /* 0x1B94 */ public NMSString0x20 RobotResource;
        [NMS(Index = 192)]
        /* 0x1BB4 */ public bool AllowBinocularMarker;
        [NMS(Index = 191)]
        /* 0x1BB5 */ public bool AllowDeconstruct;
        [NMS(Index = 161)]
        /* 0x1BB6 */ public bool AllowSpaceScanEvents;
        [NMS(Index = 207)]
        /* 0x1BB7 */ public TkCurveType AtmosphereEntryCurve;
        [NMS(Index = 461)]
        /* 0x1BB8 */ public bool Autolevel;
        [NMS(Index = 215)]
        /* 0x1BB9 */ public bool BinocsDisplayUnknownCreatures;
        [NMS(Index = 222)]
        /* 0x1BBA */ public TkCurveType BinocularScanTargetHeightCurve;
        [NMS(Index = 162)]
        /* 0x1BBB */ public bool CanMoveTechnology;
        [NMS(Index = 603)]
        /* 0x1BBC */ public bool ChangePricesLocally;
        [NMS(Index = 532)]
        /* 0x1BBD */ public bool DebugDrawTriggerBoxes;
        [NMS(Index = 33)]
        /* 0x1BBE */ public bool DebugPrintShootables;
        [NMS(Index = 443)]
        /* 0x1BBF */ public bool DebugScanForceBuilding;
        [NMS(Index = 190)]
        /* 0x1BC0 */ public bool DisableAnomalyAmbientSpawn;
        [NMS(Index = 598)]
        /* 0x1BC1 */ public bool DisableBasePowerHUDOverlay;
        [NMS(Index = 158)]
        /* 0x1BC2 */ public bool DisableGalaxyMapInQuickMenu;
        [NMS(Index = 159)]
        /* 0x1BC3 */ public bool DisableNexusInQuickMenu;
        [NMS(Index = 3)]
        /* 0x1BC4 */ public bool DoShipBuilderInteractionBuildEffect;
        [NMS(Index = 6)]
        /* 0x1BC5 */ public bool DoShipBuilderInteractionBuildEffectOutward;
        [NMS(Index = 195)]
        /* 0x1BC6 */ public bool EnableShootHitEffect;
        [NMS(Index = 36)]
        /* 0x1BC7 */ public bool EnableTechPackaging;
        [NMS(Index = 160)]
        /* 0x1BC8 */ public bool EnableTeleporters;
        [NMS(Index = 193)]
        /* 0x1BC9 */ public bool EveryMaintenanceIsBroken;
        [NMS(Index = 336)]
        /* 0x1BCA */ public bool FailToFindBuildings;
        [NMS(Index = 189)]
        /* 0x1BCB */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        [NMS(Index = 475)]
        /* 0x1BCC */ public bool HUDUpdateFromData;
        [NMS(Index = 188)]
        /* 0x1BCD */ public bool InstallTechWithInteraction;
        [NMS(Index = 268)]
        /* 0x1BCE */ public bool InteractionOverride;
        [NMS(Index = 599)]
        /* 0x1BCF */ public bool KeepAttackingMaxWantedLevel;
        [NMS(Index = 125)]
        /* 0x1BD0 */ public bool MissionSurveySuggestSurveyForNearScannables;
        [NMS(Index = 177)]
        /* 0x1BD1 */ public TkCurveType OverheatColourCurve;
        [NMS(Index = 176)]
        /* 0x1BD2 */ public TkCurveType OverheatColourCurveShip;
        [NMS(Index = 172)]
        /* 0x1BD3 */ public TkCurveType OverheatCurve;
        [NMS(Index = 517)]
        /* 0x1BD4 */ public TkCurveType PainCurve;
        [NMS(Index = 493)]
        /* 0x1BD5 */ public bool PlayHitEffectsOnZeroDamage;
        [NMS(Index = 8)]
        /* 0x1BD6 */ public bool RewardInventoryClassItemFromShipSalvage;
        [NMS(Index = 23)]
        /* 0x1BD7 */ public bool ScanToRevealIgnoreRequirements;
        [NMS(Index = 24)]
        /* 0x1BD8 */ public bool ScanToRevealNPCsAlwaysTriggersCameraEvent;
        [NMS(Index = 447)]
        /* 0x1BD9 */ public TkCurveType ShipScanCurve;
        [NMS(Index = 604)]
        /* 0x1BDA */ public bool ShowPriceMarkupsAsPercentages;
        [NMS(Index = 194)]
        /* 0x1BDB */ public bool SpawnResourceBlobsOnPartDelete;
        [NMS(Index = 32)]
        /* 0x1BDC */ public bool TechMustBeInTechInventory;
        [NMS(Index = 560)]
        /* 0x1BDD */ public bool TorchDisabledInTheDay;
        [NMS(Index = 651)]
        /* 0x1BDE */ public bool UseCustomSaveDirectory;
        [NMS(Index = 442)]
        /* 0x1BDF */ public bool UseDebugScan;
        [NMS(Index = 600)]
        /* 0x1BE0 */ public bool UseMultiplierBonus;
        [NMS(Index = 173)]
        /* 0x1BE1 */ public bool UseOverheatColour;
        [NMS(Index = 31)]
        /* 0x1BE2 */ public bool UseSecondaryBiomeSubstances;
        [NMS(Index = 602)]
        /* 0x1BE3 */ public bool UseTradingCostTable;
    }
}
