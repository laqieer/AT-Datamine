// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Search.GuildSearchListBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using Scenes.Guild.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Search
{
  [Token(Token = "0x2002BB3")]
  public class GuildSearchListBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BA00")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400BA01")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GuildSearchListItem templateListItem;
    [Token(Token = "0x400BA02")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private float toasterDelayTime;
    [Token(Token = "0x400BA03")]
    [FieldOffset(Offset = "0x50")]
    private List<GuildSearchListItem> listItem;
    [Token(Token = "0x400BA04")]
    [FieldOffset(Offset = "0x58")]
    private GuildSearchSettings guildSearchSettings;
    [Token(Token = "0x400BA05")]
    [FieldOffset(Offset = "0x60")]
    private GuildDetailInfo[] arrayGuildDetailInfo;

    [Token(Token = "0x17003AE3")]
    private GuildDataManager GuildDataManager
    {
      [Token(Token = "0x6011110"), Address(RVA = "0x1C7C060", Offset = "0x1C7C060", VA = "0x1C7C060")] get
      {
        return (GuildDataManager) null;
      }
    }

    [Token(Token = "0x6011111")]
    [Address(RVA = "0x1C7C0B0", Offset = "0x1C7C0B0", VA = "0x1C7C0B0", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011112")]
    [Address(RVA = "0x1C7C140", Offset = "0x1C7C140", VA = "0x1C7C140", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011113")]
    [Address(RVA = "0x1C7C160", Offset = "0x1C7C160", VA = "0x1C7C160", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011114")]
    [Address(RVA = "0x1C7C16C", Offset = "0x1C7C16C", VA = "0x1C7C16C", Slot = "10")]
    public override IEnumerator ReOpenUpdate(GuildBelowScreenParam param) => (IEnumerator) null;

    [Token(Token = "0x6011115")]
    [Address(RVA = "0x1C7C208", Offset = "0x1C7C208", VA = "0x1C7C208")]
    public void UpdateSettings(GuildSearchSettings settings, bool isForce = false)
    {
    }

    [Token(Token = "0x6011116")]
    [Address(RVA = "0x1C7C448", Offset = "0x1C7C448", VA = "0x1C7C448")]
    public void OnClickUpdateButton()
    {
    }

    [Token(Token = "0x6011117")]
    [Address(RVA = "0x1C7C560", Offset = "0x1C7C560", VA = "0x1C7C560")]
    public void OnClickChangeSearchCondition()
    {
    }

    [Token(Token = "0x6011118")]
    [Address(RVA = "0x1C7C604", Offset = "0x1C7C604", VA = "0x1C7C604")]
    public void OnClickGuildDetail(GuildDetailInfo guildDetail)
    {
    }

    [Token(Token = "0x6011119")]
    [Address(RVA = "0x1C7CAAC", Offset = "0x1C7CAAC", VA = "0x1C7CAAC")]
    private void SetupGuildList(GuildDetailInfo[] guildDetails)
    {
    }

    [Token(Token = "0x601111A")]
    [Address(RVA = "0x1C7C3E0", Offset = "0x1C7C3E0", VA = "0x1C7C3E0")]
    private IEnumerator SetupGuildListAsync() => (IEnumerator) null;

    [Token(Token = "0x601111B")]
    [Address(RVA = "0x1C7CE50", Offset = "0x1C7CE50", VA = "0x1C7CE50")]
    private IEnumerator RequestGuildList(Action onSuccess, Action<string> onFailed)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601111C")]
    [Address(RVA = "0x1C7CEF4", Offset = "0x1C7CEF4", VA = "0x1C7CEF4")]
    private IEnumerator RequestGuildSearchList(Action onSuccess, Action<string> onFailed)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601111D")]
    [Address(RVA = "0x1C7CF98", Offset = "0x1C7CF98", VA = "0x1C7CF98")]
    private void UpdateGuildListData(
      List<GuildSearchResultType> guilds,
      GuildJoinRequestType joinRequest)
    {
    }

    [Token(Token = "0x601111E")]
    [Address(RVA = "0x1C7D204", Offset = "0x1C7D204", VA = "0x1C7D204")]
    private IEnumerator RequestJoinRequestCancel(Action onSuccess, Action<string> onFailed)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601111F")]
    [Address(RVA = "0x1C7C378", Offset = "0x1C7C378", VA = "0x1C7C378")]
    private IEnumerator ShowToasterDelay() => (IEnumerator) null;

    [Token(Token = "0x6011120")]
    [Address(RVA = "0x1C7D2D0", Offset = "0x1C7D2D0", VA = "0x1C7D2D0")]
    private void ShowToasterSearchNotExist()
    {
    }

    [Token(Token = "0x6011121")]
    [Address(RVA = "0x1C7D3E8", Offset = "0x1C7D3E8", VA = "0x1C7D3E8")]
    public GuildSearchListBelowScreen()
    {
    }
  }
}
