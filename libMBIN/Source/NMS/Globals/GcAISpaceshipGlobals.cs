﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x2F1219C1CF4D69F8)]
    public class GcAISpaceshipGlobals : NMSTemplate
    {
        /* 0x00 */ public float Unknown0x0;
        /* 0x04 */ public bool TradersAttackPirates;
        /* 0x05 */ public bool TraderHailingEnabled;
        /* 0x06 */ public bool FreightersAlwaysAttackPlayer;
        /* 0x07 */ public bool GroundEffectEnabled;
        /* 0x08 */ public bool AtmosphereEffectEnabled;
        /* 0x09 */ public bool FillUpOutposts;
        /* 0x0C */ public float Unknown0xC;
        /* 0x10 */ public float Unknown0x10;
        /* 0x14 */ public float Unknown0x14;
        /* 0x18 */ public float DockingWaitDistance;
        /* 0x1C */ public int MaxNumActiveTraders;
        /* 0x20 */ public float MaxNumActiveTraderRadius;
        /* 0x24 */ public int MaxNumActivePolice;
        /* 0x28 */ public float MaxNumActivePoliceRadius;
        /* 0x2C */ public int MinAggroDamage;
        /* 0x30 */ public float TrailLandingFadeTime;
        /* 0x34 */ public float MinLaserFireTime;
        /* 0x38 */ public float ShipAlertPirateRange;
        /* 0x3C */ public float EscapeRollTime;
        /* 0x40 */ public float EscapeRollPlanet;
        /* 0x44 */ public float EscapeRoll;
        /* 0x48 */ public int CrashedShipMinNonBrokenSlots;
        /* 0x4C */ public float CrashedShipBrokenSlotChance;
        /* 0x50 */ public float CrashedShipBrokenTechChance;
        /* 0x54 */ public float CrashedShipRepairSlotCostIncreaseFactor;
        /* 0x58 */ public float CrashedShipGeneralCostDiscount;
        /* 0x5C */ public float CrashedShipTechSlotsCostDiscount;
        /* 0x60 */ public float PirateSpawnSpacing;
        /* 0x64 */ public float DistanceFlareMinDistance;
        /* 0x68 */ public float DistanceFlareRange;
        /* 0x6C */ public float DistanceFlareMinScale;
        /* 0x70 */ public float DistanceFlareMaxScale;
        /* 0x74 */ public float DistanceFlareMinSpeed;
        /* 0x78 */ public float DistanceFlareSpeedRange;
        /* 0x7C */ public float DistanceFlareFlickerFreq;
        /* 0x80 */ public float DistanceFlareFlickerAmp;
        /* 0x84 */ public bool AttackRepositionBoost;
        /* 0x85 */ public bool AttackShipsFollowLeader;
        /* 0x88 */ public float AttackTooCloseMinRelSpeed;
        /* 0x8C */ public float RewardLootOffset;
        /* 0x90 */ public float RewardLootOffsetSpeed;
        /* 0x94 */ public float RewardLootAngularSpeed;
        /* 0x98 */ public GcSpaceshipTravelData PirateTravel;
        /* 0xF8 */ public GcSpaceshipTravelData PoliceTravel;
        /* 0x158 */ public GcSpaceshipTravelData TraderAttackTravel;
        /* 0x1B8 */ public float AttackShipAvoidStartTime;
        /* 0x1BC */ public float AttackMinimumTimeBeforeTargetSwitch;
        /* 0x1C0 */ public GcShipAIAttackData Attack;
        /* 0x290 */ public float PirateExtraDamage;
        /* 0x294 */ public float ShieldCollisionRadiusMultiplier;
        /* 0x298 */ public float CollisionRayLengthMin;
        /* 0x29C */ public float CollisionRayLengthMax;
        /* 0x2A0 */ public GcSpaceshipTravelData OutpostLanding;
        /* 0x300 */ public float OutpostLandingNoiseFreq;
        /* 0x304 */ public float OutpostLandingNoiseAmp;
        /* 0x308 */ public float OutpostLandingNoiseOffset;
        /* 0x30C */ public float OutpostDockUpAlignMaxAngleFirstPerson;
        /* 0x310 */ public float OutpostDockUpAlignMaxAngle;
        /* 0x314 */ public float OutpostDockMaxApproachSpeed;
        /* 0x318 */ public float OutpostDockOverspeedBrake;
        /* 0x31C */ public float OutpostDockGetToApproachForce;
        /* 0x320 */ public float OutpostDockGetToApproachBrakeForce;
        /* 0x324 */ public float OutpostDockGetToApproachExtraBrakeForce;
        /* 0x328 */ public float OutpostDockApproachSpeedForce;
        /* 0x32C */ public float OutpostDockApproachDistance;
        /* 0x330 */ public float OutpostDockApproachSpeedUpDamper;
        /* 0x334 */ public float OutpostDockAIGetToApproachForce;
        /* 0x338 */ public float OutpostDockAIGetToApproachBrakeForce;
        /* 0x33C */ public float OutpostDockAIApproachSpeedForce;
        /* 0x340 */ public float OutpostDockMaxForce;
        /* 0x344 */ public float OutpostDockMinTipLength;
        /* 0x348 */ public float OutpostDockMaxTipLength;
        /* 0x34C */ public float OutpostDockApproachUpAmount;
        /* 0x350 */ public float OutpostDockApproachRenderRadius;
        /* 0x354 */ public float OutpostDockApproachRenderFlickerOffset;
        /* 0x358 */ public float LandingTipAngle;
        /* 0x35C */ public float LandingLongTipAngle;
        /* 0x360 */ public Vector2f SpaceBattleSpawnAngle;
        /* 0x368 */ public Vector2f SpaceBattleSpawnPitch;
        /* 0x370 */ public Vector2f SpaceBattleSpawnOffset;
        /* 0x378 */ public Vector2f SpaceBattleSunHeightAngle;
        /* 0x380 */ public Vector2f SpaceBattleSunAroundAngle;
        [NMS(Size = 0x3)]
        /* 0x388 */ public Vector2f[] SpaceBattleSpawnRange;
        [NMS(Size = 0x3)]
        /* 0x3A0 */ public Vector2f[] SpaceBattlePirateRange;
        [NMS(Size = 0x3)]
        /* 0x3B8 */ public Vector2f[] SpaceBattleGuardsRange;
        /* 0x3D0 */ public float SpaceBattleGuardOffset;
        /* 0x3D4 */ public float SpaceBattleGuardUpOffset;
        /* 0x3D8 */ public float SpaceBattleInitialPirateUpOffset;
        /* 0x3DC */ public float SpaceBattleInitialPirateOffset;
        /* 0x3E0 */ public float SpaceBattleObstructionRadius;
        /* 0x3E4 */ public float SpaceBattleFlybyTime;
        /* 0x3E8 */ public float SpaceBattleLevel;
        /* 0x3EC */ public Vector2f ConeSpawnOffsetFactor;
        /* 0x3F4 */ public float ConeSpawnFlattenUp;
        /* 0x3F8 */ public float ConeSpawnFlattenDown;
        /* 0x3FC */ public bool FreighterAlertLights;
        /* 0x400 */ public float FreighterAlertLightCapitalSize;
        [NMS(Size = 0x80)]
        /* 0x404 */ public string LegacyHangarFilename;
        [NMS(Size = 0x80)]
        /* 0x484 */ public string HangarFilename;
        /* 0x504 */ public float PoliceFreighterWarpOutRange;
        /* 0x508 */ public float MissileRange;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x50C */ public byte[] Padding50C;
        /* 0x510 */ public Colour FreighterDoorColourActive;
        /* 0x520 */ public Colour FreighterDoorColourInactive;
        /* 0x530 */ public Colour AlertLightColour;
        /* 0x540 */ public TkHitCurveData FreighterLightHitCurve;
        /* 0x550 */ public float FreighterAlertLightTime;
        /* 0x554 */ public float FreighterAlertLightIntensity;
        /* 0x558 */ public float MaxNumTurretMissiles;
        /* 0x55C */ public float TurretShootPauseTime;
        /* 0x560 */ public float TurretDispersionAngle;
        /* 0x564 */ public float TurretMissileLaunchSpeed;
        /* 0x568 */ public float TurretMissileLaunchTime;
        /* 0x56C */ public float TurretMissileRange;
        /* 0x570 */ public float TurretOriginOffset;
        /* 0x574 */ public float TurretAlertLightIntensity;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x578 */ public byte[] Padding578;
        /* 0x580 */ public Vector4f TurretAlertLightOffset;
        /* 0x590 */ public bool DisableTradeRoutes;
        /* 0x594 */ public float AttackFreighterGetThereBoost;
        /* 0x598 */ public float AttackFreighterApproach;
        /* 0x59C */ public float AttackFreighterWingmanAlignMinDist;
        /* 0x5A0 */ public float AttackFreighterWingmanAlignRange;
        /* 0x5A4 */ public float AttackFreighterApproachDistance;
        /* 0x5A8 */ public float AttackFreighterAttackRunStartDistance;
        /* 0x5AC */ public float AttackFreighterBugOutDistance;
        /* 0x5B0 */ public float AttackFreighterButOutTurnUp;
        /* 0x5B4 */ public float AttackFreighterButOutSpeedUp;
        /* 0x5B8 */ public float AttackFreighterWingmanRadius;
        /* 0x5BC */ public float AttackFreighterWingmanOffset;
        /* 0x5C0 */ public float AttackFreighterWingmanLockAlign;
        /* 0x5C4 */ public float AttackFreighterWingmanLock;
        /* 0x5C8 */ public float AttackFreighterWingmanMaxForce;
        /* 0x5CC */ public float AttackFreighterAngle;
        /* 0x5D0 */ public float AttackFreighterRunOffset;
        /* 0x5D4 */ public float AttackFreighterWingmanStart;
        /* 0x5D8 */ public float PirateFreighterWarpOffset;
        /* 0x5DC */ public Vector2f PirateFreighterAttackRange;
        /* 0x5E4 */ public float MissileLaunchSpeed;
        /* 0x5E8 */ public float AttackAfterSpawnTime;
        /* 0x5EC */ public Vector2f FreighterMiniSpeeds;
        /* 0x5F4 */ public float AsteroidShootAngle;
        /* 0x5F8 */ public float TraderWantedTime;
        /* 0x5FC */ public float TraderRequestTime;
        /* 0x600 */ public float TraderPostCombatRequestTime;
        /* 0x604 */ public float TradingPostTraderRequestTime;
        /* 0x608 */ public float TradingPostTraderRange;
        /* 0x60C */ public float TradingPostTraderRangeSpace;
        /* 0x610 */ public float SpaceStationTraderRequestTime;
        /* 0x614 */ public float AbandonedSystemShipSpawnProbablity;
        /* 0x618 */ public int FlybyCloseOdds;
        /* 0x61C */ public float BountySpawnAngle;
        /* 0x620 */ public GcShipAIAttackData BountyAttack;
        /* 0x6F0 */ public float PoliceLaunchSpeed;
        /* 0x6F4 */ public float PoliceLaunchTime;
        /* 0x6F8 */ public float PolicePauseTime;
        /* 0x6FC */ public float PolicePauseTimeSpaceBattle;
        /* 0x700 */ public float PoliceEscapeTime;
        /* 0x704 */ public float PoliceEscapeMinTime;
        /* 0x708 */ public float PoliceStationWaveTimer;
        /* 0x70C */ public float PoliceStationEngageRange;
        /* 0x710 */ public int PoliceStationNumToLaunch;
        /* 0x714 */ public int TraderIgnoreHits;
        /* 0x718 */ public float PirateFreighterSpawnAttackAngle;
        /* 0x71C */ public float PirateFreighterSpawnAttackOffset;
        /* 0x720 */ public float PirateFreighterSpawnAttackSpread;
        /* 0x724 */ public float PirateSpawnAngle;
        /* 0x728 */ public float PirateBattleMaxTime;
        /* 0x72C */ public float PirateArriveTime;
        /* 0x730 */ public float PirateBattleStartSpeed;
        /* 0x734 */ public float PirateInterestTime;
        /* 0x738 */ public float PirateBattleInterestTime;
        /* 0x73C */ public float TraderArriveSpeed;
        /* 0x740 */ public float TraderArriveTime;
        /* 0x744 */ public float HeightTestSampleDistance;
        /* 0x748 */ public float HeightTestSampleTime;
        /* 0x74C */ public float OutpostToLandingDistance;
        /* 0x750 */ public bool FreightersSamePalette;
        /* 0x754 */ public float PlanetUpAlignTime;
        /* 0x758 */ public float CollisionReactionTime;
        /* 0x75C */ public float FreighterScale;
        /* 0x760 */ public bool PoliceSpawnEffect;
        /* 0x764 */ public int MaxNumFreighters;
        /* 0x768 */ public float ShipSpawnStationRadius;
        /* 0x76C */ public float ShipSpawnAnomalyRadius;
        /* 0x770 */ public float BattleSpawnStationMinDistance;
        /* 0x774 */ public float PoliceSpawnViewAngle;
        /* 0x778 */ public float PoliceEntranceStartTime;
        /* 0x77C */ public float PoliceEntranceProbe;
        /* 0x780 */ public float PoliceEntranceEscalateProbingTime;
        /* 0x784 */ public float PoliceEntranceEscalateIncomingTime;
        /* 0x788 */ public float PoliceArriveTime;
        /* 0x78C */ public float PoliceAbortRange;
        /* 0x790 */ public float PoliceWarnBeaconPulseTime;
        /* 0x794 */ public float TrailScaleMinDistance;
        /* 0x798 */ public float TrailScale;
        /* 0x79C */ public float TrailScaleRange;
        /* 0x7A0 */ public float TrailScaleMaxScale;
        /* 0x7A4 */ public float TrailScaleFreighterMaxScale;
        /* 0x7A8 */ public TkCurveType TrailScaleCurve;
        /* 0x7AC */ public float TradeRouteSeekOutpostRange;
        /* 0x7B0 */ public float TradeRouteFollowOffset;
        [NMS(Size = 0x100)]
        /* 0x7B4 */ public string TradeRouteIcon;
        /* 0x8B4 */ public float TradeRouteSpawnDistance;
        /* 0x8B8 */ public float TradeRouteTrailDrawDistance;
        /* 0x8BC */ public float TradeRouteTrailFadeTime;
        /* 0x8C0 */ public float TradeRouteTrailTimeOffset;
        /* 0x8C4 */ public float TradeRouteStationRadius;
        /* 0x8C8 */ public float TradeRouteSpeed;
        /* 0x8CC */ public float TradeRouteSlowRange;
        /* 0x8D0 */ public float TradeRouteSlowSpeed;
        /* 0x8D4 */ public int TradeRouteDivisions;
        /* 0x8D8 */ public float TradeRouteFlickerFreq;
        /* 0x8DC */ public float TradeRouteFlickerAmp;
        /* 0x8E0 */ public int TradeRouteMaxNum;
        [NMS(Size = 0x5)]
        /* 0x8F0 */ public Colour[] TradeRouteColours;
        /* 0x940 */ public bool EnableLoot;
        /* 0x944 */ public float LaserHitOffset;
        /* 0x948 */ public float DirectionBrakeThresholdSq;
        /* 0x94C */ public int PoliceNumPerTarget;
        /* 0x950 */ public Vector2f PoliceSideOffset;
        /* 0x958 */ public Vector2f PoliceUpOffset;
        /* 0x960 */ public float WitnessHearingRange;
        /* 0x964 */ public float WitnessSightRange;
        /* 0x968 */ public float WitnessSightAngle;
        /* 0x96C */ public float FreighterImpactScale;
        /* 0x970 */ public float FreighterAlertThreshold;
        /* 0x974 */ public float Unknown0x974;
        /* 0x978 */ public float FreighterAttackAlertThreshold;
        /* 0x97C */ public float FreighterAlertTimeOutRate;
        /* 0x980 */ public float FreighterAlertTimeOutMinTime;
        /* 0x984 */ public float FreighterShipLaunchSpeed;
        /* 0x988 */ public float FreighterLaunchTime;
        /* 0x98C */ public float FreighterLaunchStartTime;
        /* 0x990 */ public bool FreighterIgnorePlayer;
        /* 0x994 */ public int FreighterNotifySquadAlertLevel;
        /* 0x998 */ public int FreighterMaxNumLaunchedShips;
        /* 0x99C */ public float FreighterSpawnMargin;
        /* 0x9A0 */ public float FreighterSpawnRadius;
        /* 0x9A4 */ public float FreighterSpawnRate;
        /* 0x9A8 */ public float FreighterSpawnViewAngle;
        /* 0x9AC */ public float FreighterSpawnVisibleFreightersDistance;
        /* 0x9B0 */ public float FrigateSpawnMargin;
        /* 0x9B4 */ public float EngineFlareAccelMin;
        /* 0x9B8 */ public float EngineFlareAccelMax;
        /* 0x9BC */ public float EngineFlareSizeMin;
        /* 0x9C0 */ public float EngineFlareSizeMax;
        /* 0x9C4 */ public float EngineFlareVibrateAmp;
        /* 0x9C8 */ public float EngineFlareVibrateFreq;
        /* 0x9CC */ public float EngineFlareOffset;
        /* 0x9D0 */ public float EngineFireSize;
        /* 0x9D4 */ public float PitchFlip;
        /* 0x9D8 */ public float AttackAimTime;
        /* 0x9DC */ public float AttackRunSlowdown;
        /* 0x9E0 */ public float PiratePlayerAttackRange;
        /* 0x9E4 */ public float MoveHeightAdjust;
        /* 0x9E8 */ public float MoveAvoidRange;
        /* 0x9EC */ public int MoveHeightNumSamples;
        /* 0x9F0 */ public float MoveHeightSampleSectionSize;
        /* 0x9F4 */ public float MoveHeightCheckTime;
        /* 0x9F8 */ public float TurretRange;
        /* 0x9FC */ public float TurretProjectileRange;
        /* 0xA00 */ public float TurretAngle;
        /* 0xA04 */ public float TurretMaxDownAngle;
        /* 0xA08 */ public float TurretLaserShootTime;
        /* 0xA0C */ public float TurretLaserActiveTime;
        /* 0xA10 */ public float TurretLaserLength;
        /* 0xA14 */ public float TurretRandomOffset;
        /* 0xA18 */ public float TurretRandomAIShipOffset;
        /* 0xA1C */ public float TurretLaserAbortDistance;
        /* 0xA20 */ public float TurretLaserMoveSpeed;
        /* 0xA24 */ public float TurretSlerpFactor;
        /* 0xA28 */ public float PoliceLaunchDistance;
        /* 0xA2C */ public float Scaler;
        /* 0xA30 */ public float ScaleTime;
        /* 0xA34 */ public float ScalerMinDist;
        /* 0xA38 */ public float ScalerMaxDist;
        /* 0xA3C */ public float ScaleHeightMin;
        /* 0xA40 */ public float ScaleHeightMax;
        /* 0xA44 */ public bool ScaleDisabledWhenOnFreighter;
        /* 0xA48 */ public float WarpInPlayerLocatorTime;
        /* 0xA4C */ public float WarpInPlayerLocatorMinOffset;
        /* 0xA50 */ public float WarpInTime;
        /* 0xA54 */ public float WarpFadeInTime;
        /* 0xA58 */ public float WarpInTimeFreighter;
        /* 0xA5C */ public TkCurveType WarpInCurve;
        /* 0xA60 */ public float WarpInVariance;
        /* 0xA64 */ public float WarpInDistance;
        /* 0xA68 */ public float WarpInPostSpeed;
        /* 0xA6C */ public float WarpInPostSpeedFreighter;
        /* 0xA70 */ public float WarpInAudioFXDelay;
        /* 0xA74 */ public float WarpOutDistance;
        /* 0xA78 */ public float PirateFlybyLength;
        /* 0xA7C */ public float FlybyLength;
        /* 0xA80 */ public float FlybyHeight;
        /* 0xA84 */ public float FlybyOffset;
        /* 0xA88 */ public GcProjectileLineData ShipBullet;
        /* 0xAB0 */ public GcSpaceshipTravelData TraderTravel;
        /* 0xB10 */ public float WingmanLockDistance;
        /* 0xB14 */ public float WingmanLockBetweenTime;
        /* 0xB18 */ public float WingmanLockArriveTime;
        /* 0xB1C */ public float WingmanMinHeight;
        /* 0xB20 */ public float WingmanHeightAdjust;
        /* 0xB24 */ public float WingmanStartTime;
        /* 0xB28 */ public float WingmanOffsetStart;
        /* 0xB2C */ public float WingmanOffset;
        /* 0xB30 */ public float WingmanSideOffset;
        /* 0xB34 */ public float WingmanRotate;
        /* 0xB38 */ public float WingmanAtTime;
        /* 0xB3C */ public float WingmanAtTimeBack;
        /* 0xB40 */ public float WingmanPerpTime;
        /* 0xB44 */ public float WingmanVelocityBand;
        /* 0xB48 */ public float WingmanVelocityBandForce;
        /* 0xB4C */ public float TraderAtTime;
        /* 0xB50 */ public float TraderAtTimeBack;
        /* 0xB54 */ public float TraderPerpTime;
        /* 0xB58 */ public float TraderVelocityBand;
        /* 0xB5C */ public float TraderVelocityBandForce;
        /* 0xB60 */ public float WingmanAlign;
        /* 0xB64 */ public float WarpSpeed;
        /* 0xB68 */ public float WarpForce;
        /* 0xB6C */ public float TrailSpeedFadeMinSpeed;
        /* 0xB70 */ public float TrailSpeedFadeFalloff;
        /* 0xB74 */ public float DockingLandingTime;
        /* 0xB78 */ public float DockingLandingTimeDirectional;
        /* 0xB7C */ public float DockingSpringTime;
        /* 0xB80 */ public float DockingLandingBounceTime;
        /* 0xB84 */ public float DockingLandingBounceHeight;
        /* 0xB88 */ public float DockingRotateStartTime;
        /* 0xB8C */ public float DockingRotateSpeed;
        /* 0xB90 */ public float DockWaitMinTime;
        /* 0xB94 */ public float DockWaitMaxTime;
        /* 0xB98 */ public float TakeOffHoverPointReachedDistance;
        /* 0xB9C */ public float TakeOffExitHeightOffset;
        /* 0xBA0 */ public float TakeOffExtraAIHeight;
        /* 0xBA4 */ public float LandingManuevreTime;
        /* 0xBA8 */ public float LandingManeuvreAlignTime;
        /* 0xBAC */ public float LandingHoverPointReachedDistance;
        /* 0xBB0 */ public float LandingDirectionalHoverPointReachedDistance;
        /* 0xBB4 */ public float AtmosphereTerminalSpeed;
        /* 0xBB8 */ public float CircleApproachDistance;
        /* 0xBBC */ public float TravelMinBoostTime;
        /* 0xBC0 */ public float GroundCircleHeight;
        /* 0xBC4 */ public float GroundCircleHeightMax;
        /* 0xBC8 */ public float OrbitHeight;
        /* 0xBCC */ public float AtmosphereEffectMin;
        /* 0xBD0 */ public float AtmosphereEffectMax;
        /* 0xBD4 */ public float MaxTorque;
        /* 0xBD8 */ public float ShipAngularFactor;
        /* 0xBDC */ public float RollAmount;
        /* 0xBE0 */ public float RollMinTurnAngle;
        /* 0xBE4 */ public float FinalDeathExplosionScale;
        /* 0xBE8 */ public float FinalDeathExplosionTime;
        /* 0xBEC */ public GcShipAIDeathData Death;
        /* 0xC08 */ public GcShipAIAttackData AttackPlanet;
        /* 0xCD8 */ public GcShipAIAttackData TraderAttack;
        /* 0xDA8 */ public GcShipAIPlanetPatrolData WingmanPathData;
    }
}
