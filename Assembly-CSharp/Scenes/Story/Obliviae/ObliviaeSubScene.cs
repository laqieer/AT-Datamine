// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E74")]
  public class ObliviaeSubScene : SubScene
  {
    [Token(Token = "0x400C74F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int UNIT_ICON_MIN_COUNT;
    [Token(Token = "0x400C750")]
    private const string BGM_NAME = "BGM_OutGame_Oblivie";
    [Token(Token = "0x400C751")]
    private const string BGM_IN_EVENT_NAME = "BGM_OutGame_Oblivie_In";
    [Token(Token = "0x400C752")]
    private const string BGM_OUT_EVENT_NAME = "BGM_OutGame_Oblivie_Out";
    [Token(Token = "0x400C753")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasGroup SafeAreaCanvasGroup;
    [Token(Token = "0x400C754")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400C755")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton returnButton;
    [Token(Token = "0x400C756")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton medalButton;
    [Token(Token = "0x400C757")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text exchangeItemCountText;
    [Token(Token = "0x400C758")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text challengeCountText;
    [Token(Token = "0x400C759")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private HorizontalInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400C75A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400C75B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Header("タイムライン対象のCanvasGropusリスト")]
    private CanvasGroup[] timelineTargetCanvases;
    [Token(Token = "0x400C75C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    [Header("無限スクロールの左にどれぐらいの間隔を開けるか")]
    private float scrollMarginLeft;
    [Token(Token = "0x400C75D")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject[] viewPortInThumbnailDisableObjects;
    [Token(Token = "0x400C75E")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C75F")]
    [FieldOffset(Offset = "0xB8")]
    private ObliviaeSubScene.SceneParam sceneParam;
    [Token(Token = "0x400C760")]
    [FieldOffset(Offset = "0xC0")]
    private StoryObliviaeData obliviae;
    [Token(Token = "0x400C761")]
    [FieldOffset(Offset = "0xC8")]
    private StoryObliviaeDetailData[] obliviaes;
    [Token(Token = "0x400C762")]
    [FieldOffset(Offset = "0xD0")]
    private float scrollCellContainerWidthFull;
    [Token(Token = "0x400C763")]
    [FieldOffset(Offset = "0xD4")]
    private float scrollCellContainerWidthSingle;
    [Token(Token = "0x400C764")]
    [FieldOffset(Offset = "0xD8")]
    private bool isOpenTutorial;

    [Token(Token = "0x6012272")]
    [Address(RVA = "0x458EA40", Offset = "0x458EA40", VA = "0x458EA40")]
    public static void ChangeSubSceneSimple(ObliviaeSubScene.SceneParam param)
    {
    }

    [Token(Token = "0x6012273")]
    [Address(RVA = "0x458EAF0", Offset = "0x458EAF0", VA = "0x458EAF0")]
    public static void ChangeSubScene(ObliviaeSubScene.SceneParam param)
    {
    }

    [Token(Token = "0x6012274")]
    [Address(RVA = "0x458EBA4", Offset = "0x458EBA4", VA = "0x458EBA4", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6012275")]
    [Address(RVA = "0x458EC34", Offset = "0x458EC34", VA = "0x458EC34", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6012276")]
    [Address(RVA = "0x458ECC4", Offset = "0x458ECC4", VA = "0x458ECC4", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6012277")]
    [Address(RVA = "0x458ED54", Offset = "0x458ED54", VA = "0x458ED54", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6012278")]
    [Address(RVA = "0x458EDE4", Offset = "0x458EDE4", VA = "0x458EDE4", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6012279")]
    [Address(RVA = "0x458EECC", Offset = "0x458EECC", VA = "0x458EECC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601227A")]
    [Address(RVA = "0x458F464", Offset = "0x458F464", VA = "0x458F464", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601227B")]
    [Address(RVA = "0x458F4F4", Offset = "0x458F4F4", VA = "0x458F4F4")]
    private void Awake()
    {
    }

    [Token(Token = "0x601227C")]
    [Address(RVA = "0x458F5B4", Offset = "0x458F5B4", VA = "0x458F5B4")]
    private void Update()
    {
    }

    [Token(Token = "0x601227D")]
    [Address(RVA = "0x458F638", Offset = "0x458F638", VA = "0x458F638")]
    private void SetupScroll()
    {
    }

    [Token(Token = "0x601227E")]
    [Address(RVA = "0x458FBA0", Offset = "0x458FBA0", VA = "0x458FBA0")]
    private IEnumerator SetupScrollArrow(float totalContainerSize) => (IEnumerator) null;

    [Token(Token = "0x601227F")]
    [Address(RVA = "0x458FC40", Offset = "0x458FC40", VA = "0x458FC40")]
    private void SetupMedalCount()
    {
    }

    [Token(Token = "0x6012280")]
    [Address(RVA = "0x458FD70", Offset = "0x458FD70", VA = "0x458FD70")]
    private void OnClickIcon(int obliviaeDetailListIndex)
    {
    }

    [Token(Token = "0x6012281")]
    [Address(RVA = "0x4590004", Offset = "0x4590004", VA = "0x4590004")]
    private void GotoBattleSelect(int obliviaeDetailID)
    {
    }

    [Token(Token = "0x6012282")]
    [Address(RVA = "0x458EDE8", Offset = "0x458EDE8", VA = "0x458EDE8")]
    private void Back()
    {
    }

    [Token(Token = "0x6012283")]
    [Address(RVA = "0x4590094", Offset = "0x4590094", VA = "0x4590094")]
    private void GotoMedalShop()
    {
    }

    [Token(Token = "0x6012284")]
    [Address(RVA = "0x4590248", Offset = "0x4590248", VA = "0x4590248")]
    public ObliviaeSubScene()
    {
    }

    [Token(Token = "0x6012285")]
    [Address(RVA = "0x4590250", Offset = "0x4590250", VA = "0x4590250")]
    static ObliviaeSubScene()
    {
    }

    [Token(Token = "0x2002E75")]
    public class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400C765")]
      [FieldOffset(Offset = "0x18")]
      public Action OnBackScene;
      [Token(Token = "0x400C766")]
      [FieldOffset(Offset = "0x20")]
      public Action OnInitializeAsyncEnd;

      [Token(Token = "0x601228E")]
      [Address(RVA = "0x45903E8", Offset = "0x45903E8", VA = "0x45903E8")]
      public SceneParam()
      {
      }
    }
  }
}
