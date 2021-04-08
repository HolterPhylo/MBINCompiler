﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x148, GUID = 0x83595753419F7B77)]
    public class GcAudioGlobals : NMSTemplate
    {
        /* 0x000 */ public GcAudioNPCDoppler NPCEngines;
        /* 0x03C */ public GcAudio3PointDopplerData DroneDoppler;
        /* 0x048 */ public float AuxSendCaveRampDistance;
        /* 0x04C */ public float AuxSendOutdoorsRampDistance;
        /* 0x050 */ public float LadderStepDistance;
        /* 0x054 */ public float ShorelineSenseStartUp;
        /* 0x058 */ public float ShorelineSenseProbeDist;
        /* 0x05C */ public float ShorelineSenseBlend;
        /* 0x060 */ public float ShorelineSenseBaseU;
        /* 0x064 */ public Vector2f ShorelineSenseUJitter;
        /* 0x06C */ public Vector2f ShorelineSenseVJitter;
        /* 0x074 */ public Vector2f ShorelineSenseRadius;
        /* 0x07C */ public float ShorelineValidityRate;
        /* 0x080 */ public float ShorelineRTPCSmoothRate;
        /* 0x084 */ public float ShorelineObstructionSmoothRate;
        /* 0x088 */ public float ShorelineObstructionMul;
        /* 0x08C */ public float DroneDopplerExtentsFactor;
        /* 0x090 */ public float DistanceReportMin;
        /* 0x094 */ public float DistanceReportMax;
        /* 0x098 */ public float DistanceSquishScaleToListener;
        /* 0x09C */ public float DistanceSquishMaxTravel;
        /* 0x0A0 */ public int ByteBeatMaxGeneratingAudio;
        /* 0x0A4 */ public float ByteBeatCrossfadeTime;
        /* 0x0A8 */ public float ByteBeatVisualisationTime;
        /* 0x0AC */ public int ByteBeatVisualisationMode;
        /* 0x0B0 */ public int ByteBeatVisualisationPixelStep;
        /* 0x0B4 */ public int ByteBeatVisualisationMiniPixelStep;
        /* 0x0B8 */ public int ByteBeatNonSilentAttempts;
        /* 0x0BC */ public float ByteBeatNonSilentTime;
        /* 0x0C0 */ public float ByteBeatNonSilentAvgInterpSpeed;
        /* 0x0C4 */ public float ByteBeatNonSilentSDCutoff;
        /* 0x0C8 */ public float ByteBeatBeginAtTonicProbability;
        /* 0x0CC */ public float ByteBeatChangeNoteProbability;
        /* 0x0D0 */ public float ByteBeatSkipNoteProbability;
        /* 0x0D8 */ public List<float> ByteBeatScaleDegreeProbability;
        /* 0x0E8 */ public float ByteBeatSpeakerVolumeInterSpeed;
        /* 0x0EC */ public Vector2f ByteBeatSpeakerMaxAmplitude;
        /* 0x0F4 */ public Vector2f ByteBeatSpeakerMinFrequency;
        /* 0x0FC */ public Vector2f ByteBeatSpeakerMaxFrequency;
        /* 0x104 */ public float AtlasStationActiveDistance;
        /* 0x108 */ public float MiniStationActiveDistance;
        /* 0x10C */ public float PlayerDepthUnderwaterMax;
        /* 0x110 */ public float PlayerLowerOffsetEmitterMul;
        /* 0x114 */ public bool ObstructionEnabled;
        /* 0x118 */ public float ObstructionSmoothTime;
        /* 0x11C */ public float ObstructionValueMax;
        /* 0x120 */ public float ObstructionAuxControlWhenVisible;
        /* 0x124 */ public float ObstructionAuxControlWhenHidden;
        /* 0x128 */ public bool PulseMusicEnabled;
        /* 0x129 */ public bool LockListenerMatrix;
        /* 0x12A */ public bool EnableVRSpecificAudio;
        /* 0x12C */ public float ArmFoleySpeedMultiplier;
        /* 0x130 */ public float ArmWhooshFoleyValueTrigger;
        /* 0x134 */ public float MinSecondsBetweenArmWhooshes;
        /* 0x138 */ public Vector2f CommsChatterFalloffFreighers;
        /* 0x140 */ public Vector2f CommsChatterFalloffShips;
    }
}
