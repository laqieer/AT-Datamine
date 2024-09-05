// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.UnitView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Effect;
using Scenes.Story;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x200379E")]
  public sealed class UnitView : ResultViewBase
  {
    [Token(Token = "0x400F2F9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int unitGroupCount;
    [Token(Token = "0x400F2FA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int unitCellCount;
    [Token(Token = "0x400F2FB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private float snapSecond;
    [Token(Token = "0x400F2FC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float unitResultAnimationTime;
    [Token(Token = "0x400F2FD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string showName;
    [Token(Token = "0x400F2FE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string hideName;
    [Token(Token = "0x400F2FF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string buttonInName;
    [Token(Token = "0x400F300")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string buttonOutName;
    [Token(Token = "0x400F301")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private string[] unitSlideInNames;
    [Token(Token = "0x400F302")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI missionTitle;
    [Token(Token = "0x400F303")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject difficultyRoot;
    [Token(Token = "0x400F304")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject difficultyHard;
    [Token(Token = "0x400F305")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject difficultyVeryHard;
    [Token(Token = "0x400F306")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject missionProgressRoot;
    [Token(Token = "0x400F307")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject[] missionClearMark;
    [Token(Token = "0x400F308")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text playerLevelText;
    [Token(Token = "0x400F309")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text playerExpText;
    [Token(Token = "0x400F30A")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text playerGetExpText;
    [Token(Token = "0x400F30B")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    [Tooltip("playerGetExpText.text で設定している書式はこちらに移動")]
    private string playerGetExpFormat;
    [Token(Token = "0x400F30C")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Slider playerExpMeter;
    [Token(Token = "0x400F30D")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private string[] missionClearInNames;
    [Token(Token = "0x400F30E")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private ScrollRect scrollrect;
    [Token(Token = "0x400F30F")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private UnitCell[] unitCellList;
    [Token(Token = "0x400F310")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F311")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Button rightButton;
    [Token(Token = "0x400F312")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Button leftButton;
    [Token(Token = "0x400F313")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Transform popPearent;
    [Token(Token = "0x400F314")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private SupportRankUp supportRankUpPrefab;
    [Token(Token = "0x400F315")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private CommonGesturePanel gesturePanel;
    [Token(Token = "0x400F316")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F317")]
    private const int UnitPerGroup = 5;
    [Token(Token = "0x400F318")]
    [FieldOffset(Offset = "0x108")]
    private Stopwatch stopWatch;
    [Token(Token = "0x400F319")]
    [FieldOffset(Offset = "0x110")]
    private List<List<UnitCell>> unitCellInstances;
    [Token(Token = "0x400F31A")]
    [FieldOffset(Offset = "0x118")]
    private int currentGroupIndex;
    [Token(Token = "0x400F31B")]
    private const int GroupWidth = 1163;
    [Token(Token = "0x400F31C")]
    [FieldOffset(Offset = "0x120")]
    private Coroutine activeCoroutine;
    [Token(Token = "0x400F31D")]
    [FieldOffset(Offset = "0x128")]
    private List<List<ResultData.UnitDifference>> unitGroups;
    [Token(Token = "0x400F31E")]
    [FieldOffset(Offset = "0x130")]
    private List<List<(Style before, PlayerUnitType after)>> levelUpParams;
    [Token(Token = "0x400F31F")]
    [FieldOffset(Offset = "0x138")]
    private SkillUnlockView skillUnlockView;
    [Token(Token = "0x400F320")]
    [FieldOffset(Offset = "0x140")]
    private bool[] missionClearData;
    [Token(Token = "0x400F321")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private int playerunitGroupCount;
    [Token(Token = "0x400F322")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private ToasterUI toaster;
    [Token(Token = "0x400F323")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400F324")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400F325")]
    private const string inoutTimeLineAssetbundleName = "ui_page_ingame_battleresult_timeline";
    [Token(Token = "0x400F326")]
    private const string inoutTimeLineAssetName = "BattleResult";
    [Token(Token = "0x400F327")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private CanvasGroup nextButtonParent;
    [Token(Token = "0x400F328")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private GameObject fullScreenButtonWhileGauge;
    [Token(Token = "0x400F329")]
    [FieldOffset(Offset = "0x178")]
    private bool playerRankUp;
    [Token(Token = "0x400F32A")]
    [FieldOffset(Offset = "0x179")]
    private bool isNextButton;
    [Token(Token = "0x400F32B")]
    [FieldOffset(Offset = "0x180")]
    private List<UnitView.stSupportRankUpList> supportRankUpList;
    [Token(Token = "0x400F32C")]
    [FieldOffset(Offset = "0x188")]
    private List<UnitView.stWeaponMasterBonus> weaponMasterBonusList;
    [Token(Token = "0x400F32D")]
    [FieldOffset(Offset = "0x190")]
    private QuestTypeEnum questType;
    [Token(Token = "0x400F32E")]
    private const int MaxTrustValue = 10000;
    [Token(Token = "0x400F32F")]
    [FieldOffset(Offset = "0x194")]
    private int deckIdx;
    [Token(Token = "0x400F330")]
    [FieldOffset(Offset = "0x198")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F331")]
    [FieldOffset(Offset = "0x1A0")]
    public Dictionary<int, int> UnitLevelReachedDic;
    [Token(Token = "0x400F332")]
    [FieldOffset(Offset = "0x1A8")]
    private GaugeUpControl gaugeUpControl;

    [Token(Token = "0x1700487C")]
    public float SnapSecond
    {
      [Token(Token = "0x6015E64"), Address(RVA = "0x2323350", Offset = "0x2323350", VA = "0x2323350")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6015E65")]
    [Address(RVA = "0x2323358", Offset = "0x2323358", VA = "0x2323358")]
    public void Initialize(
      BattleResultSubScene subScene,
      ResultData result,
      bool[] missionClear,
      BattleResultSubScene.Parameter parameter,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6015E66")]
    [Address(RVA = "0x2323E70", Offset = "0x2323E70", VA = "0x2323E70")]
    private void SetDifficulty(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6015E67")]
    [Address(RVA = "0x23246D0", Offset = "0x23246D0", VA = "0x23246D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015E68")]
    [Address(RVA = "0x23246EC", Offset = "0x23246EC", VA = "0x23246EC")]
    private static ResultData.WeaponMasteryData FindByWeaponType(
      int WeaponType,
      ResultData.WeaponMasteryData[] datas)
    {
      return (ResultData.WeaponMasteryData) null;
    }

    [Token(Token = "0x6015E69")]
    [Address(RVA = "0x23244D4", Offset = "0x23244D4", VA = "0x23244D4")]
    public void Hide(bool immediate = false, bool disableObject = false)
    {
    }

    [Token(Token = "0x6015E6A")]
    [Address(RVA = "0x2323F58", Offset = "0x2323F58", VA = "0x2323F58")]
    private void SetData(
      ResultData.UnitDifference[] unitDifferences,
      Style[] beforeStyles,
      PlayerUnitType[] afterUnits)
    {
    }

    [Token(Token = "0x6015E6B")]
    [Address(RVA = "0x2324750", Offset = "0x2324750", VA = "0x2324750", Slot = "6")]
    public override void Play()
    {
    }

    [Token(Token = "0x6015E6C")]
    [Address(RVA = "0x2324A48", Offset = "0x2324A48", VA = "0x2324A48")]
    private void SetButtonEventStyleLevelUp(List<UnitCell> units, int index, bool isActive)
    {
    }

    [Token(Token = "0x6015E6D")]
    [Address(RVA = "0x2324B5C", Offset = "0x2324B5C", VA = "0x2324B5C")]
    public void Snap(int groupIndex, bool immediate = false)
    {
    }

    [Token(Token = "0x6015E6E")]
    [Address(RVA = "0x2324DF8", Offset = "0x2324DF8", VA = "0x2324DF8")]
    private IEnumerator SnapToUnitGroup(int groupIndex, bool immediate) => (IEnumerator) null;

    [Token(Token = "0x6015E6F")]
    [Address(RVA = "0x232442C", Offset = "0x232442C", VA = "0x232442C")]
    private void SnapToUnitGroup(int groupIndex)
    {
    }

    [Token(Token = "0x6015E70")]
    [Address(RVA = "0x2324EA4", Offset = "0x2324EA4", VA = "0x2324EA4")]
    public void SetWeaponExp(int groupIndex, int unitIndex, int[] weaponExps)
    {
    }

    [Token(Token = "0x6015E71")]
    [Address(RVA = "0x2324F3C", Offset = "0x2324F3C", VA = "0x2324F3C")]
    public void ShowStatusUp(int groupIndex, int unitIndex)
    {
    }

    [Token(Token = "0x6015E72")]
    [Address(RVA = "0x2324FCC", Offset = "0x2324FCC", VA = "0x2324FCC")]
    public void OnClick()
    {
    }

    [Token(Token = "0x6015E73")]
    [Address(RVA = "0x2325050", Offset = "0x2325050", VA = "0x2325050")]
    private IEnumerator SetOutNextButton() => (IEnumerator) null;

    [Token(Token = "0x1700487D")]
    private bool IsActiveUI
    {
      [Token(Token = "0x6015E74"), Address(RVA = "0x23250E0", Offset = "0x23250E0", VA = "0x23250E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015E75")]
    [Address(RVA = "0x2325100", Offset = "0x2325100", VA = "0x2325100")]
    public void OnClickRightButton()
    {
    }

    [Token(Token = "0x6015E76")]
    [Address(RVA = "0x2325124", Offset = "0x2325124", VA = "0x2325124")]
    public void OnClickLeftButton()
    {
    }

    [Token(Token = "0x6015E77")]
    [Address(RVA = "0x2325148", Offset = "0x2325148", VA = "0x2325148")]
    private void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x6015E78")]
    [Address(RVA = "0x2324C40", Offset = "0x2324C40", VA = "0x2324C40")]
    private void SetCurrentGroupIndex(int groupIndex)
    {
    }

    [Token(Token = "0x6015E79")]
    [Address(RVA = "0x23251F0", Offset = "0x23251F0", VA = "0x23251F0", Slot = "8")]
    protected override IEnumerator ExecutePlayFlow() => (IEnumerator) null;

    [Token(Token = "0x6015E7A")]
    [Address(RVA = "0x2325280", Offset = "0x2325280", VA = "0x2325280")]
    private void SetButtonState(bool state)
    {
    }

    [Token(Token = "0x6015E7B")]
    [Address(RVA = "0x2325390", Offset = "0x2325390", VA = "0x2325390")]
    private IEnumerator ShowToasters(Queue<string> messages) => (IEnumerator) null;

    [Token(Token = "0x6015E7C")]
    [Address(RVA = "0x2325420", Offset = "0x2325420", VA = "0x2325420")]
    private IEnumerator UnitResultAnimationInGroup() => (IEnumerator) null;

    [Token(Token = "0x6015E7D")]
    [Address(RVA = "0x23254B0", Offset = "0x23254B0", VA = "0x23254B0")]
    private bool UnitResultExpAnimationPlaying(int groupIndex) => new bool();

    [Token(Token = "0x6015E7E")]
    [Address(RVA = "0x23255B4", Offset = "0x23255B4", VA = "0x23255B4")]
    private int GetUnitFroupSkillUnlockCount(int groupIndex) => new int();

    [Token(Token = "0x6015E7F")]
    [Address(RVA = "0x23256BC", Offset = "0x23256BC", VA = "0x23256BC")]
    private void PlayTimeLine(UITimelineController.DirectionType type, Action finish)
    {
    }

    [Token(Token = "0x6015E80")]
    [Address(RVA = "0x2325868", Offset = "0x2325868", VA = "0x2325868")]
    public void PlayToaster(string text)
    {
    }

    [Token(Token = "0x6015E81")]
    [Address(RVA = "0x2325898", Offset = "0x2325898", VA = "0x2325898")]
    public UnitView()
    {
    }

    [Token(Token = "0x200379F")]
    public struct stWeaponProficiency
    {
      [Token(Token = "0x400F333")]
      [FieldOffset(Offset = "0x0")]
      public int ID;
      [Token(Token = "0x400F334")]
      [FieldOffset(Offset = "0x4")]
      public int BeforeExp;
      [Token(Token = "0x400F335")]
      [FieldOffset(Offset = "0x8")]
      public int AfterExp;

      [Token(Token = "0x6015E85")]
      [Address(RVA = "0x2325C10", Offset = "0x2325C10", VA = "0x2325C10")]
      public stWeaponProficiency(int id, int before, int after)
      {
      }
    }

    [Token(Token = "0x20037A0")]
    public struct stSupportRankUpList
    {
      [Token(Token = "0x400F336")]
      [FieldOffset(Offset = "0x0")]
      public SupportRankTypeEnum BeforeRank;
      [Token(Token = "0x400F337")]
      [FieldOffset(Offset = "0x4")]
      public SupportRankTypeEnum AfterRank;
      [Token(Token = "0x400F338")]
      [FieldOffset(Offset = "0x8")]
      public int Charactor1;
      [Token(Token = "0x400F339")]
      [FieldOffset(Offset = "0xC")]
      public int Charactor2;

      [Token(Token = "0x6015E86")]
      [Address(RVA = "0x2323F44", Offset = "0x2323F44", VA = "0x2323F44")]
      public stSupportRankUpList(
        SupportRankTypeEnum beforeRank,
        SupportRankTypeEnum afterRank,
        int chr1,
        int chr2)
      {
      }
    }

    [Token(Token = "0x20037A1")]
    public struct stWeaponMasterBonus
    {
      [Token(Token = "0x400F33A")]
      [FieldOffset(Offset = "0x0")]
      public int ID;
      [Token(Token = "0x400F33B")]
      [FieldOffset(Offset = "0x4")]
      public int Level;

      [Token(Token = "0x6015E87")]
      [Address(RVA = "0x2323F50", Offset = "0x2323F50", VA = "0x2323F50")]
      public stWeaponMasterBonus(int id, int lv)
      {
      }
    }
  }
}
