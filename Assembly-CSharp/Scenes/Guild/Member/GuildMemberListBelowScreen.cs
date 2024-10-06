// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Member.GuildMemberListBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.Param;
using Scenes.Guild.Data;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Member
{
  [Token(Token = "0x2002BCA")]
  public class GuildMemberListBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BA53")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400BA54")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GuildMemberListItem templateListItem;
    [Token(Token = "0x400BA55")]
    [FieldOffset(Offset = "0x48")]
    [Header("Member")]
    [SerializeField]
    private GameObject memberObj;
    [Token(Token = "0x400BA56")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI textGuildMember;
    [Token(Token = "0x400BA57")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI textGuildMemberMax;
    [Token(Token = "0x400BA58")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI textSubMaster;
    [Token(Token = "0x400BA59")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI textSubMasterMax;
    [Token(Token = "0x400BA5A")]
    [FieldOffset(Offset = "0x70")]
    [Header("Request")]
    [SerializeField]
    private GameObject requestObj;
    [Token(Token = "0x400BA5B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI textRequestMember;
    [Token(Token = "0x400BA5C")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI textRequestMemberMax;
    [Token(Token = "0x400BA5D")]
    [FieldOffset(Offset = "0x88")]
    private List<GuildMemberInfo> guildMemberList;
    [Token(Token = "0x400BA5E")]
    [FieldOffset(Offset = "0x90")]
    private List<GuildMemberListItem> listItem;
    [Token(Token = "0x400BA5F")]
    [FieldOffset(Offset = "0x98")]
    private bool isAscending;
    [Token(Token = "0x400BA60")]
    [FieldOffset(Offset = "0x99")]
    private bool isRequestDisplay;

    [Token(Token = "0x17003AFC")]
    private GuildDetailInfo guildDetailInfo
    {
      [Token(Token = "0x60111A7"), Address(RVA = "0x1C80418", Offset = "0x1C80418", VA = "0x1C80418")] get
      {
        return (GuildDetailInfo) null;
      }
    }

    [Token(Token = "0x60111A8")]
    [Address(RVA = "0x1C80470", Offset = "0x1C80470", VA = "0x1C80470", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x60111A9")]
    [Address(RVA = "0x1C80510", Offset = "0x1C80510", VA = "0x1C80510", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60111AA")]
    [Address(RVA = "0x1C805A0", Offset = "0x1C805A0", VA = "0x1C805A0", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x60111AB")]
    [Address(RVA = "0x1C805C0", Offset = "0x1C805C0", VA = "0x1C805C0", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x60111AC")]
    [Address(RVA = "0x1C805CC", Offset = "0x1C805CC", VA = "0x1C805CC", Slot = "10")]
    public override IEnumerator ReOpenUpdate(GuildBelowScreenParam param) => (IEnumerator) null;

    [Token(Token = "0x60111AD")]
    [Address(RVA = "0x1C8065C", Offset = "0x1C8065C", VA = "0x1C8065C")]
    private IEnumerator Setup() => (IEnumerator) null;

    [Token(Token = "0x60111AE")]
    [Address(RVA = "0x1C806C4", Offset = "0x1C806C4", VA = "0x1C806C4")]
    public void OnClickAscending()
    {
    }

    [Token(Token = "0x60111AF")]
    [Address(RVA = "0x1C80730", Offset = "0x1C80730", VA = "0x1C80730")]
    public void OnClickDescending()
    {
    }

    [Token(Token = "0x60111B0")]
    [Address(RVA = "0x1C80744", Offset = "0x1C80744", VA = "0x1C80744")]
    public void OnMemberDetailClicked(GuildMemberInfo info)
    {
    }

    [Token(Token = "0x60111B1")]
    [Address(RVA = "0x1C806DC", Offset = "0x1C806DC", VA = "0x1C806DC")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60111B2")]
    [Address(RVA = "0x1C809F0", Offset = "0x1C809F0", VA = "0x1C809F0")]
    private IEnumerator SetupGuildMemberListAsync() => (IEnumerator) null;

    [Token(Token = "0x60111B3")]
    [Address(RVA = "0x1C80A58", Offset = "0x1C80A58", VA = "0x1C80A58")]
    private IEnumerator SetupRequestListAsync() => (IEnumerator) null;

    [Token(Token = "0x60111B4")]
    [Address(RVA = "0x1C80AC0", Offset = "0x1C80AC0", VA = "0x1C80AC0")]
    private IEnumerator RequestGuildMembers() => (IEnumerator) null;

    [Token(Token = "0x60111B5")]
    [Address(RVA = "0x1C80B50", Offset = "0x1C80B50", VA = "0x1C80B50")]
    private IEnumerator RequestJoinRequestList() => (IEnumerator) null;

    [Token(Token = "0x60111B6")]
    [Address(RVA = "0x1C80BB8", Offset = "0x1C80BB8", VA = "0x1C80BB8")]
    public void OnClickRequestApprove(string playerId)
    {
    }

    [Token(Token = "0x60111B7")]
    [Address(RVA = "0x1C810D0", Offset = "0x1C810D0", VA = "0x1C810D0")]
    public void OnClickRequestReject(string playerId)
    {
    }

    [Token(Token = "0x60111B8")]
    [Address(RVA = "0x1C815E8", Offset = "0x1C815E8", VA = "0x1C815E8")]
    private void OnRequestFailed(string error)
    {
    }

    [Token(Token = "0x60111B9")]
    [Address(RVA = "0x1C8166C", Offset = "0x1C8166C", VA = "0x1C8166C")]
    private IEnumerator RequestJoinRequestApprove(string playerId) => (IEnumerator) null;

    [Token(Token = "0x60111BA")]
    [Address(RVA = "0x1C81708", Offset = "0x1C81708", VA = "0x1C81708")]
    private IEnumerator RequestJoinRequestReject(string playerId) => (IEnumerator) null;

    [Token(Token = "0x60111BB")]
    [Address(RVA = "0x1C8177C", Offset = "0x1C8177C", VA = "0x1C8177C")]
    private IEnumerator OnRequestSuccess(GuildSyncDataSet syncData) => (IEnumerator) null;

    [Token(Token = "0x60111BC")]
    [Address(RVA = "0x1C81818", Offset = "0x1C81818", VA = "0x1C81818")]
    private IEnumerator OnRequestError(NetworkErrorResult result) => (IEnumerator) null;

    [Token(Token = "0x60111BD")]
    [Address(RVA = "0x1C80884", Offset = "0x1C80884", VA = "0x1C80884")]
    private void RefreshGuildMember()
    {
    }

    [Token(Token = "0x60111BE")]
    [Address(RVA = "0x1C818A8", Offset = "0x1C818A8", VA = "0x1C818A8")]
    private void SetupMemberList()
    {
    }

    [Token(Token = "0x60111BF")]
    [Address(RVA = "0x1C807D0", Offset = "0x1C807D0", VA = "0x1C807D0")]
    private void RefreshRequestMember()
    {
    }

    [Token(Token = "0x60111C0")]
    [Address(RVA = "0x1C81DE4", Offset = "0x1C81DE4", VA = "0x1C81DE4")]
    private void SetupRequestList()
    {
    }

    [Token(Token = "0x60111C1")]
    [Address(RVA = "0x1C82260", Offset = "0x1C82260", VA = "0x1C82260")]
    public GuildMemberListBelowScreen()
    {
    }
  }
}
