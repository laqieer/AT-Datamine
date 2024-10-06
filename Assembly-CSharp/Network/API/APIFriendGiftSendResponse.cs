// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendGiftSendResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C5C")]
  [Serializable]
  public class APIFriendGiftSendResponse
  {
    [Token(Token = "0x4007975")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool is_sent;

    [Token(Token = "0x17001FA8")]
    public bool IsSent
    {
      [Token(Token = "0x600A701"), Address(RVA = "0x190CC40", Offset = "0x190CC40", VA = "0x190CC40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A702")]
    [Address(RVA = "0x190CC48", Offset = "0x190CC48", VA = "0x190CC48")]
    public APIFriendGiftSendResponse()
    {
    }
  }
}
