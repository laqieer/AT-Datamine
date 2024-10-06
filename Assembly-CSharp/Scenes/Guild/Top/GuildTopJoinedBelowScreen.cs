// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Top.GuildTopJoinedBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.Guild.Data;
using Scenes.Guild.Info;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Top
{
  [Token(Token = "0x2002B99")]
  public class GuildTopJoinedBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400B9A7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildTopBulletinBoard bulletinBoard;
    [Token(Token = "0x400B9A8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GuildTopGuildChat guildTopChatLog;
    [Token(Token = "0x400B9A9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GuildInfoDisplay guildInfoDisplay;
    [Token(Token = "0x400B9AA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject guildMenuBadgeObj;
    [Token(Token = "0x400B9AB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject guildFacilityBadgeObj;
    [Token(Token = "0x400B9AC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GuildTopTabToggle[] tagToggles;
    [Token(Token = "0x400B9AD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GuildRaidButton raidButton;
    [Token(Token = "0x400B9AE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private int medalShopId;
    [Token(Token = "0x400B9AF")]
    private const string attendRewardText = "Popup_Text_GuildAttendanceStatus_GetAttendanceReward";
    [Token(Token = "0x400B9B0")]
    [FieldOffset(Offset = "0x74")]
    private GuildTopJoinedBelowScreen.TabToggle activeTab;
    [Token(Token = "0x400B9B1")]
    [FieldOffset(Offset = "0x78")]
    private bool isFarstUpdateLog;
    [Token(Token = "0x400B9B2")]
    [FieldOffset(Offset = "0x80")]
    private string errorMessage;
    [Token(Token = "0x400B9B3")]
    [FieldOffset(Offset = "0x88")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400B9B4")]
    [FieldOffset(Offset = "0x90")]
    private ItemDetailPopupProvider provider;
    [Token(Token = "0x400B9B5")]
    [FieldOffset(Offset = "0x98")]
    private List<DisplayItemRewardInfoData> attendRewards;

    [Token(Token = "0x17003ACA")]
    private GuildDataManager guildDataManager
    {
      [Token(Token = "0x601107A"), Address(RVA = "0x1C77EC8", Offset = "0x1C77EC8", VA = "0x1C77EC8")] get
      {
        return (GuildDataManager) null;
      }
    }

    [Token(Token = "0x601107B")]
    [Address(RVA = "0x1C77F18", Offset = "0x1C77F18", VA = "0x1C77F18", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x601107C")]
    [Address(RVA = "0x1C77FE0", Offset = "0x1C77FE0", VA = "0x1C77FE0", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601107D")]
    [Address(RVA = "0x1C78070", Offset = "0x1C78070", VA = "0x1C78070")]
    private IEnumerator InitializeChatLog() => (IEnumerator) null;

    [Token(Token = "0x601107E")]
    [Address(RVA = "0x1C78100", Offset = "0x1C78100", VA = "0x1C78100", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x601107F")]
    [Address(RVA = "0x1C78380", Offset = "0x1C78380", VA = "0x1C78380", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011080")]
    [Address(RVA = "0x1C783B0", Offset = "0x1C783B0", VA = "0x1C783B0", Slot = "9")]
    public override IEnumerator CloseSync() => (IEnumerator) null;

    [Token(Token = "0x6011081")]
    [Address(RVA = "0x1C78440", Offset = "0x1C78440", VA = "0x1C78440", Slot = "10")]
    public override IEnumerator ReOpenUpdate(GuildBelowScreenParam param) => (IEnumerator) null;

    [Token(Token = "0x6011082")]
    [Address(RVA = "0x1C784D0", Offset = "0x1C784D0", VA = "0x1C784D0")]
    public IEnumerator OnRequestGuildTop() => (IEnumerator) null;

    [Token(Token = "0x6011083")]
    [Address(RVA = "0x1C78560", Offset = "0x1C78560", VA = "0x1C78560")]
    public void OnChangeTab(int tab)
    {
    }

    [Token(Token = "0x6011084")]
    [Address(RVA = "0x1C78644", Offset = "0x1C78644", VA = "0x1C78644")]
    private void OnRespanseUpdateLog(APIGuildChatLogResponse res)
    {
    }

    [Token(Token = "0x6011085")]
    [Address(RVA = "0x1C78868", Offset = "0x1C78868", VA = "0x1C78868")]
    private IEnumerator RequestBulletinBoard() => (IEnumerator) null;

    [Token(Token = "0x6011086")]
    [Address(RVA = "0x1C788F8", Offset = "0x1C788F8", VA = "0x1C788F8")]
    public void OnMemberDetailClicked(GuildMemberType memberType)
    {
    }

    [Token(Token = "0x6011087")]
    [Address(RVA = "0x1C789D4", Offset = "0x1C789D4", VA = "0x1C789D4")]
    public void OnClickGuildMembers()
    {
    }

    [Token(Token = "0x6011088")]
    [Address(RVA = "0x1C78A04", Offset = "0x1C78A04", VA = "0x1C78A04")]
    public void OnClickGuildMenu()
    {
    }

    [Token(Token = "0x6011089")]
    [Address(RVA = "0x1C78AA8", Offset = "0x1C78AA8", VA = "0x1C78AA8")]
    public void OnClickAttendInfo()
    {
    }

    [Token(Token = "0x601108A")]
    [Address(RVA = "0x1C78B4C", Offset = "0x1C78B4C", VA = "0x1C78B4C")]
    public void OnClickAttendReward()
    {
    }

    [Token(Token = "0x601108B")]
    [Address(RVA = "0x1C78BF0", Offset = "0x1C78BF0", VA = "0x1C78BF0")]
    public void OnClickMedalShop()
    {
    }

    [Token(Token = "0x601108C")]
    [Address(RVA = "0x1C78CF0", Offset = "0x1C78CF0", VA = "0x1C78CF0")]
    public void OnClickGuildFacility()
    {
    }

    [Token(Token = "0x601108D")]
    [Address(RVA = "0x1C78D18", Offset = "0x1C78D18", VA = "0x1C78D18")]
    public void OnClickGuildChat()
    {
    }

    [Token(Token = "0x601108E")]
    [Address(RVA = "0x1C78D94", Offset = "0x1C78D94", VA = "0x1C78D94")]
    public void OnClickGuildRaid(int raidId)
    {
    }

    [Token(Token = "0x601108F")]
    [Address(RVA = "0x1C78E94", Offset = "0x1C78E94", VA = "0x1C78E94")]
    private IEnumerator RequestGuildIndex() => (IEnumerator) null;

    [Token(Token = "0x6011090")]
    [Address(RVA = "0x1C78F24", Offset = "0x1C78F24", VA = "0x1C78F24")]
    private IEnumerator RequestGuildAttend() => (IEnumerator) null;

    [Token(Token = "0x6011091")]
    [Address(RVA = "0x1C78FB4", Offset = "0x1C78FB4", VA = "0x1C78FB4")]
    private IEnumerator ShowAttendReward(List<DisplayItemRewardInfoData> rewards)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011092")]
    [Address(RVA = "0x1C781A4", Offset = "0x1C781A4", VA = "0x1C781A4")]
    private void SetActiveBadges()
    {
    }

    [Token(Token = "0x6011093")]
    [Address(RVA = "0x1C79044", Offset = "0x1C79044", VA = "0x1C79044")]
    public GuildTopJoinedBelowScreen()
    {
    }

    [Token(Token = "0x2002B9A")]
    public enum TabToggle
    {
      [Token(Token = "0x400B9B7")] Tab_chat,
      [Token(Token = "0x400B9B8")] Tab_notice,
    }
  }
}
