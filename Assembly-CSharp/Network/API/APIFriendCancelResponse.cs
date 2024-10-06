// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendCancelResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C58")]
  [Serializable]
  public class APIFriendCancelResponse
  {
    [Token(Token = "0x4007969")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string canceled_player_id;

    [Token(Token = "0x17001FA1")]
    public string CanceledPlayerId
    {
      [Token(Token = "0x600A6EA"), Address(RVA = "0x190C6EC", Offset = "0x190C6EC", VA = "0x190C6EC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A6EB")]
    [Address(RVA = "0x190C6F4", Offset = "0x190C6F4", VA = "0x190C6F4")]
    public APIFriendCancelResponse()
    {
    }
  }
}
