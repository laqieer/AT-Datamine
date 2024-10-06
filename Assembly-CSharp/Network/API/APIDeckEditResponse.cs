// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditResponse
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
  [Token(Token = "0x2001BF8")]
  [Serializable]
  public class APIDeckEditResponse : ICommonApiResult
  {
    [Token(Token = "0x40077C1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40077C2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType deck;

    [Token(Token = "0x17001EA5")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A46E"), Address(RVA = "0x46D2458", Offset = "0x46D2458", VA = "0x46D2458", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001EA6")]
    public PlayerDeckType Deck
    {
      [Token(Token = "0x600A46F"), Address(RVA = "0x46D2460", Offset = "0x46D2460", VA = "0x46D2460")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x600A470")]
    [Address(RVA = "0x46D2468", Offset = "0x46D2468", VA = "0x46D2468")]
    public APIDeckEditResponse()
    {
    }
  }
}
