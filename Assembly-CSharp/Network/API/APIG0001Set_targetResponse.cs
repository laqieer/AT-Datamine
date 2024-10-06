// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001Set_targetResponse
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
  [Token(Token = "0x2001C90")]
  [Serializable]
  public class APIG0001Set_targetResponse
  {
    [Token(Token = "0x4007A2D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private G0001GachaDetailType gacha_detail;

    [Token(Token = "0x17002012")]
    public G0001GachaDetailType GachaDetail
    {
      [Token(Token = "0x600A83B"), Address(RVA = "0x19111FC", Offset = "0x19111FC", VA = "0x19111FC")] get
      {
        return (G0001GachaDetailType) null;
      }
    }

    [Token(Token = "0x600A83C")]
    [Address(RVA = "0x1911204", Offset = "0x1911204", VA = "0x1911204")]
    public APIG0001Set_targetResponse()
    {
    }
  }
}
