// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Data.GuildRequestMemberInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace Scenes.Guild.Data
{
  [Token(Token = "0x2002C22")]
  public class GuildRequestMemberInfo : GuildMemberInfo
  {
    [Token(Token = "0x17003BA0")]
    public DateTime RequestedAt
    {
      [Token(Token = "0x601147D"), Address(RVA = "0x4A1B558", Offset = "0x4A1B558", VA = "0x4A1B558")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x601147E"), Address(RVA = "0x4A1B560", Offset = "0x4A1B560", VA = "0x4A1B560")] private set
      {
      }
    }

    [Token(Token = "0x601147F")]
    [Address(RVA = "0x4A1B568", Offset = "0x4A1B568", VA = "0x4A1B568")]
    public void ApplyRequestedAt(string requestedAt)
    {
    }

    [Token(Token = "0x6011480")]
    [Address(RVA = "0x4A09F7C", Offset = "0x4A09F7C", VA = "0x4A09F7C")]
    public void ApplyRequestGuildMemberType(GuildJoinRequestPlayer requestPlayer)
    {
    }

    [Token(Token = "0x6011481")]
    [Address(RVA = "0x4A09F74", Offset = "0x4A09F74", VA = "0x4A09F74")]
    public GuildRequestMemberInfo()
    {
    }
  }
}
