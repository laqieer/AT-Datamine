// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x20032F2")]
  public class AbilityBoardBehaviour : MonoBehaviour, IItemDetailController, IAbilityBoardIconLoader
  {
    [Token(Token = "0x400DBEB")]
    private const string PLAY_VOICE_FILE_NAME = "VO_{0}_unit_{1}";
    [Token(Token = "0x400DBEC")]
    private const string PLAY_VOICE_UNLOCK_NODE = "0001";
    [Token(Token = "0x400DBED")]
    private const string PLAY_VOICE_UNLOCK_CUSTOM_NODE = "0012";
    [Token(Token = "0x400DBEE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400DBEF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400DBF0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject raycastObj;
    [Token(Token = "0x400DBF1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AbilityBoardListView abilityBoardListView;
    [Token(Token = "0x400DBF2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AbilityBoardView abilityBoardView;
    [Token(Token = "0x400DBF3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private AbilityBoardStyleStatus abilityBoardStyleStatus;
    [Token(Token = "0x400DBF4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text Txt_StyleName;
    [Token(Token = "0x400DBF5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private StyleThumb Com_StyleThumb;
    [Token(Token = "0x400DBF6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public GameObject sideMenuRoot;
    [Token(Token = "0x400DBF7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int customEffectDelay;
    [Token(Token = "0x400DBF8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400DBF9")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton selectNodeReleaseButton;
    [Token(Token = "0x400DBFA")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton allNodeReleaseButton;
    [Token(Token = "0x400DBFB")]
    [FieldOffset(Offset = "0x80")]
    [NonSerialized]
    public AbilityBoardNodeView nodeView;
    [Token(Token = "0x400DBFC")]
    [FieldOffset(Offset = "0x88")]
    [NonSerialized]
    public AbilityBoardSelectModeView selectModeView;
    [Token(Token = "0x400DBFD")]
    [FieldOffset(Offset = "0x90")]
    [NonSerialized]
    public AbilityBoardCustomNodeAView customNodeAView;
    [Token(Token = "0x400DBFE")]
    [FieldOffset(Offset = "0x98")]
    [NonSerialized]
    public AbilityBoardCustomNodeBView customNodeBView;
    [Token(Token = "0x400DBFF")]
    [FieldOffset(Offset = "0xA0")]
    [NonSerialized]
    public SpriteAtlas iconAtlas;
    [Token(Token = "0x400DC00")]
    [FieldOffset(Offset = "0xA8")]
    [NonSerialized]
    public UITweenGroup styleStatusTweenGroup;
    [Token(Token = "0x400DC01")]
    [FieldOffset(Offset = "0xB0")]
    [NonSerialized]
    public ICanvasInteractableController canvasInteractableController;
    [Token(Token = "0x400DC02")]
    [FieldOffset(Offset = "0xB8")]
    private StyleStatusSubScene styleStatusSubScene;
    [Token(Token = "0x400DC03")]
    [FieldOffset(Offset = "0xC0")]
    private Style style;
    [Token(Token = "0x400DC04")]
    [FieldOffset(Offset = "0xC8")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DC05")]
    [FieldOffset(Offset = "0xD0")]
    private int openBoardId;
    [Token(Token = "0x400DC06")]
    [FieldOffset(Offset = "0xD4")]
    private int openNodeId;
    [Token(Token = "0x400DC07")]
    [FieldOffset(Offset = "0xD8")]
    private List<PlayerUnitAbilityBoardType> unlockNodeData;
    [Token(Token = "0x400DC08")]
    [FieldOffset(Offset = "0xE0")]
    private List<PlayerUnitAbilityBoardCustomANodeType> unlockCustomNodeAData;
    [Token(Token = "0x400DC09")]
    [FieldOffset(Offset = "0xE8")]
    private List<PlayerUnitAbilityBoardCustomBNodeType> unlockCustomNodeBData;
    [Token(Token = "0x400DC0A")]
    [FieldOffset(Offset = "0xF0")]
    private bool isUnlocked;
    [Token(Token = "0x400DC0B")]
    [FieldOffset(Offset = "0xF8")]
    private AbilityBoardCustomAResult customAResult;
    [Token(Token = "0x400DC0C")]
    [FieldOffset(Offset = "0x100")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400DC0D")]
    [FieldOffset(Offset = "0x108")]
    private HashSet<string> loadedItems;
    [Token(Token = "0x400DC0E")]
    [FieldOffset(Offset = "0x110")]
    private bool isAPIConnecting;
    [Token(Token = "0x400DC0F")]
    [FieldOffset(Offset = "0x111")]
    private bool playStyleMasterTutorial;
    [Token(Token = "0x400DC10")]
    [FieldOffset(Offset = "0x112")]
    private bool playCharacterSkillTutorial;
    [Token(Token = "0x400DC11")]
    [FieldOffset(Offset = "0x113")]
    private bool playToaster;
    [Token(Token = "0x400DC12")]
    [FieldOffset(Offset = "0x118")]
    private string toasterMsg;
    [Token(Token = "0x400DC13")]
    [FieldOffset(Offset = "0x120")]
    private Coroutine afterEffectCoroutine;
    [Token(Token = "0x400DC14")]
    [FieldOffset(Offset = "0x128")]
    private AbilityBoardBehaviour.SubMenuState subMenuState;
    [Token(Token = "0x400DC15")]
    [FieldOffset(Offset = "0x130")]
    private Action onOpenSubMenu;
    [Token(Token = "0x400DC16")]
    [FieldOffset(Offset = "0x138")]
    private Action onCloseSubMenu;
    [Token(Token = "0x400DC17")]
    [FieldOffset(Offset = "0x140")]
    private bool changeSceneBeforeBulkMode;
    [Token(Token = "0x400DC18")]
    [FieldOffset(Offset = "0x148")]
    private AbilityBoardNodeReleaseModeController abilityBoardNodeReleaseModeController;

    [Token(Token = "0x6014049")]
    [Address(RVA = "0x234CF38", Offset = "0x234CF38", VA = "0x234CF38")]
    public void Initialize(
      StyleStatusSubScene statusSubScene,
      Action onOpenSubMenu,
      Action onCloseSubMenu)
    {
    }

    [Token(Token = "0x601404A")]
    [Address(RVA = "0x234D45C", Offset = "0x234D45C", VA = "0x234D45C")]
    public IEnumerator InitializeTimelineAsync(AssetCachedSpawner assetCachedSpawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601404B")]
    [Address(RVA = "0x234D4F8", Offset = "0x234D4F8", VA = "0x234D4F8")]
    private IEnumerator InitializeCommonIconAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x601404C")]
    [Address(RVA = "0x234D588", Offset = "0x234D588", VA = "0x234D588")]
    public void Release()
    {
    }

    [Token(Token = "0x601404D")]
    [Address(RVA = "0x234D750", Offset = "0x234D750", VA = "0x234D750")]
    public void CloseSubMenu()
    {
    }

    [Token(Token = "0x601404E")]
    [Address(RVA = "0x234D754", Offset = "0x234D754", VA = "0x234D754")]
    private void OnClosedSubMenu()
    {
    }

    [Token(Token = "0x601404F")]
    [Address(RVA = "0x234D93C", Offset = "0x234D93C", VA = "0x234D93C")]
    public IEnumerator Open(
      Style style,
      List<PlayerUnitAbilityBoardCustomALotteryType> resumeData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014050")]
    [Address(RVA = "0x234D9E0", Offset = "0x234D9E0", VA = "0x234D9E0")]
    public IEnumerator UpdateBoard() => (IEnumerator) null;

    [Token(Token = "0x6014051")]
    [Address(RVA = "0x234DA70", Offset = "0x234DA70", VA = "0x234DA70")]
    public void SetActiveRaycastObj(bool state)
    {
    }

    [Token(Token = "0x6014052")]
    [Address(RVA = "0x234DA90", Offset = "0x234DA90", VA = "0x234DA90")]
    private void OpenResumeResult(
      List<PlayerUnitAbilityBoardCustomALotteryType> resumeData)
    {
    }

    [Token(Token = "0x6014053")]
    [Address(RVA = "0x234E0AC", Offset = "0x234E0AC", VA = "0x234E0AC")]
    private IEnumerator loadStyleThumbAB(int styleID) => (IEnumerator) null;

    [Token(Token = "0x6014054")]
    [Address(RVA = "0x234E13C", Offset = "0x234E13C", VA = "0x234E13C")]
    private void PlayInAnim(Action onFinish = null)
    {
    }

    [Token(Token = "0x6014055")]
    [Address(RVA = "0x234E210", Offset = "0x234E210", VA = "0x234E210")]
    public void PlayOutAnim(Action onFinish = null)
    {
    }

    [Token(Token = "0x6014056")]
    [Address(RVA = "0x234E2E4", Offset = "0x234E2E4", VA = "0x234E2E4")]
    private IEnumerator ConnectAPIUnitAbilityboardList(
      Action<List<PlayerUnitAbilityBoardType>, List<PlayerUnitAbilityBoardCustomANodeType>, List<PlayerUnitAbilityBoardCustomBNodeType>> finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014057")]
    [Address(RVA = "0x234E380", Offset = "0x234E380", VA = "0x234E380")]
    private void SetData(
      List<PlayerUnitAbilityBoardType> releaseNodes,
      List<PlayerUnitAbilityBoardCustomANodeType> releaseCustomANodes,
      List<PlayerUnitAbilityBoardCustomBNodeType> releaseCustomBNodes,
      List<PlayerUnitAbilityBoardCustomALotteryType> resumeData = null,
      bool playAnim = true)
    {
    }

    [Token(Token = "0x6014058")]
    [Address(RVA = "0x234E994", Offset = "0x234E994", VA = "0x234E994")]
    private void UpdateBoardNodes(
      List<PlayerUnitAbilityBoardType> releaseNodes,
      List<PlayerUnitAbilityBoardCustomANodeType> releaseCustomANodes,
      List<PlayerUnitAbilityBoardCustomBNodeType> releaseCustomBNodes)
    {
    }

    [Token(Token = "0x6014059")]
    [Address(RVA = "0x234E788", Offset = "0x234E788", VA = "0x234E788")]
    private int GetFirstBoardId(int boardListId) => new int();

    [Token(Token = "0x601405A")]
    [Address(RVA = "0x234E8FC", Offset = "0x234E8FC", VA = "0x234E8FC")]
    private void OnBoardListButton(int boardId, bool isPlayBoardLineAnime)
    {
    }

    [Token(Token = "0x601405B")]
    [Address(RVA = "0x234DCE8", Offset = "0x234DCE8", VA = "0x234DCE8")]
    private void OnBoardButton(int nodeId)
    {
    }

    [Token(Token = "0x601405C")]
    [Address(RVA = "0x234F110", Offset = "0x234F110", VA = "0x234F110")]
    private void CallNodeUnlockAPI(List<AbilityBoardReleaseNodeData> unlockNodeList)
    {
    }

    [Token(Token = "0x601405D")]
    [Address(RVA = "0x234F8D4", Offset = "0x234F8D4", VA = "0x234F8D4")]
    private IEnumerator ConnectAPIUnitAbilityboardUnlock(
      Action<List<int>> finishAction,
      List<int> unlockNodeIds)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601405E")]
    [Address(RVA = "0x234F978", Offset = "0x234F978", VA = "0x234F978")]
    private void OnFinishUnitAbilityboardUnlock(List<int> unlockNodeIds)
    {
    }

    [Token(Token = "0x601405F")]
    [Address(RVA = "0x234FB10", Offset = "0x234FB10", VA = "0x234FB10")]
    private void CallUnlockNodeListAPI(
      Action<List<PlayerUnitAbilityBoardType>, List<PlayerUnitAbilityBoardCustomANodeType>, List<PlayerUnitAbilityBoardCustomBNodeType>> finishAction)
    {
    }

    [Token(Token = "0x6014060")]
    [Address(RVA = "0x234FCE0", Offset = "0x234FCE0", VA = "0x234FCE0")]
    private void CallCustomANodeUnlockAPI(int itemId, int lotteryCount)
    {
    }

    [Token(Token = "0x6014061")]
    [Address(RVA = "0x234FE20", Offset = "0x234FE20", VA = "0x234FE20")]
    private IEnumerator ConnectAPIUnitAbilityboardCustomAUnlock(
      Action<List<PlayerUnitAbilityBoardCustomALotteryType>> finishAction,
      int itemId,
      int lotteryCount)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014062")]
    [Address(RVA = "0x234DE30", Offset = "0x234DE30", VA = "0x234DE30")]
    private void OnFinishUnitAbilityboardCustomAUnlock(
      List<PlayerUnitAbilityBoardCustomALotteryType> lottetyResults)
    {
    }

    [Token(Token = "0x6014063")]
    [Address(RVA = "0x234FED4", Offset = "0x234FED4", VA = "0x234FED4")]
    private void CallCustomANodeSelectAPI(string selectId, bool selectCurrentParam)
    {
    }

    [Token(Token = "0x6014064")]
    [Address(RVA = "0x234FF9C", Offset = "0x234FF9C", VA = "0x234FF9C")]
    private IEnumerator ConnectAPIUnitAbilityboardCustomASelect(
      Action<bool> finishAction,
      string selectId,
      bool selectCurrentParam)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014065")]
    [Address(RVA = "0x2350054", Offset = "0x2350054", VA = "0x2350054")]
    private void OnFinishUnitAbilityboardCustomASelect(bool selectCurrentParam)
    {
    }

    [Token(Token = "0x6014066")]
    [Address(RVA = "0x23501D4", Offset = "0x23501D4", VA = "0x23501D4")]
    private void CallCustomBNodeUnlockAPI()
    {
    }

    [Token(Token = "0x6014067")]
    [Address(RVA = "0x23502F8", Offset = "0x23502F8", VA = "0x23502F8")]
    private IEnumerator ConnectAPIUnitAbilityboardCustomBUnlock(Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014068")]
    [Address(RVA = "0x2350394", Offset = "0x2350394", VA = "0x2350394")]
    private void OnFinishUnitAbilityboardCustomBUnlock()
    {
    }

    [Token(Token = "0x6014069")]
    [Address(RVA = "0x23504E8", Offset = "0x23504E8", VA = "0x23504E8")]
    private IEnumerator DelayCoroutine(int delayFrameCount, Action action) => (IEnumerator) null;

    [Token(Token = "0x601406A")]
    [Address(RVA = "0x2350588", Offset = "0x2350588", VA = "0x2350588")]
    private IEnumerator AfterEffectAction() => (IEnumerator) null;

    [Token(Token = "0x601406B")]
    [Address(RVA = "0x2350618", Offset = "0x2350618", VA = "0x2350618", Slot = "4")]
    private void Scenes\u002EOutGame\u002EUnitDetail\u002EAbilityBoard\u002EIItemDetailController\u002EOpenItemDetailPopup(
      ItemData item)
    {
    }

    [Token(Token = "0x601406C")]
    [Address(RVA = "0x235064C", Offset = "0x235064C", VA = "0x235064C", Slot = "5")]
    private void Scenes\u002EOutGame\u002EUnitDetail\u002EAbilityBoard\u002EIItemDetailController\u002ECloseItemDetailPopup()
    {
    }

    [Token(Token = "0x601406D")]
    [Address(RVA = "0x234D928", Offset = "0x234D928", VA = "0x234D928")]
    private void CloseItemDetailPopup()
    {
    }

    [Token(Token = "0x601406E")]
    [Address(RVA = "0x2350660", Offset = "0x2350660", VA = "0x2350660", Slot = "6")]
    private IEnumerator Scenes\u002EOutGame\u002EUnitDetail\u002EAbilityBoard\u002EIAbilityBoardIconLoader\u002ESetItemIcon(
      ItemIcon icon,
      ItemUtility.Parameter parameter,
      bool rarityBase)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601406F")]
    [Address(RVA = "0x2350724", Offset = "0x2350724", VA = "0x2350724")]
    private IEnumerator SetItemIcon(
      ItemIcon icon,
      ItemUtility.Parameter parameter,
      bool rarityBase = true)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014070")]
    [Address(RVA = "0x23507D8", Offset = "0x23507D8", VA = "0x23507D8", Slot = "7")]
    private IEnumerator Scenes\u002EOutGame\u002EUnitDetail\u002EAbilityBoard\u002EIAbilityBoardIconLoader\u002ESetItemIcon(
      ItemIcon icon,
      int id)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014071")]
    [Address(RVA = "0x235087C", Offset = "0x235087C", VA = "0x235087C", Slot = "8")]
    private Sprite Scenes\u002EOutGame\u002EUnitDetail\u002EAbilityBoard\u002EIAbilityBoardIconLoader\u002EGetNodeIcon(
      int iconId)
    {
      return (Sprite) null;
    }

    [Token(Token = "0x6014072")]
    [Address(RVA = "0x234FBFC", Offset = "0x234FBFC", VA = "0x234FBFC")]
    private void PlayVoice(string voiceId)
    {
    }

    [Token(Token = "0x6014073")]
    [Address(RVA = "0x2350924", Offset = "0x2350924", VA = "0x2350924")]
    public void SetAllNodeReleaseButtonInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6014074")]
    [Address(RVA = "0x2350948", Offset = "0x2350948", VA = "0x2350948")]
    public void SetSelectNodeReleaseButtonInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6014075")]
    [Address(RVA = "0x235096C", Offset = "0x235096C", VA = "0x235096C")]
    private void OnAllRelease()
    {
    }

    [Token(Token = "0x6014076")]
    [Address(RVA = "0x23509BC", Offset = "0x23509BC", VA = "0x23509BC")]
    private void OnChangeNodeReleaseModeToSelect()
    {
    }

    [Token(Token = "0x6014077")]
    [Address(RVA = "0x2350B6C", Offset = "0x2350B6C", VA = "0x2350B6C")]
    private void PlayOpenSideMenu()
    {
    }

    [Token(Token = "0x6014078")]
    [Address(RVA = "0x234ED08", Offset = "0x234ED08", VA = "0x234ED08")]
    private void OpenSubMenu(int nodeId)
    {
    }

    [Token(Token = "0x6014079")]
    [Address(RVA = "0x2350C6C", Offset = "0x2350C6C", VA = "0x2350C6C")]
    public AbilityBoardBehaviour()
    {
    }

    [Token(Token = "0x20032F3")]
    public enum NodeType
    {
      [Token(Token = "0x400DC1A")] None,
      [Token(Token = "0x400DC1B")] Node,
      [Token(Token = "0x400DC1C")] Custom_A,
      [Token(Token = "0x400DC1D")] Custom_B,
    }

    [Token(Token = "0x20032F4")]
    private enum SubMenuState
    {
      [Token(Token = "0x400DC1F")] CLOSE,
      [Token(Token = "0x400DC20")] OPEN,
      [Token(Token = "0x400DC21")] OPEN_SELECT_MODE,
      [Token(Token = "0x400DC22")] OPEN_CUSTOM_A,
      [Token(Token = "0x400DC23")] OPEN_CUSTOM_B,
    }
  }
}
