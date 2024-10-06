// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.TrustDetailSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A4E")]
  public class TrustDetailSubScene : SubScene
  {
    [Token(Token = "0x400FF77")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FF78")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400FF79")]
    private const string trustDetailTimeLineAssetbundleName = "ui_page_trustdetail_timeline";
    [Token(Token = "0x400FF7A")]
    [FieldOffset(Offset = "0x68")]
    private readonly string[] timeLineSettingNameList;
    [Token(Token = "0x400FF7B")]
    [FieldOffset(Offset = "0x70")]
    private bool isTimelineDirection;
    [Token(Token = "0x400FF7C")]
    [FieldOffset(Offset = "0x74")]
    private TrustDetailSubScene.eTrustDetailMode nowTrustDetailMode;
    [Token(Token = "0x400FF7D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CanvasGroup statusWindow;
    [Token(Token = "0x400FF7E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Image imgTrust;
    [Token(Token = "0x400FF7F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text txtTrustName;
    [Token(Token = "0x400FF80")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RarityIcon imgTrustRarity;
    [Token(Token = "0x400FF81")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text txtTrustCombatPower;
    [Token(Token = "0x400FF82")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text[] txtTrustStatus;
    [Token(Token = "0x400FF83")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private DetailSkillListThumb detailSkillList;
    [Token(Token = "0x400FF84")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Button statusButton;
    [Token(Token = "0x400FF85")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Button skillButton;
    [Token(Token = "0x400FF86")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Button AdditionalStatusButton;
    [Token(Token = "0x400FF87")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private HomeButtonAnimationController homeButtonAnimationController;
    [Token(Token = "0x400FF88")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Button returnButton;
    [Token(Token = "0x400FF89")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Button prevStyleButton;
    [Token(Token = "0x400FF8A")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Button nextStyleButton;
    [Token(Token = "0x400FF8B")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400FF8C")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private ContainerSkillSideWindow containerSkillSideWindow;
    [Token(Token = "0x400FF8D")]
    [FieldOffset(Offset = "0xF8")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400FF8E")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private UITweenGroup toasterTween;
    [Token(Token = "0x400FF8F")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Text toasterText;
    [Token(Token = "0x400FF90")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private GameObject noReactionBoard;
    [Token(Token = "0x400FF91")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400FF92")]
    [FieldOffset(Offset = "0x120")]
    private TrustDetailSubScene.Param sceneParam;
    [Token(Token = "0x400FF93")]
    [FieldOffset(Offset = "0x128")]
    private UnitTrust trustData;
    [Token(Token = "0x400FF94")]
    [FieldOffset(Offset = "0x130")]
    private TrustData trustMasterData;
    [Token(Token = "0x400FF95")]
    [FieldOffset(Offset = "0x138")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400FF96")]
    [FieldOffset(Offset = "0x140")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17004B24")]
    public PlayableDirector TimeLinePlayableDirector
    {
      [Token(Token = "0x6016EA0"), Address(RVA = "0x29BCAAC", Offset = "0x29BCAAC", VA = "0x29BCAAC")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x6016EA1")]
    [Address(RVA = "0x29BCAB4", Offset = "0x29BCAB4", VA = "0x29BCAB4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016EA2")]
    [Address(RVA = "0x29BCAD4", Offset = "0x29BCAD4", VA = "0x29BCAD4", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6016EA3")]
    [Address(RVA = "0x29BCBEC", Offset = "0x29BCBEC", VA = "0x29BCBEC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016EA4")]
    [Address(RVA = "0x29BCC7C", Offset = "0x29BCC7C", VA = "0x29BCC7C")]
    private IEnumerator directInWait() => (IEnumerator) null;

    [Token(Token = "0x6016EA5")]
    [Address(RVA = "0x29BCD0C", Offset = "0x29BCD0C", VA = "0x29BCD0C", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016EA6")]
    [Address(RVA = "0x29BCD10", Offset = "0x29BCD10", VA = "0x29BCD10")]
    private void SetThumbnail(int trustId)
    {
    }

    [Token(Token = "0x6016EA7")]
    [Address(RVA = "0x29BCE14", Offset = "0x29BCE14", VA = "0x29BCE14")]
    private IEnumerator playTimeline(
      TrustDetailSubScene.eTrustDetailMode mode,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016EA8")]
    [Address(RVA = "0x29BCEC8", Offset = "0x29BCEC8", VA = "0x29BCEC8")]
    public void SetOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6016EA9")]
    [Address(RVA = "0x29BD0F4", Offset = "0x29BD0F4", VA = "0x29BD0F4")]
    private void SetStatus(UnitTrust trustData)
    {
    }

    [Token(Token = "0x6016EAA")]
    [Address(RVA = "0x29BD628", Offset = "0x29BD628", VA = "0x29BD628")]
    public static int CalcCombatPower(UnitTrust trustData) => new int();

    [Token(Token = "0x6016EAB")]
    [Address(RVA = "0x29BD648", Offset = "0x29BD648", VA = "0x29BD648")]
    private void SetSkillStatus(int skillID, UnitTrustSkill skillData)
    {
    }

    [Token(Token = "0x6016EAC")]
    [Address(RVA = "0x29BDB00", Offset = "0x29BDB00", VA = "0x29BDB00")]
    private void SetSkillSideWindow(UnitTrust trust)
    {
    }

    [Token(Token = "0x6016EAD")]
    [Address(RVA = "0x29BD028", Offset = "0x29BD028", VA = "0x29BD028")]
    private void UpdatePrevNextButtonState()
    {
    }

    [Token(Token = "0x6016EAE")]
    [Address(RVA = "0x29BDB34", Offset = "0x29BDB34", VA = "0x29BDB34")]
    private void OnBackButton()
    {
    }

    [Token(Token = "0x6016EAF")]
    [Address(RVA = "0x29BDCC8", Offset = "0x29BDCC8", VA = "0x29BDCC8", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6016EB0")]
    [Address(RVA = "0x29BDE10", Offset = "0x29BDE10", VA = "0x29BDE10")]
    private IEnumerator ConnectAPIFavorite(bool flg, Action finish = null) => (IEnumerator) null;

    [Token(Token = "0x6016EB1")]
    [Address(RVA = "0x29BDEB8", Offset = "0x29BDEB8", VA = "0x29BDEB8")]
    private void AddedStatusWindow()
    {
    }

    [Token(Token = "0x6016EB2")]
    [Address(RVA = "0x29BDECC", Offset = "0x29BDECC", VA = "0x29BDECC")]
    private void Update()
    {
    }

    [Token(Token = "0x6016EB3")]
    [Address(RVA = "0x29BDEE8", Offset = "0x29BDEE8", VA = "0x29BDEE8")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6016EB4")]
    [Address(RVA = "0x29BDF04", Offset = "0x29BDF04", VA = "0x29BDF04")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6016EB5")]
    [Address(RVA = "0x29BDF20", Offset = "0x29BDF20", VA = "0x29BDF20")]
    public TrustDetailSubScene()
    {
    }

    [Token(Token = "0x2003A4F")]
    public enum eTrustDetailMode
    {
      [Token(Token = "0x400FF98")] TrustDetail,
      [Token(Token = "0x400FF99")] SkillSideWindow,
      [Token(Token = "0x400FF9A")] SkillLvUp,
      [Token(Token = "0x400FF9B")] MODEMAX,
    }

    [Token(Token = "0x2003A50")]
    public class Param : ChangeSceneParameter
    {
      [Token(Token = "0x400FF9C")]
      [FieldOffset(Offset = "0x14")]
      public TrustDetailSubScene.eTrustDetailMode StartMode;
      [Token(Token = "0x400FF9E")]
      [FieldOffset(Offset = "0x20")]
      public int listIndex;
      [Token(Token = "0x400FF9F")]
      [FieldOffset(Offset = "0x28")]
      public Action<int> OnBackScene;

      [Token(Token = "0x17004B25")]
      public List<UnitTrust> trustIDList
      {
        [Token(Token = "0x6016EC6"), Address(RVA = "0x29BE740", Offset = "0x29BE740", VA = "0x29BE740")] get
        {
          return (List<UnitTrust>) null;
        }
        [Token(Token = "0x6016EC7"), Address(RVA = "0x29BE748", Offset = "0x29BE748", VA = "0x29BE748")] set
        {
        }
      }

      [Token(Token = "0x6016EC8")]
      [Address(RVA = "0x29BE750", Offset = "0x29BE750", VA = "0x29BE750")]
      public Param(
        TrustDetailSubScene.eTrustDetailMode mode,
        int index,
        List<UnitTrust> trustIdList)
      {
      }
    }
  }
}
