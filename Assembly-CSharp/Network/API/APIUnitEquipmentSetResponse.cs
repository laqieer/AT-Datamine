// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitEquipmentSetResponse
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
  [Token(Token = "0x2001EBC")]
  [Serializable]
  public class APIUnitEquipmentSetResponse
  {
    [Token(Token = "0x4008407")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerUnitType player_unit;

    [Token(Token = "0x170025AA")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B683"), Address(RVA = "0x22ECDA4", Offset = "0x22ECDA4", VA = "0x22ECDA4")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x600B684")]
    [Address(RVA = "0x22ECDAC", Offset = "0x22ECDAC", VA = "0x22ECDAC")]
    public APIUnitEquipmentSetResponse()
    {
    }
  }
}
