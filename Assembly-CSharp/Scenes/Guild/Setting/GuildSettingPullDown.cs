// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Setting.GuildSettingPullDown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Setting
{
  [Token(Token = "0x2002BAD")]
  public class GuildSettingPullDown : MonoBehaviour
  {
    [Token(Token = "0x400B9E7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildSettingPullDownContainer policyContainer;
    [Token(Token = "0x400B9E8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GuildSettingPullDownContainer conditionContainer;
    [Token(Token = "0x400B9E9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GuildSettingPullDownContainer autoApproveContainer;
    [Token(Token = "0x400B9EA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GuildSettingPullDownContainer recruitContainer;

    [Token(Token = "0x60110F0")]
    [Address(RVA = "0x1C7B068", Offset = "0x1C7B068", VA = "0x1C7B068")]
    public void Initialize(GuildDetailInfo guildDetailInfo)
    {
    }

    [Token(Token = "0x60110F1")]
    [Address(RVA = "0x1C7B580", Offset = "0x1C7B580", VA = "0x1C7B580")]
    public void Initialize(GuildSearchSettings settings)
    {
    }

    [Token(Token = "0x60110F2")]
    [Address(RVA = "0x1C7B7AC", Offset = "0x1C7B7AC", VA = "0x1C7B7AC")]
    public void ApplyPlayerGuildDetail()
    {
    }

    [Token(Token = "0x60110F3")]
    [Address(RVA = "0x1C7B868", Offset = "0x1C7B868", VA = "0x1C7B868")]
    public GuildSearchSettings GetGuildSearchSettings() => (GuildSearchSettings) null;

    [Token(Token = "0x60110F4")]
    [Address(RVA = "0x1C7B1DC", Offset = "0x1C7B1DC", VA = "0x1C7B1DC")]
    private string GetText(string key) => (string) null;

    [Token(Token = "0x60110F5")]
    [Address(RVA = "0x1C7B908", Offset = "0x1C7B908", VA = "0x1C7B908")]
    public GuildSettingPullDown()
    {
    }
  }
}
