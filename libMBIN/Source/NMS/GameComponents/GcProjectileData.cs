using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF02FF914C4DB7B62, NameHash = 0x1119BAC1)]
    public class GcProjectileData : NMSTemplate
    {
        [NMS(Index = 43)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 52)]
        /* 0x010 */ public Vector3f ImpactOffset;
        [NMS(Index = 45)]
        /* 0x020 */ public Colour LightColour;
        [NMS(Index = 1)]
        /* 0x030 */ public GcResourceElement Model;
        [NMS(Index = 53)]
        /* 0x078 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        [NMS(Index = 49)]
        /* 0x088 */ public NMSString0x10 CriticalImpact;
        [NMS(Index = 48)]
        /* 0x098 */ public NMSString0x10 DefaultImpact;
        [NMS(Index = 0)]
        /* 0x0A8 */ public NMSString0x10 Id;
        [NMS(Index = 51)]
        /* 0x0B8 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Index = 26)]
        /* 0x0C8 */ public NMSString0x10 PlayerDamage;
        [NMS(Index = 38)]
        /* 0x0D8 */ public GcProjectileLineData CustomBulletData;
        // size: 0x8
        [Flags]
        public enum BehaviourFlagsEnum : uint {
            None = 0x0,
            DestroyTerrain = 0x1,
            DestroyAsteroids = 0x2,
            GatherResources = 0x4,
            Homing = 0x8,
            HomingLaser = 0x10,
            ScareCreatures = 0x20,
            ExplosionForce = 0x40,
        }
        [NMS(Index = 46)]
        /* 0x100 */ public BehaviourFlagsEnum BehaviourFlags;
        [NMS(Index = 23)]
        /* 0x104 */ public float BounceDamping;
        [NMS(Index = 24)]
        /* 0x108 */ public float BounceFinalStopTime;
        [NMS(Index = 22)]
        /* 0x10C */ public float BounceMaxSpeed;
        [NMS(Index = 10)]
        /* 0x110 */ public float CapsuleHeight;
        [NMS(Index = 4)]
        /* 0x114 */ public GcAudioWwiseEvents ChargedFireAudioEvent;
        // size: 0x4
        public enum ClassEnum : uint {
            Player,
            PlayerShip,
            Ship,
            Robot,
        }
        [NMS(Index = 47)]
        /* 0x118 */ public ClassEnum Class;
        [NMS(Index = 27)]
        /* 0x11C */ public float CriticalHitModifier;
        [NMS(Index = 40)]
        /* 0x120 */ public float DamageImpactMergeTime;
        [NMS(Index = 42)]
        /* 0x124 */ public float DamageImpactMinDistance;
        [NMS(Index = 41)]
        /* 0x128 */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 20)]
        /* 0x12C */ public GcDamageType DamageType;
        [NMS(Index = 21)]
        /* 0x130 */ public int DefaultBounces;
        [NMS(Index = 18)]
        /* 0x134 */ public int DefaultDamage;
        [NMS(Index = 11)]
        /* 0x138 */ public float DefaultSpeed;
        [NMS(Index = 17)]
        /* 0x13C */ public float DroneImpulse;
        [NMS(Index = 19)]
        /* 0x140 */ public float ExtraPlayerDamage;
        [NMS(Index = 3)]
        /* 0x144 */ public GcAudioWwiseEvents FireAudioEvent;
        [NMS(Index = 12)]
        /* 0x148 */ public float Gravity;
        [NMS(Index = 29)]
        /* 0x14C */ public float HomingDelay;
        [NMS(Index = 30)]
        /* 0x150 */ public float HomingDelayAcceleration;
        [NMS(Index = 31)]
        /* 0x154 */ public float HomingDuration;
        [NMS(Index = 13)]
        /* 0x158 */ public float Life;
        [NMS(Index = 32)]
        /* 0x15C */ public float MaxHomingAcceleration;
        [NMS(Index = 33)]
        /* 0x160 */ public float MaxHomingTargetAngleLower;
        [NMS(Index = 35)]
        /* 0x164 */ public float MaxHomingTargetAngleLowerDistance;
        [NMS(Index = 34)]
        /* 0x168 */ public float MaxHomingTargetAngleUpper;
        [NMS(Index = 36)]
        /* 0x16C */ public float MaxHomingTargetAngleUpperDistance;
        [NMS(Index = 14)]
        /* 0x170 */ public float Offset;
        [NMS(Index = 5)]
        /* 0x174 */ public GcAudioWwiseEvents OverheatAudioEvent;
        [NMS(Index = 16)]
        /* 0x178 */ public float PhysicsPush;
        [NMS(Index = 28)]
        /* 0x17C */ public float PiercingDamagePercentage;
        [NMS(Index = 9)]
        /* 0x180 */ public float Radius;
        [NMS(Index = 15)]
        /* 0x184 */ public float RagdollPush;
        [NMS(Index = 6)]
        /* 0x188 */ public float Scale;
        [NMS(Index = 8)]
        /* 0x18C */ public bool ApplyCombatLevelMultipliers;
        [NMS(Index = 25)]
        /* 0x18D */ public bool HitOnBounce;
        [NMS(Index = 7)]
        /* 0x18E */ public bool IsAutonomous;
        [NMS(Index = 44)]
        /* 0x18F */ public bool OverrideLightColour;
        [NMS(Index = 50)]
        /* 0x190 */ public bool ShootableCanOverrideImpact;
        [NMS(Index = 37)]
        /* 0x191 */ public bool UseCustomBulletData;
        [NMS(Index = 39)]
        /* 0x192 */ public bool UseDamageNumberData;
        [NMS(Index = 2)]
        /* 0x193 */ public bool UsePersistentAudio;
    }
}
