// Decompiled with JetBrains decompiler
// Type: Network.API.APIConfirmExpirationResponse
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
  [Token(Token = "0x2001BE4")]
  [Serializable]
  public class APIConfirmExpirationResponse
  {
    [Token(Token = "0x400776F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerPresentType> presents;
    [Token(Token = "0x4007770")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int total_presents_number;

    [Token(Token = "0x17001E74")]
    public List<PlayerPresentType> Presents
    {
      [Token(Token = "0x600A3ED"), Address(RVA = "0x46D0944", Offset = "0x46D0944", VA = "0x46D0944")] get
      {
        return (List<PlayerPresentType>) null;
      }
    }

    [Token(Token = "0x17001E75")]
    public int TotalPresentsNumber
    {
      [Token(Token = "0x600A3EE"), Address(RVA = "0x46D094C", Offset = "0x46D094C", VA = "0x46D094C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A3EF")]
    [Address(RVA = "0x46D0954", Offset = "0x46D0954", VA = "0x46D0954")]
    public APIConfirmExpirationResponse()
    {
    }
  }
}
