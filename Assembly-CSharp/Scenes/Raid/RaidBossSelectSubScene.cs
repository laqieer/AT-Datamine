// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.RaidBossSelectSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Scene;
using GlobalMenu;
using Il2CppDummyDll;
using Network;
using Network.Param;
using Scenes.OutGame.OutGameMenu.ShopDetail;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029BF")]
  public class RaidBossSelectSubScene : SubScene
  {
    [Token(Token = "0x400B1D7")]
    [FieldOffset(Offset = "0x58")]
    private RaidBossSelectSubScene.RaidBossSelectSubSceneParam param;
    [Token(Token = "0x400B1D8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400B1D9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B1DA")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400B1DB")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Image bossImage;
    [Token(Token = "0x400B1DC")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PlayerData playerDataHeader;
    [Token(Token = "0x400B1DD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RaidDamageRanking damageRanking;
    [Token(Token = "0x400B1DE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TrialMemberView trialMember;
    [Token(Token = "0x400B1DF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BossStatusView rightStatus;
    [Token(Token = "0x400B1E0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BossStatusView centerStatus;
    [Token(Token = "0x400B1E1")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI damageText;
    [Token(Token = "0x400B1E2")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private RewardView reward;
    [Token(Token = "0x400B1E3")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject[] epBaseIcon;
    [Token(Token = "0x400B1E4")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject[] epIcon;
    [Token(Token = "0x400B1E5")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject mockDisableObj;
    [Token(Token = "0x400B1E6")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject battleDisableObj;
    [Token(Token = "0x400B1E7")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400B1E8")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton nextFullScreenButton;
    [Token(Token = "0x400B1E9")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton nextButton;
    [Token(Token = "0x400B1EA")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CommonButton skipButton;
    [Token(Token = "0x400B1EB")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private CommonButton comfirmRewardButton;
    [Token(Token = "0x400B1EC")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private CommonButton mockBattleButton;
    [Token(Token = "0x400B1ED")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private CommonButton battleButton;
    [Token(Token = "0x400B1EE")]
    [FieldOffset(Offset = "0x110")]
    private LapChoicePopup lapPopup;
    [Token(Token = "0x400B1EF")]
    [FieldOffset(Offset = "0x118")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400B1F0")]
    [FieldOffset(Offset = "0x120")]
    private PopupBase itemDetailPopup;
    [Token(Token = "0x400B1F1")]
    [FieldOffset(Offset = "0x128")]
    private ShopItemDetailPopup otherItemDetailPopup;
    [Token(Token = "0x400B1F2")]
    [FieldOffset(Offset = "0x130")]
    private bool isHeld;
    [Token(Token = "0x400B1F3")]
    [FieldOffset(Offset = "0x131")]
    private bool canSkip;
    [Token(Token = "0x400B1F4")]
    [FieldOffset(Offset = "0x132")]
    private bool isError;
    [Token(Token = "0x400B1F5")]
    [FieldOffset(Offset = "0x133")]
    private bool webConnecting;

    [Token(Token = "0x1700392C")]
    public static string SceneName
    {
      [Token(Token = "0x6010633"), Address(RVA = "0x4886518", Offset = "0x4886518", VA = "0x4886518")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700392D")]
    public static string AssetBundleName
    {
      [Token(Token = "0x6010634"), Address(RVA = "0x4886558", Offset = "0x4886558", VA = "0x4886558")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700392E")]
    public static string AssetName
    {
      [Token(Token = "0x6010635"), Address(RVA = "0x4886598", Offset = "0x4886598", VA = "0x4886598")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6010636")]
    [Address(RVA = "0x48865D8", Offset = "0x48865D8", VA = "0x48865D8")]
    private void Update()
    {
    }

    [Token(Token = "0x6010637")]
    [Address(RVA = "0x48865F4", Offset = "0x48865F4", VA = "0x48865F4", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter = null)
    {
    }

    [Token(Token = "0x6010638")]
    [Address(RVA = "0x4886B6C", Offset = "0x4886B6C", VA = "0x4886B6C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010639")]
    [Address(RVA = "0x4886BFC", Offset = "0x4886BFC", VA = "0x4886BFC", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x601063A")]
    [Address(RVA = "0x4886C8C", Offset = "0x4886C8C", VA = "0x4886C8C", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x601063B")]
    [Address(RVA = "0x4887004", Offset = "0x4887004", VA = "0x4887004")]
    private void SetCanvasInteractable(bool state)
    {
    }

    [Token(Token = "0x601063C")]
    [Address(RVA = "0x4886ADC", Offset = "0x4886ADC", VA = "0x4886ADC")]
    private void SetMockButtonInteractable(bool value)
    {
    }

    [Token(Token = "0x601063D")]
    [Address(RVA = "0x4886B24", Offset = "0x4886B24", VA = "0x4886B24")]
    private void SetBattleButtonInteractable(bool value)
    {
    }

    [Token(Token = "0x601063E")]
    [Address(RVA = "0x4886E6C", Offset = "0x4886E6C", VA = "0x4886E6C")]
    private void OnClickBack()
    {
    }

    [Token(Token = "0x601063F")]
    [Address(RVA = "0x48870A4", Offset = "0x48870A4", VA = "0x48870A4")]
    private void OnClickSkip()
    {
    }

    [Token(Token = "0x6010640")]
    [Address(RVA = "0x4887110", Offset = "0x4887110", VA = "0x4887110")]
    private void OnClickConfirmReward()
    {
    }

    [Token(Token = "0x6010641")]
    [Address(RVA = "0x48873D8", Offset = "0x48873D8", VA = "0x48873D8")]
    private void OnClickBattle()
    {
    }

    [Token(Token = "0x6010642")]
    [Address(RVA = "0x4887754", Offset = "0x4887754", VA = "0x4887754")]
    private IEnumerator OnClickMock() => (IEnumerator) null;

    [Token(Token = "0x6010643")]
    [Address(RVA = "0x4887574", Offset = "0x4887574", VA = "0x4887574")]
    private void ChangeQuestPrepareSubScene(bool isMock = false, int mockLap = 0)
    {
    }

    [Token(Token = "0x6010644")]
    [Address(RVA = "0x48877EC", Offset = "0x48877EC", VA = "0x48877EC")]
    private void OnClickRewardItem(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010645")]
    [Address(RVA = "0x4887A80", Offset = "0x4887A80", VA = "0x4887A80")]
    private void OpenSingleItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010646")]
    [Address(RVA = "0x4887908", Offset = "0x4887908", VA = "0x4887908")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010647")]
    [Address(RVA = "0x4887AB0", Offset = "0x4887AB0", VA = "0x4887AB0")]
    private IEnumerator LoadBossImage(int styleId) => (IEnumerator) null;

    [Token(Token = "0x6010648")]
    [Address(RVA = "0x4887B50", Offset = "0x4887B50", VA = "0x4887B50")]
    private void SetSelectView()
    {
    }

    [Token(Token = "0x6010649")]
    [Address(RVA = "0x4888024", Offset = "0x4888024", VA = "0x4888024")]
    private void SetResultView()
    {
    }

    [Token(Token = "0x601064A")]
    [Address(RVA = "0x488810C", Offset = "0x488810C", VA = "0x488810C")]
    private void SetDefeatedView()
    {
    }

    [Token(Token = "0x601064B")]
    [Address(RVA = "0x4887024", Offset = "0x4887024", VA = "0x4887024")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601064C")]
    [Address(RVA = "0x48883B4", Offset = "0x48883B4", VA = "0x48883B4")]
    private IEnumerator ConnectRaidBossDetail() => (IEnumerator) null;

    [Token(Token = "0x601064D")]
    [Address(RVA = "0x4888444", Offset = "0x4888444", VA = "0x4888444")]
    private IEnumerator ConnectRaidBattleEnd() => (IEnumerator) null;

    [Token(Token = "0x601064E")]
    [Address(RVA = "0x4886A20", Offset = "0x4886A20", VA = "0x4886A20")]
    private void LoadParam()
    {
    }

    [Token(Token = "0x601064F")]
    [Address(RVA = "0x48884D4", Offset = "0x48884D4", VA = "0x48884D4")]
    private IEnumerator OnError(NetworkErrorResult result) => (IEnumerator) null;

    [Token(Token = "0x6010650")]
    [Address(RVA = "0x4887C04", Offset = "0x4887C04", VA = "0x4887C04")]
    private void DisableTapNextButton()
    {
    }

    [Token(Token = "0x6010651")]
    [Address(RVA = "0x4888564", Offset = "0x4888564", VA = "0x4888564")]
    private void PlayBGM()
    {
    }

    [Token(Token = "0x6010652")]
    [Address(RVA = "0x4888780", Offset = "0x4888780", VA = "0x4888780")]
    public RaidBossSelectSubScene()
    {
    }

    [Token(Token = "0x20029C0")]
    public enum BossSelectContentType
    {
      [Token(Token = "0x400B1F7")] Select,
      [Token(Token = "0x400B1F8")] Result,
      [Token(Token = "0x400B1F9")] Defeated,
    }

    [Token(Token = "0x20029C1")]
    public class RaidBossSelectSubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400B1FA")]
      [FieldOffset(Offset = "0x18")]
      public GuildRaidPositionDetailType PositionDetailType;
      [Token(Token = "0x400B1FB")]
      [FieldOffset(Offset = "0x20")]
      public List<GuildMemberType> MemberTypes;
      [Token(Token = "0x400B1FC")]
      [FieldOffset(Offset = "0x28")]
      public List<string> UsedStyleIds;
      [Token(Token = "0x400B1FD")]
      [FieldOffset(Offset = "0x30")]
      public RaidBossSelectSubScene.BossSelectContentType ContentType;
      [Token(Token = "0x400B1FE")]
      [FieldOffset(Offset = "0x34")]
      public int RaidId;
      [Token(Token = "0x400B1FF")]
      [FieldOffset(Offset = "0x38")]
      public int Lap;
      [Token(Token = "0x400B200")]
      [FieldOffset(Offset = "0x3C")]
      public int Position;
      [Token(Token = "0x400B201")]
      [FieldOffset(Offset = "0x40")]
      public string BattleUuid;
      [Token(Token = "0x400B202")]
      [FieldOffset(Offset = "0x48")]
      public BoardData Board;
      [Token(Token = "0x400B203")]
      [FieldOffset(Offset = "0x50")]
      public IReadOnlyList<IUnitPlacementData> EnemyPlacements;
      [Token(Token = "0x400B204")]
      [FieldOffset(Offset = "0x58")]
      public int Damage;
      [Token(Token = "0x400B205")]
      [FieldOffset(Offset = "0x5C")]
      public int Score;
      [Token(Token = "0x400B206")]
      [FieldOffset(Offset = "0x60")]
      public bool IsMock;
      [Token(Token = "0x400B207")]
      [FieldOffset(Offset = "0x61")]
      public bool IsRetreat;

      [Token(Token = "0x6010659")]
      [Address(RVA = "0x488897C", Offset = "0x488897C", VA = "0x488897C")]
      public RaidBossSelectSubSceneParam()
      {
      }
    }
  }
}
