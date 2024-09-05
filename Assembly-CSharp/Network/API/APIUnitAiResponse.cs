// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAiResponse
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
  [Token(Token = "0x2001EA4")]
  [Serializable]
  public class APIUnitAiResponse
  {
    [Token(Token = "0x40083B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerUnitType player_unit;

    [Token(Token = "0x1700257A")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B5F3"), Address(RVA = "0x22EAD7C", Offset = "0x22EAD7C", VA = "0x22EAD7C")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x600B5F4")]
    [Address(RVA = "0x22EAD84", Offset = "0x22EAD84", VA = "0x22EAD84")]
    public APIUnitAiResponse()
    {
    }
  }
}
