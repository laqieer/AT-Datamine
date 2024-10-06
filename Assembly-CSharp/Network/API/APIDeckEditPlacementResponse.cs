// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditPlacementResponse
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
  [Token(Token = "0x2001C00")]
  [Serializable]
  public class APIDeckEditPlacementResponse
  {
    [Token(Token = "0x40077DF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerDeckType deck;

    [Token(Token = "0x17001EB4")]
    public PlayerDeckType Deck
    {
      [Token(Token = "0x600A49D"), Address(RVA = "0x46D2F08", Offset = "0x46D2F08", VA = "0x46D2F08")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x600A49E")]
    [Address(RVA = "0x46D2F10", Offset = "0x46D2F10", VA = "0x46D2F10")]
    public APIDeckEditPlacementResponse()
    {
    }
  }
}
