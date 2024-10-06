// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendRejectResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C64")]
  [Serializable]
  public class APIFriendRejectResponse
  {
    [Token(Token = "0x4007990")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string rejected_player_id;

    [Token(Token = "0x17001FB8")]
    public string RejectedPlayerId
    {
      [Token(Token = "0x600A731"), Address(RVA = "0x190D6F8", Offset = "0x190D6F8", VA = "0x190D6F8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A732")]
    [Address(RVA = "0x190D700", Offset = "0x190D700", VA = "0x190D700")]
    public APIFriendRejectResponse()
    {
    }
  }
}
