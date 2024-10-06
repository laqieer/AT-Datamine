// Decompiled with JetBrains decompiler
// Type: DuelManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data.Board;
using Battle.DuelScene;
using Cinemachine;
using DuelMarker;
using GameCore;
using GameCore.DLC;
using GameCore.MasterData;
using GameCore.Sound;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200012B")]
public class DuelManager : MonoBehaviour
{
  [Token(Token = "0x400063F")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private DuelSettingsAsset duelSettings;
  [Token(Token = "0x4000640")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private DuelCharacterAbnormalStateEffectSettingsAsset abnormalStateEffectSettingsAsset;
  [Token(Token = "0x4000641")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private GameObject defaultFootSmokePrefab;
  [Token(Token = "0x4000642")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private DuelVirtualCameraSwitchFlowSettingsAsset defaultVCSwichFlowSettings;
  [Token(Token = "0x4000643")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private DuelVirtualCameraSwitchFlowSettingsAsset giantBossVCSwichFlowSettings;
  [Token(Token = "0x4000644")]
  [FieldOffset(Offset = "0x40")]
  private DuelCharacterAnimation.MainAnimationRange currentTurnRangeType;
  [Token(Token = "0x4000645")]
  [FieldOffset(Offset = "0x48")]
  private DuelVirtualCameraSwitchFlow currentTurnVCSwitchFlow;
  [Token(Token = "0x4000646")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private SignalAsset nextTurnMoveStartSignalAsset;
  [Token(Token = "0x4000647")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private SignalAsset enableSoundControllerSignalAsset;
  [Token(Token = "0x4000648")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private SignalAsset disableSoundControllerSignalAsset;
  [Token(Token = "0x4000649")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private List<SignalAsset> duelSignals;
  [Token(Token = "0x400064A")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private GameObject durlCharacterRoot;
  [Token(Token = "0x400064B")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private GameObject subPlayableDirectorRoot;
  [Token(Token = "0x400064C")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private List<PlayableDirector> subPlayableDirectors;
  [Token(Token = "0x400064D")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private GameObject stepBackPlayableDirectorRoot;
  [Token(Token = "0x400064E")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private PlayableDirector pauseTimelinePlayableDirector;
  [Token(Token = "0x400064F")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private CinemachineTargetGroup availableCharacterCenter;
  [Token(Token = "0x4000650")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private CinemachineTargetGroup actioningCharacterCenter;
  [Token(Token = "0x4000651")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private CinemachineTargetGroup flyingObjectAndTargetCenter;
  [Token(Token = "0x4000652")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private CinemachineTargetGroup attackerTeamCenter;
  [Token(Token = "0x4000653")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private CinemachineTargetGroup defenderTeamCenter;
  [Token(Token = "0x4000654")]
  [FieldOffset(Offset = "0xC0")]
  public CinemachineBrain cinemachineBrain;
  [Token(Token = "0x4000655")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private LightForCharacters lightForCharacters;
  [Token(Token = "0x4000656")]
  [FieldOffset(Offset = "0xD0")]
  public BGParameters BGColorController;
  [Token(Token = "0x4000657")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private GlobalTextures globalTextures;
  [Token(Token = "0x4000658")]
  [FieldOffset(Offset = "0xE0")]
  public DuelSkillVCController skillVCController;
  [Token(Token = "0x4000659")]
  [FieldOffset(Offset = "0xE8")]
  private DuelVCShakeController duelVCShakeController;
  [Token(Token = "0x400065A")]
  [FieldOffset(Offset = "0xF0")]
  [SerializeField]
  private CinemachineVirtualCamera defaultVirtualCamera;
  [Token(Token = "0x400065B")]
  [FieldOffset(Offset = "0xF8")]
  [SerializeField]
  private CinemachineVirtualCamera actioningCharacterCenterVC;
  [Token(Token = "0x400065C")]
  [FieldOffset(Offset = "0x100")]
  [SerializeField]
  private CinemachineVirtualCamera flyingObjectVC;
  [Token(Token = "0x400065D")]
  [FieldOffset(Offset = "0x108")]
  [SerializeField]
  private CinemachineVirtualCamera attackerTeamCenterVC;
  [Token(Token = "0x400065E")]
  [FieldOffset(Offset = "0x110")]
  [SerializeField]
  private CinemachineVirtualCamera defenderTeamCenterVC;
  [Token(Token = "0x400065F")]
  [FieldOffset(Offset = "0x118")]
  [SerializeField]
  private GameObject directionalLight;
  [Token(Token = "0x4000660")]
  [FieldOffset(Offset = "0x120")]
  [SerializeField]
  private Volume animatedVolume;
  [Token(Token = "0x4000661")]
  [FieldOffset(Offset = "0x128")]
  [SerializeField]
  private GameObject duelBackgroundRoot;
  [Token(Token = "0x4000662")]
  [FieldOffset(Offset = "0x130")]
  [SerializeField]
  private DuelBGSceneController duelBackgroundController;
  [Token(Token = "0x4000663")]
  [FieldOffset(Offset = "0x138")]
  [SerializeField]
  private GameObject flyingObjectsRoot;
  [Token(Token = "0x4000664")]
  [FieldOffset(Offset = "0x140")]
  [SerializeField]
  private GameObject duelUIRoot;
  [Token(Token = "0x4000665")]
  [FieldOffset(Offset = "0x148")]
  [SerializeField]
  private DuelUIController duelUIController;
  [Token(Token = "0x4000666")]
  [FieldOffset(Offset = "0x150")]
  [SerializeField]
  private Image fadeImage;
  [Token(Token = "0x4000667")]
  [FieldOffset(Offset = "0x158")]
  private Vector3 savedDirectionalLightLocalPosition;
  [Token(Token = "0x4000668")]
  [FieldOffset(Offset = "0x164")]
  private Quaternion savedDirectionalLightLocalRotation;
  [Token(Token = "0x4000669")]
  [FieldOffset(Offset = "0x174")]
  private float savedHardLightBlend;
  [Token(Token = "0x400066A")]
  [FieldOffset(Offset = "0x178")]
  private Color savedHardLightColor;
  [Token(Token = "0x400066B")]
  [FieldOffset(Offset = "0x188")]
  private Color savedDirectionalLightColor;
  [Token(Token = "0x400066C")]
  [FieldOffset(Offset = "0x198")]
  private Scene oldActiveScene;
  [Token(Token = "0x400066D")]
  [FieldOffset(Offset = "0x1A0")]
  private List<GameObject> oldSceneActiveRootObjects;
  [Token(Token = "0x400066E")]
  private const float defaultPlaySpeed = 1f;
  [Token(Token = "0x400066F")]
  [FieldOffset(Offset = "0x0")]
  private static float playSpeed;
  [Token(Token = "0x4000670")]
  [FieldOffset(Offset = "0x4")]
  public static float playSpeedMultiple;
  [Token(Token = "0x4000671")]
  [FieldOffset(Offset = "0x1A8")]
  private float previousTimeScale;
  [Token(Token = "0x4000672")]
  [FieldOffset(Offset = "0x1AC")]
  public bool isGiantBossQuest;
  [Token(Token = "0x4000673")]
  [FieldOffset(Offset = "0x1B0")]
  private List<DuelCharacterController> allDuelCharacters;
  [Token(Token = "0x4000674")]
  [FieldOffset(Offset = "0x1B8")]
  [SerializeField]
  private GameObject attackerControllerPrefab;
  [Token(Token = "0x4000675")]
  [FieldOffset(Offset = "0x1C0")]
  [SerializeField]
  private GameObject attackerSupporterControllerPrefab;
  [Token(Token = "0x4000676")]
  [FieldOffset(Offset = "0x1C8")]
  [SerializeField]
  private GameObject defenderControllerPrefab;
  [Token(Token = "0x4000677")]
  [FieldOffset(Offset = "0x1D0")]
  [SerializeField]
  private GameObject defenderSupporterControllerPrefab;
  [Token(Token = "0x4000678")]
  [FieldOffset(Offset = "0x1D8")]
  private List<DuelCharacterController> availableDuelCharacters;
  [Token(Token = "0x4000679")]
  [FieldOffset(Offset = "0x1E0")]
  private Dictionary<DuelCharacterController.DuelCharacterRole, HashSet<BattleBadStatusTypeEnum>> duelCharacterBadStatus;
  [Token(Token = "0x400067A")]
  [FieldOffset(Offset = "0x1E8")]
  private bool isInitialized;
  [Token(Token = "0x400067B")]
  [FieldOffset(Offset = "0x1EC")]
  private DuelManager.DuelProcessType duelProcessType;
  [Token(Token = "0x400067C")]
  [FieldOffset(Offset = "0x1F0")]
  private bool isPlaying;
  [Token(Token = "0x400067D")]
  [FieldOffset(Offset = "0x1F4")]
  private int currentTurnIndex;
  [Token(Token = "0x400067E")]
  [FieldOffset(Offset = "0x1F8")]
  private List<double> turnStartTimes;
  [Token(Token = "0x400067F")]
  [FieldOffset(Offset = "0x200")]
  private bool isPreviousTurnSkill;
  [Token(Token = "0x4000680")]
  [FieldOffset(Offset = "0x201")]
  private bool shouldUpdateActioningCharacterCenter;
  [Token(Token = "0x4000681")]
  [FieldOffset(Offset = "0x208")]
  private DuelCharacterController currentTurnMainCharacter;
  [Token(Token = "0x4000682")]
  [FieldOffset(Offset = "0x210")]
  private DuelCharacterController currentTurnTargetCharacter;
  [Token(Token = "0x4000683")]
  [FieldOffset(Offset = "0x218")]
  private DuelCharacterController currentTurnTargetPartnerCharacter;
  [Token(Token = "0x4000684")]
  [FieldOffset(Offset = "0x220")]
  private DuelCharacterController previousTurnMainCharacter;
  [Token(Token = "0x4000685")]
  [FieldOffset(Offset = "0x228")]
  private DuelCharacterAction currentTurnMainCharacterAction;
  [Token(Token = "0x4000686")]
  [FieldOffset(Offset = "0x230")]
  private DuelCharacterAction currentTurnTargetCharacterAction;
  [Token(Token = "0x4000687")]
  [FieldOffset(Offset = "0x238")]
  private DuelCharacterAction currentTurnTargetPartnerCharacterAction;
  [Token(Token = "0x4000688")]
  [FieldOffset(Offset = "0x240")]
  private Coroutine duelCoroutine;
  [Token(Token = "0x4000689")]
  [FieldOffset(Offset = "0x248")]
  private List<string> loadedBackgroundScene;
  [Token(Token = "0x400068A")]
  [FieldOffset(Offset = "0x250")]
  private SoundManager soundManager;
  [Token(Token = "0x400068B")]
  [FieldOffset(Offset = "0x258")]
  private AssetBundleManager assetBundleManager;
  [Token(Token = "0x400068C")]
  [FieldOffset(Offset = "0x260")]
  private List<string> loadedAssetBundleNames;
  [Token(Token = "0x400068D")]
  [FieldOffset(Offset = "0x268")]
  private List<string> loadedSkillSceneAssetBundleNames;
  [Token(Token = "0x400068E")]
  [FieldOffset(Offset = "0x270")]
  private List<string> loadedBackGroundSceneAssetBundleNames;
  [Token(Token = "0x400068F")]
  [FieldOffset(Offset = "0x278")]
  private MasterDataManager masterDataManager;
  [Token(Token = "0x4000690")]
  [FieldOffset(Offset = "0x280")]
  private Coroutine initializeCoroutine;
  [Token(Token = "0x4000691")]
  [FieldOffset(Offset = "0x288")]
  public Dictionary<int, DuelSingleSkillSceneController> singleSkillSceneControllerDictionary;
  [Token(Token = "0x4000692")]
  [FieldOffset(Offset = "0x290")]
  private DuelStratagemSceneController stratagemSceneController;
  [Token(Token = "0x4000693")]
  [FieldOffset(Offset = "0x298")]
  private List<Tuple<UnitParameterData, DuelCharacterController.DuelCharacterRole>> availableBattleUnits;
  [Token(Token = "0x4000694")]
  [FieldOffset(Offset = "0x2A0")]
  private DuelVirtualCameraSwitchFlowSettingsAsset currentVCSwitchFlowSettings;
  [Token(Token = "0x4000695")]
  [FieldOffset(Offset = "0x2A8")]
  private string cachedBgSceneName;
  [Token(Token = "0x4000696")]
  [FieldOffset(Offset = "0x2B0")]
  private GameObject cachedDuelBgBaseRoot;
  [Token(Token = "0x4000697")]
  [FieldOffset(Offset = "0x2B8")]
  private GameObject cachedDirectionalBaseLight;
  [Token(Token = "0x4000698")]
  [FieldOffset(Offset = "0x2C0")]
  private int beforeRenderFrameInterval;
  [Token(Token = "0x4000699")]
  [FieldOffset(Offset = "0x2C4")]
  public float movelessTurnTimelineDelay;
  [Token(Token = "0x400069A")]
  [FieldOffset(Offset = "0x2C8")]
  private RenderTexture fullScreenMaskRT;
  [Token(Token = "0x400069B")]
  [FieldOffset(Offset = "0x2D0")]
  [SerializeField]
  private SingleSkillCutinBG fullScreenMaskImage;
  [Token(Token = "0x400069C")]
  [FieldOffset(Offset = "0x2D8")]
  [SerializeField]
  private Transform cutinRoot;
  [Token(Token = "0x400069D")]
  [FieldOffset(Offset = "0x2E0")]
  private bool timelineInPause;
  [Token(Token = "0x400069E")]
  [FieldOffset(Offset = "0x2E1")]
  private bool timelineResumeRequest;
  [Token(Token = "0x400069F")]
  [FieldOffset(Offset = "0x2E8")]
  private GameObject singleSkillCutinPrefab;
  [Token(Token = "0x40006A0")]
  [FieldOffset(Offset = "0x2F0")]
  private GameObject singleSkillCutinObject;
  [Token(Token = "0x40006A1")]
  [FieldOffset(Offset = "0x2F8")]
  private List<GameObject> createdSingleSkillCutinObjects;
  [Token(Token = "0x40006A2")]
  [FieldOffset(Offset = "0x300")]
  private Dictionary<DuelCharacterController.DuelCharacterRole, int> singleSkillOwner;
  [Token(Token = "0x40006A3")]
  [FieldOffset(Offset = "0x308")]
  private AssetCachedSpawner singleSkillCutinAssetCachedSpawner;
  [Token(Token = "0x40006A4")]
  [FieldOffset(Offset = "0x310")]
  private Scene bgScene;
  [Token(Token = "0x40006A5")]
  [FieldOffset(Offset = "0x314")]
  private bool fastMode;
  [Token(Token = "0x40006A6")]
  private const float GIANTBOSS_CAMERA_FOV = 30f;
  [Token(Token = "0x40006A7")]
  private const string duelBGSceneAssetbundleNamePrefix = "content_bg_duel_";
  [Token(Token = "0x40006A8")]
  private const string characterClassSettingsAssetbundleNamePrefix = "content_duel_classes_";
  [Token(Token = "0x40006A9")]
  private const string commonSkillAssetbundleNamePrefix = "content_duel_skill_common_";
  [Token(Token = "0x40006AA")]
  private const string commonSkillSettingsAssetNameFormat = "{0}_CommonSkillSettingsAsset";
  [Token(Token = "0x40006AB")]
  private const string singleSkillAssetbundleNamePrefix = "content_duel_skill_single_";
  [Token(Token = "0x40006AC")]
  private const string singleSkillSettingsAssetNameFormat = "{0}_SingleSkillSettingsAsset";
  [Token(Token = "0x40006AD")]
  private const string stratagemSkillAssetbundleNamePrefix = "content_duel_skill_stratagem_";
  [Token(Token = "0x40006AE")]
  private const string stratagemSkillSettingsAssetNameFormat = "{0}_StratagemSkillSettingsAsset";
  [Token(Token = "0x40006AF")]
  private const string fierceAttackSkillAssetbundleNamePrefix = "content_duel_skill_fierce_";
  [Token(Token = "0x40006B0")]
  private const string fierceAttackSkillSettingsAssetNameFormat = "{0}_FierceAttackSkillSettingsAsset";
  [Token(Token = "0x40006B1")]
  private const string duelUIAssetbundleName = "ui_page_ingame_duelui_prefab";
  [Token(Token = "0x40006B2")]
  private const string duelUIAssetName = "Container_Battle_Duel";
  [Token(Token = "0x40006B3")]
  private const string abnormalStateEffectSettingsAssetbundleName = "content_duel_settings";
  [Token(Token = "0x40006B4")]
  private const string abnormalStateEffectSettingsAssetName = "AbnormalStateEffectSettingsAsset";
  [Token(Token = "0x40006B5")]
  private const string defaultFootSmokeEffectSettingsAssetbundleName = "content_effect3d_common_other";
  [Token(Token = "0x40006B6")]
  private const string defaultFootSmokeEffectSettingsAssetName = "DefaultSmoke";
  [Token(Token = "0x40006B7")]
  private const string singleSkillCutinAssetBundleName = "ui_page_ingame_singlecutin_prefab";
  [Token(Token = "0x40006B8")]
  private const string singleSkillCutinAssetName = "Container_SingleCutin";
  [Token(Token = "0x40006B9")]
  private const string singleSkillCutinFaceAssetBundlePrefix = "content_chr_";
  [Token(Token = "0x40006BA")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_ANIMATION_MALE = "Act_Anim_Track";
  [Token(Token = "0x40006BB")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_ANIMATION_FEMALE = "Act_Anim_Track_F";
  [Token(Token = "0x40006BC")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_FACE_ANIMATION_MALE = "Act_Anim_Face_Track";
  [Token(Token = "0x40006BD")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_FACE_ANIMATION_FEMALE = "Act_Anim_Face_Track_F";
  [Token(Token = "0x40006BE")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_MATERIAL = "Act_Mat_Track";
  [Token(Token = "0x40006BF")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_ANIMATION_OVERRIDE = "Act_Anim_Override_Track";
  [Token(Token = "0x40006C0")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_ANIMATION_OVERRIDE_FEMALE = "Act_Anim_Override_Track_F";
  [Token(Token = "0x40006C1")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_FACE_ANIMATION_OVERRIDE = "Act_Anim_Face_Override_Track";
  [Token(Token = "0x40006C2")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_FACE_ANIMATION_OVERRIDE_FEMALE = "Act_Anim_Face_Override_Track_F";
  [Token(Token = "0x40006C3")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_MOTION = "Act_Pos_Track";
  [Token(Token = "0x40006C4")]
  private const string RESOURCE_TRACK_NAME_TARGET_MOTION = "Tgt_Pos_Track";
  [Token(Token = "0x40006C5")]
  private const string RESOURCE_TRACK_NAME_OBJECT_MOTION = "Obj_Pos_Track";
  [Token(Token = "0x40006C6")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VEHICLE_ANIMATION = "Rid_Anim_Track";
  [Token(Token = "0x40006C7")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VEHICLE_ANIMATION_OVERRIDE = "Rid_Anim_Override_Track";
  [Token(Token = "0x40006C8")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VEHICLE_MOTION = "Rid_Pos_Track";
  [Token(Token = "0x40006C9")]
  private const string RESOURCE_TRACK_NAME_ACTION_CAMERA = "Virtual_Cam_Track";
  [Token(Token = "0x40006CA")]
  private const string RESOURCE_TRACK_NAME_PREFIX_WEAPON_ANIMATION = "Wep_Anim_Track_";
  [Token(Token = "0x40006CB")]
  private const string RESOURCE_TRACK_NAME_SKILL_CAMERA = "Skill_Cam_Track";
  [Token(Token = "0x40006CC")]
  private const string RESOURCE_TRACK_NAME_SKILL_CAMERA_AIM_TARGET_FOR_ACTOR = "Act_Aim_Pos_Track";
  [Token(Token = "0x40006CD")]
  private const string RESOURCE_TRACK_NAME_SKILL_CAMERA_AIM_TARGET_FOR_TARGET = "Tgt_Aim_Pos_Track";
  [Token(Token = "0x40006CE")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_SIGNAL = "Cam_Swich_Track";
  [Token(Token = "0x40006CF")]
  private const string RESOURCE_TRACK_NAME_CAMERA_SHAKE = "Cam_Shake_Track";
  [Token(Token = "0x40006D0")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_SOUND = "Act_Sound_Track";
  [Token(Token = "0x40006D1")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VOICE = "Act_Voice_Track";
  [Token(Token = "0x40006D2")]
  private const string RESOURCE_TRACK_NAME_CAMERA_SWITCH = "Cam_Switch_Track";
  [Token(Token = "0x40006D3")]
  private const string RESOURCE_TRACK_NAME_TIME_DILATION = "Time Dilation Track";
  [Token(Token = "0x40006D4")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_DISSOLVE = "Act_Anim_Track_Dissolve";
  [Token(Token = "0x40006D5")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_DISSOLVE_ENEMY = "Act_Anim_Track_Dissolve_Emy";
  [Token(Token = "0x40006D6")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_DEATH_EFFECT = "Act_Eff_Character_Death";
  [Token(Token = "0x40006D7")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_DEATH_EFFECT_ENEMY = "Act_Eff_Character_Death_Emy";
  [Token(Token = "0x40006D8")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_EFFECT = "Act_Eff_Track";
  [Token(Token = "0x40006D9")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_WEAPON_BREAK_EFFECT = "Act_Wep_Break";
  [Token(Token = "0x40006DA")]
  private const string RESOURCE_TRACK_NAME_HIT_EFFECT = "Hit_Eff_Track";
  [Token(Token = "0x40006DB")]
  private const string RESOURCE_TRACK_NAME_TARGET_EFFECT = "Tgt_Eff_Track";
  [Token(Token = "0x40006DC")]
  private const string RESOURCE_TRACK_NAME_POST_EFFECT = "Post_Eff_Track";
  [Token(Token = "0x40006DD")]
  private const string RESOURCE_TRACK_NAME_POST_EFFECT_ANIMATION = "Post_Eff_Anim_Track";
  [Token(Token = "0x40006DE")]
  private const string RESOURCE_TRACK_NAME_BG_COLOR = "BG_Color_Track";
  [Token(Token = "0x40006DF")]
  private const string WEAPON_TYPE_TRACK_NAME_PREFIX = "Wep_Type_Eff_Track";
  [Token(Token = "0x40006E0")]
  private const string RESOURCE_TRACK_NAME_STAGE_ANIMATION = "Stg_Animation_Track";
  [Token(Token = "0x40006E1")]
  private const string RESOURCE_TRACK_NAME_STAGE_ACTIVATION = "Stg_Activation_Track";
  [Token(Token = "0x40006E2")]
  private const string RESOURCE_TRACK_NAME_OLD_BG_ACTIVATION = "OBG_Activation_Track";
  [Token(Token = "0x40006E3")]
  private const string RESOURCE_TRACK_NAME_SKILL_BG_ACTIVATION = "SBG_Activation_Track";
  [Token(Token = "0x40006E4")]
  private const string RESOURCE_TRACK_NAME_LIGHT_CONTROL = "Light_Ctrl_Track";
  [Token(Token = "0x40006E5")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_LIGHT = "Chr_Light_Track";
  [Token(Token = "0x40006E6")]
  private const string RESOURCE_TRACK_NAME_BG_COLOR_COLLECT = "Bg_Color_Collect_Track";
  [Token(Token = "0x40006E7")]
  private const string RESOURCE_TRACK_NAME_CAMERA_EFFECT = "Cam_Eff_Track";
  [Token(Token = "0x40006E8")]
  private const string ANIMATION_TRACK_NAME_ATTACKER = "Attacker Animation Track";
  [Token(Token = "0x40006E9")]
  private const string ANIMATION_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Animation Track";
  [Token(Token = "0x40006EA")]
  private const string ANIMATION_TRACK_NAME_DEFENDER = "Defender Animation Track";
  [Token(Token = "0x40006EB")]
  private const string ANIMATION_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Animation Track";
  [Token(Token = "0x40006EC")]
  private const string VEHICLE_ANIMATION_TRACK_NAME_ATTACKER = "Attacker Vehicle Animation Track";
  [Token(Token = "0x40006ED")]
  private const string VEHICLE_ANIMATION_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Vehicle Animation Track";
  [Token(Token = "0x40006EE")]
  private const string VEHICLE_ANIMATION_TRACK_NAME_DEFENDER = "Defender Vehicle Animation Track";
  [Token(Token = "0x40006EF")]
  private const string VEHICLE_ANIMATION_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Vehicle Animation Track";
  [Token(Token = "0x40006F0")]
  private const string MATERIAL_TRACK_NAME_ATTACKER = "Attacker Material Track";
  [Token(Token = "0x40006F1")]
  private const string MATERIAL_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Material Track";
  [Token(Token = "0x40006F2")]
  private const string MATERIAL_TRACK_NAME_DEFENDER = "Defender Material Track";
  [Token(Token = "0x40006F3")]
  private const string MATERIAL_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Material Track";
  [Token(Token = "0x40006F4")]
  private const string VEHICLE_MATERIAL_TRACK_NAME_ATTACKER = "Attacker Vehicle Material Track";
  [Token(Token = "0x40006F5")]
  private const string VEHICLE_MATERIAL_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Vehicle Material Track";
  [Token(Token = "0x40006F6")]
  private const string VEHICLE_MATERIAL_TRACK_NAME_DEFENDER = "Defender Vehicle Material Track";
  [Token(Token = "0x40006F7")]
  private const string VEHICLE_MATERIAL_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Vehicle Material Track";
  [Token(Token = "0x40006F8")]
  private const string MOTION_TRACK_NAME_ATTACKER = "Attacker Motion Track";
  [Token(Token = "0x40006F9")]
  private const string MOTION_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Motion Track";
  [Token(Token = "0x40006FA")]
  private const string MOTION_TRACK_NAME_DEFENDER = "Defender Motion Track";
  [Token(Token = "0x40006FB")]
  private const string MOTION_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Motion Track";
  [Token(Token = "0x40006FC")]
  private const string VEHICLE_MOTION_TRACK_NAME_ATTACKER = "Attacker Vehicle Motion Track";
  [Token(Token = "0x40006FD")]
  private const string VEHICLE_MOTION_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Vehicle Motion Track";
  [Token(Token = "0x40006FE")]
  private const string VEHICLE_MOTION_TRACK_NAME_DEFENDER = "Defender Vehicle Motion Track";
  [Token(Token = "0x40006FF")]
  private const string VEHICLE_MOTION_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Vehicle Motion Track";
  [Token(Token = "0x4000700")]
  private const string SIGNAL_TRACK_NAME_ATTACKER = "Attacker Signal Track";
  [Token(Token = "0x4000701")]
  private const string SIGNAL_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Signal Track";
  [Token(Token = "0x4000702")]
  private const string SIGNAL_TRACK_NAME_DEFENDER = "Defender Signal Track";
  [Token(Token = "0x4000703")]
  private const string SIGNAL_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Signal Track";
  [Token(Token = "0x4000704")]
  private const string ACTION_VC_TRACK_NAME_ATTACKER = "Attacker Action VC Track";
  [Token(Token = "0x4000705")]
  private const string ACTION_VC_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Action VC Track";
  [Token(Token = "0x4000706")]
  private const string ACTION_VC_TRACK_NAME_DEFENDER = "Defender Action VC Track";
  [Token(Token = "0x4000707")]
  private const string ACTION_VC_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Action VC Track";
  [Token(Token = "0x4000708")]
  private const string VC_SHAKE_TRACK_NAME_ATTACKER = "Attacker VC Shake Track";
  [Token(Token = "0x4000709")]
  private const string VC_SHAKE_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner VC Shake Track";
  [Token(Token = "0x400070A")]
  private const string VC_SHAKE_TRACK_NAME_DEFENDER = "Defender VC Shake Track";
  [Token(Token = "0x400070B")]
  private const string VC_SHAKE_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner VC Shake Track";
  [Token(Token = "0x400070C")]
  private const string SKILL_VC_TRACK_NAME_ATTACKER = "Attacker Skill VC Track";
  [Token(Token = "0x400070D")]
  private const string SKILL_VC_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Skill VC Track";
  [Token(Token = "0x400070E")]
  private const string SKILL_VC_TRACK_NAME_DEFENDER = "Defender Skill VC Track";
  [Token(Token = "0x400070F")]
  private const string SKILL_VC_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Skill VC Track";
  [Token(Token = "0x4000710")]
  private const string SKILL_VC_AIM_TARGET_TRACK_NAME_ATTACKER = "Attacker Skill VC Aim Target Track";
  [Token(Token = "0x4000711")]
  private const string SKILL_VC_AIM_TARGET_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Skill VC Aim Target Track";
  [Token(Token = "0x4000712")]
  private const string SKILL_VC_AIM_TARGET_TRACK_NAME_DEFENDER = "Defender Skill VC Aim Target Track";
  [Token(Token = "0x4000713")]
  private const string SKILL_VC_AIM_TARGET_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Skill VC Aim Target Track";
  [Token(Token = "0x4000714")]
  private const string EFFECT_TRACK_NAME_ATTACKER = "Attacker Effect Track";
  [Token(Token = "0x4000715")]
  private const string EFFECT_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Effect Track";
  [Token(Token = "0x4000716")]
  private const string EFFECT_TRACK_NAME_DEFENDER = "Defender Effect Track";
  [Token(Token = "0x4000717")]
  private const string EFFECT_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Effect Track";
  [Token(Token = "0x4000718")]
  private const string POST_EFFECT_ANIMATION_TRACK_NAME_ATTACKER = "Attacker Post Effect Animation Track";
  [Token(Token = "0x4000719")]
  private const string POST_EFFECT_ANIMATION_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner Post Effect Animation Track";
  [Token(Token = "0x400071A")]
  private const string POST_EFFECT_ANIMATION_TRACK_NAME_DEFENDER = "Defender Post Effect Animation Track";
  [Token(Token = "0x400071B")]
  private const string POST_EFFECT_ANIMATION_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner Post Effect Animation Track";
  [Token(Token = "0x400071C")]
  private const string BG_COLOR_TRACK_NAME_ATTACKER = "Attacker BG Color Track";
  [Token(Token = "0x400071D")]
  private const string BG_COLOR_TRACK_NAME_ATTACKER_PARTNER = "Attacker Partner BG Color Track";
  [Token(Token = "0x400071E")]
  private const string BG_COLOR_TRACK_NAME_DEFENDER = "Defender BG Color Track";
  [Token(Token = "0x400071F")]
  private const string BG_COLOR_TRACK_NAME_DEFENDER_PARTNER = "Defender Partner BG Color Track";
  [Token(Token = "0x4000720")]
  private const string SIGNAL_TRACK_NAME_MAIN = "Main Signal Track";
  [Token(Token = "0x4000721")]
  private const string SIGNAL_TRACK_NAME_SUB = "Sub Signal Track";
  [Token(Token = "0x4000722")]
  private const string MARKER_NAME_DAMAGE = "Damage";
  [Token(Token = "0x4000723")]
  private const string MARKER_NAME_DAMAGE_IN_ESCAPE_FOR_DEATH = "Damage2";
  [Token(Token = "0x4000724")]
  private const string MARKER_NAME_DAMAGE_LIGHT = "Damage_Light";
  [Token(Token = "0x4000725")]
  private const string MARKER_NAME_DAMAGE_CONTINUOUS = "Damage_Continuous";
  [Token(Token = "0x4000726")]
  private const string MARKER_NAME_DAMAGE_CONTINUOUS_END = "Damage_Continuous_End";
  [Token(Token = "0x4000727")]
  private const string MARKER_NAME_SHOT = "Shot";
  [Token(Token = "0x4000728")]
  private const string MARKER_NAME_SHOT_LIGHT = "Shot_Light";
  [Token(Token = "0x4000729")]
  private const string MARKER_NAME_SHOT_CONTINUOUS = "Shot_Continuous";
  [Token(Token = "0x400072A")]
  private const string MARKER_NAME_SHOT_CONTINUOUS_END = "Shot_Continuous_End";
  [Token(Token = "0x400072B")]
  private const string MARKER_NAME_ATTACK_END = "Attack_End";
  [Token(Token = "0x400072C")]
  private const string MARKER_NAME_NEXT_TURN_MOVE_START = "Next_Turn_Move_Start";
  [Token(Token = "0x400072D")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VOICE_DUAL_GUARD = "Act_Voice_Track_DualGuard";
  [Token(Token = "0x400072E")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VOICE_SINGLE_GUARD = "Act_Voice_Track_SingleGuard";
  [Token(Token = "0x400072F")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VOICE_ATTACK = "Act_Voice_Track_Atk";
  [Token(Token = "0x4000730")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VOICE_DEFENDER_FIRST_STRIKE = "Act_Voice_Track_Preemptive";
  [Token(Token = "0x4000731")]
  private const string RESOURCE_TRACK_NAME_CHARACTER_VOICE_DEFENDER_FIRST_STRIKE_PAIR = "Act_Voice_Track_Preemptive_Pair";

  [Token(Token = "0x6000824")]
  [Address(RVA = "0x408752C", Offset = "0x408752C", VA = "0x408752C")]
  public void InitializeFromDuelDebugTool(IDuelDebugToolController duelDebugToolController)
  {
  }

  [Token(Token = "0x6000825")]
  [Address(RVA = "0x4087568", Offset = "0x4087568", VA = "0x4087568")]
  public IEnumerator InitializeFromDuelDebugToolCoroutine(
    IDuelDebugToolController duelDebugToolController)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000826")]
  [Address(RVA = "0x40875DC", Offset = "0x40875DC", VA = "0x40875DC")]
  public IEnumerator InitializeFromBattleFieldCoroutine(
    DuelData duelData,
    DuelManager.DuelProcessType processType)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000827")]
  [Address(RVA = "0x4087658", Offset = "0x4087658", VA = "0x4087658")]
  public IEnumerator InitializeFromBattleSetupSceneCoroutine(
    DuelData duelData,
    DuelManager.DuelProcessType processType,
    bool fastMode)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000828")]
  [Address(RVA = "0x40876EC", Offset = "0x40876EC", VA = "0x40876EC")]
  private IEnumerator InitializeNormalAttackCommonSingleSkill(DuelData duelData = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000829")]
  [Address(RVA = "0x4087760", Offset = "0x4087760", VA = "0x4087760")]
  private IEnumerator InitializeStratagem(DuelData duelData = null) => (IEnumerator) null;

  [Token(Token = "0x600082A")]
  [Address(RVA = "0x40877D4", Offset = "0x40877D4", VA = "0x40877D4")]
  private IEnumerator InitializeFiereceAttack(DuelData duelData = null) => (IEnumerator) null;

  [Token(Token = "0x600082B")]
  [Address(RVA = "0x4087848", Offset = "0x4087848", VA = "0x4087848")]
  private void CreateDuelCharacterControllers(DuelData duelData)
  {
  }

  [Token(Token = "0x600082C")]
  [Address(RVA = "0x4087E68", Offset = "0x4087E68", VA = "0x4087E68")]
  private void CreateDissolveComponentToCharacters()
  {
  }

  [Token(Token = "0x600082D")]
  [Address(RVA = "0x4087DE8", Offset = "0x4087DE8", VA = "0x4087DE8")]
  private DuelCharacterController CreateDuelCharacterController(
    GameObject prefab,
    DuelCharacterController.DuelCharacterRole role,
    ForceTypeEnum force)
  {
    return (DuelCharacterController) null;
  }

  [Token(Token = "0x600082E")]
  [Address(RVA = "0x4087BE4", Offset = "0x4087BE4", VA = "0x4087BE4")]
  private void DestroyDuelCharacterControllers()
  {
  }

  [Token(Token = "0x600082F")]
  [Address(RVA = "0x40880AC", Offset = "0x40880AC", VA = "0x40880AC")]
  private IEnumerator InitializeDuelSettingsDataFromBattleField(
    DuelData duelData,
    DuelManager.DuelProcessType processType)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000830")]
  [Address(RVA = "0x4088128", Offset = "0x4088128", VA = "0x4088128")]
  private IEnumerator InitializeDuelSettingsDataFromDuelDebugTool(
    IDuelDebugToolController duelDebugToolController)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000831")]
  [Address(RVA = "0x408819C", Offset = "0x408819C", VA = "0x408819C")]
  private void InitializeDuelSettingsSoundPackName(
    DuelSettingsAsset duelSettings,
    DuelData duelData)
  {
  }

  [Token(Token = "0x6000832")]
  [Address(RVA = "0x40885F8", Offset = "0x40885F8", VA = "0x40885F8")]
  private void InitializeDuelSettingsSoundPackName(
    DuelSettingsAsset duelSettings,
    IDuelDebugToolController duelDebugToolController)
  {
  }

  [Token(Token = "0x6000833")]
  [Address(RVA = "0x4088E10", Offset = "0x4088E10", VA = "0x4088E10")]
  private string BackgroundSceneName(DuelData duelData) => (string) null;

  [Token(Token = "0x6000834")]
  [Address(RVA = "0x4088EAC", Offset = "0x4088EAC", VA = "0x4088EAC")]
  private IEnumerator InitializeDuelSettingsDataForNormalAttackAndCommonSingleSkill(
    DuelData duelData)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000835")]
  [Address(RVA = "0x4088F20", Offset = "0x4088F20", VA = "0x4088F20")]
  private int GetSupporterInitHP(List<DuelTurnActions> duelTurnActionsList) => new int();

  [Token(Token = "0x6000836")]
  [Address(RVA = "0x4089210", Offset = "0x4089210", VA = "0x4089210")]
  private IEnumerator InitializeDuelSettingsDataForStratagem(DuelData duelData)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000837")]
  [Address(RVA = "0x4089284", Offset = "0x4089284", VA = "0x4089284")]
  private IEnumerator InitializeDuelSettingsDataForFierceAttack(DuelData duelData)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000838")]
  [Address(RVA = "0x40892F8", Offset = "0x40892F8", VA = "0x40892F8")]
  private IEnumerator InitializeDuelSettingsDataForNormalAttackAndCommonSingleSkill(
    IDuelDebugToolController duelDebugToolController)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000839")]
  [Address(RVA = "0x408936C", Offset = "0x408936C", VA = "0x408936C")]
  private IEnumerator InitializeDuelSettingsDataForStratagem(
    IDuelDebugToolController duelDebugToolController)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x600083A")]
  [Address(RVA = "0x40893E0", Offset = "0x40893E0", VA = "0x40893E0")]
  private IEnumerator InitializeDuelSettingsDataForFierceAttack(
    IDuelDebugToolController duelDebugToolController)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x600083B")]
  [Address(RVA = "0x4089454", Offset = "0x4089454", VA = "0x4089454")]
  private IEnumerator InitializeDuelAbnormalEffect() => (IEnumerator) null;

  [Token(Token = "0x600083C")]
  [Address(RVA = "0x40894BC", Offset = "0x40894BC", VA = "0x40894BC")]
  private void InitializeDuelCharacterAbnormalState(DuelData duelData)
  {
  }

  [Token(Token = "0x600083D")]
  [Address(RVA = "0x4089FE0", Offset = "0x4089FE0", VA = "0x4089FE0")]
  private IEnumerator InitializeDefaultFootSmokeEffect() => (IEnumerator) null;

  [Token(Token = "0x600083E")]
  [Address(RVA = "0x408A048", Offset = "0x408A048", VA = "0x408A048")]
  private IEnumerator InitializeDuelUIFromBattleField(
    DuelData duelData,
    List<Tuple<UnitParameterData, DuelCharacterController.DuelCharacterRole>> availableBattleUnits,
    DuelManager.DuelProcessType processType)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x600083F")]
  [Address(RVA = "0x408A0D4", Offset = "0x408A0D4", VA = "0x408A0D4")]
  private IEnumerator InitializeDuelUIFromDuelDebugTool(
    IDuelDebugToolController duelDebugToolController,
    DuelSettingsAsset duelSettingsAsset)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000840")]
  [Address(RVA = "0x408A150", Offset = "0x408A150", VA = "0x408A150")]
  private IEnumerator InitializeSingleSkillScene(string sceneName) => (IEnumerator) null;

  [Token(Token = "0x6000841")]
  [Address(RVA = "0x408A1C4", Offset = "0x408A1C4", VA = "0x408A1C4")]
  private IEnumerator InitializeBackgroundScene(string sceneName, DuelData duelData = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000842")]
  [Address(RVA = "0x408A240", Offset = "0x408A240", VA = "0x408A240")]
  private IEnumerator InitializeStratagemScene(string sceneName) => (IEnumerator) null;

  [Token(Token = "0x6000843")]
  [Address(RVA = "0x408A2B4", Offset = "0x408A2B4", VA = "0x408A2B4")]
  public void Play()
  {
  }

  [Token(Token = "0x6000844")]
  [Address(RVA = "0x408A460", Offset = "0x408A460", VA = "0x408A460")]
  public bool IsPlaying() => new bool();

  [Token(Token = "0x6000845")]
  [Address(RVA = "0x408A328", Offset = "0x408A328", VA = "0x408A328")]
  private IEnumerator PlayNormalAttackAndCommonSingleSkillCoroutine() => (IEnumerator) null;

  [Token(Token = "0x6000846")]
  [Address(RVA = "0x408A468", Offset = "0x408A468", VA = "0x408A468")]
  private void UpdateDuelUIHitAndCrit(
    DuelCharacterController.DuelCharacterRole role,
    int hitRate,
    int critRate)
  {
  }

  [Token(Token = "0x6000847")]
  [Address(RVA = "0x408A4C4", Offset = "0x408A4C4", VA = "0x408A4C4")]
  private bool IsMainCharacterMoving() => new bool();

  [Token(Token = "0x6000848")]
  [Address(RVA = "0x408A390", Offset = "0x408A390", VA = "0x408A390")]
  private IEnumerator PlayStratagemCoroutine() => (IEnumerator) null;

  [Token(Token = "0x6000849")]
  [Address(RVA = "0x408A3F8", Offset = "0x408A3F8", VA = "0x408A3F8")]
  private IEnumerator PlayFierceAttackCoroutine() => (IEnumerator) null;

  [Token(Token = "0x600084A")]
  [Address(RVA = "0x408A4E0", Offset = "0x408A4E0", VA = "0x408A4E0")]
  private void UpdateActioningCharacterCenter()
  {
  }

  [Token(Token = "0x600084B")]
  [Address(RVA = "0x408A738", Offset = "0x408A738", VA = "0x408A738")]
  private void SwitchVirtualCamera(DuelTurnActions.VirtualCameraType vcType, bool isPlayingTimeline)
  {
  }

  [Token(Token = "0x600084C")]
  [Address(RVA = "0x408A998", Offset = "0x408A998", VA = "0x408A998")]
  private void ClearCharacterMoveStatus()
  {
  }

  [Token(Token = "0x600084D")]
  [Address(RVA = "0x408AAE4", Offset = "0x408AAE4", VA = "0x408AAE4")]
  private void ClearCharacterTransformOffsets()
  {
  }

  [Token(Token = "0x600084E")]
  [Address(RVA = "0x408AC30", Offset = "0x408AC30", VA = "0x408AC30")]
  private void ClearCharacterHealEffects()
  {
  }

  [Token(Token = "0x600084F")]
  [Address(RVA = "0x408AD7C", Offset = "0x408AD7C", VA = "0x408AD7C")]
  private void ClearCopiedCharacterMaterials()
  {
  }

  [Token(Token = "0x6000850")]
  [Address(RVA = "0x408AEDC", Offset = "0x408AEDC", VA = "0x408AEDC")]
  private void SetCharacterToGuardAndEscapeMode(List<DuelCharacterAction> duelCharacterActions)
  {
  }

  [Token(Token = "0x6000851")]
  [Address(RVA = "0x408B324", Offset = "0x408B324", VA = "0x408B324")]
  private void ClearFlyingObjects()
  {
  }

  [Token(Token = "0x6000852")]
  [Address(RVA = "0x408B630", Offset = "0x408B630", VA = "0x408B630")]
  private void DisableVirutalCameras()
  {
  }

  [Token(Token = "0x6000853")]
  [Address(RVA = "0x408B634", Offset = "0x408B634", VA = "0x408B634")]
  private void ClearCharacterLoadedResources()
  {
  }

  [Token(Token = "0x6000854")]
  [Address(RVA = "0x408B780", Offset = "0x408B780", VA = "0x408B780")]
  private void DisableFieldBackground()
  {
  }

  [Token(Token = "0x6000855")]
  [Address(RVA = "0x408BA0C", Offset = "0x408BA0C", VA = "0x408BA0C")]
  private void EnableFieldBackground()
  {
  }

  [Token(Token = "0x6000856")]
  [Address(RVA = "0x408BC40", Offset = "0x408BC40", VA = "0x408BC40")]
  private string StratagemDirectionTypeToWeaponType(StratagemDirectionTypeEnum directionTypeEnum)
  {
    return (string) null;
  }

  [Token(Token = "0x6000857")]
  [Address(RVA = "0x408BCC8", Offset = "0x408BCC8", VA = "0x408BCC8")]
  private void SetTrackWeaponTypeAndElementType(
    PlayableDirector playableDirector,
    string weaponType,
    ElementEffectItem.ElementType elementType,
    UnityEngine.Object bindingTarget)
  {
  }

  [Token(Token = "0x6000858")]
  [Address(RVA = "0x408C170", Offset = "0x408C170", VA = "0x408C170")]
  private void SetTrackVoiceActor(
    PlayableDirector playableDirector,
    DuelCharacterController.DuelCharacterRole role)
  {
  }

  [Token(Token = "0x6000859")]
  [Address(RVA = "0x408C6A0", Offset = "0x408C6A0", VA = "0x408C6A0")]
  private void SetVoiceTrackSituation(
    PlayableDirector playableDirector,
    string trackName,
    BattleVoiceTimingEnum battleVoiceTimingEnum)
  {
  }

  [Token(Token = "0x600085A")]
  [Address(RVA = "0x408CA84", Offset = "0x408CA84", VA = "0x408CA84")]
  private void ResetAnimatedVolume()
  {
  }

  [Token(Token = "0x600085B")]
  [Address(RVA = "0x408CBB0", Offset = "0x408CBB0", VA = "0x408CBB0")]
  public void Clear()
  {
  }

  [Token(Token = "0x600085C")]
  [Address(RVA = "0x408DC6C", Offset = "0x408DC6C", VA = "0x408DC6C")]
  public void EnableTargetFrontAheadVC()
  {
  }

  [Token(Token = "0x600085D")]
  [Address(RVA = "0x408DC78", Offset = "0x408DC78", VA = "0x408DC78")]
  public void EnableTargetFrontNearVC()
  {
  }

  [Token(Token = "0x600085E")]
  [Address(RVA = "0x408DC84", Offset = "0x408DC84", VA = "0x408DC84")]
  public void EnableTargetFrontMediumVC()
  {
  }

  [Token(Token = "0x600085F")]
  [Address(RVA = "0x408DC90", Offset = "0x408DC90", VA = "0x408DC90")]
  public void EnableTargetFrontFarVC()
  {
  }

  [Token(Token = "0x6000860")]
  [Address(RVA = "0x408DC9C", Offset = "0x408DC9C", VA = "0x408DC9C")]
  public void EnableTargetRightBehindVC()
  {
  }

  [Token(Token = "0x6000861")]
  [Address(RVA = "0x408DCA8", Offset = "0x408DCA8", VA = "0x408DCA8")]
  public void EnableTargetBackNearVC()
  {
  }

  [Token(Token = "0x6000862")]
  [Address(RVA = "0x408DCB4", Offset = "0x408DCB4", VA = "0x408DCB4")]
  public void EnableTargetBackMediumVC()
  {
  }

  [Token(Token = "0x6000863")]
  [Address(RVA = "0x408DCC0", Offset = "0x408DCC0", VA = "0x408DCC0")]
  public void EnableTargetBackFarVC()
  {
  }

  [Token(Token = "0x6000864")]
  [Address(RVA = "0x408DCCC", Offset = "0x408DCCC", VA = "0x408DCCC")]
  public void EnableMainTeamCenterVC()
  {
  }

  [Token(Token = "0x6000865")]
  [Address(RVA = "0x408DCD8", Offset = "0x408DCD8", VA = "0x408DCD8")]
  public void EnableTargetTeamCenterVC()
  {
  }

  [Token(Token = "0x6000866")]
  [Address(RVA = "0x408DCE4", Offset = "0x408DCE4", VA = "0x408DCE4")]
  public void EnableActioningCharacterCenterVC()
  {
  }

  [Token(Token = "0x6000867")]
  [Address(RVA = "0x408DCF0", Offset = "0x408DCF0", VA = "0x408DCF0")]
  public void EnableFlyingObjectVC()
  {
  }

  [Token(Token = "0x6000868")]
  [Address(RVA = "0x408DCFC", Offset = "0x408DCFC", VA = "0x408DCFC")]
  public void SwitchToAttackStartVC()
  {
  }

  [Token(Token = "0x6000869")]
  [Address(RVA = "0x408DD1C", Offset = "0x408DD1C", VA = "0x408DD1C")]
  public void SwitchToEscapeStartVC()
  {
  }

  [Token(Token = "0x600086A")]
  [Address(RVA = "0x408DD4C", Offset = "0x408DD4C", VA = "0x408DD4C")]
  public void SwitchToBeforeHitVC()
  {
  }

  [Token(Token = "0x600086B")]
  [Address(RVA = "0x408DD6C", Offset = "0x408DD6C", VA = "0x408DD6C")]
  public void OnCameraActivated(ICinemachineCamera after, ICinemachineCamera before)
  {
  }

  [Token(Token = "0x600086C")]
  [Address(RVA = "0x408DF14", Offset = "0x408DF14", VA = "0x408DF14")]
  public void NextTurnMoveStart()
  {
  }

  [Token(Token = "0x600086D")]
  [Address(RVA = "0x408DF34", Offset = "0x408DF34", VA = "0x408DF34")]
  private IEnumerator MoveInAdvanceCoroutine() => (IEnumerator) null;

  [Token(Token = "0x600086E")]
  [Address(RVA = "0x408DF9C", Offset = "0x408DF9C", VA = "0x408DF9C")]
  private void SetCharacterTransformBeforeSkill(
    List<DuelCharacterAction> characterActions,
    DuelCharacterAnimation.MainAnimationType mainAnimationType)
  {
  }

  [Token(Token = "0x600086F")]
  [Address(RVA = "0x408E154", Offset = "0x408E154", VA = "0x408E154")]
  private void SaveDuelEnvironment()
  {
  }

  [Token(Token = "0x6000870")]
  [Address(RVA = "0x408D9BC", Offset = "0x408D9BC", VA = "0x408D9BC")]
  private void ResumeDuelEnvironment()
  {
  }

  [Token(Token = "0x6000871")]
  [Address(RVA = "0x408E234", Offset = "0x408E234", VA = "0x408E234")]
  private void ResumeCharacterTransformAfterSkill(
    List<DuelCharacterController.DuelCharacterRole> actionCharacters)
  {
  }

  [Token(Token = "0x6000872")]
  [Address(RVA = "0x408E478", Offset = "0x408E478", VA = "0x408E478")]
  public void ThrowFlyingObject(Shot_Base marker)
  {
  }

  [Token(Token = "0x6000873")]
  [Address(RVA = "0x408EB68", Offset = "0x408EB68", VA = "0x408EB68")]
  public Transform GetLookAtTarget(VirtualCameraControlMarker marker) => (Transform) null;

  [Token(Token = "0x6000874")]
  [Address(RVA = "0x408ED44", Offset = "0x408ED44", VA = "0x408ED44")]
  public void UpdateCharacterStatus(UpdateCharacterStatusMarker marker)
  {
  }

  [Token(Token = "0x6000875")]
  [Address(RVA = "0x408F340", Offset = "0x408F340", VA = "0x408F340")]
  public void SetPlaySpeed(bool fastMode)
  {
  }

  [Token(Token = "0x6000876")]
  [Address(RVA = "0x408F4E8", Offset = "0x408F4E8", VA = "0x408F4E8")]
  public static float GetDuelTimeScale() => new float();

  [Token(Token = "0x6000877")]
  [Address(RVA = "0x408F540", Offset = "0x408F540", VA = "0x408F540")]
  private string GetDuelCharacterAnimationTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000878")]
  [Address(RVA = "0x408F5F8", Offset = "0x408F5F8", VA = "0x408F5F8")]
  private string GetDuelCharacterFaceAnimationTrackName(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000879")]
  [Address(RVA = "0x408F6CC", Offset = "0x408F6CC", VA = "0x408F6CC")]
  private string GetDuelCharacterMaterialTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x600087A")]
  [Address(RVA = "0x408F784", Offset = "0x408F784", VA = "0x408F784")]
  private string GetDuelCharacterVehicleAnimationTrackName(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x600087B")]
  [Address(RVA = "0x408F83C", Offset = "0x408F83C", VA = "0x408F83C")]
  private string GetDuelCharacterVehicleMaterialTrackName(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x600087C")]
  [Address(RVA = "0x408F8F4", Offset = "0x408F8F4", VA = "0x408F8F4")]
  private string GetDuelCharacterMotionTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x600087D")]
  [Address(RVA = "0x408F9AC", Offset = "0x408F9AC", VA = "0x408F9AC")]
  private string GetDuelCharacterVehicleMotionTrackName(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x600087E")]
  [Address(RVA = "0x408FA64", Offset = "0x408FA64", VA = "0x408FA64")]
  private string GetDuelCharacterBGColorTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x600087F")]
  [Address(RVA = "0x408FB1C", Offset = "0x408FB1C", VA = "0x408FB1C")]
  private string GetDuelCharacterSignalTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000880")]
  [Address(RVA = "0x408FBD4", Offset = "0x408FBD4", VA = "0x408FBD4")]
  private string GetDuelCharacterActionVCTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000881")]
  [Address(RVA = "0x408FC8C", Offset = "0x408FC8C", VA = "0x408FC8C")]
  private string GetDuelCharacterVCShakeTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000882")]
  [Address(RVA = "0x408FD44", Offset = "0x408FD44", VA = "0x408FD44")]
  private string GetDuelCharacterSkillVCTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000883")]
  [Address(RVA = "0x408FDFC", Offset = "0x408FDFC", VA = "0x408FDFC")]
  private string GetDuelCharacterSkillVCAimTargetTrackName(
    DuelCharacterController.DuelCharacterRole role,
    bool isActor)
  {
    return (string) null;
  }

  [Token(Token = "0x6000884")]
  [Address(RVA = "0x408FEC0", Offset = "0x408FEC0", VA = "0x408FEC0")]
  private string GetDuelCharacterEffectTrackName(DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000885")]
  [Address(RVA = "0x408FF78", Offset = "0x408FF78", VA = "0x408FF78")]
  private string GetDuelCharacterPostEffectAnimationTrackName(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (string) null;
  }

  [Token(Token = "0x6000886")]
  [Address(RVA = "0x408B1CC", Offset = "0x408B1CC", VA = "0x408B1CC")]
  public DuelCharacterController GetDuelCharacterController(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (DuelCharacterController) null;
  }

  [Token(Token = "0x6000887")]
  [Address(RVA = "0x4090030", Offset = "0x4090030", VA = "0x4090030")]
  private Tuple<TimelineAsset, DuelCharacterAnimation.MainAnimationRange, float> GetMainCharacterTimelineData(
    DuelCharacterAction duelCharacterAction)
  {
    return (Tuple<TimelineAsset, DuelCharacterAnimation.MainAnimationRange, float>) null;
  }

  [Token(Token = "0x6000888")]
  [Address(RVA = "0x4090348", Offset = "0x4090348", VA = "0x4090348")]
  private DuelCharacterCommonTimelineSettingsAsset GetPassiveCharacterTimelineSettings(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (DuelCharacterCommonTimelineSettingsAsset) null;
  }

  [Token(Token = "0x6000889")]
  [Address(RVA = "0x409043C", Offset = "0x409043C", VA = "0x409043C")]
  private TimelineAsset GetDamageTimelineAsset(
    DuelCharacterCommonTimelineSettingsAsset timelineSettings,
    Marker marker)
  {
    return (TimelineAsset) null;
  }

  [Token(Token = "0x600088A")]
  [Address(RVA = "0x409062C", Offset = "0x409062C", VA = "0x409062C")]
  private DuelCharacterSettings GetSideCharacterSettings(
    DuelCharacterController.DuelCharacterRole role)
  {
    return (DuelCharacterSettings) null;
  }

  [Token(Token = "0x600088B")]
  [Address(RVA = "0x40907E0", Offset = "0x40907E0", VA = "0x40907E0")]
  private void CreateActiveDuelCharacterTimelineTracks(
    DuelCharacterController mainCharcterController,
    DuelCharacterController targetCharcterController,
    PlayableDirector duelTurnPlayableDirector,
    TimelineAsset resourceTimelineAsset,
    DuelCharacterSettings characterSettings,
    double startTime,
    DuelManager.DuelHitStatus hitType,
    DuelCharacterAction mainCharacterAction,
    bool hasShotMarker,
    float defaultAttackDistance,
    List<Tuple<double, Marker>> damageMarkerTimes,
    double originalFirstMarkerTime,
    bool isLastTurn)
  {
  }

  [Token(Token = "0x600088C")]
  [Address(RVA = "0x40928D8", Offset = "0x40928D8", VA = "0x40928D8")]
  private void CreateActiveDuelCharacterTimelineTracksForFierceAttack(
    DuelCharacterController actorController,
    PlayableDirector playableDirector,
    TimelineAsset resourceTimelineAsset,
    DuelCharacterSettings characterSettings,
    double startTime,
    DuelCharacterAction actorAction)
  {
  }

  [Token(Token = "0x600088D")]
  [Address(RVA = "0x409381C", Offset = "0x409381C", VA = "0x409381C")]
  private void CreateSingleSkillDuelCharacterTimelineTracks(
    DuelCharacterController controller,
    PlayableDirector playableDirector,
    DuelSingleSkillSceneController singleSkillSceneController,
    int turnNumber,
    DuelCharacterAction mainCharacterAction,
    List<Tuple<double, Marker>> damageMarkerTimes,
    List<Tuple<double, Marker>> pauseMarkerTimes,
    Tuple<double, Marker> fastModeEntryPoint,
    double originalFirstMarkerTime)
  {
  }

  [Token(Token = "0x600088E")]
  [Address(RVA = "0x40948D0", Offset = "0x40948D0", VA = "0x40948D0")]
  private void UpdateSingleSkillTimelineBindingTarget(
    DuelCharacterController actorController,
    DuelCharacterController targetController,
    DuelSingleSkillSceneController singleSkillSceneController,
    bool isWeaponBreak,
    DuelCharacterSettings actorCharacterSettings)
  {
  }

  [Token(Token = "0x600088F")]
  [Address(RVA = "0x4095BA8", Offset = "0x4095BA8", VA = "0x4095BA8")]
  private void CreatePassiveDuelCharacterTimelineTracks(
    DuelCharacterController passiveCharacterController,
    DuelCharacterController mainCharacterController,
    PlayableDirector targetPlayableDirector,
    DuelCharacterAction mainCharacterAction,
    bool hasShotMarker,
    DuelCharacterAction passiveCharacterAction,
    DuelCharacterCommonTimelineSettingsAsset passiveCharacterTimelineSettings,
    TimelineAsset activeResourceTimelineAsset,
    List<Tuple<double, Marker>> damageMarkerTimes,
    double? attackEndMarkerTime,
    double maxStartTimeOffset,
    DuelManager.DuelHitStatus hitStatus,
    float defaultFlyingDistance,
    float realFlyingDistance)
  {
  }

  [Token(Token = "0x6000890")]
  [Address(RVA = "0x4095E64", Offset = "0x4095E64", VA = "0x4095E64")]
  private void CreateDuelCharacterDamageTimelineTracks(
    DuelCharacterController passiveCharacterController,
    DuelCharacterController mainCharacterController,
    PlayableDirector duelTurnPlayableDirector,
    DuelCharacterAction passiveCharacterAction,
    DuelCharacterCommonTimelineSettingsAsset passiveCharacterTimelineSettings,
    TimelineAsset activeResourceTimelineAsset,
    double activeResourceTimelineStartTime,
    List<Tuple<double, Marker>> damageMarkerTimes,
    DuelCharacterAction mainCharacterAction,
    bool hasShotMarker,
    float defaultFlyingDistance,
    float realFlyingDistance,
    bool noDamageMotion)
  {
  }

  [Token(Token = "0x6000891")]
  [Address(RVA = "0x4097610", Offset = "0x4097610", VA = "0x4097610")]
  private void CreateDuelCharacterEscapeTimelineTracks(
    DuelCharacterController passiveCharacterController,
    DuelCharacterController mainCharacterController,
    PlayableDirector duelTurnPlayableDirector,
    DuelCharacterCommonTimelineSettingsAsset passiveCharacterTimelineSettings,
    List<Tuple<double, Marker>> damageMarkerTimes,
    TimelineAsset activeResourceTimelineAsset,
    double activeResourceTimelineStartTime,
    DuelCharacterAction mainCharacterAction,
    bool hasShotMarker,
    float defaultFlyingDistance,
    float realFlyingDistance,
    DuelManager.DuelHitStatus hitStatus,
    DuelCharacterAction passiveCharacterAction)
  {
  }

  [Token(Token = "0x6000892")]
  [Address(RVA = "0x409D1C0", Offset = "0x409D1C0", VA = "0x409D1C0")]
  private void CreateDuelCharacterStepBackTracks(
    PlayableDirector playableDirector,
    DuelCharacterSettings duelCharacterSettings,
    DuelCharacterController duelCharacterController)
  {
  }

  [Token(Token = "0x6000893")]
  [Address(RVA = "0x4098718", Offset = "0x4098718", VA = "0x4098718")]
  private void CreateDuelCharacterDualGuardTimelineTracks(
    DuelCharacterController passiveCharacterController,
    DuelCharacterController mainCharacterController,
    PlayableDirector duelTurnPlayableDirector,
    DuelCharacterAction passiveCharacterAction,
    DuelCharacterCommonTimelineSettingsAsset passiveCharacterTimelineSettings,
    List<Tuple<double, Marker>> damageMarkerTimes,
    double attackEndMarkerTime,
    TimelineAsset activeResourceTimelineAsset,
    double activeResourceTimelineStartTime,
    DuelCharacterAction mainCharacterAction,
    bool hasShotMarker,
    float defaultFlyingDistance,
    float realFlyingDistance)
  {
  }

  [Token(Token = "0x6000894")]
  [Address(RVA = "0x409AB38", Offset = "0x409AB38", VA = "0x409AB38")]
  private void CreateDuelCharacterSingleGuardTimelineTracks(
    DuelCharacterController passiveCharacterController,
    DuelCharacterController mainCharacterController,
    PlayableDirector duelTurnPlayableDirector,
    DuelCharacterCommonTimelineSettingsAsset passiveCharacterTimelineSettings,
    List<Tuple<double, Marker>> damageMarkerTimes,
    double attackEndMarkerTime,
    TimelineAsset activeResourceTimelineAsset,
    double activeResourceTimelineStartTime,
    DuelCharacterAction mainCharacterAction,
    bool hasShotMarker,
    float defaultFlyingDistance,
    float realFlyingDistance,
    DuelCharacterAction passiveCharacterAction)
  {
  }

  [Token(Token = "0x6000895")]
  [Address(RVA = "0x409C60C", Offset = "0x409C60C", VA = "0x409C60C")]
  private void CreateDuelCharacterReceiveSupportTimelineTracks(
    DuelCharacterController passiveCharacterController,
    DuelCharacterController mainCharacterController,
    PlayableDirector duelTurnPlayableDirector,
    DuelCharacterAction passiveCharacterAction,
    DuelCharacterCommonTimelineSettingsAsset passiveCharacterTimelineSettings,
    TimelineAsset activeResourceTimelineAsset,
    double activeResourceTimelineStartTime,
    List<Tuple<double, Marker>> damageMarkerTimes,
    DuelCharacterAction mainCharacterAction,
    bool hasShotMarker,
    float defaultFlyingDistance,
    float realFlyingDistance)
  {
  }

  [Token(Token = "0x6000896")]
  [Address(RVA = "0x409DD40", Offset = "0x409DD40", VA = "0x409DD40")]
  private void MoveToTarget(
    DuelCharacterController movedCharacter,
    DuelCharacterController targetCharacter,
    float attackTimelineDistance,
    DuelCharacterAnimation.MainAnimationRange mainAnimationRange,
    DuelCharacterAnimation.MainAnimationType mainAnimationType)
  {
  }

  [Token(Token = "0x6000897")]
  [Address(RVA = "0x409DF8C", Offset = "0x409DF8C", VA = "0x409DF8C")]
  private void WarpToTarget(
    DuelCharacterController movedCharacter,
    DuelCharacterController targetCharacter,
    float attackTimelineDistance)
  {
  }

  [Token(Token = "0x6000898")]
  [Address(RVA = "0x409E118", Offset = "0x409E118", VA = "0x409E118")]
  private void KeepRelativePositionFromPartner(
    DuelCharacterController movedCharacter,
    float attackTimelineDistance,
    DuelCharacterAnimation.MainAnimationRange mainAnimationRange,
    DuelCharacterAnimation.MainAnimationType mainAnimationType)
  {
  }

  [Token(Token = "0x6000899")]
  [Address(RVA = "0x40927AC", Offset = "0x40927AC", VA = "0x40927AC")]
  public static string GetDuelCharacterWeaponAnimationTrackName(
    SexTypeEnum gender,
    string defaultName,
    TimelineAsset timelineAsset)
  {
    return (string) null;
  }

  [Token(Token = "0x600089A")]
  [Address(RVA = "0x40924E4", Offset = "0x40924E4", VA = "0x40924E4")]
  public static string GetDuelCharacterResourceAnimationTrackName(
    SexTypeEnum gender,
    TimelineAsset timelineAsset)
  {
    return (string) null;
  }

  [Token(Token = "0x600089B")]
  [Address(RVA = "0x4092648", Offset = "0x4092648", VA = "0x4092648")]
  public static string GetDuelCharacterResourceFaceAnimationTrackName(
    SexTypeEnum gender,
    TimelineAsset timelineAsset)
  {
    return (string) null;
  }

  [Token(Token = "0x600089C")]
  [Address(RVA = "0x409DA78", Offset = "0x409DA78", VA = "0x409DA78")]
  private string GetDuelCharacterResourceAnimationOverrideTrackName(
    SexTypeEnum gender,
    TimelineAsset timelineAsset)
  {
    return (string) null;
  }

  [Token(Token = "0x600089D")]
  [Address(RVA = "0x409DBDC", Offset = "0x409DBDC", VA = "0x409DBDC")]
  private string GetDuelCharacterResourceFaceAnimationOverrideTrackName(
    SexTypeEnum gender,
    TimelineAsset timelineAsset)
  {
    return (string) null;
  }

  [Token(Token = "0x600089E")]
  [Address(RVA = "0x409E43C", Offset = "0x409E43C", VA = "0x409E43C")]
  public DuelCharacterController.DuelCharacterRole GetOpponentCharacterRole(
    DuelCharacterController.DuelCharacterRole myTeamCharacter,
    bool getMainCharacter)
  {
    return new DuelCharacterController.DuelCharacterRole();
  }

  [Token(Token = "0x600089F")]
  [Address(RVA = "0x409E468", Offset = "0x409E468", VA = "0x409E468")]
  public DuelCharacterController.DuelCharacterRole GetPartnerCharacterRole(
    DuelCharacterController.DuelCharacterRole role)
  {
    return new DuelCharacterController.DuelCharacterRole();
  }

  [Token(Token = "0x60008A0")]
  [Address(RVA = "0x409E48C", Offset = "0x409E48C", VA = "0x409E48C")]
  private bool IsMainCharacterRole(DuelCharacterController.DuelCharacterRole role) => new bool();

  [Token(Token = "0x60008A1")]
  [Address(RVA = "0x408DB6C", Offset = "0x408DB6C", VA = "0x408DB6C")]
  private void UnloadScene(string chacheStageName = "")
  {
  }

  [Token(Token = "0x60008A2")]
  [Address(RVA = "0x409E4A8", Offset = "0x409E4A8", VA = "0x409E4A8")]
  public static ElementEffectItem.ElementType GetElementType(ElementTypeEnum elementTypeEnum)
  {
    return new ElementEffectItem.ElementType();
  }

  [Token(Token = "0x60008A3")]
  [Address(RVA = "0x409E4CC", Offset = "0x409E4CC", VA = "0x409E4CC")]
  public void TakeScreenShotAndPauseTimeline()
  {
  }

  [Token(Token = "0x60008A4")]
  [Address(RVA = "0x409E4EC", Offset = "0x409E4EC", VA = "0x409E4EC")]
  private IEnumerator TakeScreenShot() => (IEnumerator) null;

  [Token(Token = "0x60008A5")]
  [Address(RVA = "0x409E554", Offset = "0x409E554", VA = "0x409E554")]
  private void CreateSingleSkillCutin()
  {
  }

  [Token(Token = "0x60008A6")]
  [Address(RVA = "0x409E66C", Offset = "0x409E66C", VA = "0x409E66C")]
  public void FadeOutFastModeBack()
  {
  }

  [Token(Token = "0x60008A7")]
  [Address(RVA = "0x409E6D4", Offset = "0x409E6D4", VA = "0x409E6D4")]
  public void ResumeTimelineFromScreenShotPause()
  {
  }

  [Token(Token = "0x60008A8")]
  [Address(RVA = "0x409E718", Offset = "0x409E718", VA = "0x409E718")]
  private void TakeScreenShot(ScriptableRenderContext context, Camera camera)
  {
  }

  [Token(Token = "0x60008A9")]
  [Address(RVA = "0x40898E4", Offset = "0x40898E4", VA = "0x40898E4")]
  private bool NeedToSwapPosition(DuelData duelData) => new bool();

  [Token(Token = "0x60008AA")]
  [Address(RVA = "0x409E8B0", Offset = "0x409E8B0", VA = "0x409E8B0")]
  private DuelCharacterController.DuelCharacterRole GetTurnActionTargetRole(
    ActionData turnActionData)
  {
    return new DuelCharacterController.DuelCharacterRole();
  }

  [Token(Token = "0x60008AB")]
  [Address(RVA = "0x409EA74", Offset = "0x409EA74", VA = "0x409EA74")]
  private void ApplyStatusEffectToTarget(ActionData turnActionData)
  {
  }

  [Token(Token = "0x60008AC")]
  [Address(RVA = "0x408F2A8", Offset = "0x408F2A8", VA = "0x408F2A8")]
  private void ApplyStatusEffectToTarget(
    DuelCharacterController.DuelCharacterRole targetRole,
    BattleBadStatusTypeEnum badStatus)
  {
  }

  [Token(Token = "0x60008AD")]
  [Address(RVA = "0x40899B0", Offset = "0x40899B0", VA = "0x40899B0")]
  private bool IsBadStatusOnTarget(
    DuelCharacterController.DuelCharacterRole targetRole)
  {
    return new bool();
  }

  [Token(Token = "0x60008AE")]
  [Address(RVA = "0x4089A40", Offset = "0x4089A40", VA = "0x4089A40")]
  private BattleBadStatusTypeEnum GetMostImportantBadStatusEffectByTargetRole(
    DuelCharacterController.DuelCharacterRole targetRole)
  {
    return new BattleBadStatusTypeEnum();
  }

  [Token(Token = "0x60008AF")]
  [Address(RVA = "0x4089CF0", Offset = "0x4089CF0", VA = "0x4089CF0")]
  private List<BattleBadStatusData> GetEffectOrderedBadStatusEffectsByTargetRole(
    DuelCharacterController.DuelCharacterRole targetRole)
  {
    return (List<BattleBadStatusData>) null;
  }

  [Token(Token = "0x60008B0")]
  [Address(RVA = "0x409EC3C", Offset = "0x409EC3C", VA = "0x409EC3C")]
  public DuelManager()
  {
  }

  [Token(Token = "0x60008B1")]
  [Address(RVA = "0x409EFC8", Offset = "0x409EFC8", VA = "0x409EFC8")]
  static DuelManager()
  {
  }

  [Token(Token = "0x200012C")]
  public enum DuelProcessType
  {
    [Token(Token = "0x4000733")] NormalAttackAndCommonSingleSkill,
    [Token(Token = "0x4000734")] Stratagem,
    [Token(Token = "0x4000735")] FierceAttack,
  }

  [Token(Token = "0x200012D")]
  public enum DuelHitStatus
  {
    [Token(Token = "0x4000737")] Hit,
    [Token(Token = "0x4000738")] Escaped,
    [Token(Token = "0x4000739")] DualGuarded,
  }
}
