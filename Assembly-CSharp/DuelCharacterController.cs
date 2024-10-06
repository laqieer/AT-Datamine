// Decompiled with JetBrains decompiler
// Type: DuelCharacterController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x20000FC")]
public class DuelCharacterController : MonoBehaviour
{
  [Token(Token = "0x40004BB")]
  [FieldOffset(Offset = "0x18")]
  private DuelManager duelManager;
  [Token(Token = "0x40004BC")]
  [FieldOffset(Offset = "0x20")]
  private DuelCharacterSettingsAsset duelCharacterSettingsAsset;
  [Token(Token = "0x40004BD")]
  [FieldOffset(Offset = "0x28")]
  private CinemachineTargetGroup actioningCharacterCenter;
  [Token(Token = "0x40004BE")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private NavMeshAgent navMeshAgent;
  [Token(Token = "0x40004BF")]
  [FieldOffset(Offset = "0x38")]
  public GameObject agentRotationRoot;
  [Token(Token = "0x40004C0")]
  [FieldOffset(Offset = "0x40")]
  public GameObject timelineMotionRoot;
  [Token(Token = "0x40004C1")]
  [FieldOffset(Offset = "0x48")]
  public GameObject riderTimelineMotionRoot;
  [Token(Token = "0x40004C2")]
  [FieldOffset(Offset = "0x50")]
  public GameObject timelineMotionRootParent;
  [Token(Token = "0x40004C3")]
  [FieldOffset(Offset = "0x58")]
  public List<GameObject> customGameObjectMotionRoots;
  [Token(Token = "0x40004C4")]
  [FieldOffset(Offset = "0x60")]
  public List<GameObject> customGameObjectInnerRoots;
  [Token(Token = "0x40004C5")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private GameObject innerRotationRoot;
  [Token(Token = "0x40004C6")]
  [FieldOffset(Offset = "0x70")]
  public GameObject innerMotionRoot;
  [Token(Token = "0x40004C7")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  public CinemachineVirtualCamera frontNearVC;
  [Token(Token = "0x40004C8")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  public CinemachineVirtualCamera backNearVC;
  [Token(Token = "0x40004C9")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  public CinemachineVirtualCamera frontMediumVC;
  [Token(Token = "0x40004CA")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  public CinemachineVirtualCamera backMediumVC;
  [Token(Token = "0x40004CB")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  public CinemachineVirtualCamera frontFarVC;
  [Token(Token = "0x40004CC")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  public CinemachineVirtualCamera backFarVC;
  [Token(Token = "0x40004CD")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  public CinemachineVirtualCamera frontAheadVC;
  [Token(Token = "0x40004CE")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  public CinemachineVirtualCamera rightBehindVC;
  [Token(Token = "0x40004CF")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  public CinemachineVirtualCamera actionVC;
  [Token(Token = "0x40004D0")]
  [FieldOffset(Offset = "0xC0")]
  public GameObject actionVCRoot;
  [Token(Token = "0x40004D1")]
  [FieldOffset(Offset = "0xC8")]
  public GameObject staticVCRoot;
  [Token(Token = "0x40004D2")]
  [FieldOffset(Offset = "0xD0")]
  public GameObject dynamicVCRoot;
  [Token(Token = "0x40004D3")]
  [FieldOffset(Offset = "0xD8")]
  private DuelCharacterVCSettingsAsset VCSettings;
  [Token(Token = "0x40004D4")]
  [FieldOffset(Offset = "0xE0")]
  private List<DuelTargetGroup> generatedDuelTargetGroups;
  [Token(Token = "0x40004D5")]
  [FieldOffset(Offset = "0xE8")]
  public GameObject characterModel;
  [Token(Token = "0x40004D6")]
  [FieldOffset(Offset = "0xF0")]
  public GameObject vehicleModel;
  [Token(Token = "0x40004D7")]
  [FieldOffset(Offset = "0xF8")]
  private GameObject characterJRoot;
  [Token(Token = "0x40004D8")]
  [FieldOffset(Offset = "0x100")]
  private GameObject vehicleJRoot;
  [Token(Token = "0x40004D9")]
  [FieldOffset(Offset = "0x108")]
  public GameObject characterJHips;
  [Token(Token = "0x40004DA")]
  [FieldOffset(Offset = "0x110")]
  public GameObject vehicleJHips;
  [Token(Token = "0x40004DB")]
  [FieldOffset(Offset = "0x118")]
  public GameObject characterJHead;
  [Token(Token = "0x40004DC")]
  [FieldOffset(Offset = "0x120")]
  public WeaponMoverCorrector weaponMoverCorrector;
  [Token(Token = "0x40004DD")]
  [FieldOffset(Offset = "0x128")]
  public Animator characterModelAnimator;
  [Token(Token = "0x40004DE")]
  [FieldOffset(Offset = "0x130")]
  public Animator vehicleModelAnimator;
  [Token(Token = "0x40004DF")]
  [FieldOffset(Offset = "0x138")]
  private DuelCharacterSoundController characterSoundController;
  [Token(Token = "0x40004E0")]
  [FieldOffset(Offset = "0x140")]
  private DuelCharacterSoundController vehicleSoundController;
  [Token(Token = "0x40004E1")]
  [FieldOffset(Offset = "0x148")]
  [SerializeField]
  private DuelCharacterMaterialController characterMaterialController;
  [Token(Token = "0x40004E2")]
  [FieldOffset(Offset = "0x150")]
  private GameObject footSmoke;
  [Token(Token = "0x40004E3")]
  [FieldOffset(Offset = "0x158")]
  public DuelCharacterController.DuelCharacterRole role;
  [Token(Token = "0x40004E4")]
  [FieldOffset(Offset = "0x15C")]
  public ForceTypeEnum force;
  [Token(Token = "0x40004E5")]
  [FieldOffset(Offset = "0x160")]
  public SexTypeEnum gender;
  [Token(Token = "0x40004E6")]
  [FieldOffset(Offset = "0x168")]
  public DuelCharacterController opponentLeader;
  [Token(Token = "0x40004E7")]
  [FieldOffset(Offset = "0x170")]
  public DuelCharacterController opponentSupporter;
  [Token(Token = "0x40004E8")]
  [FieldOffset(Offset = "0x178")]
  public DuelCharacterController myPartner;
  [Token(Token = "0x40004E9")]
  [FieldOffset(Offset = "0x180")]
  private DuelCharacterController lookAtTargetForAgentRotationRoot;
  [Token(Token = "0x40004EA")]
  [FieldOffset(Offset = "0x188")]
  public DuelCharacterController lookAtTargetForInnerRotationRoot;
  [Token(Token = "0x40004EB")]
  [FieldOffset(Offset = "0x190")]
  public Vector3? moveDestination;
  [Token(Token = "0x40004ED")]
  [FieldOffset(Offset = "0x1A4")]
  private DuelCharacterController.MoveMethod moveMethod;
  [Token(Token = "0x40004EE")]
  [FieldOffset(Offset = "0x1A8")]
  private float minWalkSpeed;
  [Token(Token = "0x40004EF")]
  [FieldOffset(Offset = "0x1AC")]
  private float minRunSpeed;
  [Token(Token = "0x40004F0")]
  [FieldOffset(Offset = "0x1B0")]
  private DuelCharacterController.MoveStatus moveStatus;
  [Token(Token = "0x40004F1")]
  [FieldOffset(Offset = "0x1B4")]
  private bool isAbnormalState;
  [Token(Token = "0x40004F2")]
  [FieldOffset(Offset = "0x1B8")]
  private BattleBadStatusTypeEnum abnormalState;
  [Token(Token = "0x40004F3")]
  [FieldOffset(Offset = "0x1C0")]
  private string toIdleTriggerName;
  [Token(Token = "0x40004F4")]
  [FieldOffset(Offset = "0x1C8")]
  private GameObject abnormalStateStartEffect;
  [Token(Token = "0x40004F5")]
  [FieldOffset(Offset = "0x1D0")]
  private GameObject abnormalStateLoopEffect;
  [Token(Token = "0x40004F6")]
  [FieldOffset(Offset = "0x1D8")]
  private Dictionary<Renderer, Material[]> originalMaterialDictionary;
  [Token(Token = "0x40004F7")]
  [FieldOffset(Offset = "0x1E0")]
  private Dictionary<Renderer, Material[]> abnormalStateMaterialDictionary;
  [Token(Token = "0x40004F8")]
  [FieldOffset(Offset = "0x1E8")]
  private List<DynamicBone> dynamicBones;
  [Token(Token = "0x40004F9")]
  [FieldOffset(Offset = "0x1F0")]
  private GameObject healEffect;
  [Token(Token = "0x40004FA")]
  [FieldOffset(Offset = "0x1F8")]
  public Dictionary<string, Tuple<GameObject, GameObject>> equipmentDictionary;
  [Token(Token = "0x40004FB")]
  [FieldOffset(Offset = "0x200")]
  private DuelCharacterAbnormalStateEffectSettingsAsset abnormalStateSettingsAsset;
  [Token(Token = "0x40004FC")]
  [FieldOffset(Offset = "0x208")]
  public Vector3 relativePositionFromPartner;
  [Token(Token = "0x40004FD")]
  [FieldOffset(Offset = "0x214")]
  private Vector3 savedAgentMotionRootLocalPosition;
  [Token(Token = "0x40004FE")]
  [FieldOffset(Offset = "0x220")]
  private Quaternion savedAgentMotionRootLocalRotation;
  [Token(Token = "0x40004FF")]
  [FieldOffset(Offset = "0x230")]
  private Quaternion savedAgentRotationRootLocalRotation;
  [Token(Token = "0x4000501")]
  [FieldOffset(Offset = "0x244")]
  private float moveForwardThreshold;
  [Token(Token = "0x4000502")]
  [FieldOffset(Offset = "0x248")]
  private float moveBackwardThreshold;
  [Token(Token = "0x4000503")]
  [FieldOffset(Offset = "0x24C")]
  private bool isInitialized;
  [Token(Token = "0x4000504")]
  [FieldOffset(Offset = "0x250")]
  private float defaultFoV;
  [Token(Token = "0x4000505")]
  private const string TRIGGER_NAME_TO_IDLE_NORMAL = "ToIdle";
  [Token(Token = "0x4000506")]
  private const string TRIGGER_NAME_TO_WALK = "ToWalk";
  [Token(Token = "0x4000507")]
  private const string TRIGGER_NAME_TO_RUN = "ToRun";
  [Token(Token = "0x4000508")]
  private const string TRIGGER_NAME_TO_IDLE_ABNORMAL = "ToAbnormal";
  [Token(Token = "0x4000509")]
  private const string LOC_FOOT_ATTACH_L = "Loc_Foot_Attach_L";
  [Token(Token = "0x400050A")]
  private const string LOC_FOOT_ATTACH_R = "Loc_Foot_Attach_R";
  [Token(Token = "0x400050B")]
  private const string LOC_REINS_HAND_L = "Loc_Reins_hand_L";
  [Token(Token = "0x400050C")]
  private const string LOC_REINS_HAND_R = "Loc_Reins_hand_R";
  [Token(Token = "0x400050D")]
  private const string LOC_WEAPON_HAND_L = "Loc_Weapon_Hand_L";
  [Token(Token = "0x400050E")]
  private const string LOC_WEAPON_HAND_R = "Loc_Weapon_Hand_R";
  [Token(Token = "0x400050F")]
  private const string J_TOEBASE_L = "J_ToeBase_L";
  [Token(Token = "0x4000510")]
  private const string J_TOEBASE_R = "J_ToeBase_R";
  [Token(Token = "0x4000511")]
  private const string LOC_WEAPON_L = "Loc_Weapon_L";
  [Token(Token = "0x4000512")]
  private const string LOC_WEAPON_R = "Loc_Weapon_R";
  [Token(Token = "0x4000513")]
  [FieldOffset(Offset = "0x258")]
  public PlayableDirector stepBackPlayableDirector;

  [Token(Token = "0x17000067")]
  public bool IsMoving
  {
    [Token(Token = "0x60006E2"), Address(RVA = "0x4188768", Offset = "0x4188768", VA = "0x4188768")] get
    {
      return new bool();
    }
    [Token(Token = "0x60006E3"), Address(RVA = "0x4188770", Offset = "0x4188770", VA = "0x4188770")] private set
    {
    }
  }

  [Token(Token = "0x17000068")]
  public bool IsRider
  {
    [Token(Token = "0x60006E4"), Address(RVA = "0x418877C", Offset = "0x418877C", VA = "0x418877C")] get
    {
      return new bool();
    }
    [Token(Token = "0x60006E5"), Address(RVA = "0x4188784", Offset = "0x4188784", VA = "0x4188784")] private set
    {
    }
  }

  [Token(Token = "0x17000069")]
  public bool IsInitialized
  {
    [Token(Token = "0x60006E6"), Address(RVA = "0x4188790", Offset = "0x4188790", VA = "0x4188790")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x60006E7")]
  [Address(RVA = "0x4188798", Offset = "0x4188798", VA = "0x4188798")]
  public void InitializeForNormalAttackAndCommonSingleSkill(
    DuelManager duelManager,
    DuelCharacterSettings characterSettings,
    DuelCharacterSettings partnerSettings,
    DuelCharacterAbnormalStateEffectSettingsAsset abnormalStateSettingsAsset,
    CinemachineTargetGroup actioningCharacterCenter,
    GameObject defaultFootSmokePrefab)
  {
  }

  [Token(Token = "0x60006E8")]
  [Address(RVA = "0x418BAF8", Offset = "0x418BAF8", VA = "0x418BAF8")]
  public void InitializeForStratagem(
    DuelManager duelManager,
    DuelCharacterSettings characterSettings,
    DuelCharacterSettings partnerSettings,
    DuelCharacterAbnormalStateEffectSettingsAsset abnormalStateSettingsAsset,
    CinemachineTargetGroup actioningCharacterCenter)
  {
  }

  [Token(Token = "0x60006E9")]
  [Address(RVA = "0x418BCE4", Offset = "0x418BCE4", VA = "0x418BCE4")]
  public void InitializeForFierceAttack(
    DuelManager duelManager,
    DuelCharacterSettings characterSettings,
    DuelCharacterSettings partnerSettings,
    DuelCharacterAbnormalStateEffectSettingsAsset abnormalStateSettingsAsset,
    CinemachineTargetGroup actioningCharacterCenter)
  {
  }

  [Token(Token = "0x60006EA")]
  [Address(RVA = "0x418ACB4", Offset = "0x418ACB4", VA = "0x418ACB4")]
  private void SetConstraint(
    GameObject fromParentGameObject,
    string fromChildGameObjectName,
    GameObject toParentGameObject,
    string toChildGameObjectName)
  {
  }

  [Token(Token = "0x60006EB")]
  [Address(RVA = "0x418C474", Offset = "0x418C474", VA = "0x418C474")]
  public Vector3 GetWeaponMoverCorrectionValue(string nodeName) => new Vector3();

  [Token(Token = "0x60006EC")]
  [Address(RVA = "0x418C5D4", Offset = "0x418C5D4", VA = "0x418C5D4")]
  public void EnableWeaponMoverCorrector(Vector3 correctionValue)
  {
  }

  [Token(Token = "0x60006ED")]
  [Address(RVA = "0x418C604", Offset = "0x418C604", VA = "0x418C604")]
  public void DisableWeaponMoverCorrector()
  {
  }

  [Token(Token = "0x60006EE")]
  [Address(RVA = "0x4189E00", Offset = "0x4189E00", VA = "0x4189E00")]
  public static void AddEffectNodes(
    GameObject root,
    List<EffectNodeSettingsData> effectNodeSettingsDataList)
  {
  }

  [Token(Token = "0x60006EF")]
  [Address(RVA = "0x418C678", Offset = "0x418C678", VA = "0x418C678")]
  public void SetRelatedDuelCharacters(
    DuelCharacterController opponentLeader,
    DuelCharacterController opponentSupporter,
    DuelCharacterController myPartner)
  {
  }

  [Token(Token = "0x60006F0")]
  [Address(RVA = "0x418C684", Offset = "0x418C684", VA = "0x418C684")]
  public bool IsLeader() => new bool();

  [Token(Token = "0x60006F1")]
  [Address(RVA = "0x418C698", Offset = "0x418C698", VA = "0x418C698")]
  public bool IsSupporter() => new bool();

  [Token(Token = "0x60006F2")]
  [Address(RVA = "0x418C6B4", Offset = "0x418C6B4", VA = "0x418C6B4")]
  public IEnumerator SetMotionEnabledCoroutine(bool isEnabled, float delay) => (IEnumerator) null;

  [Token(Token = "0x60006F3")]
  [Address(RVA = "0x418AF00", Offset = "0x418AF00", VA = "0x418AF00")]
  private void InitializeStaticVC()
  {
  }

  [Token(Token = "0x60006F4")]
  [Address(RVA = "0x418C740", Offset = "0x418C740", VA = "0x418C740")]
  private Transform CreateDuelTargetGroup(
    CinemachineVirtualCamera virtualCamera,
    CinemachineTargetGroup targetGroup,
    GameObject parent)
  {
    return (Transform) null;
  }

  [Token(Token = "0x60006F5")]
  [Address(RVA = "0x418C8A0", Offset = "0x418C8A0", VA = "0x418C8A0")]
  private void StartMove(bool isMovingForward)
  {
  }

  [Token(Token = "0x60006F6")]
  [Address(RVA = "0x418CCE0", Offset = "0x418CCE0", VA = "0x418CCE0")]
  public void MoveTo(
    Vector3 worldDestination,
    DuelCharacterController lookAtTargetForAgentRotationRoot,
    DuelCharacterController lookAtTargetForInnerRotationRoot)
  {
  }

  [Token(Token = "0x60006F7")]
  [Address(RVA = "0x418D310", Offset = "0x418D310", VA = "0x418D310")]
  public void ClearTransformOffset()
  {
  }

  [Token(Token = "0x60006F8")]
  [Address(RVA = "0x418D83C", Offset = "0x418D83C", VA = "0x418D83C")]
  public void SetCharacterPosition(Vector3 localPosition)
  {
  }

  [Token(Token = "0x60006F9")]
  [Address(RVA = "0x418D88C", Offset = "0x418D88C", VA = "0x418D88C")]
  public void ClearCharacterRotation()
  {
  }

  [Token(Token = "0x60006FA")]
  [Address(RVA = "0x418CF9C", Offset = "0x418CF9C", VA = "0x418CF9C")]
  public void SetCharacterOrientation(
    DuelCharacterController lookAtTargetForAgentRotationRoot,
    DuelCharacterController lookAtTargetForInnerRotationRoot,
    bool shouldConsiderSpeed)
  {
  }

  [Token(Token = "0x60006FB")]
  [Address(RVA = "0x418D958", Offset = "0x418D958", VA = "0x418D958")]
  public void SetModelVisibility(bool isVisible)
  {
  }

  [Token(Token = "0x60006FC")]
  [Address(RVA = "0x418E69C", Offset = "0x418E69C", VA = "0x418E69C")]
  public void SetMaterialControllerEnabled(bool isEnabled)
  {
  }

  [Token(Token = "0x60006FD")]
  [Address(RVA = "0x418CB0C", Offset = "0x418CB0C", VA = "0x418CB0C")]
  public void PrepareToMoveByTimeline(float moveDistance)
  {
  }

  [Token(Token = "0x60006FE")]
  [Address(RVA = "0x418E6EC", Offset = "0x418E6EC", VA = "0x418E6EC")]
  public void ResetAgentTransformBeforeSkill()
  {
  }

  [Token(Token = "0x60006FF")]
  [Address(RVA = "0x418E894", Offset = "0x418E894", VA = "0x418E894")]
  public void ResetAgentTransformBeforeSkill2()
  {
  }

  [Token(Token = "0x6000700")]
  [Address(RVA = "0x418EAB4", Offset = "0x418EAB4", VA = "0x418EAB4")]
  public void ResumeAgentTransformAfterSkill()
  {
  }

  [Token(Token = "0x6000701")]
  [Address(RVA = "0x418EB44", Offset = "0x418EB44", VA = "0x418EB44")]
  public void ResumeAgentTransformAfterSkill2()
  {
  }

  [Token(Token = "0x6000702")]
  [Address(RVA = "0x418EC38", Offset = "0x418EC38", VA = "0x418EC38")]
  public float GetAimTargetScaleY() => new float();

  [Token(Token = "0x6000703")]
  [Address(RVA = "0x418EC5C", Offset = "0x418EC5C", VA = "0x418EC5C")]
  public void DisableNavmeshAgent()
  {
  }

  [Token(Token = "0x6000704")]
  [Address(RVA = "0x418EC7C", Offset = "0x418EC7C", VA = "0x418EC7C")]
  public Vector3 GetNavmeshAgentPosition() => new Vector3();

  [Token(Token = "0x6000705")]
  [Address(RVA = "0x418ECA4", Offset = "0x418ECA4", VA = "0x418ECA4")]
  public float GetDistanceFromDestination() => new float();

  [Token(Token = "0x6000706")]
  [Address(RVA = "0x418ED70", Offset = "0x418ED70", VA = "0x418ED70")]
  public float GetNavmeshAgentHeight() => new float();

  [Token(Token = "0x6000707")]
  [Address(RVA = "0x418ED8C", Offset = "0x418ED8C", VA = "0x418ED8C")]
  public float GetNavmeshAgentRadius() => new float();

  [Token(Token = "0x6000708")]
  [Address(RVA = "0x418EDA8", Offset = "0x418EDA8", VA = "0x418EDA8")]
  public GameObject GetBindingModel() => (GameObject) null;

  [Token(Token = "0x6000709")]
  [Address(RVA = "0x418EE20", Offset = "0x418EE20", VA = "0x418EE20")]
  public void ClearLoadedResources()
  {
  }

  [Token(Token = "0x600070A")]
  [Address(RVA = "0x418F0AC", Offset = "0x418F0AC", VA = "0x418F0AC")]
  public void ClearAbnormalStateMaterials()
  {
  }

  [Token(Token = "0x600070B")]
  [Address(RVA = "0x418F2B4", Offset = "0x418F2B4", VA = "0x418F2B4")]
  public static void DisableVirtualCamera(CinemachineVirtualCamera vc)
  {
  }

  [Token(Token = "0x600070C")]
  [Address(RVA = "0x418F360", Offset = "0x418F360", VA = "0x418F360")]
  public void ClearMoveStatus()
  {
  }

  [Token(Token = "0x600070D")]
  [Address(RVA = "0x418F404", Offset = "0x418F404", VA = "0x418F404")]
  public void DisableVirtualCameras()
  {
  }

  [Token(Token = "0x600070E")]
  [Address(RVA = "0x418F458", Offset = "0x418F458", VA = "0x418F458")]
  public void RestoreVirtualCameraFoV()
  {
  }

  [Token(Token = "0x600070F")]
  [Address(RVA = "0x418F460", Offset = "0x418F460", VA = "0x418F460")]
  public void OverrideVirtualCameraFoV(float fov)
  {
  }

  [Token(Token = "0x6000710")]
  [Address(RVA = "0x418F4DC", Offset = "0x418F4DC", VA = "0x418F4DC")]
  private void OverrideFov(CinemachineVirtualCamera cam, float fov)
  {
  }

  [Token(Token = "0x6000711")]
  [Address(RVA = "0x418F4F4", Offset = "0x418F4F4", VA = "0x418F4F4")]
  public void SetBackVCFollowOffsetY(float offsetY)
  {
  }

  [Token(Token = "0x6000712")]
  [Address(RVA = "0x418F538", Offset = "0x418F538", VA = "0x418F538")]
  private void SetVCFollowOffsetY(
    CinemachineVirtualCamera vc,
    float offsetY,
    bool resetPositionImmediately)
  {
  }

  [Token(Token = "0x6000713")]
  [Address(RVA = "0x418F5D8", Offset = "0x418F5D8", VA = "0x418F5D8")]
  public void ResumeBackVCFollowOffsetY()
  {
  }

  [Token(Token = "0x6000714")]
  [Address(RVA = "0x418F6D4", Offset = "0x418F6D4", VA = "0x418F6D4")]
  public float GetAverageVCFollowOffsetY() => new float();

  [Token(Token = "0x6000715")]
  [Address(RVA = "0x418F7A8", Offset = "0x418F7A8", VA = "0x418F7A8")]
  public void SetEnableDynamicBone()
  {
  }

  [Token(Token = "0x6000716")]
  [Address(RVA = "0x418F834", Offset = "0x418F834", VA = "0x418F834")]
  public void ResetWeaponLoc()
  {
  }

  [Token(Token = "0x6000717")]
  [Address(RVA = "0x418FB40", Offset = "0x418FB40", VA = "0x418FB40")]
  private void Start()
  {
  }

  [Token(Token = "0x6000718")]
  [Address(RVA = "0x418FB44", Offset = "0x418FB44", VA = "0x418FB44")]
  private void Update()
  {
  }

  [Token(Token = "0x6000719")]
  [Address(RVA = "0x4190470", Offset = "0x4190470", VA = "0x4190470")]
  public void EnableFrontAheadVC()
  {
  }

  [Token(Token = "0x600071A")]
  [Address(RVA = "0x4190490", Offset = "0x4190490", VA = "0x4190490")]
  public void EnableRightBehindVC()
  {
  }

  [Token(Token = "0x600071B")]
  [Address(RVA = "0x41904B0", Offset = "0x41904B0", VA = "0x41904B0")]
  public void EnableFrontNearVC()
  {
  }

  [Token(Token = "0x600071C")]
  [Address(RVA = "0x41904D0", Offset = "0x41904D0", VA = "0x41904D0")]
  public void EnableBackNearVC()
  {
  }

  [Token(Token = "0x600071D")]
  [Address(RVA = "0x41904F0", Offset = "0x41904F0", VA = "0x41904F0")]
  public void EnableFrontMediumVC()
  {
  }

  [Token(Token = "0x600071E")]
  [Address(RVA = "0x4190510", Offset = "0x4190510", VA = "0x4190510")]
  public void EnableBackMediumVC()
  {
  }

  [Token(Token = "0x600071F")]
  [Address(RVA = "0x4190530", Offset = "0x4190530", VA = "0x4190530")]
  public void EnableFrontFarVC()
  {
  }

  [Token(Token = "0x6000720")]
  [Address(RVA = "0x4190550", Offset = "0x4190550", VA = "0x4190550")]
  public void EnableBackFarVC()
  {
  }

  [Token(Token = "0x6000721")]
  [Address(RVA = "0x4190570", Offset = "0x4190570", VA = "0x4190570")]
  public void EnableActionVC()
  {
  }

  [Token(Token = "0x6000722")]
  [Address(RVA = "0x4190590", Offset = "0x4190590", VA = "0x4190590")]
  public void EnableMainTeamCenterVC()
  {
  }

  [Token(Token = "0x6000723")]
  [Address(RVA = "0x41905AC", Offset = "0x41905AC", VA = "0x41905AC")]
  public void EnableTargetFrontAheadVC()
  {
  }

  [Token(Token = "0x6000724")]
  [Address(RVA = "0x41905C8", Offset = "0x41905C8", VA = "0x41905C8")]
  public void EnableTargetFrontNearVC()
  {
  }

  [Token(Token = "0x6000725")]
  [Address(RVA = "0x41905E4", Offset = "0x41905E4", VA = "0x41905E4")]
  public void EnableTargetFrontMediumVC()
  {
  }

  [Token(Token = "0x6000726")]
  [Address(RVA = "0x4190600", Offset = "0x4190600", VA = "0x4190600")]
  public void EnableTargetFrontFarVC()
  {
  }

  [Token(Token = "0x6000727")]
  [Address(RVA = "0x419061C", Offset = "0x419061C", VA = "0x419061C")]
  public void EnableTargetBackNearVC()
  {
  }

  [Token(Token = "0x6000728")]
  [Address(RVA = "0x4190638", Offset = "0x4190638", VA = "0x4190638")]
  public void EnableTargetBackMediumVC()
  {
  }

  [Token(Token = "0x6000729")]
  [Address(RVA = "0x4190654", Offset = "0x4190654", VA = "0x4190654")]
  public void EnableTargetBackFarVC()
  {
  }

  [Token(Token = "0x600072A")]
  [Address(RVA = "0x4190670", Offset = "0x4190670", VA = "0x4190670")]
  public void EnableTargetRightBehindVC()
  {
  }

  [Token(Token = "0x600072B")]
  [Address(RVA = "0x419068C", Offset = "0x419068C", VA = "0x419068C")]
  public void EnableTargetTeamCenterVC()
  {
  }

  [Token(Token = "0x600072C")]
  [Address(RVA = "0x41906A8", Offset = "0x41906A8", VA = "0x41906A8")]
  public void EnableFlyingObjectVC()
  {
  }

  [Token(Token = "0x600072D")]
  [Address(RVA = "0x41906C4", Offset = "0x41906C4", VA = "0x41906C4")]
  public void EnableActioningCharacterCenterVC()
  {
  }

  [Token(Token = "0x600072E")]
  [Address(RVA = "0x41906E0", Offset = "0x41906E0", VA = "0x41906E0")]
  public void SwitchToAttackStartVC()
  {
  }

  [Token(Token = "0x600072F")]
  [Address(RVA = "0x41906FC", Offset = "0x41906FC", VA = "0x41906FC")]
  public void SwitchToEscapeStartVC()
  {
  }

  [Token(Token = "0x6000730")]
  [Address(RVA = "0x4190718", Offset = "0x4190718", VA = "0x4190718")]
  public void SwitchToBeforeHitVC()
  {
  }

  [Token(Token = "0x6000731")]
  [Address(RVA = "0x4190734", Offset = "0x4190734", VA = "0x4190734")]
  public void DisableSoundController()
  {
  }

  [Token(Token = "0x6000732")]
  [Address(RVA = "0x41907B8", Offset = "0x41907B8", VA = "0x41907B8")]
  public void EnableSoundController()
  {
  }

  [Token(Token = "0x6000733")]
  [Address(RVA = "0x4190844", Offset = "0x4190844", VA = "0x4190844")]
  public void SetCharacterAbnormalState(bool isAbnormalState, BattleBadStatusTypeEnum abnormalState)
  {
  }

  [Token(Token = "0x6000734")]
  [Address(RVA = "0x41897E8", Offset = "0x41897E8", VA = "0x41897E8")]
  public static GameObject CreatePrefabInstance(GameObject prefab, GameObject parent)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000735")]
  [Address(RVA = "0x418DA14", Offset = "0x418DA14", VA = "0x418DA14")]
  private void SetCharacterAbnormalState(
    bool isAbnormalState,
    BattleBadStatusTypeEnum abnormalState,
    bool showStartEffect)
  {
  }

  [Token(Token = "0x6000736")]
  [Address(RVA = "0x4190C20", Offset = "0x4190C20", VA = "0x4190C20")]
  public void ShowHealEffect()
  {
  }

  [Token(Token = "0x6000737")]
  [Address(RVA = "0x4190E7C", Offset = "0x4190E7C", VA = "0x4190E7C")]
  public void HideHealEffect()
  {
  }

  [Token(Token = "0x6000738")]
  [Address(RVA = "0x419032C", Offset = "0x419032C", VA = "0x419032C")]
  private void UpdateAbnormalStateEffectRotation()
  {
  }

  [Token(Token = "0x6000739")]
  [Address(RVA = "0x4190B48", Offset = "0x4190B48", VA = "0x4190B48")]
  private void RemoveAbnormalStateEffect()
  {
  }

  [Token(Token = "0x600073A")]
  [Address(RVA = "0x418A418", Offset = "0x418A418", VA = "0x418A418")]
  private void SetCharacterEquipments(
    GameObject characterModel,
    List<DuelCharacterEquipmentSettingsAsset> equipments,
    float weaponScale)
  {
  }

  [Token(Token = "0x600073B")]
  [Address(RVA = "0x4190F0C", Offset = "0x4190F0C", VA = "0x4190F0C")]
  private void SetCharacterEquipmentConstraint(
    GameObject characterModel,
    GameObject equipmentInstance)
  {
  }

  [Token(Token = "0x600073C")]
  [Address(RVA = "0x4190850", Offset = "0x4190850", VA = "0x4190850")]
  public static void SetLayer(GameObject target, int layer)
  {
  }

  [Token(Token = "0x600073D")]
  [Address(RVA = "0x41910D8", Offset = "0x41910D8", VA = "0x41910D8")]
  public static void SetLayer(GameObject target, int layer, List<string> excludedObjects)
  {
  }

  [Token(Token = "0x600073E")]
  [Address(RVA = "0x4189A88", Offset = "0x4189A88", VA = "0x4189A88")]
  public static Transform FindDeepChild(Transform parent, string name) => (Transform) null;

  [Token(Token = "0x600073F")]
  [Address(RVA = "0x4191414", Offset = "0x4191414", VA = "0x4191414")]
  public DuelCharacterController()
  {
  }

  [Token(Token = "0x20000FD")]
  public enum DuelCharacterRole
  {
    [Token(Token = "0x4000515")] None,
    [Token(Token = "0x4000516")] Attacker,
    [Token(Token = "0x4000517")] AttackerSupporter,
    [Token(Token = "0x4000518")] Defender,
    [Token(Token = "0x4000519")] DefenderSupporter,
  }

  [Token(Token = "0x20000FE")]
  public enum DuelCharacterGender
  {
    [Token(Token = "0x400051B")] Male,
    [Token(Token = "0x400051C")] Female,
  }

  [Token(Token = "0x20000FF")]
  private enum MoveMethod
  {
    [Token(Token = "0x400051E")] MoveByNavmeshAgent,
    [Token(Token = "0x400051F")] MoveByTimeline,
  }

  [Token(Token = "0x2000100")]
  private enum MoveStatus
  {
    [Token(Token = "0x4000521")] Idle,
    [Token(Token = "0x4000522")] Walk,
    [Token(Token = "0x4000523")] Run,
  }
}
