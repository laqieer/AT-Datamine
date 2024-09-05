// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.ShieldAccessoryDetailSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Common;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
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
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x200338B")]
  public class ShieldAccessoryDetailSubScene : EquipmentDetailSubScene
  {
    [Token(Token = "0x400DF7A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RarityIcon rarityIconImage;
    [Token(Token = "0x400DF7B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text ShieldAccessoryNameText;
    [Token(Token = "0x400DF7C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image ShieldAccessoryImage;
    [Token(Token = "0x400DF7D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton statusButton;
    [Token(Token = "0x400DF7E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton enhanceButton;
    [Token(Token = "0x400DF7F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton optionEffectButton;
    [Token(Token = "0x400DF80")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton skillButton;
    [Token(Token = "0x400DF81")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400DF82")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CanvasGroup enhanceMenuGroup;
    [Token(Token = "0x400DF83")]
    [FieldOffset(Offset = "0xA0")]
    private bool enhanceMenuOn;
    [Token(Token = "0x400DF84")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Image typeIcon;
    [Token(Token = "0x400DF85")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Image[] gemOffIconImage;
    [Token(Token = "0x400DF86")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Image[] gemOnIconImage;
    [Token(Token = "0x400DF87")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text levelText;
    [Token(Token = "0x400DF88")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text levelMaxText;
    [Token(Token = "0x400DF89")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GaugeScale levelExpSlider;
    [Token(Token = "0x400DF8A")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400DF8B")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400DF8C")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Transform safeArea;
    [Token(Token = "0x400DF8D")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private StatusViewBase shieldStatus;
    [Token(Token = "0x400DF8E")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private StatusViewBase accessoryStatus;
    [Token(Token = "0x400DF8F")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private WeaponOptionEffectContainer[] ShieldAccessoryOptionEffectContainers;
    [Token(Token = "0x400DF90")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private GameObject skillObject;
    [Token(Token = "0x400DF91")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private DetailSkillListThumb detailSkillList;
    [Token(Token = "0x400DF92")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private HomeButtonAnimationController homeButtonAnimationController;
    [Token(Token = "0x400DF93")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private CommonButton returnButton;
    [Token(Token = "0x400DF94")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private CommonButton prevButton;
    [Token(Token = "0x400DF95")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400DF96")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400DF97")]
    [FieldOffset(Offset = "0x140")]
    private bool favoriteConnecting;
    [Token(Token = "0x400DF98")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private CommonButton limitBreakButton;
    [Token(Token = "0x400DF99")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private CommonButton levelUpButton;
    [Token(Token = "0x400DF9A")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private ContainerSkillSideWindow containerSkillSideWindow;
    [Token(Token = "0x400DF9B")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private ShieldAccessoryLimitBreak ShieldAccessoryLimitBreak;
    [Token(Token = "0x400DF9C")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private ShieldAccessoryLevelUp ShieldAccessoryLevelUp;
    [Token(Token = "0x400DF9D")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private ShieldAccessoryOptionEffect ShieldAccessoryOptionEffect;
    [Token(Token = "0x400DF9E")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private SkillEnhanceController skillEnhanceController;
    [Token(Token = "0x400DF9F")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private CanvasGroup canvasGroup_top;
    [Token(Token = "0x400DFA0")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400DFA1")]
    [FieldOffset(Offset = "0x190")]
    private bool isTimelineDirection;
    [Token(Token = "0x400DFA2")]
    private const string inoutTimeLineAssetbundleName = "ui_page_shielddetail_timeline";
    [Token(Token = "0x400DFA3")]
    [FieldOffset(Offset = "0x198")]
    private readonly string[] timeLineSettingNameList;
    [Token(Token = "0x400DFA4")]
    [FieldOffset(Offset = "0x1A0")]
    private ShieldAccessoryDetailSubScene.eTimeLineMode timeLineMode;
    [Token(Token = "0x400DFA5")]
    [FieldOffset(Offset = "0x1A8")]
    private readonly string[] directAssetBundleName;
    [Token(Token = "0x400DFA6")]
    [FieldOffset(Offset = "0x1B0")]
    private List<string>[] loadWaitShieldAccessoryId;
    [Token(Token = "0x400DFA7")]
    [FieldOffset(Offset = "0x1B8")]
    private int loadWaitShieldAccessoryIdOfs;
    [Token(Token = "0x400DFA8")]
    [FieldOffset(Offset = "0x1BC")]
    private bool assetBundleLoading;
    [Token(Token = "0x400DFA9")]
    [FieldOffset(Offset = "0x1C0")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x400DFAA")]
    [FieldOffset(Offset = "0x1C8")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400DFAB")]
    [FieldOffset(Offset = "0x1D0")]
    private ShieldAccessoryDetailSubScene.Param sceneParam;
    [Token(Token = "0x400DFAC")]
    [FieldOffset(Offset = "0x1D8")]
    public Accessory ShieldAccessoryData;
    [Token(Token = "0x400DFAD")]
    [FieldOffset(Offset = "0x1E0")]
    private int ShieldAccessoryDataIndex;
    [Token(Token = "0x400DFAE")]
    [FieldOffset(Offset = "0x1E8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400DFB0")]
    [FieldOffset(Offset = "0x1F8")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400DFB1")]
    [FieldOffset(Offset = "0x200")]
    public Action onClickPrevAction;
    [Token(Token = "0x400DFB2")]
    [FieldOffset(Offset = "0x208")]
    public Action onClickNextAction;

    [Token(Token = "0x60143FF")]
    [Address(RVA = "0x2060BAC", Offset = "0x2060BAC", VA = "0x2060BAC")]
    public static bool TryToChangeScene(PlayerAccessoriesOptionChangePending pending) => new bool();

    [Token(Token = "0x6014400")]
    [Address(RVA = "0x2060DC4", Offset = "0x2060DC4", VA = "0x2060DC4")]
    public static void ChangeScene(ShieldAccessoryDetailSubScene.Param param)
    {
    }

    [Token(Token = "0x6014401")]
    [Address(RVA = "0x2060E74", Offset = "0x2060E74", VA = "0x2060E74")]
    public void SetSceneInteractable(bool state)
    {
    }

    [Token(Token = "0x17004396")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x6014402"), Address(RVA = "0x2060E94", Offset = "0x2060E94", VA = "0x2060E94")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x6014403"), Address(RVA = "0x2060E9C", Offset = "0x2060E9C", VA = "0x2060E9C")] private set
      {
      }
    }

    [Token(Token = "0x6014404")]
    [Address(RVA = "0x2060EA4", Offset = "0x2060EA4", VA = "0x2060EA4")]
    public AssetCachedSpawner GetAssetCachedSpawner() => (AssetCachedSpawner) null;

    [Token(Token = "0x6014405")]
    [Address(RVA = "0x2060EAC", Offset = "0x2060EAC", VA = "0x2060EAC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6014406")]
    [Address(RVA = "0x2060F34", Offset = "0x2060F34", VA = "0x2060F34", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014407")]
    [Address(RVA = "0x2061218", Offset = "0x2061218", VA = "0x2061218", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014408")]
    [Address(RVA = "0x20612A8", Offset = "0x20612A8", VA = "0x20612A8")]
    private bool IsDisabledLimitBreak() => new bool();

    [Token(Token = "0x6014409")]
    [Address(RVA = "0x206135C", Offset = "0x206135C", VA = "0x206135C")]
    private bool IsDisabledLevelUp() => new bool();

    [Token(Token = "0x601440A")]
    [Address(RVA = "0x2061378", Offset = "0x2061378", VA = "0x2061378")]
    private void UpdateLeftMenuSkillButton()
    {
    }

    [Token(Token = "0x601440B")]
    [Address(RVA = "0x20613F0", Offset = "0x20613F0", VA = "0x20613F0")]
    private void SetDisabledLeftMenuSkillButton(bool isDisabled)
    {
    }

    [Token(Token = "0x601440C")]
    [Address(RVA = "0x206143C", Offset = "0x206143C", VA = "0x206143C")]
    private void SetDisabledColorLimitBreakButton(bool isDisabled)
    {
    }

    [Token(Token = "0x601440D")]
    [Address(RVA = "0x206145C", Offset = "0x206145C", VA = "0x206145C")]
    private void SetDisabledColorLevelUpButton(bool isDisabled)
    {
    }

    [Token(Token = "0x601440E")]
    [Address(RVA = "0x206147C", Offset = "0x206147C", VA = "0x206147C")]
    public void OnBackButton()
    {
    }

    [Token(Token = "0x601440F")]
    [Address(RVA = "0x20619AC", Offset = "0x20619AC", VA = "0x20619AC", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6014410")]
    [Address(RVA = "0x2061B48", Offset = "0x2061B48", VA = "0x2061B48")]
    private void OnClickPrevButton()
    {
    }

    [Token(Token = "0x6014411")]
    [Address(RVA = "0x2061C98", Offset = "0x2061C98", VA = "0x2061C98")]
    private void OnClickNextButton()
    {
    }

    [Token(Token = "0x6014412")]
    [Address(RVA = "0x2061D8C", Offset = "0x2061D8C", VA = "0x2061D8C")]
    public void SetOperationPossible(bool flg, ShieldAccessoryDetailSubScene.eTimeLineMode state)
    {
    }

    [Token(Token = "0x6014413")]
    [Address(RVA = "0x2061ED0", Offset = "0x2061ED0", VA = "0x2061ED0")]
    private void SetPrevNextInteractable(bool prevNext)
    {
    }

    [Token(Token = "0x6014414")]
    [Address(RVA = "0x2061EDC", Offset = "0x2061EDC", VA = "0x2061EDC")]
    private void SetPrevNextInteractable(bool prev, bool next)
    {
    }

    [Token(Token = "0x6014415")]
    [Address(RVA = "0x2061F94", Offset = "0x2061F94", VA = "0x2061F94")]
    public void SetShieldAccessoryData()
    {
    }

    [Token(Token = "0x6014416")]
    [Address(RVA = "0x2062344", Offset = "0x2062344", VA = "0x2062344")]
    private void UpdateStatusSkill()
    {
    }

    [Token(Token = "0x6014417")]
    [Address(RVA = "0x20624B0", Offset = "0x20624B0", VA = "0x20624B0")]
    private IStatusView SwitchedStatusView(Accessory accessory) => (IStatusView) null;

    [Token(Token = "0x6014418")]
    [Address(RVA = "0x2062548", Offset = "0x2062548", VA = "0x2062548")]
    public void UpdateStatus(Accessory accessory, int level)
    {
    }

    [Token(Token = "0x6014419")]
    [Address(RVA = "0x2061614", Offset = "0x2061614", VA = "0x2061614")]
    public void UpdateStatus(Accessory accessory, AccessoryStandardStatus assumption = null)
    {
    }

    [Token(Token = "0x601441A")]
    [Address(RVA = "0x2061920", Offset = "0x2061920", VA = "0x2061920")]
    private IEnumerator playTimeline(
      ShieldAccessoryDetailSubScene.eTimeLineMode mode,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601441B")]
    [Address(RVA = "0x206262C", Offset = "0x206262C", VA = "0x206262C")]
    private void SkipTimeline()
    {
    }

    [Token(Token = "0x601441C")]
    [Address(RVA = "0x2062794", Offset = "0x2062794", VA = "0x2062794", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601441D")]
    [Address(RVA = "0x20627CC", Offset = "0x20627CC", VA = "0x20627CC", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x601441E")]
    [Address(RVA = "0x2061C24", Offset = "0x2061C24", VA = "0x2061C24")]
    private IEnumerator LoadingShieldAccessoryImage(Action finish = null) => (IEnumerator) null;

    [Token(Token = "0x601441F")]
    [Address(RVA = "0x206283C", Offset = "0x206283C", VA = "0x206283C")]
    private IEnumerator ConnectAPIFavorite(Accessory accessory, bool flg) => (IEnumerator) null;

    [Token(Token = "0x6014420")]
    [Address(RVA = "0x20628E8", Offset = "0x20628E8", VA = "0x20628E8")]
    private void onClickSkillEnhance(int count)
    {
    }

    [Token(Token = "0x6014421")]
    [Address(RVA = "0x2062980", Offset = "0x2062980", VA = "0x2062980")]
    private void onClickInvalidEnhance(int count)
    {
    }

    [Token(Token = "0x6014422")]
    [Address(RVA = "0x2062AA0", Offset = "0x2062AA0", VA = "0x2062AA0")]
    private void OnClickLvInfo()
    {
    }

    [Token(Token = "0x6014423")]
    [Address(RVA = "0x2062908", Offset = "0x2062908", VA = "0x2062908")]
    private IEnumerator ConnectSkillEnhanceAPI(int tryCount) => (IEnumerator) null;

    [Token(Token = "0x6014424")]
    [Address(RVA = "0x2062B08", Offset = "0x2062B08", VA = "0x2062B08")]
    public static int CalcCombatPower(Accessory accessory) => new int();

    [Token(Token = "0x6014425")]
    [Address(RVA = "0x20625F0", Offset = "0x20625F0", VA = "0x20625F0")]
    private static int CalcCombatPower(Accessory accessory, AccessoryStandardStatus status)
    {
      return new int();
    }

    [Token(Token = "0x6014426")]
    [Address(RVA = "0x2062A1C", Offset = "0x2062A1C", VA = "0x2062A1C")]
    public void SetToaster(string txt)
    {
    }

    [Token(Token = "0x6014427")]
    [Address(RVA = "0x2062B28", Offset = "0x2062B28", VA = "0x2062B28")]
    private void OpenOptionEffect()
    {
    }

    [Token(Token = "0x6014428")]
    [Address(RVA = "0x2062C40", Offset = "0x2062C40", VA = "0x2062C40")]
    private void OpenSkillMenu()
    {
    }

    [Token(Token = "0x6014429")]
    [Address(RVA = "0x2062E20", Offset = "0x2062E20", VA = "0x2062E20")]
    private void AddedStatusWindow()
    {
    }

    [Token(Token = "0x601442A")]
    [Address(RVA = "0x2062DBC", Offset = "0x2062DBC", VA = "0x2062DBC")]
    private void InitSkillSideWindow()
    {
    }

    [Token(Token = "0x601442B")]
    [Address(RVA = "0x2062E9C", Offset = "0x2062E9C", VA = "0x2062E9C")]
    private bool CanSkillEnhance() => new bool();

    [Token(Token = "0x601442C")]
    [Address(RVA = "0x2062F7C", Offset = "0x2062F7C", VA = "0x2062F7C")]
    private void Update()
    {
    }

    [Token(Token = "0x601442D")]
    [Address(RVA = "0x2062F98", Offset = "0x2062F98", VA = "0x2062F98")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x601442E")]
    [Address(RVA = "0x2062FB4", Offset = "0x2062FB4", VA = "0x2062FB4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601442F")]
    [Address(RVA = "0x2062FD0", Offset = "0x2062FD0", VA = "0x2062FD0")]
    public ShieldAccessoryDetailSubScene()
    {
    }

    [Token(Token = "0x200338C")]
    public enum eTimeLineMode
    {
      [Token(Token = "0x400DFB4")] ShieldAccessoryDetail,
      [Token(Token = "0x400DFB5")] ShieldAccessoryLimitBreak,
      [Token(Token = "0x400DFB6")] ShieldAccessoryLvup,
      [Token(Token = "0x400DFB7")] ShieldAccessoryOpitonEff,
      [Token(Token = "0x400DFB8")] ShieldAccessorySkill,
      [Token(Token = "0x400DFB9")] ShieldAccessoryLvupSkill,
    }

    [Token(Token = "0x200338D")]
    public class Param : ChangeSceneParameter
    {
      [Token(Token = "0x400DFBE")]
      [FieldOffset(Offset = "0x30")]
      public Action onInitializeAction;
      [Token(Token = "0x400DFBF")]
      [FieldOffset(Offset = "0x38")]
      public SafeObjectCallback onDestroyAction;
      [Token(Token = "0x400DFC1")]
      [FieldOffset(Offset = "0x48")]
      public Action<int> OnBackScene;

      [Token(Token = "0x17004397")]
      public ShieldAccessoryDetailSubScene.eTimeLineMode TimeLineMode
      {
        [Token(Token = "0x6014436"), Address(RVA = "0x20634D0", Offset = "0x20634D0", VA = "0x20634D0")] get
        {
          return new ShieldAccessoryDetailSubScene.eTimeLineMode();
        }
        [Token(Token = "0x6014437"), Address(RVA = "0x20634D8", Offset = "0x20634D8", VA = "0x20634D8")] protected set
        {
        }
      }

      [Token(Token = "0x17004398")]
      public int ShieldAccessoryDataIndex
      {
        [Token(Token = "0x6014438"), Address(RVA = "0x20634E0", Offset = "0x20634E0", VA = "0x20634E0")] get
        {
          return new int();
        }
        [Token(Token = "0x6014439"), Address(RVA = "0x20634E8", Offset = "0x20634E8", VA = "0x20634E8")] protected set
        {
        }
      }

      [Token(Token = "0x17004399")]
      public List<Accessory> ShieldAccessoryDataList
      {
        [Token(Token = "0x601443A"), Address(RVA = "0x20634F0", Offset = "0x20634F0", VA = "0x20634F0")] get
        {
          return (List<Accessory>) null;
        }
        [Token(Token = "0x601443B"), Address(RVA = "0x20634F8", Offset = "0x20634F8", VA = "0x20634F8")] protected set
        {
        }
      }

      [Token(Token = "0x1700439A")]
      public bool EnhanceMenuOn
      {
        [Token(Token = "0x601443C"), Address(RVA = "0x2063500", Offset = "0x2063500", VA = "0x2063500")] get
        {
          return new bool();
        }
        [Token(Token = "0x601443D"), Address(RVA = "0x2063508", Offset = "0x2063508", VA = "0x2063508")] protected set
        {
        }
      }

      [Token(Token = "0x1700439B")]
      public PlayerAccessoriesOptionChangePending OptionPending
      {
        [Token(Token = "0x601443E"), Address(RVA = "0x2063514", Offset = "0x2063514", VA = "0x2063514")] get
        {
          return (PlayerAccessoriesOptionChangePending) null;
        }
        [Token(Token = "0x601443F"), Address(RVA = "0x206351C", Offset = "0x206351C", VA = "0x206351C")] protected set
        {
        }
      }

      [Token(Token = "0x6014440")]
      [Address(RVA = "0x2060D54", Offset = "0x2060D54", VA = "0x2060D54")]
      public Param(
        ShieldAccessoryDetailSubScene.eTimeLineMode timeLineMode,
        int index,
        List<Accessory> ShieldAccessoryList,
        bool enhanceMenuOn = false,
        Action onInitializeAction = null,
        SafeObjectCallback onDestroyAction = null,
        PlayerAccessoriesOptionChangePending optionPending = null)
      {
      }
    }
  }
}
