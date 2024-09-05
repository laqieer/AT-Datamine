// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitFavoriteResponse
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
  [Token(Token = "0x2001EC0")]
  [Serializable]
  public class APIUnitFavoriteResponse
  {
    [Token(Token = "0x4008415")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerUnitType> player_units;

    [Token(Token = "0x170025B1")]
    public List<PlayerUnitType> PlayerUnits
    {
      [Token(Token = "0x600B69A"), Address(RVA = "0x22ED2F8", Offset = "0x22ED2F8", VA = "0x22ED2F8")] get
      {
        return (List<PlayerUnitType>) null;
      }
    }

    [Token(Token = "0x600B69B")]
    [Address(RVA = "0x22ED300", Offset = "0x22ED300", VA = "0x22ED300")]
    public APIUnitFavoriteResponse()
    {
    }
  }
}
