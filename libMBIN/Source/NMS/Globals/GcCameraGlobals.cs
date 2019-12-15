using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xE8DD5B40E5464FFF)]
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public GcCameraFollowSettings VehicleCamHmd;
        /* 0x00E8 */ public GcCameraFollowSettings VehicleCam;
        /* 0x01D0 */ public float SpecialVehicleMouseRecentreTime;
        /* 0x01D4 */ public float SpecialVehicleMouseRecentreWeaponTime;
        /* 0x01D8 */ public float HmdEyeLookAngle;
        /* 0x01DC */ public float HmdEyeExtraTurnAngle;
        /* 0x01E0 */ public float HmdEyeExtraTurnMinHeadAngle;
        /* 0x01E4 */ public float HmdEyeExtraTurnHeadAngleRange;
        /* 0x01E8 */ public bool PauseThirdPersonCamInPause;
        /* 0x01EC */ public float DebugPlanetJumpNearHeight;
        /* 0x01F0 */ public float DebugPlanetJumpFarHeight;
        /* 0x01F4 */ public float TogglePerspectiveBlendTime;
        /* 0x01F8 */ public float UnderwaterCameraSurfaceOffset;
        /* 0x01FC */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x0200 */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x0204 */ public float VehicleExitFlashTime;
        /* 0x0208 */ public float VehicleExitFlashStrength;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x020C */ public byte[] Padding20C;
        /* 0x0210 */ public Colour VehicleExitFlashColour;
        /* 0x0220 */ public float VehicleFirstToThirdExitOffsetY;
        /* 0x0224 */ public float VehicleFirstToThirdExitOffsetZ;
        /* 0x0228 */ public float ShipThirdPersonBlendTime;
        /* 0x022C */ public float ShipThirdPersonBlendWithOffsetTime;
        /* 0x0230 */ public float ShipThirdPersonBlendOffset;
        /* 0x0234 */ public float ShipThirdPersonBlendOutTime;
        /* 0x0238 */ public float ShipThirdPersonBlendOutOffset;
        /* 0x023C */ public float ShipFirstPersonBlendTime;
        /* 0x0240 */ public float ShipFirstPersonBlendOffset;
        /* 0x0244 */ public float ShipThirdPersonEnterBlendTime;
        /* 0x0248 */ public float ShipThirdPersonEnterBlendOffset;
        /* 0x024C */ public float FlybyMinRange;
        /* 0x0250 */ public float FlybyRange;
        /* 0x0254 */ public float FlybyMinRelativeSpeed;
        /* 0x0258 */ public float FlybyRelativeSpeedRange;
        /* 0x025C */ public float FlybyInVehicleDamper;
        /* 0x0260 */ public float BinocularFlashTime;
        /* 0x0264 */ public float BinocularFlashStrength;
        /* 0x0268 */ public float MinFirstPersonCameraPitch;
        /* 0x026C */ public float MaxFirstPersonCameraPitch;
        /* 0x0270 */ public float MaxCreatureRidingYaw;
        /* 0x0274 */ public float VehicleThirdPersonShootOffsetReturnTime;
        /* 0x0278 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x027C */ public byte[] Padding27C;
        /* 0x0280 */ public GcCameraFollowSettings CharacterUnarmedCam;
        /* 0x0368 */ public GcCameraFollowSettings CharacterRunCam;
        /* 0x0450 */ public GcCameraFollowSettings CharacterCombatCam;
        /* 0x0538 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x0620 */ public GcCameraFollowSettings CharacterNexusCam;
        /* 0x0708 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x07F0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x08D8 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        /* 0x09C0 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        /* 0x0AA8 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x0B90 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x0C78 */ public GcCameraFollowSettings CharacterSpaceCam;
        /* 0x0D60 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        /* 0x0E48 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x0F30 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        /* 0x1018 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        /* 0x1100 */ public GcCameraFollowSettings CharacterGrabbedCam;
        /* 0x11E8 */ public GcCameraFollowSettings CharacterSitCam;
        /* 0x12D0 */ public GcCameraFollowSettings CharacterRideCam;
        /* 0x1320 */ public GcCameraFollowSettings CharacterRideCamMedium;
        /* 0x14A0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        /* 0x1588 */ public GcCameraFollowSettings CharacterRideCamHuge;
        /* 0x1670 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1674 */ public byte[] Padding1674;
        /* 0x1678 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x1760 */ public GcCameraFollowSettings HovercraftFollowCam;
        /* 0x1848 */ public GcCameraFollowSettings SubmarineFollowCam;
        /* 0x1930 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x1A18 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        /* 0x1B00 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x1BE8 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x1CD0 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x1DB8 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x1EA0 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x1F88 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x2070 */ public float FrontendModelCameraSpringTime;
        /* 0x2074 */ public float ModelViewFlashTime;
        /* 0x2080 */ public Vector3f ModelViewOffset;
        /* 0x2090 */ public Vector2f ModelViewFocusOffset;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2098 */ public byte[] Padding2098;
        /* 0x20A0 */ public Vector3f InteractionOffset;
        /* 0x20B0 */ public Vector3f InteractionOffsetExtraVR;
        /* 0x20C0 */ public Vector3f InteractionOffsetExtraVRSeated;
        /* 0x20D0 */ public Vector3f InteractionOffsetDefault;
        /* 0x20E0 */ public Vector3f InteractionOffsetGek;
        /* 0x20F0 */ public Vector3f InteractionShipFocusOffset;
        /* 0x2100 */ public float InteractionHeadHeightDefault;
        /* 0x2104 */ public float InteractionHeadHeightGek;
        /* 0x2108 */ public float InteractionHeadHeightVykeen;
        /* 0x210C */ public float InteractionPitchAdjustTime;
        /* 0x2110 */ public float InteractionPitchAdjustStrength;
        /* 0x2114 */ public float InteractionPitchAdjustDeadZone;
        /* 0x2118 */ public float InteractionHeadPosHeightAdjust;
        /* 0x211C */ public float NPCTradeLateralShiftAmount;
        /* 0x2120 */ public float NPCTradeLateralShiftTime;
        /* 0x2124 */ public float DistanceForFleetInteraction;
        /* 0x2128 */ public float DistanceForFrigateInteraction;
        /* 0x212C */ public float DistanceForFrigatePurchaseInteraction;
        /* 0x2130 */ public Vector3f OffsetForFleetInteraction;
        /* 0x2140 */ public Vector3f OffsetForFrigateInteraction;
        /* 0x2150 */ public float FleetUIOrbitRate;
        /* 0x2154 */ public float FleetUIVerticalMotionDuration;
        /* 0x2158 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x215C */ public Vector2f PitchForFrigateInteraction;
        /* 0x2164 */ public Vector2f RotationForFrigateInteraction;
        /* 0x216C */ public float InteractionModeBlendTime;
        /* 0x2170 */ public float InteractionModeFocusCamBlend;
        /* 0x2174 */ public float InteractionModeFoV;
        /* 0x2178 */ public float MinInteractFocusAngle;
        /* 0x217C */ public float ModelViewInterpTime;
        /* 0x2180 */ public float ThirdPersonBlendInTime;
        /* 0x2184 */ public float ThirdPersonBlendOutTime;
        /* 0x2188 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x218C */ public float ThirdPersonOffsetSpringTime;
        /* 0x2190 */ public bool MaxBob;
        /* 0x2194 */ public float PhotoModeMoveSpeed;
        /* 0x2198 */ public float PhotoModeTurnSpeed;
        /* 0x219C */ public float PhotoModeMaxDistance;
        /* 0x21A0 */ public float PhotoModeMaxDistanceSpace;
        /* 0x21A4 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x21A8 */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x21AC */ public float PhotoModeCollisionRadius;
        /* 0x21B0 */ public float PhotoModeRollSpeed;
        /* 0x21B4 */ public float PhotoModeFlashDuration;
        /* 0x21B8 */ public float PhotoModeFlashIntensity;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x21BC */ public byte[] Padding21BC;
        /* 0x21C0 */ public Vector3f PhotoModeShipOffset;
        /* 0x21D0 */ public Vector3f BuildingModeInitialOffset;
        /* 0x21E0 */ public float BuildingModeMaxDistance;
        /* 0x21E4 */ public float RunningFoVAdjust;
        /* 0x21E8 */ public float MeleeBoostedFoV;
        /* 0x21EC */ public float MeleeFoV;
        /* 0x21F0 */ public float AerialViewDownDistance;
        /* 0x21F4 */ public float AerialViewPause;
        /* 0x21F8 */ public float AerialViewStartTime;
        /* 0x21FC */ public float AerialViewBackTime;
        /* 0x2200 */ public float AerialViewBlendTime;
        /* 0x2204 */ public TkCurveType AerialViewCurve;
        /* 0x2208 */ public GcCameraAerialViewData BeaconTransition;
        /* 0x2238 */ public GcCameraAerialViewData SignalTransition;
        /* 0x2268 */ public GcCameraAerialViewData WaypointTransition;
        /* 0x2298 */ public GcCameraAerialViewData RadioTowerTransition;
        /* 0x22C8 */ public float ScreenshotHorizonHeight;
        /* 0x22CC */ public float ScreenshotHorizonFaceFactor;
        /* 0x22D0 */ public float ScreenshotBendDownAmount;
        /* 0x22D4 */ public float ScreenshotRightDistance;
        /* 0x22D8 */ public float ScreenshotBackDistance;
        /* 0x22DC */ public float ScreenshotInTime;
        /* 0x22E0 */ public float ScreenshotOutTime;
        /* 0x22E4 */ public float ShipCamSpringStrengthMin;
        /* 0x22E8 */ public float ShipCamSpringStrengthMax;
        /* 0x22EC */ public float ShipCamTurn;
        /* 0x22F0 */ public float ShipCamPitch;
        /* 0x22F4 */ public float ShipCamPitchMod;
        /* 0x22F8 */ public float ShipCamLookInterp;
        /* 0x22FC */ public float ShipCamMinReturnTime;
        /* 0x2300 */ public float ShipCamReturnTime;
        /* 0x2304 */ public float ShipCamMotionTurn;
        /* 0x2308 */ public float ShipCamMotionPitch;
        /* 0x230C */ public float ShipCamMotionPitchMod;
        /* 0x2310 */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x2314 */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x2318 */ public float ShipCamMotionInterp;
        /* 0x231C */ public float ShipCamRollAmountMin;
        /* 0x2320 */ public float ShipCamRollAmountMax;
        /* 0x2324 */ public float ShipCamRollSpeedScaler;
        /* 0x2328 */ public float ShipCamAimFOV;
        /* 0x232C */ public float MouseSensitivity;
        /* 0x2330 */ public float ModelViewRotateSpeed;
        /* 0x2334 */ public float ModelViewMouseRotateSpeed;
        /* 0x2338 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x233C */ public float ModelViewMouseMoveSpeed;
        /* 0x2340 */ public float ModelViewDistSpeed;
        /* 0x2344 */ public float ModelViewMinDist;
        /* 0x2348 */ public float ModelViewMaxDist;
        /* 0x234C */ public float ModelViewDefaultPitch;
        /* 0x2350 */ public float ModelViewDefaultYaw;
        /* 0x2354 */ public bool DebugMoveCam;
        /* 0x2358 */ public float DebugMoveCamSpeed;
        /* 0x235C */ public float DebugMoveCamHeight;
        /* 0x2360 */ public bool DebugAICam;
        /* 0x2364 */ public float DebugAICamUp;
        /* 0x2368 */ public float DebugAICamAt;
        /* 0x236C */ public float PainShakeTime;
        /* 0x2370 */ public float ShipShakeDamper;
        /* 0x2374 */ public float IndoorCamShakeDamper;
        /* 0x2378 */ public float FirstPersonSlerpAway;
        /* 0x237C */ public float FirstPersonSlerpTowards;
        [NMS(Size = 0x24)]
        /* 0x2380 */ public GcCameraShakeData[] CameraShakeTable;
        /* 0x3E80 */ public float BobAmount;
        /* 0x3E84 */ public float BobFactor;
        /* 0x3E88 */ public float BobFocus;
        /* 0x3E8C */ public float BobRollFactor;
        /* 0x3E90 */ public float BobRollAmount;
        /* 0x3E94 */ public float BobRollOffset;
        /* 0x3E98 */ public float BobFwdAmount;
        /* 0x3E9C */ public float CamSeed1;
        /* 0x3EA0 */ public float CamSeed2;
        /* 0x3EA4 */ public float CamWander1Phase;
        /* 0x3EA8 */ public float CamWander2Phase;
        /* 0x3EAC */ public float CamWander1Amplitude;
        /* 0x3EB0 */ public float CamWander2Amplitude;
        /* 0x3EB4 */ public float DebugSpaceStationTeleportOffset;
        /* 0x3EB8 */ public float DebugCameraSlowFactor;
        /* 0x3EBC */ public float DebugCameraFastFactor;
        /* 0x3EC0 */ public float DebugCameraSpaceFastFactor;
        /* 0x3EC4 */ public float OffsetCamFOV;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3EC8 */ public byte[] Padding3EC8;
        /* 0x3ED0 */ public Vector3f OffsetCamOffset;
        /* 0x3EE0 */ public Vector3f OffsetCamRotation;
        /* 0x3EF0 */ public float ObjectFocusTime;
        /* 0x3EF4 */ public float CharCamFocusHeight;
        /* 0x3EF8 */ public float CharCamMaxDistance;
        /* 0x3EFC */ public float CharCamMinDistance;
        /* 0x3F00 */ public float CharCamHeight;
        /* 0x3F04 */ public float CharCamOffsetTime;
        /* 0x3F08 */ public float CharCamAutoDirStartTime;
        /* 0x3F0C */ public float CharCamLookOffset;
        /* 0x3F10 */ public float CharCamLookOffsetFactor;
        /* 0x3F14 */ public float CharCamDeflectSpeed;
        /* 0x3F18 */ public float CharCamMinSpeed;
        /* 0x3F1C */ public float CharCamRightStickX;
        /* 0x3F20 */ public float CharCamRightStickY;
        /* 0x3F24 */ public float FirstPersonCamHeight;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3F28 */ public byte[] Padding3F28;
        [NMS(Size = 0x8)]
        /* 0x3F30 */ public Vector4f[] FirstPersonCamOffset;
        /* 0x3FB0 */ public Vector3f FirstPersonInShipCamOffset;
        /* 0x3FC0 */ public float FirstPersonFoV;
        /* 0x3FC4 */ public float ThirdPersonFoV;
        /* 0x3FC8 */ public float FirstPersonZoom1FoV;
        /* 0x3FCC */ public float FirstPersonZoom2FoV;
        /* 0x3FD0 */ public float ShipFoVMin;
        /* 0x3FD4 */ public float ShipFoVMin2;
        /* 0x3FD8 */ public float ShipFoVMax;
        /* 0x3FDC */ public float ShipWarpFoV;
        /* 0x3FE0 */ public float ShipFoVMin3rdPerson;
        /* 0x3FE4 */ public float ShipFoVMax3rdPerson;
        /* 0x3FE8 */ public float ShipFoVBoost;
        /* 0x3FEC */ public float ShipFoVMiniJump;
        /* 0x3FF0 */ public float ShipFoVSpring;
        /* 0x3FF4 */ public float ShipMiniJumpFoVSpring;
        /* 0x3FF8 */ public float FoVSpring;
        /* 0x3FFC */ public float FoVAdjust;
        /* 0x4000 */ public bool FollowDrawCamProbes;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x4001 */ public byte[] Padding4001;
        /* 0x4004 */ public GcCameraAnimationData CameraAnimations;
        /* 0x4088 */ public TkTextureResource AmbientDroneAnimations;
        [NMS(Size = 0x80)]
        /* 0x410C */ public string CameraAmbientAnimationsData;
        /* 0x418C */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x4190 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x4194 */ public byte[] Padding4194;
        /* 0x41A0 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x4250 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Size = 0x4)]
        /* 0x4300 */ public TkPhysRelVectorData[] SavedCameraPositions;
        [NMS(Size = 0x4)]
        /* 0x4380 */ public Vector4f[] SavedCameraFacing;
        /* 0x43C0 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x4404 */ public byte[] EndPadding;
    }
}
