// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A33")]
  public class OutGameMenuSubScene : SubScene
  {
    [Token(Token = "0x400FEE1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400FEE2")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup paramTweenGroup;
    [Token(Token = "0x400FEE3")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image[] titleIconImage;
    [Token(Token = "0x400FEE4")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400FEE5")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Button backButton;
    [Token(Token = "0x400FEE6")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Transform SubjectScreenParent;
    [Token(Token = "0x400FEE7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform SubjectScreenChild;
    [Token(Token = "0x400FEE8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject sideMenuBG;
    [Token(Token = "0x400FEE9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CanvasGroup headerTitleCG;
    [Token(Token = "0x400FEEA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FEEB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400FEEC")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private HomeButtonAnimationController homeButtonAnimationController;
    [Token(Token = "0x400FEED")]
    [FieldOffset(Offset = "0xB8")]
    private readonly string[] timeLineSettingNameList;
    [Token(Token = "0x400FEEE")]
    private const string TimeLineAssetbundleName = "content_effect_common_outgamemenu_timeline";
    [Token(Token = "0x400FEEF")]
    [FieldOffset(Offset = "0xC0")]
    private bool isTimelineDirection;
    [Token(Token = "0x400FEF0")]
    [FieldOffset(Offset = "0xC8")]
    private AssetCachedSpawner cachedSpawner;
    [Token(Token = "0x400FEF1")]
    [FieldOffset(Offset = "0xD0")]
    private OutGameMenuSubScene.OutGameMenuID currentSubjectScreenID;
    [Token(Token = "0x400FEF2")]
    [FieldOffset(Offset = "0xD8")]
    private OutGameMenuSubScene.SubSceneParam sceneParam;
    [Token(Token = "0x400FEF3")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private OutGameMenuSubjectScreenHandler subjectScreenHandler;
    [Token(Token = "0x400FEF4")]
    [FieldOffset(Offset = "0xE8")]
    private readonly string[] SubjectScreenAssetBundleNameList;
    [Token(Token = "0x400FEF5")]
    [FieldOffset(Offset = "0xF0")]
    private readonly string[] SubjectScreenObjectNameList;
    [Token(Token = "0x400FEF6")]
    [FieldOffset(Offset = "0xF8")]
    private OutGameMenuOperationPossible operationPossibleEvent;
    [Token(Token = "0x400FEF7")]
    [FieldOffset(Offset = "0x100")]
    private OutGameMenuOnBackScene onBackSceneEvent;
    [Token(Token = "0x400FEF8")]
    [FieldOffset(Offset = "0x108")]
    private Canvas canvas;
    [Token(Token = "0x400FEF9")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private EventTrigger listOutRangeTapEventTrigger;
    [Token(Token = "0x400FEFA")]
    [FieldOffset(Offset = "0x118")]
    private Action outRangeTap;
    [Token(Token = "0x400FEFB")]
    [FieldOffset(Offset = "0x120")]
    private SceneHandler.ProcessingSubSceneFlag processingSubScene;

    [Token(Token = "0x6016DF4")]
    [Address(RVA = "0x2C5C520", Offset = "0x2C5C520", VA = "0x2C5C520")]
    public void OutRangeEvent()
    {
    }

    [Token(Token = "0x6016DF5")]
    [Address(RVA = "0x2C5C53C", Offset = "0x2C5C53C", VA = "0x2C5C53C")]
    public void SetOutRangeEvent(Action outRange)
    {
    }

    [Token(Token = "0x6016DF6")]
    [Address(RVA = "0x2C5C544", Offset = "0x2C5C544", VA = "0x2C5C544")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016DF7")]
    [Address(RVA = "0x2C5C594", Offset = "0x2C5C594", VA = "0x2C5C594")]
    public void SetCanvasEnabled(bool isEnabled)
    {
    }

    [Token(Token = "0x6016DF8")]
    [Address(RVA = "0x2C5C628", Offset = "0x2C5C628", VA = "0x2C5C628", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6016DF9")]
    [Address(RVA = "0x2C5C864", Offset = "0x2C5C864", VA = "0x2C5C864", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016DFA")]
    [Address(RVA = "0x2C5C8F4", Offset = "0x2C5C8F4", VA = "0x2C5C8F4")]
    private void BeginProcessingSubScene()
    {
    }

    [Token(Token = "0x6016DFB")]
    [Address(RVA = "0x2C5C958", Offset = "0x2C5C958", VA = "0x2C5C958")]
    private void EndProcessingSubScene()
    {
    }

    [Token(Token = "0x6016DFC")]
    [Address(RVA = "0x2C5C980", Offset = "0x2C5C980", VA = "0x2C5C980", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016DFD")]
    [Address(RVA = "0x2C5C988", Offset = "0x2C5C988", VA = "0x2C5C988", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6016DFE")]
    [Address(RVA = "0x2C5C9B8", Offset = "0x2C5C9B8", VA = "0x2C5C9B8")]
    private bool BackKeyDownActionShop() => new bool();

    [Token(Token = "0x6016DFF")]
    [Address(RVA = "0x2C5CF68", Offset = "0x2C5CF68", VA = "0x2C5CF68")]
    private void OnBackSubScene()
    {
    }

    [Token(Token = "0x6016E00")]
    [Address(RVA = "0x2C5CEB4", Offset = "0x2C5CEB4", VA = "0x2C5CEB4")]
    public void BackSubScene()
    {
    }

    [Token(Token = "0x6016E01")]
    [Address(RVA = "0x2C5D05C", Offset = "0x2C5D05C", VA = "0x2C5D05C")]
    private IEnumerator waitStartDirection() => (IEnumerator) null;

    [Token(Token = "0x6016E02")]
    [Address(RVA = "0x2C5D0EC", Offset = "0x2C5D0EC", VA = "0x2C5D0EC")]
    public void SetFotterButtonActive(bool active)
    {
    }

    [Token(Token = "0x6016E03")]
    [Address(RVA = "0x2C5D11C", Offset = "0x2C5D11C", VA = "0x2C5D11C")]
    public void ChangeBackButtonCallback(Action backAction = null)
    {
    }

    [Token(Token = "0x6016E04")]
    [Address(RVA = "0x2C5D230", Offset = "0x2C5D230", VA = "0x2C5D230")]
    private IEnumerator playTimeline(
      OutGameMenuSubScene.eTimeLinedirecton idx,
      UITimelineController.DirectionType inout,
      Action playAction,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016E05")]
    [Address(RVA = "0x2C5D2E8", Offset = "0x2C5D2E8", VA = "0x2C5D2E8")]
    private IEnumerator PlayTimeLine(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016E06")]
    [Address(RVA = "0x2C5D38C", Offset = "0x2C5D38C", VA = "0x2C5D38C")]
    public void PlayHomeButtonInAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6016E07")]
    [Address(RVA = "0x2C5D3B8", Offset = "0x2C5D3B8", VA = "0x2C5D3B8")]
    public void PlayHomeButtonOutAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6016E08")]
    [Address(RVA = "0x2C5D3E4", Offset = "0x2C5D3E4", VA = "0x2C5D3E4")]
    public void ChangeGlobalShopSubjectScreen(
      OutGameMenuGlobalShopSubjectScreen.OutGameMenuGlobalShopSubjectParameter parameter)
    {
    }

    [Token(Token = "0x6016E09")]
    [Address(RVA = "0x2C5D49C", Offset = "0x2C5D49C", VA = "0x2C5D49C")]
    public void BackSubjectScreen(OutGameMenuSubScene.OutGameMenuID target)
    {
    }

    [Token(Token = "0x6016E0A")]
    [Address(RVA = "0x2C5D424", Offset = "0x2C5D424", VA = "0x2C5D424")]
    private IEnumerator ChangeSubjectScreen(OutGameMenuSubScene.OutGameMenuID target)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016E0B")]
    [Address(RVA = "0x2C5D4E4", Offset = "0x2C5D4E4", VA = "0x2C5D4E4")]
    private IEnumerator _ChangeSubjectScreen(
      OutGameMenuSubScene.OutGameMenuID target,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016E0C")]
    [Address(RVA = "0x2C5D03C", Offset = "0x2C5D03C", VA = "0x2C5D03C")]
    private void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6016E0D")]
    [Address(RVA = "0x2C5D58C", Offset = "0x2C5D58C", VA = "0x2C5D58C")]
    public void SetTitle(string titleText)
    {
    }

    [Token(Token = "0x6016E0E")]
    [Address(RVA = "0x2C5D5B0", Offset = "0x2C5D5B0", VA = "0x2C5D5B0")]
    public void SetTitleParameter(OutGameMenuSubScene.OutGameMenuID menuId)
    {
    }

    [Token(Token = "0x6016E0F")]
    [Address(RVA = "0x2C5D7A0", Offset = "0x2C5D7A0", VA = "0x2C5D7A0", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6016E10")]
    [Address(RVA = "0x2C5D8B0", Offset = "0x2C5D8B0", VA = "0x2C5D8B0")]
    public static OutGameMenuSubScene.OutGameMenuID? GetCurrentMenuID()
    {
      return new OutGameMenuSubScene.OutGameMenuID?();
    }

    [Token(Token = "0x6016E11")]
    [Address(RVA = "0x2C5D978", Offset = "0x2C5D978", VA = "0x2C5D978")]
    public OutGameMenuSubjectScreenBase GetCurrentSubjectScreen()
    {
      return (OutGameMenuSubjectScreenBase) null;
    }

    [Token(Token = "0x6016E12")]
    [Address(RVA = "0x2C5D994", Offset = "0x2C5D994", VA = "0x2C5D994")]
    public OutGameMenuSubScene()
    {
    }

    [Token(Token = "0x2003A34")]
    private enum eTimeLinedirecton
    {
      [Token(Token = "0x400FEFD")] Global,
      [Token(Token = "0x400FEFE")] OutGameMenu_SameLayer,
      [Token(Token = "0x400FEFF")] MedalShop,
      [Token(Token = "0x400FF00")] MAX,
    }

    [Token(Token = "0x2003A35")]
    public enum OutGameMenuID
    {
      [Token(Token = "0x400FF02")] Top,
      [Token(Token = "0x400FF03")] Armoury,
      [Token(Token = "0x400FF04")] Shop,
      [Token(Token = "0x400FF05")] Gacha,
      [Token(Token = "0x400FF06")] MAX,
    }

    [Token(Token = "0x2003A36")]
    public class SubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400FF0A")]
      [FieldOffset(Offset = "0x1C")]
      public int BelowScreenValue;

      [Token(Token = "0x17004B10")]
      public OutGameMenuSubScene.OutGameMenuID Id
      {
        [Token(Token = "0x6016E19"), Address(RVA = "0x2C5DEA0", Offset = "0x2C5DEA0", VA = "0x2C5DEA0")] get
        {
          return new OutGameMenuSubScene.OutGameMenuID();
        }
        [Token(Token = "0x6016E1A"), Address(RVA = "0x2C5DEA8", Offset = "0x2C5DEA8", VA = "0x2C5DEA8")] protected set
        {
        }
      }

      [Token(Token = "0x17004B11")]
      public bool IsGotoMedalShop
      {
        [Token(Token = "0x6016E1B"), Address(RVA = "0x2C5DEB0", Offset = "0x2C5DEB0", VA = "0x2C5DEB0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6016E1C"), Address(RVA = "0x2C5DEB8", Offset = "0x2C5DEB8", VA = "0x2C5DEB8")] private set
        {
        }
      }

      [Token(Token = "0x17004B12")]
      public bool IsGotoSaleShop
      {
        [Token(Token = "0x6016E1D"), Address(RVA = "0x2C5DEC4", Offset = "0x2C5DEC4", VA = "0x2C5DEC4")] get
        {
          return new bool();
        }
        [Token(Token = "0x6016E1E"), Address(RVA = "0x2C5DECC", Offset = "0x2C5DECC", VA = "0x2C5DECC")] private set
        {
        }
      }

      [Token(Token = "0x6016E1F")]
      [Address(RVA = "0x2C5C7B8", Offset = "0x2C5C7B8", VA = "0x2C5C7B8")]
      public SubSceneParam(OutGameMenuSubScene.OutGameMenuID id, bool isCreatedBack = false)
      {
      }

      [Token(Token = "0x6016E20")]
      [Address(RVA = "0x2C5DED8", Offset = "0x2C5DED8", VA = "0x2C5DED8")]
      public SubSceneParam(OutGameMenuSubScene.OutGameMenuID id, bool isGotoMedalShop, int val)
      {
      }

      [Token(Token = "0x6016E21")]
      [Address(RVA = "0x2C5DF90", Offset = "0x2C5DF90", VA = "0x2C5DF90")]
      public SubSceneParam(
        OutGameMenuSubScene.OutGameMenuID id,
        bool isGotoSaleShop,
        bool isCreatedBack = false)
      {
      }

      [Token(Token = "0x6016E22")]
      [Address(RVA = "0x2C5E050", Offset = "0x2C5E050", VA = "0x2C5E050")]
      public SubSceneParam(OutGameMenuSubScene.OutGameMenuID id, int shopListIndex)
      {
      }
    }
  }
}
