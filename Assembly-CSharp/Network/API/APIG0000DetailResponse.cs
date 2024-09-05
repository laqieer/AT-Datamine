// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0000DetailResponse
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
  [Token(Token = "0x2001C70")]
  [Serializable]
  public class APIG0000DetailResponse
  {
    [Token(Token = "0x40079B9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private G0000GachaDetailType gacha_detail;

    [Token(Token = "0x17001FD0")]
    public G0000GachaDetailType GachaDetail
    {
      [Token(Token = "0x600A779"), Address(RVA = "0x190E70C", Offset = "0x190E70C", VA = "0x190E70C")] get
      {
        return (G0000GachaDetailType) null;
      }
    }

    [Token(Token = "0x600A77A")]
    [Address(RVA = "0x190E714", Offset = "0x190E714", VA = "0x190E714")]
    public APIG0000DetailResponse()
    {
    }
  }
}
