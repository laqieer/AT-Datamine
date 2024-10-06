// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckNameResponse
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
  [Token(Token = "0x2001C04")]
  [Serializable]
  public class APIDeckNameResponse
  {
    [Token(Token = "0x40077EE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerDeckType deck;

    [Token(Token = "0x17001EBB")]
    public PlayerDeckType Deck
    {
      [Token(Token = "0x600A4B4"), Address(RVA = "0x46D345C", Offset = "0x46D345C", VA = "0x46D345C")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x600A4B5")]
    [Address(RVA = "0x46D3464", Offset = "0x46D3464", VA = "0x46D3464")]
    public APIDeckNameResponse()
    {
    }
  }
}
