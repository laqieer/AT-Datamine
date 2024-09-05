// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendAcceptResponse
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
  [Token(Token = "0x2001C50")]
  [Serializable]
  public class APIFriendAcceptResponse
  {
    [Token(Token = "0x400794F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerFriendType updated_player_friend;

    [Token(Token = "0x17001F93")]
    public PlayerFriendType UpdatedPlayerFriend
    {
      [Token(Token = "0x600A6BC"), Address(RVA = "0x190BC44", Offset = "0x190BC44", VA = "0x190BC44")] get
      {
        return (PlayerFriendType) null;
      }
    }

    [Token(Token = "0x600A6BD")]
    [Address(RVA = "0x190BC4C", Offset = "0x190BC4C", VA = "0x190BC4C")]
    public APIFriendAcceptResponse()
    {
    }
  }
}
