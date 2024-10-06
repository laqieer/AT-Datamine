// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendRemoveResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C68")]
  [Serializable]
  public class APIFriendRemoveResponse
  {
    [Token(Token = "0x400799D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string removed_player_id;

    [Token(Token = "0x17001FBF")]
    public string RemovedPlayerId
    {
      [Token(Token = "0x600A748"), Address(RVA = "0x190DC4C", Offset = "0x190DC4C", VA = "0x190DC4C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A749")]
    [Address(RVA = "0x190DC54", Offset = "0x190DC54", VA = "0x190DC54")]
    public APIFriendRemoveResponse()
    {
    }
  }
}
