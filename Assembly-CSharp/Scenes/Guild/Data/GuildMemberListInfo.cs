// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Data.GuildMemberListInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Guild.Data
{
  [Token(Token = "0x2002C1E")]
  public class GuildMemberListInfo
  {
    [Token(Token = "0x400BBF3")]
    [FieldOffset(Offset = "0x10")]
    public List<GuildMemberInfo> playerGuildMembers;

    [Token(Token = "0x17003B9F")]
    public List<GuildMemberInfo> PlayerGuildMembers
    {
      [Token(Token = "0x601146C"), Address(RVA = "0x4A1B214", Offset = "0x4A1B214", VA = "0x4A1B214")] get
      {
        return (List<GuildMemberInfo>) null;
      }
    }

    [Token(Token = "0x601146D")]
    [Address(RVA = "0x4A1907C", Offset = "0x4A1907C", VA = "0x4A1907C")]
    public void ApplyGuildMemberType(string guildId, List<GuildMemberType> guildMemberType)
    {
    }

    [Token(Token = "0x601146E")]
    [Address(RVA = "0x4A194F8", Offset = "0x4A194F8", VA = "0x4A194F8")]
    public GuildMemberInfo GetGuildMaster() => (GuildMemberInfo) null;

    [Token(Token = "0x601146F")]
    [Address(RVA = "0x4A101B0", Offset = "0x4A101B0", VA = "0x4A101B0")]
    public GuildMemberInfo GetGuildMemberInfo(string playerId) => (GuildMemberInfo) null;

    [Token(Token = "0x6011470")]
    [Address(RVA = "0x4A15824", Offset = "0x4A15824", VA = "0x4A15824")]
    public int GetSubMasterCount() => new int();

    [Token(Token = "0x6011471")]
    [Address(RVA = "0x4A18A8C", Offset = "0x4A18A8C", VA = "0x4A18A8C")]
    public GuildMemberListInfo()
    {
    }
  }
}
