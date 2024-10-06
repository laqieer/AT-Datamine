// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200279C")]
  public struct EffectValue : IEquatable<EffectValue>, IEffectValue
  {
    [Token(Token = "0x400A8E9")]
    [FieldOffset(Offset = "0x0")]
    public BattleEffectValueTypeEnum valueType;
    [Token(Token = "0x400A8EA")]
    [FieldOffset(Offset = "0x4")]
    public int value;

    [Token(Token = "0x600F758")]
    [Address(RVA = "0x1ED9DAC", Offset = "0x1ED9DAC", VA = "0x1ED9DAC")]
    public static EffectValue Default(BattleEffectValueTypeEnum type = BattleEffectValueTypeEnum.Fixed)
    {
      return new EffectValue();
    }

    [Token(Token = "0x1700352A")]
    public BattleEffectValueTypeEnum ValueType
    {
      [Token(Token = "0x600F759"), Address(RVA = "0x1ED9DCC", Offset = "0x1ED9DCC", VA = "0x1ED9DCC", Slot = "5")] get
      {
        return new BattleEffectValueTypeEnum();
      }
    }

    [Token(Token = "0x1700352B")]
    public int Value
    {
      [Token(Token = "0x600F75A"), Address(RVA = "0x1ED9DD4", Offset = "0x1ED9DD4", VA = "0x1ED9DD4", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F75B")]
    [Address(RVA = "0x1ED9DDC", Offset = "0x1ED9DDC", VA = "0x1ED9DDC", Slot = "4")]
    public bool Equals(EffectValue other) => new bool();

    [Token(Token = "0x600F75C")]
    [Address(RVA = "0x1ED9E04", Offset = "0x1ED9E04", VA = "0x1ED9E04", Slot = "0")]
    public override bool Equals(object other) => new bool();

    [Token(Token = "0x600F75D")]
    [Address(RVA = "0x1ED9E8C", Offset = "0x1ED9E8C", VA = "0x1ED9E8C", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F75E")]
    [Address(RVA = "0x1ED9E98", Offset = "0x1ED9E98", VA = "0x1ED9E98")]
    public static bool operator ==(EffectValue a, EffectValue b) => new bool();

    [Token(Token = "0x600F75F")]
    [Address(RVA = "0x1ED9EE8", Offset = "0x1ED9EE8", VA = "0x1ED9EE8")]
    public static bool operator !=(EffectValue a, EffectValue b) => new bool();
  }
}
