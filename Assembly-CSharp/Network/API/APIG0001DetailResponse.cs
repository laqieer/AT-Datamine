// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001DetailResponse
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
  [Token(Token = "0x2001C80")]
  [Serializable]
  public class APIG0001DetailResponse
  {
    [Token(Token = "0x40079F2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private G0001GachaDetailType gacha_detail;

    [Token(Token = "0x17001FF1")]
    public G0001GachaDetailType GachaDetail
    {
      [Token(Token = "0x600A7DA"), Address(RVA = "0x190FC84", Offset = "0x190FC84", VA = "0x190FC84")] get
      {
        return (G0001GachaDetailType) null;
      }
    }

    [Token(Token = "0x600A7DB")]
    [Address(RVA = "0x190FC8C", Offset = "0x190FC8C", VA = "0x190FC8C")]
    public APIG0001DetailResponse()
    {
    }
  }
}
