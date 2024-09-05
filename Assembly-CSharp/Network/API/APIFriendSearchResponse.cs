// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendSearchResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C6C")]
  [Serializable]
  public class APIFriendSearchResponse
  {
    [Token(Token = "0x40079AA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerOpenProfileType target_player_profile;
    [Token(Token = "0x40079AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int friend_status;
    [Token(Token = "0x40079AC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string guild_id;
    [Token(Token = "0x40079AD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool is_block;

    [Token(Token = "0x17001FC6")]
    public PlayerOpenProfileType TargetPlayerProfile
    {
      [Token(Token = "0x600A75F"), Address(RVA = "0x190E1A0", Offset = "0x190E1A0", VA = "0x190E1A0")] get
      {
        return (PlayerOpenProfileType) null;
      }
    }

    [Token(Token = "0x17001FC7")]
    public int FriendStatus
    {
      [Token(Token = "0x600A760"), Address(RVA = "0x190E1A8", Offset = "0x190E1A8", VA = "0x190E1A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001FC8")]
    public string GuildId
    {
      [Token(Token = "0x600A761"), Address(RVA = "0x190E1B0", Offset = "0x190E1B0", VA = "0x190E1B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FC9")]
    public bool IsBlock
    {
      [Token(Token = "0x600A762"), Address(RVA = "0x190E1B8", Offset = "0x190E1B8", VA = "0x190E1B8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A763")]
    [Address(RVA = "0x190E1C0", Offset = "0x190E1C0", VA = "0x190E1C0")]
    public APIFriendSearchResponse()
    {
    }
  }
}
