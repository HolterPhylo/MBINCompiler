using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x1B4D931F76E042A5, NameHash = 0xA826BCA4D4C3DFE3)]
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public float SClassLandingShakeMultiplier;
        /* 0x0004 */ public bool OffsetCombatCameraHorizontal;
        /* 0x0008 */ public float OffsetCombatCameraHorizontalAngle;
        /* 0x0010 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        /* 0x00C0 */ public TkModelRendererData FreighterCustomisationStandardCameraAlt;
        /* 0x0170 */ public List<GcCameraFollowSettings> Cameras;
        /* 0x0180 */ public GcCameraFollowSettings VehicleCamHmd;
        /* 0x0278 */ public GcCameraFollowSettings VehicleCam;
        /* 0x0370 */ public GcCameraFollowSettings MechFirstPersonCam;
        /* 0x0468 */ public float SpecialVehicleMouseRecentreTime;
        /* 0x046C */ public float SpecialVehicleMouseRecentreWeaponTime;
        /* 0x0470 */ public float HmdEyeLookAngle;
        /* 0x0474 */ public float HmdEyeExtraTurnAngle;
        /* 0x0478 */ public float HmdEyeExtraTurnMinHeadAngle;
        /* 0x047C */ public float HmdEyeExtraTurnHeadAngleRange;
        /* 0x0480 */ public bool PauseThirdPersonCamInPause;
        /* 0x0484 */ public float DebugPlanetJumpNearHeight;
        /* 0x0488 */ public float DebugPlanetJumpFarHeight;
        /* 0x048C */ public float TogglePerspectiveBlendTime;
        /* 0x0490 */ public bool LockFollowSpring;
        /* 0x0494 */ public float UnderwaterCameraSurfaceOffset;
        /* 0x0498 */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x049C */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x04A0 */ public float MiniportalFlashTime;
        /* 0x04A4 */ public float MiniportalFlashStrength;
        /* 0x04B0 */ public Colour MiniportalFlashColour;
        /* 0x04C0 */ public float VehicleExitFlashTime;
        /* 0x04C4 */ public float VehicleExitFlashStrength;
        /* 0x04D0 */ public Colour VehicleExitFlashColour;
        /* 0x04E0 */ public float VehicleFirstToThirdExitOffsetY;
        /* 0x04E4 */ public float VehicleFirstToThirdExitOffsetZ;
        /* 0x04E8 */ public float ShipThirdPersonBlendTime;
        /* 0x04EC */ public float ShipThirdPersonBlendWithOffsetTime;
        /* 0x04F0 */ public float ShipThirdPersonBlendOffset;
        /* 0x04F4 */ public float ShipThirdPersonBlendOutTime;
        /* 0x04F8 */ public float ShipThirdPersonBlendOutOffset;
        /* 0x04FC */ public float ShipFirstPersonBlendTime;
        /* 0x0500 */ public float ShipFirstPersonBlendOffset;
        /* 0x0504 */ public float ShipThirdPersonEnterBlendTime;
        /* 0x0508 */ public float ShipThirdPersonEnterBlendOffset;
        /* 0x050C */ public float FlybyMinRange;
        /* 0x0510 */ public float FlybyRange;
        /* 0x0514 */ public float FlybyMinRelativeSpeed;
        /* 0x0518 */ public float FlybyRelativeSpeedRange;
        /* 0x051C */ public float FlybyInVehicleDamper;
        /* 0x0520 */ public float BinocularFlashTime;
        /* 0x0524 */ public float BinocularFlashStrength;
        /* 0x0528 */ public float MinFirstPersonCameraPitch;
        /* 0x052C */ public float MaxFirstPersonCameraPitch;
        /* 0x0530 */ public float MaxCreatureRidingYaw;
        /* 0x0534 */ public float ThirdPersonRotationBackAdjustAngleMin;
        /* 0x0538 */ public float ThirdPersonClosePitch;
        /* 0x053C */ public float ThirdPersonCloseDistance;
        /* 0x0540 */ public float ThirdPersonCloseDistanceX;
        /* 0x0544 */ public float ThirdPersonRotationBackAdjustAngleMax;
        /* 0x0548 */ public float ThirdPersonUphillAdjustSpringTimeMin;
        /* 0x054C */ public float ThirdPersonUphillAdjustSpringTimeMax;
        /* 0x0550 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        /* 0x0554 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        /* 0x0558 */ public float ThirdPersonDownhillAdjustMinAngle;
        /* 0x055C */ public float ThirdPersonDownhillAdjustMaxAngle;
        /* 0x0560 */ public float ThirdPersonUphillAdjustMinAngle;
        /* 0x0564 */ public float ThirdPersonUphillAdjustMaxAngle;
        /* 0x0568 */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        /* 0x056C */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        /* 0x0570 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        /* 0x0574 */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        /* 0x0578 */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        /* 0x057C */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        /* 0x0580 */ public float VehicleThirdPersonShootOffsetReturnTime;
        /* 0x0584 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        /* 0x0588 */ public float MechCameraNoExtraYTimeAfterLand;
        /* 0x058C */ public float MechCameraExtraYPostLandingBlendTime;
        /* 0x0590 */ public float MechCameraArmShootOffsetY;
        /* 0x0594 */ public float MechCameraCombatFakeSpeed;
        /* 0x0598 */ public GcCameraFollowSettings CharacterUnarmedCam;
        /* 0x0690 */ public GcCameraFollowSettings CharacterRunCam;
        /* 0x0788 */ public GcCameraFollowSettings CharacterCombatCam;
        /* 0x0880 */ public GcCameraFollowSettings CharacterMiningCam;
        /* 0x0978 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x0A70 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        /* 0x0B68 */ public GcCameraFollowSettings CharacterAbandCam;
        /* 0x0C60 */ public GcCameraFollowSettings CharacterNexusCam;
        /* 0x0D58 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x0E50 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x0F48 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        /* 0x1040 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        /* 0x1138 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x1230 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x1328 */ public GcCameraFollowSettings CharacterSpaceCam;
        /* 0x1420 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        /* 0x1518 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x1610 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        /* 0x1708 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        /* 0x1800 */ public GcCameraFollowSettings CharacterGrabbedCam;
        /* 0x18F8 */ public GcCameraFollowSettings CharacterSitCam;
        /* 0x19F0 */ public GcCameraFollowSettings CharacterRideCam;
        /* 0x1AE8 */ public GcCameraFollowSettings CharacterRideCamMedium;
        /* 0x1BE0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        /* 0x1CD8 */ public GcCameraFollowSettings CharacterRideCamHuge;
        /* 0x1DD0 */ public float ThirdPersonCameraChangeBlendTime;
        /* 0x1DD4 */ public float ThirdPersonCameraChangeMinimumBlend;
        /* 0x1DD8 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x1ED0 */ public GcCameraFollowSettings HovercraftFollowCam;
        /* 0x1FC8 */ public GcCameraFollowSettings SubmarineFollowCam;
        /* 0x20C0 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x21B8 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        /* 0x22B0 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x23A8 */ public GcCameraFollowSettings MechFollowCam;
        /* 0x24A0 */ public GcCameraFollowSettings MechCombatCam;
        /* 0x2598 */ public GcCameraFollowSettings MechJetpackCam;
        /* 0x2690 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x2788 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x2880 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x2978 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x2A70 */ public GcCameraFollowSettings SailShipFollowCam;
        /* 0x2B68 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x2C60 */ public GcCameraFollowSettings AlienShipFollowCam;
        /* 0x2D58 */ public GcCameraFollowSettings RobotShipFollowCam;
        /* 0x2E50 */ public GcCameraFollowSettings BuildingIndoorsCam;
        /* 0x2F48 */ public GcCameraFollowSettings BuildingOutdoorsCam;
        /* 0x3040 */ public GcCameraFollowSettings BuildingUnderwaterCam;
        /* 0x3138 */ public float FrontendModelCameraSpringTime;
        /* 0x313C */ public float ModelViewFlashTime;
        /* 0x3140 */ public Vector3f ModelViewOffset;
        /* 0x3150 */ public Vector2f ModelViewFocusOffset;
        /* 0x3160 */ public Vector3f InteractionOffset;
        /* 0x3170 */ public Vector3f InteractionOffsetExtraVR;
        /* 0x3180 */ public Vector3f InteractionOffsetExtraVRSeated;
        /* 0x3190 */ public Vector3f ShopInteractionOffsetExtraVR;
        /* 0x31A0 */ public Vector3f ShopInteractionOffsetExtraVRSeated;
        /* 0x31B0 */ public Vector3f InteractionOffsetDefault;
        /* 0x31C0 */ public Vector3f InteractionOffsetGek;
        /* 0x31D0 */ public Vector3f InteractionOffsetSpiderman;
        /* 0x31E0 */ public Vector3f InteractionShipFocusOffset;
        /* 0x31F0 */ public Vector3f InteractionHailingFocusOffset;
        /* 0x3200 */ public Vector3f InteractionOffsetRecruitment;
        /* 0x3210 */ public float InteractionHeadHeightDefault;
        /* 0x3214 */ public float InteractionHeadHeightGek;
        /* 0x3218 */ public float InteractionHeadHeightVykeen;
        /* 0x321C */ public float InteractionHeadHeightSpiderman;
        /* 0x3220 */ public float InteractionPitchAdjustTime;
        /* 0x3224 */ public float InteractionPitchAdjustStrength;
        /* 0x3228 */ public float InteractionPitchAdjustDeadZone;
        /* 0x322C */ public float InteractionHeadPosHeightAdjust;
        /* 0x3230 */ public float InteractionHeadPosHeightAdjustSpiderman;
        /* 0x3234 */ public float FrigateCaptainLateralShiftAmount;
        /* 0x3238 */ public float PilotDetailsLateralShiftAmount;
        /* 0x323C */ public float RecruitmentLateralShiftAmount;
        /* 0x3240 */ public float NPCTradeLateralShiftAmount;
        /* 0x3244 */ public float NPCTradeLateralShiftTime;
        /* 0x3248 */ public float DistanceForFleetInteraction;
        /* 0x324C */ public float DistanceForFrigateInteraction;
        /* 0x3250 */ public float DistanceForFrigatePurchaseInteraction;
        /* 0x3260 */ public Vector3f OffsetForFleetInteraction;
        /* 0x3270 */ public Vector3f OffsetForFrigateInteraction;
        /* 0x3280 */ public float FleetUIOrbitRate;
        /* 0x3284 */ public float FleetUIVerticalMotionDuration;
        /* 0x3288 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x328C */ public Vector2f PitchForFrigateInteraction;
        /* 0x3294 */ public Vector2f RotationForFrigateInteraction;
        /* 0x329C */ public float InteractionModeBlendTime;
        /* 0x32A0 */ public float InteractionModeFocusCamBlend;
        /* 0x32A4 */ public float InteractionModeFoV;
        /* 0x32A8 */ public float MinInteractFocusAngle;
        /* 0x32AC */ public float ModelViewInterpTime;
        /* 0x32B0 */ public float ThirdPersonBlendInTime;
        /* 0x32B4 */ public float ThirdPersonBlendOutTime;
        /* 0x32B8 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x32BC */ public float ThirdPersonOffsetSpringTime;
        /* 0x32C0 */ public bool MaxBob;
        /* 0x32C4 */ public float PhotoModeVelocitySmoothTime;
        /* 0x32C8 */ public float PhotoModeMoveSpeed;
        /* 0x32CC */ public float PhotoModeTurnSpeed;
        /* 0x32D0 */ public float PhotoModeMaxDistance;
        /* 0x32D4 */ public float PhotoModeMaxDistanceSpace;
        /* 0x32D8 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x32DC */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x32E0 */ public float PhotoModeCollisionRadius;
        /* 0x32E4 */ public float PhotoModeRollSpeed;
        /* 0x32E8 */ public float PhotoModeFlashDuration;
        /* 0x32EC */ public float PhotoModeFlashIntensity;
        /* 0x32F0 */ public Vector3f PhotoModeShipOffset;
        /* 0x3300 */ public Vector3f PhotoModeVRFPOffset;
        /* 0x3310 */ public Vector3f BuildingModeInitialOffset;
        /* 0x3320 */ public float BuildingModeMaxDistance;
        /* 0x3324 */ public float RunningFoVAdjust;
        /* 0x3328 */ public float MeleeBoostedFoV;
        /* 0x332C */ public float MeleeFoV;
        /* 0x3330 */ public float AerialViewDownDistance;
        /* 0x3334 */ public float AerialViewPause;
        /* 0x3338 */ public float AerialViewStartTime;
        /* 0x333C */ public float AerialViewBackTime;
        /* 0x3340 */ public float AerialViewBlendTime;
        /* 0x3344 */ public TkCurveType AerialViewCurve;
        /* 0x3348 */ public GcCameraAerialViewData BeaconTransition;
        /* 0x3370 */ public GcCameraAerialViewData SignalTransition;
        /* 0x3398 */ public GcCameraAerialViewData WaypointTransition;
        /* 0x33C0 */ public GcCameraAerialViewData RadioTowerTransition;
        /* 0x33E8 */ public float ScreenshotHorizonHeight;
        /* 0x33EC */ public float ScreenshotHorizonFaceFactor;
        /* 0x33F0 */ public float ScreenshotBendDownAmount;
        /* 0x33F4 */ public float ScreenshotRightDistance;
        /* 0x33F8 */ public float ScreenshotBackDistance;
        /* 0x33FC */ public float ScreenshotInTime;
        /* 0x3400 */ public float ScreenshotOutTime;
        /* 0x3404 */ public float MechCamSpringStrengthMin;
        /* 0x3408 */ public float MechCamSpringStrengthMax;
        /* 0x340C */ public float ShipCamSpringStrengthMin;
        /* 0x3410 */ public float ShipCamSpringStrengthMax;
        /* 0x3414 */ public float ShipCamTurn;
        /* 0x3418 */ public float ShipCamPitch;
        /* 0x341C */ public float ShipCamPitchMod;
        /* 0x3420 */ public float ShipCamLookInterp;
        /* 0x3424 */ public float ShipCamMinReturnTime;
        /* 0x3428 */ public float ShipCamReturnTime;
        /* 0x342C */ public float ShipCamMotionTurn;
        /* 0x3430 */ public float ShipCamMotionPitch;
        /* 0x3434 */ public float ShipCamMotionPitchMod;
        /* 0x3438 */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x343C */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x3440 */ public float ShipCamMotionInterp;
        /* 0x3444 */ public float ShipCamRollAmountMin;
        /* 0x3448 */ public float ShipCamRollAmountMax;
        /* 0x344C */ public float ShipCamRollSpeedScaler;
        /* 0x3450 */ public float ShipCamAimFOV;
        /* 0x3454 */ public float MouseSensitivity;
        /* 0x3458 */ public float ModelViewRotateSpeed;
        /* 0x345C */ public float ModelViewMouseRotateSpeed;
        /* 0x3460 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x3464 */ public float ModelViewMouseMoveSpeed;
        /* 0x3468 */ public float ModelViewDistSpeed;
        /* 0x346C */ public float ModelViewMinDist;
        /* 0x3470 */ public float ModelViewMaxDist;
        /* 0x3474 */ public float ModelViewDefaultPitch;
        /* 0x3478 */ public float ModelViewDefaultYaw;
        /* 0x347C */ public bool DebugMoveCam;
        /* 0x3480 */ public float DebugMoveCamSpeed;
        /* 0x3484 */ public float DebugMoveCamHeight;
        /* 0x3488 */ public bool DebugAICam;
        /* 0x348C */ public float DebugAICamUp;
        /* 0x3490 */ public float DebugAICamAt;
        /* 0x3494 */ public float VRShakeMultiplier;
        /* 0x3498 */ public float PainShakeTime;
        /* 0x349C */ public float ShipShakeDamper;
        /* 0x34A0 */ public float IndoorCamShakeDamper;
        /* 0x34A4 */ public float FirstPersonSlerpAway;
        /* 0x34A8 */ public float FirstPersonSlerpTowards;
        /* 0x34B0 */ public List<GcCameraShakeData> CameraShakeTable;
        /* 0x34C0 */ public float BobAmountAbandFreighter;
        /* 0x34C4 */ public float BobFactorAbandFreighter;
        /* 0x34C8 */ public float BobAmount;
        /* 0x34CC */ public float BobFactor;
        /* 0x34D0 */ public float BobFocus;
        /* 0x34D4 */ public float BobRollFactor;
        /* 0x34D8 */ public float BobRollAmount;
        /* 0x34DC */ public float BobRollOffset;
        /* 0x34E0 */ public float BobFwdAmount;
        /* 0x34E4 */ public float CamSeed1;
        /* 0x34E8 */ public float CamSeed2;
        /* 0x34EC */ public float CamWander1Phase;
        /* 0x34F0 */ public float CamWander2Phase;
        /* 0x34F4 */ public float CamWander1Amplitude;
        /* 0x34F8 */ public float CamWander2Amplitude;
        /* 0x34FC */ public float DebugSpaceStationTeleportOffset;
        /* 0x3500 */ public float DebugCameraSlowFactor;
        /* 0x3504 */ public float DebugCameraFastFactor;
        /* 0x3508 */ public float DebugCameraSpaceFastFactor;
        /* 0x350C */ public float DebugCameraHeightForAccelerateBegin;
        /* 0x3510 */ public float DebugCameraSpeedAtPlanetThreshold;
        /* 0x3514 */ public float DebugCameraHeightForAccelerateEnd;
        /* 0x3518 */ public float DebugCameraMaxSpeed;
        /* 0x351C */ public float OffsetCamFOV;
        /* 0x3520 */ public Vector3f OffsetCamOffset;
        /* 0x3530 */ public Vector3f OffsetCamRotation;
        /* 0x3540 */ public float ObjectFocusTime;
        /* 0x3544 */ public float CharCamFocusHeight;
        /* 0x3548 */ public float CharCamMaxDistance;
        /* 0x354C */ public float CharCamMinDistance;
        /* 0x3550 */ public float CharCamHeight;
        /* 0x3554 */ public float CharCamOffsetTime;
        /* 0x3558 */ public float CharCamAutoDirStartTime;
        /* 0x355C */ public float CharCamLookOffset;
        /* 0x3560 */ public float CharCamLookOffsetFactor;
        /* 0x3564 */ public float CharCamDeflectSpeed;
        /* 0x3568 */ public float CharCamMinSpeed;
        /* 0x356C */ public float CharCamRightStickX;
        /* 0x3570 */ public float CharCamRightStickY;
        /* 0x3574 */ public float FirstPersonCamHeight;
        /* 0x3578 */ public List<Vector3f> FirstPersonCamOffset;
        /* 0x3590 */ public Vector3f FirstPersonInShipCamOffset;
        /* 0x35A0 */ public float CloseFactorSpring;
        /* 0x35A4 */ public float FirstPersonFoV;
        /* 0x35A8 */ public float ThirdPersonFoV;
        /* 0x35AC */ public float ThirdPersonCombatFoV;
        /* 0x35B0 */ public float FirstPersonZoom1FoV;
        /* 0x35B4 */ public float FirstPersonZoom2FoV;
        /* 0x35B8 */ public float ShipFoVMin;
        /* 0x35BC */ public float ShipFoVMin2;
        /* 0x35C0 */ public float ShipFoVMax;
        /* 0x35C4 */ public float ShipWarpFoV;
        /* 0x35C8 */ public float ShipFoVMin3rdPerson;
        /* 0x35CC */ public float ShipFoVMax3rdPerson;
        /* 0x35D0 */ public float ShipFoVBoost;
        /* 0x35D4 */ public float ShipFoVMiniJump;
        /* 0x35D8 */ public float ShipFoVSpring;
        /* 0x35DC */ public float ShipMiniJumpFoVSpring;
        /* 0x35E0 */ public float FoVSpring;
        /* 0x35E4 */ public float FoVSpringSights;
        /* 0x35E8 */ public float FoVSpringSightsPassive;
        /* 0x35EC */ public float FoVAdjust;
        /* 0x35F0 */ public bool CreatureInteractionInterpolateDuringHold;
        /* 0x35F4 */ public float CreatureSizeMin;
        /* 0x35F8 */ public float CreatureSizeMax;
        /* 0x35FC */ public float CreatureInteractionMinDist;
        /* 0x3600 */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        /* 0x3604 */ public float CreatureInteractionPushCameraDownAmount;
        /* 0x3608 */ public float CreatureInteractionDistMulMin;
        /* 0x360C */ public float CreatureInteractionDistMulMax;
        /* 0x3610 */ public float CreatureInteractionYawMin;
        /* 0x3614 */ public float CreatureInteractionYawMax;
        /* 0x3618 */ public float CreatureInteractionPitchSplit;
        /* 0x361C */ public float CreatureInteractionPitchMin;
        /* 0x3620 */ public float CreatureInteractionPitchMax;
        /* 0x3624 */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        /* 0x3628 */ public float CreatureInteractionDownhillPitchTransfer;
        /* 0x362C */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        /* 0x3630 */ public float CreatureInteractionUphillPitchTransfer;
        /* 0x3634 */ public float CreatureInteractionFoVSplitSize;
        /* 0x3638 */ public float CreatureInteractionFoVMin;
        /* 0x363C */ public float CreatureInteractionFoVMax;
        /* 0x3640 */ public float CreatureInteractionCamSpring;
        /* 0x3644 */ public float CreatureInteractionHeadHeightSpring;
        /* 0x3648 */ public bool FollowDrawCamProbes;
        /* 0x364C */ public GcCameraAnimationData AmbientCameraAnimations;
        /* 0x36D0 */ public TkModelResource AmbientDroneAnimations;
        /* 0x3754 */ public NMSString0x80 CameraAmbientAnimationsData;
        /* 0x37D4 */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x37D8 */ public float CameraAmbientAutoSwitchMaxTime;
        /* 0x37E0 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x3890 */ public TkModelRendererData CameraNPCShopInteraction;
        /* 0x3940 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        /* 0x39F0 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        /* 0x3AA0 */ public TkModelRendererData CameraCreatureCustomiseRight;
        /* 0x3B50 */ public TkModelRendererData CameraCreatureCustomiseFront;
        /* 0x3C00 */ public TkModelRendererData CameraCreatureCustomiseBack;
        /* 0x3CB0 */ public List<TkPhysRelVectorData> SavedCameraPositions;
        /* 0x3CC0 */ public List<Vector3f> SavedCameraFacing;
        /* 0x3CD0 */ public GcCameraWarpSettings WarpSettings;
        /* 0x3D24 */ public GcCameraWarpSettings FreighterWarpSettings;
    }
}
