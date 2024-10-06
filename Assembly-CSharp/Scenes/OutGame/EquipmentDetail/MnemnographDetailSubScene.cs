// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographDetailSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Common;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Common;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036D2")]
  public class MnemnographDetailSubScene : EquipmentDetailSubScene, IMnemnographStatusMediator
  {
    [Token(Token = "0x400EF00")]
    private const string InAnimationName = "In";
    [Token(Token = "0x400EF01")]
    private const string OutAnimationName = "Out";
    [Token(Token = "0x400EF02")]
    private const string MenuInAnimationName = "GameMenu_In";
    [Token(Token = "0x400EF03")]
    private const string MenuOutAnimationName = "GameMenu_Out";
    [Token(Token = "0x400EF04")]
    private const string InEnhanceMenu = "EnhanceMenu_In";
    [Token(Token = "0x400EF05")]
    private const string OutEnhanceMenu = "EnhanceMenu_Out";
    [Token(Token = "0x400EF06")]
    private const string InoutTimeLineAssetName = "ui_page_mnemnographdetail_timeline";
    [Token(Token = "0x400EF07")]
    private const string InoutTimeLineAssetbundleName = "MnemnographDetail";
    [Token(Token = "0x400EF08")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400EF09")]
    private const string GetCustomSkillAssetbundleName = "ui_page_mnemnographdetail";
    [Token(Token = "0x400EF0A")]
    private const string DetailIn = "MnemnographDetail_In";
    [Token(Token = "0x400EF0B")]
    private const string DetailOut = "MnemnographDetail_Out";
    [Token(Token = "0x400EF0C")]
    private const string LimitBreakIn = "MnemnographLimitBreak_SideMenu_In";
    [Token(Token = "0x400EF0D")]
    private const string LimitBreakOut = "MnemnographLimitBreak_SideMenu_out";
    [Token(Token = "0x400EF0E")]
    private const string LevelUpIn = "MnemnographLvup_SideMenu_In";
    [Token(Token = "0x400EF0F")]
    private const string LevelUpOut = "MnemnographLvup_SideMenu_out";
    [Token(Token = "0x400EF10")]
    private const string SkillIn = "MnemnographSkillSideWindow_In";
    [Token(Token = "0x400EF11")]
    private const string SkillOut = "MnemnographSkillSideWindow_out";
    [Token(Token = "0x400EF12")]
    private const string TrustIn = "MnemnographTrustValueup_SideMenu_In";
    [Token(Token = "0x400EF13")]
    private const string TrustOut = "MnemnographTrustValueup_SideMenu_out";
    [Token(Token = "0x400EF14")]
    private const string MnemnographViewerAssetBundleName = "ui_page_mnemnographdetail";
    [Token(Token = "0x400EF15")]
    private const string MnemnographViewerAssetName = "MnemonographDetail_Viewer";
    [Token(Token = "0x400EF16")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400EF17")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400EF18")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton statusButton;
    [Token(Token = "0x400EF19")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton enhanceMenuButton;
    [Token(Token = "0x400EF1A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton enhanceMenuLimitBreakButton;
    [Token(Token = "0x400EF1B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton enhanceMenuLevelUpButton;
    [Token(Token = "0x400EF1C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton skillButton;
    [Token(Token = "0x400EF1D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400EF1E")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400EF1F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400EF20")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400EF21")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400EF22")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private MnemnographDetailCenter _detailCenter;
    [Token(Token = "0x400EF23")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text mnemnographNameText;
    [Token(Token = "0x400EF24")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private MnemnographStatus mnemnographStatus;
    [Token(Token = "0x400EF25")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private MnemnographLimitBreakSideMenu mnemnographLimitBreakSideMenu;
    [Token(Token = "0x400EF26")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private MnemnographLevelUpSideMenu mnemnographLevelUpSideMenu;
    [Token(Token = "0x400EF27")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CanvasGroup suppression;
    [Token(Token = "0x400EF28")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Transform enhanceMenuParent;
    [Token(Token = "0x400EF29")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Canvas gestureCanvas;
    [Token(Token = "0x400EF2A")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Camera gestureCamera;
    [Token(Token = "0x400EF2B")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private MnemnographViewer mnemnographViewer;
    [Token(Token = "0x400EF2C")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private ContainerSkillSideWindow containerSkillSideWindow;
    [Token(Token = "0x400EF2D")]
    [FieldOffset(Offset = "0x110")]
    private MnemnographDetailSubScene.Param<MindEquipment> sceneParam;
    [Token(Token = "0x400EF2E")]
    [FieldOffset(Offset = "0x118")]
    private MnemnographDetailSubScene.TransitionState transitionStateId;
    [Token(Token = "0x400EF2F")]
    [FieldOffset(Offset = "0x11C")]
    private MnemnographDetailSubScene.State state;
    [Token(Token = "0x400EF30")]
    [FieldOffset(Offset = "0x120")]
    private bool isDispEnhanceMenu;
    [Token(Token = "0x400EF31")]
    [FieldOffset(Offset = "0x124")]
    private int index;
    [Token(Token = "0x400EF32")]
    [FieldOffset(Offset = "0x128")]
    private bool isDispEnhance;
    [Token(Token = "0x400EF33")]
    [FieldOffset(Offset = "0x130")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400EF34")]
    [FieldOffset(Offset = "0x138")]
    private SkillViewModel customSkillViewModel;
    [Token(Token = "0x400EF35")]
    [FieldOffset(Offset = "0x140")]
    private SkillModel customSkillModel;
    [Token(Token = "0x400EF36")]
    [FieldOffset(Offset = "0x148")]
    private SkillViewModel partySkillViewModel;
    [Token(Token = "0x400EF37")]
    [FieldOffset(Offset = "0x150")]
    private SkillModel partySkillModel;
    [Token(Token = "0x400EF38")]
    [FieldOffset(Offset = "0x158")]
    private bool isFullImageLoaded;
    [Token(Token = "0x400EF39")]
    [FieldOffset(Offset = "0x15C")]
    private Vector3 enhanceMenuDefaultPos;
    [Token(Token = "0x400EF3A")]
    [FieldOffset(Offset = "0x168")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400EF3C")]
    [FieldOffset(Offset = "0x178")]
    private NewBadgeProxy newBadgeProxy;

    [Token(Token = "0x6015947")]
    [Address(RVA = "0x1A65460", Offset = "0x1A65460", VA = "0x1A65460")]
    public void SetSceneInteractable(bool state)
    {
    }

    [Token(Token = "0x17004771")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x6015948"), Address(RVA = "0x1A65480", Offset = "0x1A65480", VA = "0x1A65480")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x6015949"), Address(RVA = "0x1A65488", Offset = "0x1A65488", VA = "0x1A65488")] private set
      {
      }
    }

    [Token(Token = "0x601594A")]
    [Address(RVA = "0x1A65490", Offset = "0x1A65490", VA = "0x1A65490")]
    public AssetCachedSpawner GetAssetCachedSpawner() => (AssetCachedSpawner) null;

    [Token(Token = "0x601594B")]
    [Address(RVA = "0x1A65498", Offset = "0x1A65498", VA = "0x1A65498")]
    private void Awake()
    {
    }

    [Token(Token = "0x601594C")]
    [Address(RVA = "0x1A654B8", Offset = "0x1A654B8", VA = "0x1A654B8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601594D")]
    [Address(RVA = "0x1A654D8", Offset = "0x1A654D8", VA = "0x1A654D8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601594E")]
    [Address(RVA = "0x1A65A20", Offset = "0x1A65A20", VA = "0x1A65A20", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601594F")]
    [Address(RVA = "0x1A65A88", Offset = "0x1A65A88", VA = "0x1A65A88")]
    private IEnumerator Disclosure() => (IEnumerator) null;

    [Token(Token = "0x6015950")]
    [Address(RVA = "0x1A65AF0", Offset = "0x1A65AF0", VA = "0x1A65AF0", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6015951")]
    [Address(RVA = "0x1A65C18", Offset = "0x1A65C18", VA = "0x1A65C18", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6015952")]
    [Address(RVA = "0x1A65C80", Offset = "0x1A65C80", VA = "0x1A65C80", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6015953")]
    [Address(RVA = "0x1A65D30", Offset = "0x1A65D30", VA = "0x1A65D30")]
    private IEnumerator Show(MindEquipment mindEquipment) => (IEnumerator) null;

    [Token(Token = "0x6015954")]
    [Address(RVA = "0x1A65DA4", Offset = "0x1A65DA4", VA = "0x1A65DA4")]
    private void UpdateInfo(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6015955")]
    [Address(RVA = "0x1A65E00", Offset = "0x1A65E00", VA = "0x1A65E00")]
    private IEnumerator SetMnemnographViewer(int id) => (IEnumerator) null;

    [Token(Token = "0x6015956")]
    [Address(RVA = "0x1A65E78", Offset = "0x1A65E78", VA = "0x1A65E78")]
    public void OnClickStats()
    {
    }

    [Token(Token = "0x6015957")]
    [Address(RVA = "0x1A66180", Offset = "0x1A66180", VA = "0x1A66180")]
    public void OnClickEnhanceMenu()
    {
    }

    [Token(Token = "0x6015958")]
    [Address(RVA = "0x1A66274", Offset = "0x1A66274", VA = "0x1A66274")]
    public void OnClickEnhanceMenuLimitBreak()
    {
    }

    [Token(Token = "0x6015959")]
    [Address(RVA = "0x1A665C8", Offset = "0x1A665C8", VA = "0x1A665C8")]
    public void OnClickEnhanceMenuLevelUP()
    {
    }

    [Token(Token = "0x601595A")]
    [Address(RVA = "0x1A66944", Offset = "0x1A66944", VA = "0x1A66944")]
    public void OnClickSkill()
    {
    }

    [Token(Token = "0x601595B")]
    [Address(RVA = "0x1A66A88", Offset = "0x1A66A88", VA = "0x1A66A88")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x601595C")]
    [Address(RVA = "0x1A66D24", Offset = "0x1A66D24", VA = "0x1A66D24", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x601595D")]
    [Address(RVA = "0x1A66E6C", Offset = "0x1A66E6C", VA = "0x1A66E6C")]
    public void OnClickPrev()
    {
    }

    [Token(Token = "0x601595E")]
    [Address(RVA = "0x1A66F8C", Offset = "0x1A66F8C", VA = "0x1A66F8C")]
    public void OnClickNext()
    {
    }

    [Token(Token = "0x601595F")]
    [Address(RVA = "0x1A66F80", Offset = "0x1A66F80", VA = "0x1A66F80")]
    private void SetPrevNextInteractable(bool prevNext)
    {
    }

    [Token(Token = "0x6015960")]
    [Address(RVA = "0x1A670BC", Offset = "0x1A670BC", VA = "0x1A670BC")]
    private void SetPrevNextInteractable(bool prev, bool next)
    {
    }

    [Token(Token = "0x6015961")]
    [Address(RVA = "0x1A67180", Offset = "0x1A67180", VA = "0x1A67180")]
    public void OnClickFavorite()
    {
    }

    [Token(Token = "0x6015962")]
    [Address(RVA = "0x1A67208", Offset = "0x1A67208", VA = "0x1A67208")]
    private bool ResponseCodeJudgement(int responseCode) => new bool();

    [Token(Token = "0x6015963")]
    [Address(RVA = "0x1A671A0", Offset = "0x1A671A0", VA = "0x1A671A0")]
    private IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6015964")]
    [Address(RVA = "0x1A65F34", Offset = "0x1A65F34", VA = "0x1A65F34")]
    private void SetButtonControll(bool flg, MnemnographDetailSubScene.State state)
    {
    }

    [Token(Token = "0x6015965")]
    [Address(RVA = "0x1A67238", Offset = "0x1A67238", VA = "0x1A67238")]
    public void OnClickImage()
    {
    }

    [Token(Token = "0x6015966")]
    [Address(RVA = "0x1A672EC", Offset = "0x1A672EC", VA = "0x1A672EC")]
    private void AnimFinishCallback()
    {
    }

    [Token(Token = "0x6015967")]
    [Address(RVA = "0x1A6608C", Offset = "0x1A6608C", VA = "0x1A6608C")]
    private void PlayAnim(string name, bool stopCurrent = true)
    {
    }

    [Token(Token = "0x6015968")]
    [Address(RVA = "0x1A673B8", Offset = "0x1A673B8", VA = "0x1A673B8")]
    private void ChangeState(MnemnographDetailSubScene.TransitionState id, bool force = false)
    {
    }

    [Token(Token = "0x6015969")]
    [Address(RVA = "0x1A66544", Offset = "0x1A66544", VA = "0x1A66544")]
    public void SetToaster(string txt)
    {
    }

    [Token(Token = "0x601596A")]
    [Address(RVA = "0x1A6748C", Offset = "0x1A6748C", VA = "0x1A6748C")]
    public MnemnographStatus GetMnemnographStatus() => (MnemnographStatus) null;

    [Token(Token = "0x601596B")]
    [Address(RVA = "0x1A67494", Offset = "0x1A67494", VA = "0x1A67494")]
    private bool IsDisabledLimitBreak() => new bool();

    [Token(Token = "0x601596C")]
    [Address(RVA = "0x1A67588", Offset = "0x1A67588", VA = "0x1A67588")]
    private bool IsDisabledLevelUp() => new bool();

    [Token(Token = "0x601596D")]
    [Address(RVA = "0x1A675FC", Offset = "0x1A675FC", VA = "0x1A675FC")]
    private void UpdateLeftMenuButton()
    {
    }

    [Token(Token = "0x601596E")]
    [Address(RVA = "0x1A67648", Offset = "0x1A67648", VA = "0x1A67648")]
    private void SetDisabledColorLimitBreakButton(bool isDisabled)
    {
    }

    [Token(Token = "0x601596F")]
    [Address(RVA = "0x1A67668", Offset = "0x1A67668", VA = "0x1A67668")]
    private void SetDisabledColorLevelUpButton(bool isDisabled)
    {
    }

    [Token(Token = "0x6015970")]
    [Address(RVA = "0x1A67688", Offset = "0x1A67688", VA = "0x1A67688")]
    private void Update()
    {
    }

    [Token(Token = "0x6015971")]
    [Address(RVA = "0x1A676A4", Offset = "0x1A676A4", VA = "0x1A676A4")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6015972")]
    [Address(RVA = "0x1A676C0", Offset = "0x1A676C0", VA = "0x1A676C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015973")]
    [Address(RVA = "0x1A676DC", Offset = "0x1A676DC", VA = "0x1A676DC", Slot = "32")]
    public bool TryGetTragetLevel(out int targetLevel) => new bool();

    [Token(Token = "0x6015974")]
    [Address(RVA = "0x1A6771C", Offset = "0x1A6771C", VA = "0x1A6771C")]
    public MnemnographDetailSubScene()
    {
    }

    [Token(Token = "0x20036D3")]
    public class Param<T> : ChangeSceneParameter
    {
      [Token(Token = "0x400EF41")]
      [FieldOffset(Offset = "0x0")]
      public Action onInitializeAction;
      [Token(Token = "0x400EF42")]
      [FieldOffset(Offset = "0x0")]
      public SafeObjectCallback onDestroyAction;
      [Token(Token = "0x400EF43")]
      [FieldOffset(Offset = "0x0")]
      public Action<int> OnBackScene;

      [Token(Token = "0x17004772")]
      public bool IsDispEnhance
      {
        [Token(Token = "0x6015989")] get => new bool();
        [Token(Token = "0x601598A")] protected set
        {
        }
      }

      [Token(Token = "0x17004773")]
      public bool IsEnterToSkill
      {
        [Token(Token = "0x601598B")] get => new bool();
        [Token(Token = "0x601598C")] protected set
        {
        }
      }

      [Token(Token = "0x17004774")]
      public List<T> ItemList
      {
        [Token(Token = "0x601598D")] get => (List<T>) null;
        [Token(Token = "0x601598E")] protected set
        {
        }
      }

      [Token(Token = "0x17004775")]
      public int Index
      {
        [Token(Token = "0x601598F")] get => new int();
        [Token(Token = "0x6015990")] protected set
        {
        }
      }

      [Token(Token = "0x6015991")]
      public Param(
        bool isDispEnhance,
        bool isEnterToSkill,
        List<T> itemList,
        int index,
        Action onInitializeAction = null,
        SafeObjectCallback onDestroyAction = null)
      {
      }
    }

    [Token(Token = "0x20036D4")]
    private enum TransitionState
    {
      [Token(Token = "0x400EF45")] None,
      [Token(Token = "0x400EF46")] Open,
      [Token(Token = "0x400EF47")] Normal,
      [Token(Token = "0x400EF48")] Close,
      [Token(Token = "0x400EF49")] Closed,
    }

    [Token(Token = "0x20036D5")]
    private enum State
    {
      [Token(Token = "0x400EF4B")] Top,
      [Token(Token = "0x400EF4C")] Status,
      [Token(Token = "0x400EF4D")] LimitBreak,
      [Token(Token = "0x400EF4E")] LevelUp,
      [Token(Token = "0x400EF4F")] Trust,
      [Token(Token = "0x400EF50")] Option,
      [Token(Token = "0x400EF51")] Skill,
      [Token(Token = "0x400EF52")] Viewer,
    }

    [Token(Token = "0x20036D6")]
    private enum Favorite
    {
      [Token(Token = "0x400EF54")] Off,
      [Token(Token = "0x400EF55")] On,
    }
  }
}
