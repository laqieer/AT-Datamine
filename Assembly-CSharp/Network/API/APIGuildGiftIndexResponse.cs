// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftIndexResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CC8")]
  [Serializable]
  public class APIGuildGiftIndexResponse
  {
    [Token(Token = "0x4007B0A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildGiftType> gifts;
    [Token(Token = "0x4007B0B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GuildGiftTarget> unsent_members;
    [Token(Token = "0x4007B0C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<Reward> expired_gifts;
    [Token(Token = "0x4007B0D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int wish_id;

    [Token(Token = "0x1700208D")]
    public List<GuildGiftType> Gifts
    {
      [Token(Token = "0x600A996"), Address(RVA = "0x1915D4C", Offset = "0x1915D4C", VA = "0x1915D4C")] get
      {
        return (List<GuildGiftType>) null;
      }
    }

    [Token(Token = "0x1700208E")]
    public List<GuildGiftTarget> UnsentMembers
    {
      [Token(Token = "0x600A997"), Address(RVA = "0x1915D54", Offset = "0x1915D54", VA = "0x1915D54")] get
      {
        return (List<GuildGiftTarget>) null;
      }
    }

    [Token(Token = "0x1700208F")]
    public List<Reward> ExpiredGifts
    {
      [Token(Token = "0x600A998"), Address(RVA = "0x1915D5C", Offset = "0x1915D5C", VA = "0x1915D5C")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x17002090")]
    public int WishId
    {
      [Token(Token = "0x600A999"), Address(RVA = "0x1915D64", Offset = "0x1915D64", VA = "0x1915D64")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A99A")]
    [Address(RVA = "0x1915D6C", Offset = "0x1915D6C", VA = "0x1915D6C")]
    public APIGuildGiftIndexResponse()
    {
    }
  }
}
