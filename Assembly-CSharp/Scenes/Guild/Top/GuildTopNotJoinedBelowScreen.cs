// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Top.GuildTopNotJoinedBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Top
{
  [Token(Token = "0x2002BA8")]
  public class GuildTopNotJoinedBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400B9DC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<GameObject> activateObj;
    [Token(Token = "0x400B9DD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<GameObject> deactivateObj;

    [Token(Token = "0x60110D9")]
    [Address(RVA = "0x1C7A750", Offset = "0x1C7A750", VA = "0x1C7A750", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x60110DA")]
    [Address(RVA = "0x1C7A920", Offset = "0x1C7A920", VA = "0x1C7A920", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x60110DB")]
    [Address(RVA = "0x1C7AC1C", Offset = "0x1C7AC1C", VA = "0x1C7AC1C", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x60110DC")]
    [Address(RVA = "0x1C7AC28", Offset = "0x1C7AC28", VA = "0x1C7AC28")]
    public void OnClickCreateGuild()
    {
    }

    [Token(Token = "0x60110DD")]
    [Address(RVA = "0x1C7AC50", Offset = "0x1C7AC50", VA = "0x1C7AC50")]
    public void OnClickSearchGuild()
    {
    }

    [Token(Token = "0x60110DE")]
    [Address(RVA = "0x1C7AC78", Offset = "0x1C7AC78", VA = "0x1C7AC78")]
    public void OnClickDisable()
    {
    }

    [Token(Token = "0x60110DF")]
    [Address(RVA = "0x1C7ABBC", Offset = "0x1C7ABBC", VA = "0x1C7ABBC")]
    public IEnumerator RequestMaintenance() => (IEnumerator) null;

    [Token(Token = "0x60110E0")]
    [Address(RVA = "0x1C7AD84", Offset = "0x1C7AD84", VA = "0x1C7AD84")]
    public GuildTopNotJoinedBelowScreen()
    {
    }
  }
}
