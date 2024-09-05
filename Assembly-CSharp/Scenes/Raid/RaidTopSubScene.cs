// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.RaidTopSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Scene;
using GlobalMenu;
using Il2CppDummyDll;
using Network;
using Network.API;
using Scenes.Guild.Chat;
using Scenes.OutGame.LimitedEventQuest;
using Scenes.OutGame.OutGameMenu.ShopDetail;
using Scenes.Raid.Popup;
using System;
using System.Collections;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029D5")]
  public class RaidTopSubScene : SubScene
  {
    [Token(Token = "0x400B252")]
    [FieldOffset(Offset = "0x58")]
    private RaidTopSubScene.RaidTopSubSceneParam param;
    [Token(Token = "0x400B253")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400B254")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B255")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400B256")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private PlayerData playerDataHeader;
    [Token(Token = "0x400B257")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400B258")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton helpButton;
    [Token(Token = "0x400B259")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton lapRewardButton;
    [Token(Token = "0x400B25A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton guildChatButton;
    [Token(Token = "0x400B25B")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject guildChatBadge;
    [Token(Token = "0x400B25C")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RaidUpdateButton updateButton;
    [Token(Token = "0x400B25D")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private StaminaItemPopUpButton staminaItemPopUpButton;
    [Token(Token = "0x400B25E")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private RaidTopView topView;
    [Token(Token = "0x400B25F")]
    [FieldOffset(Offset = "0xC0")]
    private APIGuildRaidTopResponse response;
    [Token(Token = "0x400B260")]
    [FieldOffset(Offset = "0xC8")]
    private bool isError;
    [Token(Token = "0x400B261")]
    [FieldOffset(Offset = "0xC9")]
    private bool isHeld;
    [Token(Token = "0x400B262")]
    [FieldOffset(Offset = "0xD0")]
    private GuildChatPopup chatPopup;
    [Token(Token = "0x400B263")]
    [FieldOffset(Offset = "0xD8")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400B264")]
    [FieldOffset(Offset = "0xE0")]
    private PopupBase itemDetailPopup;
    [Token(Token = "0x400B265")]
    [FieldOffset(Offset = "0xE8")]
    private ShopItemDetailPopup otherItemDetailPopup;
    [Token(Token = "0x400B266")]
    [FieldOffset(Offset = "0xF0")]
    private GuildRaidLapClearPopup lapClearPopup;

    [Token(Token = "0x60106B3")]
    [Address(RVA = "0x488C04C", Offset = "0x488C04C", VA = "0x488C04C")]
    private void Update()
    {
    }

    [Token(Token = "0x60106B4")]
    [Address(RVA = "0x488C068", Offset = "0x488C068", VA = "0x488C068", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter = null)
    {
    }

    [Token(Token = "0x60106B5")]
    [Address(RVA = "0x488C8AC", Offset = "0x488C8AC", VA = "0x488C8AC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60106B6")]
    [Address(RVA = "0x488C93C", Offset = "0x488C93C", VA = "0x488C93C", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60106B7")]
    [Address(RVA = "0x488C9CC", Offset = "0x488C9CC", VA = "0x488C9CC", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60106B8")]
    [Address(RVA = "0x488CD70", Offset = "0x488CD70", VA = "0x488CD70")]
    private IEnumerator UpdateView() => (IEnumerator) null;

    [Token(Token = "0x60106B9")]
    [Address(RVA = "0x488C88C", Offset = "0x488C88C", VA = "0x488C88C")]
    private void SetCanvasInteractable(bool state)
    {
    }

    [Token(Token = "0x60106BA")]
    [Address(RVA = "0x488CB9C", Offset = "0x488CB9C", VA = "0x488CB9C")]
    private void OnClickBack()
    {
    }

    [Token(Token = "0x60106BB")]
    [Address(RVA = "0x488CE80", Offset = "0x488CE80", VA = "0x488CE80")]
    private void OnClickHelp()
    {
    }

    [Token(Token = "0x60106BC")]
    [Address(RVA = "0x488CF68", Offset = "0x488CF68", VA = "0x488CF68")]
    private void OnClickLapReward()
    {
    }

    [Token(Token = "0x60106BD")]
    [Address(RVA = "0x488D130", Offset = "0x488D130", VA = "0x488D130")]
    private IEnumerator ValidateLapClear() => (IEnumerator) null;

    [Token(Token = "0x60106BE")]
    [Address(RVA = "0x488D1C0", Offset = "0x488D1C0", VA = "0x488D1C0")]
    private IEnumerator OnClickChat() => (IEnumerator) null;

    [Token(Token = "0x60106BF")]
    [Address(RVA = "0x488D250", Offset = "0x488D250", VA = "0x488D250")]
    private IEnumerator OnClickUpdate() => (IEnumerator) null;

    [Token(Token = "0x60106C0")]
    [Address(RVA = "0x488D2E0", Offset = "0x488D2E0", VA = "0x488D2E0")]
    private void OnClickRewardItem(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60106C1")]
    [Address(RVA = "0x488D574", Offset = "0x488D574", VA = "0x488D574")]
    private void OpenSingleItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60106C2")]
    [Address(RVA = "0x488D3FC", Offset = "0x488D3FC", VA = "0x488D3FC")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60106C3")]
    [Address(RVA = "0x488CE00", Offset = "0x488CE00", VA = "0x488CE00")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60106C4")]
    [Address(RVA = "0x488D5CC", Offset = "0x488D5CC", VA = "0x488D5CC")]
    private IEnumerator ConnectRaidTop() => (IEnumerator) null;

    [Token(Token = "0x60106C5")]
    [Address(RVA = "0x488D65C", Offset = "0x488D65C", VA = "0x488D65C")]
    private IEnumerator OnError(NetworkErrorResult result) => (IEnumerator) null;

    [Token(Token = "0x60106C6")]
    [Address(RVA = "0x488D6EC", Offset = "0x488D6EC", VA = "0x488D6EC")]
    private void OnClickBossThumb(int positionId, bool isAlive)
    {
    }

    [Token(Token = "0x60106C7")]
    [Address(RVA = "0x488D824", Offset = "0x488D824", VA = "0x488D824")]
    private void PlayBGM()
    {
    }

    [Token(Token = "0x60106C8")]
    [Address(RVA = "0x488DA40", Offset = "0x488DA40", VA = "0x488DA40")]
    public RaidTopSubScene()
    {
    }

    [Token(Token = "0x20029D6")]
    public class RaidTopSubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400B267")]
      [FieldOffset(Offset = "0x14")]
      public int RaidId;

      [Token(Token = "0x60106DA")]
      [Address(RVA = "0x4888918", Offset = "0x4888918", VA = "0x4888918")]
      public RaidTopSubSceneParam(int raidId)
      {
      }
    }
  }
}
