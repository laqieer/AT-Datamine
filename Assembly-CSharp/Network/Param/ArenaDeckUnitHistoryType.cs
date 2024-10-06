// Decompiled with JetBrains decompiler
// Type: Network.Param.ArenaDeckUnitHistoryType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A3E")]
  [Serializable]
  public class ArenaDeckUnitHistoryType
  {
    [Token(Token = "0x400703F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int position_id;
    [Token(Token = "0x4007040")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string player_unit_id;
    [Token(Token = "0x4007041")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int damage;

    [Token(Token = "0x17001875")]
    public int PositionId
    {
      [Token(Token = "0x60095BE"), Address(RVA = "0x48EEC18", Offset = "0x48EEC18", VA = "0x48EEC18")] get
      {
        return new int();
      }
      [Token(Token = "0x60095BF"), Address(RVA = "0x48EEC20", Offset = "0x48EEC20", VA = "0x48EEC20")] set
      {
      }
    }

    [Token(Token = "0x17001876")]
    public string PlayerUnitId
    {
      [Token(Token = "0x60095C0"), Address(RVA = "0x48EEC28", Offset = "0x48EEC28", VA = "0x48EEC28")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60095C1"), Address(RVA = "0x48EEC30", Offset = "0x48EEC30", VA = "0x48EEC30")] set
      {
      }
    }

    [Token(Token = "0x17001877")]
    public int Damage
    {
      [Token(Token = "0x60095C2"), Address(RVA = "0x48EEC38", Offset = "0x48EEC38", VA = "0x48EEC38")] get
      {
        return new int();
      }
      [Token(Token = "0x60095C3"), Address(RVA = "0x48EEC40", Offset = "0x48EEC40", VA = "0x48EEC40")] set
      {
      }
    }

    [Token(Token = "0x60095C4")]
    [Address(RVA = "0x48EEC48", Offset = "0x48EEC48", VA = "0x48EEC48")]
    public ArenaDeckUnitHistoryType()
    {
    }
  }
}
