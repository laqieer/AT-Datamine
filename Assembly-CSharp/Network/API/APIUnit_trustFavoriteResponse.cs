// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_trustFavoriteResponse
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
  [Token(Token = "0x2001EEC")]
  [Serializable]
  public class APIUnit_trustFavoriteResponse
  {
    [Token(Token = "0x40084C7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerGearUnitTrustType> unit_trusts;

    [Token(Token = "0x17002615")]
    public List<PlayerGearUnitTrustType> UnitTrusts
    {
      [Token(Token = "0x600B7AE"), Address(RVA = "0x2131990", Offset = "0x2131990", VA = "0x2131990")] get
      {
        return (List<PlayerGearUnitTrustType>) null;
      }
    }

    [Token(Token = "0x600B7AF")]
    [Address(RVA = "0x2131998", Offset = "0x2131998", VA = "0x2131998")]
    public APIUnit_trustFavoriteResponse()
    {
    }
  }
}
