// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAwakeResponse
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
  [Token(Token = "0x2001EA8")]
  [Serializable]
  public class APIUnitAwakeResponse
  {
    [Token(Token = "0x40083BD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerUnitType player_unit;
    [Token(Token = "0x40083BE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerItems consume_items;

    [Token(Token = "0x17002581")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B60A"), Address(RVA = "0x22EB2D0", Offset = "0x22EB2D0", VA = "0x22EB2D0")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x17002582")]
    public UpdatedPlayerItems ConsumeItems
    {
      [Token(Token = "0x600B60B"), Address(RVA = "0x22EB2D8", Offset = "0x22EB2D8", VA = "0x22EB2D8")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600B60C")]
    [Address(RVA = "0x22EB2E0", Offset = "0x22EB2E0", VA = "0x22EB2E0")]
    public APIUnitAwakeResponse()
    {
    }
  }
}
