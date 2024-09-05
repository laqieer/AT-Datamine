// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildJoinRequestType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A67")]
  [Serializable]
  public class GuildJoinRequestType
  {
    [Token(Token = "0x400712E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_id;
    [Token(Token = "0x400712F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string guild_id;
    [Token(Token = "0x4007130")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string requested_at;

    [Token(Token = "0x17001964")]
    public string PlayerId
    {
      [Token(Token = "0x60097C5"), Address(RVA = "0x48EFC88", Offset = "0x48EFC88", VA = "0x48EFC88")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097C6"), Address(RVA = "0x48EFC90", Offset = "0x48EFC90", VA = "0x48EFC90")] set
      {
      }
    }

    [Token(Token = "0x17001965")]
    public string GuildId
    {
      [Token(Token = "0x60097C7"), Address(RVA = "0x48EFC98", Offset = "0x48EFC98", VA = "0x48EFC98")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097C8"), Address(RVA = "0x48EFCA0", Offset = "0x48EFCA0", VA = "0x48EFCA0")] set
      {
      }
    }

    [Token(Token = "0x17001966")]
    public string RequestedAt
    {
      [Token(Token = "0x60097C9"), Address(RVA = "0x48EFCA8", Offset = "0x48EFCA8", VA = "0x48EFCA8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60097CA"), Address(RVA = "0x48EFCB0", Offset = "0x48EFCB0", VA = "0x48EFCB0")] set
      {
      }
    }

    [Token(Token = "0x60097CB")]
    [Address(RVA = "0x48EFCB8", Offset = "0x48EFCB8", VA = "0x48EFCB8")]
    public GuildJoinRequestType()
    {
    }
  }
}
