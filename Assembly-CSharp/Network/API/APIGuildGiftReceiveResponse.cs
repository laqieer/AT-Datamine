// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftReceiveResponse
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
  [Token(Token = "0x2001CCC")]
  [Serializable]
  public class APIGuildGiftReceiveResponse
  {
    [Token(Token = "0x4007B1B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildGiftType> gifts;
    [Token(Token = "0x4007B1C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17002097")]
    public List<GuildGiftType> Gifts
    {
      [Token(Token = "0x600A9B0"), Address(RVA = "0x19162B8", Offset = "0x19162B8", VA = "0x19162B8")] get
      {
        return (List<GuildGiftType>) null;
      }
    }

    [Token(Token = "0x17002098")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A9B1"), Address(RVA = "0x19162C0", Offset = "0x19162C0", VA = "0x19162C0")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600A9B2")]
    [Address(RVA = "0x19162C8", Offset = "0x19162C8", VA = "0x19162C8")]
    public APIGuildGiftReceiveResponse()
    {
    }
  }
}
