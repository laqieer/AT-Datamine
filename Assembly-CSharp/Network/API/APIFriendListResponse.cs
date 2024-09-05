// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendListResponse
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
  [Token(Token = "0x2001C60")]
  [Serializable]
  public class APIFriendListResponse
  {
    [Token(Token = "0x4007981")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerFriendType> player_friends;
    [Token(Token = "0x4007982")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerBlockType> player_blocks;
    [Token(Token = "0x4007983")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17001FAF")]
    public List<PlayerFriendType> PlayerFriends
    {
      [Token(Token = "0x600A718"), Address(RVA = "0x190D194", Offset = "0x190D194", VA = "0x190D194")] get
      {
        return (List<PlayerFriendType>) null;
      }
    }

    [Token(Token = "0x17001FB0")]
    public List<PlayerBlockType> PlayerBlocks
    {
      [Token(Token = "0x600A719"), Address(RVA = "0x190D19C", Offset = "0x190D19C", VA = "0x190D19C")] get
      {
        return (List<PlayerBlockType>) null;
      }
    }

    [Token(Token = "0x17001FB1")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A71A"), Address(RVA = "0x190D1A4", Offset = "0x190D1A4", VA = "0x190D1A4")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600A71B")]
    [Address(RVA = "0x190D1AC", Offset = "0x190D1AC", VA = "0x190D1AC")]
    public APIFriendListResponse()
    {
    }
  }
}
