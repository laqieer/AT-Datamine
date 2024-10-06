// Decompiled with JetBrains decompiler
// Type: Network.Param.ArenaDeckUnitType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A3F")]
  [Serializable]
  public class ArenaDeckUnitType
  {
    [Token(Token = "0x4007042")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int position_id;
    [Token(Token = "0x4007043")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string player_unit_id;

    [Token(Token = "0x17001878")]
    public int PositionId
    {
      [Token(Token = "0x60095C5"), Address(RVA = "0x48EEC50", Offset = "0x48EEC50", VA = "0x48EEC50")] get
      {
        return new int();
      }
      [Token(Token = "0x60095C6"), Address(RVA = "0x48EEC58", Offset = "0x48EEC58", VA = "0x48EEC58")] set
      {
      }
    }

    [Token(Token = "0x17001879")]
    public string PlayerUnitId
    {
      [Token(Token = "0x60095C7"), Address(RVA = "0x48EEC60", Offset = "0x48EEC60", VA = "0x48EEC60")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60095C8"), Address(RVA = "0x48EEC68", Offset = "0x48EEC68", VA = "0x48EEC68")] set
      {
      }
    }

    [Token(Token = "0x60095C9")]
    [Address(RVA = "0x48EEC70", Offset = "0x48EEC70", VA = "0x48EEC70")]
    public ArenaDeckUnitType()
    {
    }
  }
}
