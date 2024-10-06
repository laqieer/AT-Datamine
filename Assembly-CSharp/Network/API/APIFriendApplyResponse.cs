// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendApplyResponse
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
  [Token(Token = "0x2001C54")]
  [Serializable]
  public class APIFriendApplyResponse
  {
    [Token(Token = "0x400795C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerFriendType updated_player_friend;

    [Token(Token = "0x17001F9A")]
    public PlayerFriendType UpdatedPlayerFriend
    {
      [Token(Token = "0x600A6D3"), Address(RVA = "0x190C198", Offset = "0x190C198", VA = "0x190C198")] get
      {
        return (PlayerFriendType) null;
      }
    }

    [Token(Token = "0x600A6D4")]
    [Address(RVA = "0x190C1A0", Offset = "0x190C1A0", VA = "0x190C1A0")]
    public APIFriendApplyResponse()
    {
    }
  }
}
