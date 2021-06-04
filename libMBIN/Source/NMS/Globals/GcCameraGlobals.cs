using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x3660, GUID = 0x7EEB800C70ED478F, NameHash = 0xA826BCA4D4C3DFE3)]
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        /* 0x00B0 */ public List<GcCameraFollowSettings> Cameras;
        /* 0x00C0 */ public GcCameraFollowSettings VehicleCamHmd;
        /* 0x01C0 */ public GcCameraFollowSettings VehicleCam;
        /* 0x02C0 */ public float SpecialVehicleMouseRecentreTime;
        /* 0x02C4 */ public float SpecialVehicleMouseRecentreWeaponTime;
        /* 0x02C8 */ public float HmdEyeLookAngle;
        /* 0x02CC */ public float HmdEyeExtraTurnAngle;
        /* 0x02D0 */ public float HmdEyeExtraTurnMinHeadAngle;
        /* 0x02D4 */ public float HmdEyeExtraTurnHeadAngleRange;
        /* 0x02D8 */ public bool PauseThirdPersonCamInPause;
        /* 0x02DC */ public float DebugPlanetJumpNearHeight;
        /* 0x02E0 */ public float DebugPlanetJumpFarHeight;
        /* 0x02E4 */ public float TogglePerspectiveBlendTime;
        /* 0x02E8 */ public bool LockFollowSpring;
        /* 0x02EC */ public float UnderwaterCameraSurfaceOffset;
        /* 0x02F0 */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x02F4 */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x02F8 */ public float VehicleExitFlashTime;
        /* 0x02FC */ public float VehicleExitFlashStrength;
        /* 0x0300 */ public Colour VehicleExitFlashColour;
        /* 0x0310 */ public float VehicleFirstToThirdExitOffsetY;
        /* 0x0314 */ public float VehicleFirstToThirdExitOffsetZ;
        /* 0x0318 */ public float ShipThirdPersonBlendTime;
        /* 0x031C */ public float ShipThirdPersonBlendWithOffsetTime;
        /* 0x0320 */ public float ShipThirdPersonBlendOffset;
        /* 0x0324 */ public float ShipThirdPersonBlendOutTime;
        /* 0x0328 */ public float ShipThirdPersonBlendOutOffset;
        /* 0x032C */ public float ShipFirstPersonBlendTime;
        /* 0x0330 */ public float ShipFirstPersonBlendOffset;
        /* 0x0334 */ public float ShipThirdPersonEnterBlendTime;
        /* 0x0338 */ public float ShipThirdPersonEnterBlendOffset;
        /* 0x033C */ public float FlybyMinRange;
        /* 0x0340 */ public float FlybyRange;
        /* 0x0344 */ public float FlybyMinRelativeSpeed;
        /* 0x0348 */ public float FlybyRelativeSpeedRange;
        /* 0x034C */ public float FlybyInVehicleDamper;
        /* 0x0350 */ public float BinocularFlashTime;
        /* 0x0354 */ public float BinocularFlashStrength;
        /* 0x0358 */ public float MinFirstPersonCameraPitch;
        /* 0x035C */ public float MaxFirstPersonCameraPitch;
        /* 0x0360 */ public float MaxCreatureRidingYaw;
        /* 0x0364 */ public float ThirdPersonRotationBackAdjustAngleMin;
        /* 0x0368 */ public float ThirdPersonClosePitch;
        /* 0x036C */ public float ThirdPersonCloseDistance;
        /* 0x0370 */ public float ThirdPersonCloseDistanceX;
        /* 0x0374 */ public float ThirdPersonRotationBackAdjustAngleMax;
        /* 0x0378 */ public float ThirdPersonUphillAdjustSpringTimeMin;
        /* 0x037C */ public float ThirdPersonUphillAdjustSpringTimeMax;
        /* 0x0380 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        /* 0x0384 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        /* 0x0388 */ public float ThirdPersonDownhillAdjustMinAngle;
        /* 0x038C */ public float ThirdPersonDownhillAdjustMaxAngle;
        /* 0x0390 */ public float ThirdPersonUphillAdjustMinAngle;
        /* 0x0394 */ public float ThirdPersonUphillAdjustMaxAngle;
        /* 0x0398 */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        /* 0x039C */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        /* 0x03A0 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        /* 0x03A4 */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        /* 0x03A8 */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        /* 0x03AC */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        /* 0x03B0 */ public float VehicleThirdPersonShootOffsetReturnTime;
        /* 0x03B4 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMSDescription("Camera settings for idling/walking player in outdoors")]
        /* 0x03B8 */ public GcCameraFollowSettings CharacterUnarmedCam;
        [NMSDescription("Camera settings for when the player is running")]
        /* 0x04B8 */ public GcCameraFollowSettings CharacterRunCam;
        [NMSDescription("Camera settings for when the player is using weapons")]
        /* 0x05B8 */ public GcCameraFollowSettings CharacterCombatCam;
        [NMSDescription("Camera settings for idling/walking player in indoors")]
        /* 0x06B8 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x07B8 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        /* 0x08B8 */ public GcCameraFollowSettings CharacterAbandCam;
        /* 0x09B8 */ public GcCameraFollowSettings CharacterNexusCam;
        [NMSDescription("Camera settings for when the player uses the jetpack")]
        /* 0x0AB8 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x0BB8 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x0CB8 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        /* 0x0DB8 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        [NMSDescription("Camera settings for when the player is falling. This also includes when the player deactivates the jetpack in mid-air")]
        /* 0x0EB8 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x0FB8 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x10B8 */ public GcCameraFollowSettings CharacterSpaceCam;
        [NMSDescription("Camera settings for when the player is climbing or riding a slope")]
        /* 0x11B8 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        [NMSDescription("Camera settings for when the player is underwater")]
        /* 0x12B8 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x13B8 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        /* 0x14B8 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        /* 0x15B8 */ public GcCameraFollowSettings CharacterGrabbedCam;
        /* 0x16B8 */ public GcCameraFollowSettings CharacterSitCam;
        /* 0x17B8 */ public GcCameraFollowSettings CharacterRideCam;
        /* 0x18B8 */ public GcCameraFollowSettings CharacterRideCamMedium;
        /* 0x19B8 */ public GcCameraFollowSettings CharacterRideCamLarge;
        /* 0x1AB8 */ public GcCameraFollowSettings CharacterRideCamHuge;
        /* 0x1BB8 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1BBC */ public byte[] Padding1BBC;
        /* 0x1BC0 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x1CC0 */ public GcCameraFollowSettings HovercraftFollowCam;
        /* 0x1DC0 */ public GcCameraFollowSettings SubmarineFollowCam;
        /* 0x1EC0 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x1FC0 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        /* 0x20C0 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x21C0 */ public GcCameraFollowSettings MechFollowCam;
        /* 0x22C0 */ public GcCameraFollowSettings MechShootCam;
        /* 0x23C0 */ public GcCameraFollowSettings MechJetpackCam;
        /* 0x24C0 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x25C0 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x26C0 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x27C0 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x28C0 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x29C0 */ public GcCameraFollowSettings AlienShipFollowCam;
        /* 0x2AC0 */ public float FrontendModelCameraSpringTime;
        /* 0x2AC4 */ public float ModelViewFlashTime;
        /* 0x2AD0 */ public Vector3f ModelViewOffset;
        /* 0x2AE0 */ public Vector2f ModelViewFocusOffset;
        /* 0x2AF0 */ public Vector3f InteractionOffset;
        /* 0x2B00 */ public Vector3f InteractionOffsetExtraVR;
        /* 0x2B10 */ public Vector3f InteractionOffsetExtraVRSeated;
        /* 0x2B20 */ public Vector3f InteractionOffsetDefault;
        /* 0x2B30 */ public Vector3f InteractionOffsetGek;
        /* 0x2B40 */ public Vector3f InteractionShipFocusOffset;
        /* 0x2B50 */ public Vector3f InteractionHailingFocusOffset;
        /* 0x2B60 */ public float InteractionHeadHeightDefault;
        /* 0x2B64 */ public float InteractionHeadHeightGek;
        /* 0x2B68 */ public float InteractionHeadHeightVykeen;
        /* 0x2B6C */ public float InteractionPitchAdjustTime;
        /* 0x2B70 */ public float InteractionPitchAdjustStrength;
        /* 0x2B74 */ public float InteractionPitchAdjustDeadZone;
        /* 0x2B78 */ public float InteractionHeadPosHeightAdjust;
        /* 0x2B7C */ public float NPCTradeLateralShiftAmount;
        /* 0x2B80 */ public float NPCTradeLateralShiftTime;
        /* 0x2B84 */ public float DistanceForFleetInteraction;
        /* 0x2B88 */ public float DistanceForFrigateInteraction;
        /* 0x2B8C */ public float DistanceForFrigatePurchaseInteraction;
        /* 0x2B90 */ public Vector3f OffsetForFleetInteraction;
        /* 0x2BA0 */ public Vector3f OffsetForFrigateInteraction;
        /* 0x2BB0 */ public float FleetUIOrbitRate;
        /* 0x2BB4 */ public float FleetUIVerticalMotionDuration;
        /* 0x2BB8 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x2BBC */ public Vector2f PitchForFrigateInteraction;
        /* 0x2BC4 */ public Vector2f RotationForFrigateInteraction;
        /* 0x2BCC */ public float InteractionModeBlendTime;
        /* 0x2BD0 */ public float InteractionModeFocusCamBlend;
        /* 0x2BD4 */ public float InteractionModeFoV;
        /* 0x2BD8 */ public float MinInteractFocusAngle;
        /* 0x2BDC */ public float ModelViewInterpTime;
        /* 0x2BE0 */ public float ThirdPersonBlendInTime;
        /* 0x2BE4 */ public float ThirdPersonBlendOutTime;
        /* 0x2BE8 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x2BEC */ public float ThirdPersonOffsetSpringTime;
        /* 0x2BF0 */ public bool MaxBob;
        /* 0x2BF4 */ public float PhotoModeVelocitySmoothTime;
        [NMSDescription("Speed of the camera when photo mode is active")]
        /* 0x2BF8 */ public float PhotoModeMoveSpeed;
        [NMSDescription("Turning speed of the camera when photo mode is active")]
        /* 0x2BFC */ public float PhotoModeTurnSpeed;
        [NMSDescription("Boundary distance of the photo camera relative to the player on planet")]
        /* 0x2C00 */ public float PhotoModeMaxDistance;
        [NMSDescription("Boundary distance of the photo camera relative to the player in space")]
        /* 0x2C04 */ public float PhotoModeMaxDistanceSpace;
        /* 0x2C08 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x2C0C */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x2C10 */ public float PhotoModeCollisionRadius;
        /* 0x2C14 */ public float PhotoModeRollSpeed;
        /* 0x2C18 */ public float PhotoModeFlashDuration;
        /* 0x2C1C */ public float PhotoModeFlashIntensity;
        /* 0x2C20 */ public Vector3f PhotoModeShipOffset;
        /* 0x2C30 */ public Vector3f BuildingModeInitialOffset;
        /* 0x2C40 */ public float BuildingModeMaxDistance;
        /* 0x2C44 */ public float RunningFoVAdjust;
        /* 0x2C48 */ public float MeleeBoostedFoV;
        /* 0x2C4C */ public float MeleeFoV;
        /* 0x2C50 */ public float AerialViewDownDistance;
        /* 0x2C54 */ public float AerialViewPause;
        /* 0x2C58 */ public float AerialViewStartTime;
        /* 0x2C5C */ public float AerialViewBackTime;
        /* 0x2C60 */ public float AerialViewBlendTime;
        /* 0x2C64 */ public TkCurveType AerialViewCurve;
        /* 0x2C68 */ public GcCameraAerialViewData BeaconTransition;
        /* 0x2C98 */ public GcCameraAerialViewData SignalTransition;
        /* 0x2CC8 */ public GcCameraAerialViewData WaypointTransition;
        /* 0x2CF8 */ public GcCameraAerialViewData RadioTowerTransition;
        /* 0x2D28 */ public float ScreenshotHorizonHeight;
        /* 0x2D2C */ public float ScreenshotHorizonFaceFactor;
        /* 0x2D30 */ public float ScreenshotBendDownAmount;
        /* 0x2D34 */ public float ScreenshotRightDistance;
        /* 0x2D38 */ public float ScreenshotBackDistance;
        /* 0x2D3C */ public float ScreenshotInTime;
        /* 0x2D40 */ public float ScreenshotOutTime;
        /* 0x2D44 */ public float ShipCamSpringStrengthMin;
        /* 0x2D48 */ public float ShipCamSpringStrengthMax;
        /* 0x2D4C */ public float ShipCamTurn;
        /* 0x2D50 */ public float ShipCamPitch;
        /* 0x2D54 */ public float ShipCamPitchMod;
        /* 0x2D58 */ public float ShipCamLookInterp;
        /* 0x2D5C */ public float ShipCamMinReturnTime;
        /* 0x2D60 */ public float ShipCamReturnTime;
        /* 0x2D64 */ public float ShipCamMotionTurn;
        /* 0x2D68 */ public float ShipCamMotionPitch;
        /* 0x2D6C */ public float ShipCamMotionPitchMod;
        /* 0x2D70 */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x2D74 */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x2D78 */ public float ShipCamMotionInterp;
        /* 0x2D7C */ public float ShipCamRollAmountMin;
        /* 0x2D80 */ public float ShipCamRollAmountMax;
        /* 0x2D84 */ public float ShipCamRollSpeedScaler;
        /* 0x2D88 */ public float ShipCamAimFOV;
        /* 0x2D8C */ public float MouseSensitivity;
        /* 0x2D90 */ public float ModelViewRotateSpeed;
        /* 0x2D94 */ public float ModelViewMouseRotateSpeed;
        /* 0x2D98 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x2D9C */ public float ModelViewMouseMoveSpeed;
        /* 0x2DA0 */ public float ModelViewDistSpeed;
        /* 0x2DA4 */ public float ModelViewMinDist;
        /* 0x2DA8 */ public float ModelViewMaxDist;
        /* 0x2DAC */ public float ModelViewDefaultPitch;
        /* 0x2DB0 */ public float ModelViewDefaultYaw;
        /* 0x2DB4 */ public bool DebugMoveCam;
        /* 0x2DB8 */ public float DebugMoveCamSpeed;
        /* 0x2DBC */ public float DebugMoveCamHeight;
        /* 0x2DC0 */ public bool DebugAICam;
        /* 0x2DC4 */ public float DebugAICamUp;
        /* 0x2DC8 */ public float DebugAICamAt;
        /* 0x2DCC */ public float PainShakeTime;
        /* 0x2DD0 */ public float ShipShakeDamper;
        /* 0x2DD4 */ public float IndoorCamShakeDamper;
        /* 0x2DD8 */ public float FirstPersonSlerpAway;
        /* 0x2DDC */ public float FirstPersonSlerpTowards;
        /* 0x2DE0 */ public List<GcCameraShakeData> CameraShakeTable;
        /* 0x2DF0 */ public float BobAmountAbandFreighter;
        /* 0x2DF4 */ public float BobFactorAbandFreighter;
        /* 0x2DF8 */ public float BobAmount;
        /* 0x2DFC */ public float BobFactor;
        /* 0x2E00 */ public float BobFocus;
        /* 0x2E04 */ public float BobRollFactor;
        /* 0x2E08 */ public float BobRollAmount;
        /* 0x2E0C */ public float BobRollOffset;
        /* 0x2E10 */ public float BobFwdAmount;
        /* 0x2E14 */ public float CamSeed1;
        /* 0x2E18 */ public float CamSeed2;
        /* 0x2E1C */ public float CamWander1Phase;
        /* 0x2E20 */ public float CamWander2Phase;
        /* 0x2E24 */ public float CamWander1Amplitude;
        /* 0x2E28 */ public float CamWander2Amplitude;
        /* 0x2E2C */ public float DebugSpaceStationTeleportOffset;
        /* 0x2E30 */ public float DebugCameraSlowFactor;
        /* 0x2E34 */ public float DebugCameraFastFactor;
        /* 0x2E38 */ public float DebugCameraSpaceFastFactor;
        /* 0x2E3C */ public float DebugCameraHeightForAccelerateBegin;
        /* 0x2E40 */ public float DebugCameraSpeedAtPlanetThreshold;
        /* 0x2E44 */ public float DebugCameraHeightForAccelerateEnd;
        /* 0x2E48 */ public float DebugCameraMaxSpeed;
        /* 0x2E4C */ public float OffsetCamFOV;
        /* 0x2E50 */ public Vector3f OffsetCamOffset;
        /* 0x2E60 */ public Vector3f OffsetCamRotation;
        /* 0x2E70 */ public float ObjectFocusTime;
        /* 0x2E74 */ public float CharCamFocusHeight;
        /* 0x2E78 */ public float CharCamMaxDistance;
        /* 0x2E7C */ public float CharCamMinDistance;
        /* 0x2E80 */ public float CharCamHeight;
        /* 0x2E84 */ public float CharCamOffsetTime;
        /* 0x2E88 */ public float CharCamAutoDirStartTime;
        /* 0x2E8C */ public float CharCamLookOffset;
        /* 0x2E90 */ public float CharCamLookOffsetFactor;
        /* 0x2E94 */ public float CharCamDeflectSpeed;
        /* 0x2E98 */ public float CharCamMinSpeed;
        /* 0x2E9C */ public float CharCamRightStickX;
        /* 0x2EA0 */ public float CharCamRightStickY;
        /* 0x2EA4 */ public float FirstPersonCamHeight;
        /* 0x2EA8 */ public List<Vector3f> FirstPersonCamOffset;
        /* 0x2EC0 */ public Vector3f FirstPersonInShipCamOffset;
        /* 0x2ED0 */ public float CloseFactorSpring;
        /* 0x2ED4 */ public float FirstPersonFoV;
        /* 0x2ED8 */ public float ThirdPersonFoV;
        /* 0x2EDC */ public float CombatFoV;
        /* 0x2EE0 */ public float FirstPersonZoom1FoV;
        /* 0x2EE4 */ public float FirstPersonZoom2FoV;
        /* 0x2EE8 */ public float ShipFoVMin;
        /* 0x2EEC */ public float ShipFoVMin2;
        /* 0x2EF0 */ public float ShipFoVMax;
        /* 0x2EF4 */ public float ShipWarpFoV;
        /* 0x2EF8 */ public float ShipFoVMin3rdPerson;
        /* 0x2EFC */ public float ShipFoVMax3rdPerson;
        /* 0x2F00 */ public float ShipFoVBoost;
        /* 0x2F04 */ public float ShipFoVMiniJump;
        /* 0x2F08 */ public float ShipFoVSpring;
        /* 0x2F0C */ public float ShipMiniJumpFoVSpring;
        /* 0x2F10 */ public float FoVSpring;
        /* 0x2F14 */ public float FoVSpringSights;
        /* 0x2F18 */ public float FoVAdjust;
        /* 0x2F1C */ public bool CreatureInteractionInterpolateDuringHold;
        /* 0x2F20 */ public float CreatureSizeMin;
        /* 0x2F24 */ public float CreatureSizeMax;
        /* 0x2F28 */ public float CreatureInteractionMinDist;
        /* 0x2F2C */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        /* 0x2F30 */ public float CreatureInteractionPushCameraDownAmount;
        /* 0x2F34 */ public float CreatureInteractionDistMulMin;
        /* 0x2F38 */ public float CreatureInteractionDistMulMax;
        /* 0x2F3C */ public float CreatureInteractionYawMin;
        /* 0x2F40 */ public float CreatureInteractionYawMax;
        /* 0x2F44 */ public float CreatureInteractionPitchSplit;
        /* 0x2F48 */ public float CreatureInteractionPitchMin;
        /* 0x2F4C */ public float CreatureInteractionPitchMax;
        /* 0x2F50 */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        /* 0x2F54 */ public float CreatureInteractionDownhillPitchTransfer;
        /* 0x2F58 */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        /* 0x2F5C */ public float CreatureInteractionUphillPitchTransfer;
        /* 0x2F60 */ public float CreatureInteractionFoVSplitSize;
        /* 0x2F64 */ public float CreatureInteractionFoVMin;
        /* 0x2F68 */ public float CreatureInteractionFoVMax;
        /* 0x2F6C */ public float CreatureInteractionCamSpring;
        /* 0x2F70 */ public float CreatureInteractionHeadHeightSpring;
        /* 0x2F74 */ public bool FollowDrawCamProbes;
        /* 0x2F78 */ public GcCameraAnimationData AmbientCameraAnimations;
        /* 0x2FFC */ public TkTextureResource AmbientDroneAnimations;
        /* 0x3080 */ public NMSString0x80 CameraAmbientAnimationsData;
        /* 0x3100 */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x3104 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3108 */ public byte[] Padding3108;
        /* 0x3110 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x31C0 */ public TkModelRendererData CameraNPCShopInteraction;
        /* 0x3270 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        /* 0x3320 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        /* 0x33D0 */ public TkModelRendererData CameraCreatureCustomiseRight;
        /* 0x3480 */ public TkModelRendererData CameraCreatureCustomiseFront;
        /* 0x3530 */ public TkModelRendererData CameraCreatureCustomiseBack;
        /* 0x35E0 */ public List<TkPhysRelVectorData> SavedCameraPositions;
        /* 0x35F0 */ public List<Vector3f> SavedCameraFacing;
        /* 0x3600 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3654 */ public byte[] EndPadding;
    }
}
