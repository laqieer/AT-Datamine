// Decompiled with JetBrains decompiler
// Type: DuelUIController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data.Board;
using Battle.DuelScene;
using GameCore.DLC;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000178")]
public class DuelUIController : MonoBehaviour
{
  [Token(Token = "0x4000966")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  [Header("Common References")]
  private GameObject perspectiveCanvas;
  [Token(Token = "0x4000967")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  [Header("Animation Control")]
  private UITweenGroup duelUITweenGroupPlayer;
  [Token(Token = "0x4000968")]
  [FieldOffset(Offset = "0x28")]
  [Header("Animation Control")]
  [SerializeField]
  private UITweenGroup duelUITweenGroupEnemy;
  [Token(Token = "0x4000969")]
  [FieldOffset(Offset = "0x30")]
  [Header("Leader UI")]
  [SerializeField]
  private GameObject playerUIContainer;
  [Token(Token = "0x400096A")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  [Header("Leader UI")]
  private GameObject enemyUIContainer;
  [Token(Token = "0x400096B")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private TextMeshProUGUI playerUnitNameText;
  [Token(Token = "0x400096C")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private TextMeshProUGUI enemyUnitNameText;
  [Token(Token = "0x400096D")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private Transform playerUnitIconThumbRoot;
  [Token(Token = "0x400096E")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private Transform enemyUnitIconThumbRoot;
  [Token(Token = "0x400096F")]
  [FieldOffset(Offset = "0x60")]
  private StyleThumb playerUnitIconThumb;
  [Token(Token = "0x4000970")]
  [FieldOffset(Offset = "0x68")]
  private StyleThumb enemyUnitIconThumb;
  [Token(Token = "0x4000971")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private TextMeshProUGUI playerHitValueText;
  [Token(Token = "0x4000972")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private TextMeshProUGUI playerCritValueText;
  [Token(Token = "0x4000973")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private TextMeshProUGUI enemyHitValueText;
  [Token(Token = "0x4000974")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private TextMeshProUGUI enemyCritValueText;
  [Token(Token = "0x4000975")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private List<DuelAbnormalStatusIcon> playerConditionIconImageList;
  [Token(Token = "0x4000976")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private List<DuelAbnormalStatusIcon> enemyConditionIconImageList;
  [Token(Token = "0x4000977")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private GameObject playerConditionDotImage;
  [Token(Token = "0x4000978")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private GameObject enemyConditionDotImage;
  [Token(Token = "0x4000979")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private DuelUIHPController playerHPController;
  [Token(Token = "0x400097A")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private DuelUIHPController enemyHPController;
  [Token(Token = "0x400097B")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private DuelHPStockController playerHpStockController;
  [Token(Token = "0x400097C")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private DuelHPStockController enemyHpStockController;
  [Token(Token = "0x400097D")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private Transform playerActiveSkillIconContainer;
  [Token(Token = "0x400097E")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private Transform enemyActiveSkillIconContainer;
  [Token(Token = "0x400097F")]
  [FieldOffset(Offset = "0xE0")]
  [SerializeField]
  private Transform playerPassiveSkillIconContainer;
  [Token(Token = "0x4000980")]
  [FieldOffset(Offset = "0xE8")]
  [SerializeField]
  private Transform enemyPassiveSkillIconContainer;
  [Token(Token = "0x4000981")]
  [FieldOffset(Offset = "0xF0")]
  [SerializeField]
  private DuelUIHPHeaderController playerHeaderController;
  [Token(Token = "0x4000982")]
  [FieldOffset(Offset = "0xF8")]
  [SerializeField]
  private DuelUIHPHeaderController enemyHeaderController;
  [Token(Token = "0x4000983")]
  [FieldOffset(Offset = "0x100")]
  [Header("Supporter UI")]
  [SerializeField]
  private GameObject playerSupporterUIContainer;
  [Token(Token = "0x4000984")]
  [FieldOffset(Offset = "0x108")]
  [SerializeField]
  private GameObject playerSupporterThumbDissolveParts;
  [Token(Token = "0x4000985")]
  [FieldOffset(Offset = "0x110")]
  [SerializeField]
  private GameObject enemySupporterUIContainer;
  [Token(Token = "0x4000986")]
  [FieldOffset(Offset = "0x118")]
  [SerializeField]
  private GameObject enemySupporterThumbDissolveParts;
  [Token(Token = "0x4000987")]
  [FieldOffset(Offset = "0x120")]
  [SerializeField]
  private Transform playerSupporterUnitIconThumbRoot;
  [Token(Token = "0x4000988")]
  [FieldOffset(Offset = "0x128")]
  [SerializeField]
  private Transform enemySupporterUnitIconThumbRoot;
  [Token(Token = "0x4000989")]
  [FieldOffset(Offset = "0x130")]
  private StyleThumb playerSupporterUnitIconThumb;
  [Token(Token = "0x400098A")]
  [FieldOffset(Offset = "0x138")]
  private StyleThumb enemySupporterUnitIconThumb;
  [Token(Token = "0x400098B")]
  [FieldOffset(Offset = "0x140")]
  [SerializeField]
  private DuelAbnormalStatusIcon playerSupporterConditionIconImage;
  [Token(Token = "0x400098C")]
  [FieldOffset(Offset = "0x148")]
  [SerializeField]
  private DuelAbnormalStatusIcon enemySupporterConditionIconImage;
  [Token(Token = "0x400098D")]
  [FieldOffset(Offset = "0x150")]
  [SerializeField]
  private DuelUIHPController playerSupporterHPController;
  [Token(Token = "0x400098E")]
  [FieldOffset(Offset = "0x158")]
  [SerializeField]
  private DuelUIHPController enemySupporterHPController;
  [Token(Token = "0x400098F")]
  [FieldOffset(Offset = "0x160")]
  [SerializeField]
  private DuelHPStockController playerSupporterHpStockController;
  [Token(Token = "0x4000990")]
  [FieldOffset(Offset = "0x168")]
  [SerializeField]
  private DuelHPStockController enemySupporterHpStockController;
  [Token(Token = "0x4000991")]
  [FieldOffset(Offset = "0x170")]
  [SerializeField]
  [Header("Others")]
  private Text battleLogText;
  [Token(Token = "0x4000992")]
  [FieldOffset(Offset = "0x178")]
  [SerializeField]
  private DuelUIActiveSkillIconController playerActiveSkillIconPrefab;
  [Token(Token = "0x4000993")]
  [FieldOffset(Offset = "0x180")]
  [SerializeField]
  private DuelUIActiveSkillIconController enemyActiveSkillIconPrefab;
  [Token(Token = "0x4000994")]
  [FieldOffset(Offset = "0x188")]
  [SerializeField]
  private GameObject passiveSkillIconPrefab;
  [Token(Token = "0x4000995")]
  [FieldOffset(Offset = "0x190")]
  [SerializeField]
  private GameObject passiveSkillIconPrefabMini;
  [Token(Token = "0x4000996")]
  [FieldOffset(Offset = "0x198")]
  [SerializeField]
  private DuelUIDamageValueController damageValuePrefab;
  [Token(Token = "0x4000997")]
  [FieldOffset(Offset = "0x1A0")]
  private AssetBundleManager assetBundleManager;
  [Token(Token = "0x4000998")]
  [FieldOffset(Offset = "0x1A8")]
  private bool shouldSwapPlayerConditionIcon;
  [Token(Token = "0x4000999")]
  [FieldOffset(Offset = "0x1A9")]
  private bool shouldSwapEnemyConditionIcon;
  [Token(Token = "0x400099A")]
  [FieldOffset(Offset = "0x1AC")]
  private int currentPlayerConditionIconPage;
  [Token(Token = "0x400099B")]
  [FieldOffset(Offset = "0x1B0")]
  private int currentEnemyConditionIconPage;
  [Token(Token = "0x400099C")]
  [FieldOffset(Offset = "0x1B4")]
  private float lastSwapConditionIconTime;
  [Token(Token = "0x400099D")]
  [FieldOffset(Offset = "0x1B8")]
  private float swapConditionIconInterval;
  [Token(Token = "0x400099E")]
  [FieldOffset(Offset = "0x1C0")]
  private List<string> swapConditionIconTweenGroupList;
  [Token(Token = "0x400099F")]
  [FieldOffset(Offset = "0x1C8")]
  private List<string> loadedAssetBundleNames;
  [Token(Token = "0x40009A0")]
  [FieldOffset(Offset = "0x1D0")]
  [SerializeField]
  private Camera mainCamera;
  [Token(Token = "0x40009A1")]
  [FieldOffset(Offset = "0x1D8")]
  [SerializeField]
  private CanvasScaler canvasScaler;
  [Token(Token = "0x40009A2")]
  [FieldOffset(Offset = "0x1E0")]
  private UITimelineController uiTimelineController;
  [Token(Token = "0x40009A3")]
  [FieldOffset(Offset = "0x1E8")]
  [SerializeField]
  private PlayableDirector playableDirector;
  [Token(Token = "0x40009A4")]
  [FieldOffset(Offset = "0x1F0")]
  private List<DuelUIDamageValueController> activeDamageValueControllers;
  [Token(Token = "0x40009A5")]
  private const string SKILL_ICON_ASSETBUNDLE_NAME = "content_icon_skill";
  [Token(Token = "0x40009A6")]
  private const string TWEEN_GROUP_ID_LOG_IN = "Log_in";
  [Token(Token = "0x40009A7")]
  private const string TWEEN_GROUP_ID_PLAYER_DAMAGE = "Damage_Animation_Player";
  [Token(Token = "0x40009A8")]
  private const string TWEEN_GROUP_ID_PLAYER_HEAL = "Heal_Animation_Player";
  [Token(Token = "0x40009A9")]
  private const string TWEEN_GROUP_ID_ENEMY_DAMAGE = "Damage_Animation_Enemy";
  [Token(Token = "0x40009AA")]
  private const string TWEEN_GROUP_ID_ENEMY_HEAL = "Heal_Animation_Enemy";
  [Token(Token = "0x40009AB")]
  private const string TWEEN_GROUP_ID_DUAL_DAMAGE = "Damage_Animation_Dual";
  [Token(Token = "0x40009AC")]
  private const string TWEEN_GROUP_ID_DUAL_HEAL = "Heal_Animation_Dual";
  [Token(Token = "0x40009AD")]
  private const int PASSIVE_SKILL_ICON_NUM_MAX = 10;
  [Token(Token = "0x40009AE")]
  private const float DAMAGE_VALUE_OFFSET_MIN = 0.3f;
  [Token(Token = "0x40009AF")]
  private const int DAMAGE_VALUE_RANGE = 100;
  [Token(Token = "0x40009B0")]
  private const string STYLE_THUMB_ASSET_BUNDLE_NAME = "ui_common_thumb";
  [Token(Token = "0x40009B1")]
  private const string STYLE_THUMB_ASSET_NAME = "Com_StyleThumb";

  [Token(Token = "0x6000A36")]
  [Address(RVA = "0x4BB319C", Offset = "0x4BB319C", VA = "0x4BB319C")]
  public void SetCamera(Camera mainCamera)
  {
  }

  [Token(Token = "0x6000A37")]
  [Address(RVA = "0x4BB31A4", Offset = "0x4BB31A4", VA = "0x4BB31A4")]
  public IEnumerator InitializeFromDuelSceneSample() => (IEnumerator) null;

  [Token(Token = "0x6000A38")]
  [Address(RVA = "0x4BB3234", Offset = "0x4BB3234", VA = "0x4BB3234")]
  public IEnumerator InitializeFromBattleField(
    DuelData duelData,
    DuelSettingsAsset duelSettingsAsset,
    List<Tuple<UnitParameterData, DuelCharacterController.DuelCharacterRole>> availableBattleUnits,
    Camera mainCamera,
    CanvasScaler canvasScaler,
    DuelManager.DuelProcessType processType,
    Dictionary<DuelCharacterController.DuelCharacterRole, HashSet<BattleBadStatusTypeEnum>> duelCharacterBadStatus)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000A39")]
  [Address(RVA = "0x4BB3300", Offset = "0x4BB3300", VA = "0x4BB3300")]
  public IEnumerator InitializeFromDuelDebugTool(
    IDuelDebugToolController duelDebugToolController,
    DuelSettingsAsset duelSettingsAsset,
    Camera mainCamera,
    CanvasScaler canvasScaler)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000A3A")]
  [Address(RVA = "0x4BB33B8", Offset = "0x4BB33B8", VA = "0x4BB33B8")]
  public void SetCharacterHitAndCritRatio(
    DuelCharacterController.DuelCharacterRole role,
    int hitRatio,
    int critRatio)
  {
  }

  [Token(Token = "0x6000A3B")]
  [Address(RVA = "0x4BB3474", Offset = "0x4BB3474", VA = "0x4BB3474")]
  public void SetCharacterAbnormalState(
    DuelCharacterController.DuelCharacterRole role,
    IEnumerable<IBadStatusData> abnormalStates)
  {
  }

  [Token(Token = "0x6000A3C")]
  [Address(RVA = "0x4BB36D8", Offset = "0x4BB36D8", VA = "0x4BB36D8")]
  private void SetLeaderAbnormalState(
    IReadOnlyList<IBadStatusData> abnormalStateList,
    List<DuelAbnormalStatusIcon> imageList)
  {
  }

  [Token(Token = "0x6000A3D")]
  [Address(RVA = "0x4BB39E0", Offset = "0x4BB39E0", VA = "0x4BB39E0")]
  private void SetSupporterAbnormalState(
    IReadOnlyList<IBadStatusData> abnormalStateList,
    DuelAbnormalStatusIcon image)
  {
  }

  [Token(Token = "0x6000A3E")]
  [Address(RVA = "0x4BB3C58", Offset = "0x4BB3C58", VA = "0x4BB3C58")]
  public void StopAllTweeners()
  {
  }

  [Token(Token = "0x6000A3F")]
  [Address(RVA = "0x4BB3C78", Offset = "0x4BB3C78", VA = "0x4BB3C78")]
  private void StopAllTweeners(Transform t)
  {
  }

  [Token(Token = "0x6000A40")]
  [Address(RVA = "0x4BB3FBC", Offset = "0x4BB3FBC", VA = "0x4BB3FBC")]
  public void ShowDuelUI()
  {
  }

  [Token(Token = "0x6000A41")]
  [Address(RVA = "0x4BB40CC", Offset = "0x4BB40CC", VA = "0x4BB40CC")]
  public IEnumerator HideDuelUI() => (IEnumerator) null;

  [Token(Token = "0x6000A42")]
  [Address(RVA = "0x4BB415C", Offset = "0x4BB415C", VA = "0x4BB415C")]
  private IEnumerator WaitTimelineEnd() => (IEnumerator) null;

  [Token(Token = "0x6000A43")]
  [Address(RVA = "0x4BB41EC", Offset = "0x4BB41EC", VA = "0x4BB41EC")]
  public bool IsPlaying() => new bool();

  [Token(Token = "0x6000A44")]
  [Address(RVA = "0x4BB422C", Offset = "0x4BB422C", VA = "0x4BB422C")]
  public void InitializeCharacterHP(
    int maxValue,
    int value,
    DuelCharacterController.DuelCharacterRole role,
    ForceTypeEnum forceTypeEnum)
  {
  }

  [Token(Token = "0x6000A45")]
  [Address(RVA = "0x4BB4798", Offset = "0x4BB4798", VA = "0x4BB4798")]
  public void SetCharacterHP(int value, DuelCharacterController.DuelCharacterRole role)
  {
  }

  [Token(Token = "0x6000A46")]
  [Address(RVA = "0x4BB4920", Offset = "0x4BB4920", VA = "0x4BB4920")]
  private void PlayHPGaugeAnimation(
    UITweenGroup tweenGroup,
    DuelUIHPController controller,
    int damageValue,
    string damageAnimation,
    string healAnimation)
  {
  }

  [Token(Token = "0x6000A47")]
  [Address(RVA = "0x4BB4CEC", Offset = "0x4BB4CEC", VA = "0x4BB4CEC")]
  public void UpdateCharacterHP(int value, DuelCharacterController.DuelCharacterRole role)
  {
  }

  [Token(Token = "0x6000A48")]
  [Address(RVA = "0x4BB4E14", Offset = "0x4BB4E14", VA = "0x4BB4E14")]
  public void ShowDamageValue(
    Transform positionTarget,
    int damageValue,
    DuelUIController.DamageEffectType damageEffectType)
  {
  }

  [Token(Token = "0x6000A49")]
  [Address(RVA = "0x4BB5004", Offset = "0x4BB5004", VA = "0x4BB5004")]
  private Vector2 GetDamageValueTargetOffset() => new Vector2();

  [Token(Token = "0x6000A4A")]
  [Address(RVA = "0x4BB587C", Offset = "0x4BB587C", VA = "0x4BB587C")]
  public void SetCharacterPassiveSkill(
    List<SkillParameterData> passiveSkillDatas,
    DuelCharacterController.DuelCharacterRole role)
  {
  }

  [Token(Token = "0x6000A4B")]
  [Address(RVA = "0x4BB58A4", Offset = "0x4BB58A4", VA = "0x4BB58A4")]
  private void SetCharacterPassiveSkillInternal(
    List<SkillParameterData> passiveSkillDatas,
    Transform passiveSkillContainer)
  {
  }

  [Token(Token = "0x6000A4C")]
  [Address(RVA = "0x4BB5E68", Offset = "0x4BB5E68", VA = "0x4BB5E68")]
  public IEnumerator ShowActiveSkillIcons(
    DuelCharacterController.DuelCharacterRole role,
    List<SkillParameterData> unitSkillDatas,
    ForceTypeEnum forceTypeEnum)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000A4D")]
  [Address(RVA = "0x4BB5F1C", Offset = "0x4BB5F1C", VA = "0x4BB5F1C")]
  private IEnumerator ShowActiveSkillIcons(
    Transform parent,
    List<SkillParameterData> unitSkillDatas,
    DuelUIActiveSkillIconController iconPrefab,
    ForceTypeEnum forceTypeEnum)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000A4E")]
  [Address(RVA = "0x4BB5FD4", Offset = "0x4BB5FD4", VA = "0x4BB5FD4")]
  public void SetBattleLog(string text)
  {
  }

  [Token(Token = "0x6000A4F")]
  [Address(RVA = "0x4BB5FF4", Offset = "0x4BB5FF4", VA = "0x4BB5FF4")]
  private IEnumerator SetBattleLogCoroutine(string text) => (IEnumerator) null;

  [Token(Token = "0x6000A50")]
  [Address(RVA = "0x4BB6090", Offset = "0x4BB6090", VA = "0x4BB6090")]
  private List<BattleBadStatusData> GetEffectOrderedBadStatuses(
    DuelCharacterController.DuelCharacterRole role,
    Dictionary<DuelCharacterController.DuelCharacterRole, HashSet<BattleBadStatusTypeEnum>> duelCharacterBadStatus)
  {
    return (List<BattleBadStatusData>) null;
  }

  [Token(Token = "0x6000A51")]
  [Address(RVA = "0x4BB6350", Offset = "0x4BB6350", VA = "0x4BB6350")]
  public DuelUIController()
  {
  }

  [Token(Token = "0x2000179")]
  public enum DamageEffectType
  {
    [Token(Token = "0x40009B3")] Damage,
    [Token(Token = "0x40009B4")] CriticalDamage,
    [Token(Token = "0x40009B5")] NoDamage,
    [Token(Token = "0x40009B6")] Miss,
    [Token(Token = "0x40009B7")] CutDamage,
  }
}
