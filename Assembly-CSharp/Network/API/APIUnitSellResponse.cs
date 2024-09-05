// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitSellResponse
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
  [Token(Token = "0x2001ED8")]
  [Serializable]
  public class APIUnitSellResponse
  {
    [Token(Token = "0x4008478")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4008479")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerUnitType> player_units;

    [Token(Token = "0x170025E7")]
    public PlayerType Player
    {
      [Token(Token = "0x600B730"), Address(RVA = "0x212FE94", Offset = "0x212FE94", VA = "0x212FE94")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x170025E8")]
    public List<PlayerUnitType> PlayerUnits
    {
      [Token(Token = "0x600B731"), Address(RVA = "0x212FE9C", Offset = "0x212FE9C", VA = "0x212FE9C")] get
      {
        return (List<PlayerUnitType>) null;
      }
    }

    [Token(Token = "0x600B732")]
    [Address(RVA = "0x212FEA4", Offset = "0x212FEA4", VA = "0x212FEA4")]
    public APIUnitSellResponse()
    {
    }
  }
}
