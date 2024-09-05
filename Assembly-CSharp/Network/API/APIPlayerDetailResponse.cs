// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerDetailResponse
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
  [Token(Token = "0x2001D90")]
  [Serializable]
  public class APIPlayerDetailResponse
  {
    [Token(Token = "0x4007E37")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerOpenProfileType target_player_profile;
    [Token(Token = "0x4007E38")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int friend_status;
    [Token(Token = "0x4007E39")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string guild_id;
    [Token(Token = "0x4007E3A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool is_block;

    [Token(Token = "0x17002255")]
    public PlayerOpenProfileType TargetPlayerProfile
    {
      [Token(Token = "0x600AE7E"), Address(RVA = "0x1A4D584", Offset = "0x1A4D584", VA = "0x1A4D584")] get
      {
        return (PlayerOpenProfileType) null;
      }
    }

    [Token(Token = "0x17002256")]
    public int FriendStatus
    {
      [Token(Token = "0x600AE7F"), Address(RVA = "0x1A4D58C", Offset = "0x1A4D58C", VA = "0x1A4D58C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002257")]
    public string GuildId
    {
      [Token(Token = "0x600AE80"), Address(RVA = "0x1A4D594", Offset = "0x1A4D594", VA = "0x1A4D594")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002258")]
    public bool IsBlock
    {
      [Token(Token = "0x600AE81"), Address(RVA = "0x1A4D59C", Offset = "0x1A4D59C", VA = "0x1A4D59C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600AE82")]
    [Address(RVA = "0x1A4D5A4", Offset = "0x1A4D5A4", VA = "0x1A4D5A4")]
    public APIPlayerDetailResponse()
    {
    }
  }
}
