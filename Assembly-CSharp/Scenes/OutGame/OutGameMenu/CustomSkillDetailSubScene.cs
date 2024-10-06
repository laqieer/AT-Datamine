// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CustomSkillDetailSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System;
using System.Collections;
using UI.Common;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039BC")]
  public class CustomSkillDetailSubScene : SubScene
  {
    [Token(Token = "0x400FC64")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400FC65")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private HomeButtonAnimationController homeButtonAnimationController;
    [Token(Token = "0x400FC66")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button returnButton;
    [Token(Token = "0x400FC67")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400FC68")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CustomSkillEnhanceController cunsomEnhanceController;
    [Token(Token = "0x400FC69")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CustomSkillIcon customSkillIcon;
    [Token(Token = "0x400FC6A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text skillName;
    [Token(Token = "0x400FC6B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400FC6C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ContainerSkillSideWindow containerSkillSideWindow;
    [Token(Token = "0x400FC6D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FC6E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400FC6F")]
    private const string inoutTimeLineAssetbundleName = "ui_page_customskill_timeline";
    [Token(Token = "0x400FC70")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CanvasGroup skillEnhanceWindow;
    [Token(Token = "0x400FC71")]
    [FieldOffset(Offset = "0xB8")]
    private readonly string[] timeLineSettingNameList;
    [Token(Token = "0x400FC72")]
    [FieldOffset(Offset = "0xC0")]
    private bool isTimelineDirection;
    [Token(Token = "0x400FC73")]
    [FieldOffset(Offset = "0xC4")]
    private CustomSkillDetailSubScene.eTimelineKind execState;
    [Token(Token = "0x400FC74")]
    [FieldOffset(Offset = "0xC8")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400FC75")]
    [FieldOffset(Offset = "0xD0")]
    private bool isConnecting;
    [Token(Token = "0x400FC76")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CanvasGroup canvasGroup_top;
    [Token(Token = "0x400FC77")]
    [FieldOffset(Offset = "0xE0")]
    private CustomSkill dispSkill;
    [Token(Token = "0x400FC78")]
    [FieldOffset(Offset = "0xE8")]
    private CustomSkillDetailSubScene.Param sceneParam;
    [Token(Token = "0x400FC79")]
    [FieldOffset(Offset = "0xF0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400FC7B")]
    [FieldOffset(Offset = "0x100")]
    private bool isCharaSkill;

    [Token(Token = "0x17004A9A")]
    public PlayableDirector TimeLinePlayableDirector
    {
      [Token(Token = "0x6016ACE"), Address(RVA = "0x3F64C54", Offset = "0x3F64C54", VA = "0x3F64C54")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x17004A9B")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x6016ACF"), Address(RVA = "0x3F64C5C", Offset = "0x3F64C5C", VA = "0x3F64C5C")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x6016AD0"), Address(RVA = "0x3F64C64", Offset = "0x3F64C64", VA = "0x3F64C64")] private set
      {
      }
    }

    [Token(Token = "0x6016AD1")]
    [Address(RVA = "0x3F64C6C", Offset = "0x3F64C6C", VA = "0x3F64C6C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016AD2")]
    [Address(RVA = "0x3F64CF4", Offset = "0x3F64CF4", VA = "0x3F64CF4", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6016AD3")]
    [Address(RVA = "0x3F650C8", Offset = "0x3F650C8", VA = "0x3F650C8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016AD4")]
    [Address(RVA = "0x3F65158", Offset = "0x3F65158", VA = "0x3F65158")]
    public void OnBackButton()
    {
    }

    [Token(Token = "0x6016AD5")]
    [Address(RVA = "0x3F652F0", Offset = "0x3F652F0", VA = "0x3F652F0", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6016AD6")]
    [Address(RVA = "0x3F65264", Offset = "0x3F65264", VA = "0x3F65264")]
    private IEnumerator playTimeline(
      CustomSkillDetailSubScene.eTimelineKind mode,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016AD7")]
    [Address(RVA = "0x3F65460", Offset = "0x3F65460", VA = "0x3F65460")]
    private void Update()
    {
    }

    [Token(Token = "0x6016AD8")]
    [Address(RVA = "0x3F6547C", Offset = "0x3F6547C", VA = "0x3F6547C")]
    private void OnChangeEnhance(int skillLevel, int skillEnergy)
    {
    }

    [Token(Token = "0x6016AD9")]
    [Address(RVA = "0x3F65530", Offset = "0x3F65530", VA = "0x3F65530")]
    private void OnClickLevelInfo()
    {
    }

    [Token(Token = "0x6016ADA")]
    [Address(RVA = "0x3F65548", Offset = "0x3F65548", VA = "0x3F65548")]
    protected IEnumerator ConnectFavoriteAPI() => (IEnumerator) null;

    [Token(Token = "0x6016ADB")]
    [Address(RVA = "0x3F655D8", Offset = "0x3F655D8", VA = "0x3F655D8")]
    public void SetToaster(string txt)
    {
    }

    [Token(Token = "0x6016ADC")]
    [Address(RVA = "0x3F654DC", Offset = "0x3F654DC", VA = "0x3F654DC")]
    private void InitSkillSideWindow()
    {
    }

    [Token(Token = "0x6016ADD")]
    [Address(RVA = "0x3F6565C", Offset = "0x3F6565C", VA = "0x3F6565C")]
    private bool CanSkillEnhance() => new bool();

    [Token(Token = "0x6016ADE")]
    [Address(RVA = "0x3F65718", Offset = "0x3F65718", VA = "0x3F65718")]
    private void OpenAbilityBoard(Style style)
    {
    }

    [Token(Token = "0x6016ADF")]
    [Address(RVA = "0x3F65A20", Offset = "0x3F65A20", VA = "0x3F65A20", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6016AE0")]
    [Address(RVA = "0x3F65B4C", Offset = "0x3F65B4C", VA = "0x3F65B4C")]
    public CustomSkillDetailSubScene()
    {
    }

    [Token(Token = "0x20039BD")]
    private enum eTimelineKind
    {
      [Token(Token = "0x400FC7D")] Detail,
      [Token(Token = "0x400FC7E")] Enhance,
    }

    [Token(Token = "0x20039BE")]
    public class Param : ChangeSceneParameter
    {
      [Token(Token = "0x400FC7F")]
      [FieldOffset(Offset = "0x18")]
      public CustomSkill StaqData;
      [Token(Token = "0x400FC80")]
      [FieldOffset(Offset = "0x20")]
      public string CustomSkillUniqueId;
      [Token(Token = "0x400FC81")]
      [FieldOffset(Offset = "0x28")]
      public int SkillId;
      [Token(Token = "0x400FC82")]
      [FieldOffset(Offset = "0x2C")]
      public RarityTypeEnum RarityType;
      [Token(Token = "0x400FC83")]
      [FieldOffset(Offset = "0x30")]
      public Action onBackAction;

      [Token(Token = "0x6016AE8")]
      [Address(RVA = "0x3F65FD8", Offset = "0x3F65FD8", VA = "0x3F65FD8")]
      public Param(
        int skillID,
        RarityTypeEnum rarityType,
        CustomSkill staqData,
        Action onBackAction)
      {
      }
    }
  }
}
