// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IDamageEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002791")]
  public interface IDamageEffect : IEffectValue
  {
    [Token(Token = "0x170034F4")]
    IDamageEffect.ContextIndexInfo ContextIndex { [Token(Token = "0x600F6EA")] get; }

    [Token(Token = "0x170034F5")]
    EffectValue EffectValue { [Token(Token = "0x600F6EB")] get; }

    [Token(Token = "0x170034F6")]
    WeaponAttackTypeEnum WeaponAttackType { [Token(Token = "0x600F6EC")] get; }

    [Token(Token = "0x170034F7")]
    ElementTypeEnum Element { [Token(Token = "0x600F6ED")] get; }

    [Token(Token = "0x170034F8")]
    AttackTypeEnum AttackType { [Token(Token = "0x600F6EE")] get; }

    [Token(Token = "0x170034F9")]
    bool IsMercy { [Token(Token = "0x600F6EF")] get; }

    [Token(Token = "0x170034FA")]
    bool ConsiderBarrier { [Token(Token = "0x600F6F0")] get; }

    [Token(Token = "0x170034FB")]
    bool IsCriticalable { [Token(Token = "0x600F6F1")] get; }

    [Token(Token = "0x2002792")]
    struct ContextIndexInfo
    {
      [Token(Token = "0x400A8B1")]
      [FieldOffset(Offset = "0x0")]
      public int ValueType;
      [Token(Token = "0x400A8B2")]
      [FieldOffset(Offset = "0x4")]
      public int Value;
      [Token(Token = "0x400A8B3")]
      [FieldOffset(Offset = "0x8")]
      public int WeaponAttackType;
      [Token(Token = "0x400A8B4")]
      [FieldOffset(Offset = "0xC")]
      public int Element;
      [Token(Token = "0x400A8B5")]
      [FieldOffset(Offset = "0x10")]
      public int AttackType;
      [Token(Token = "0x400A8B6")]
      [FieldOffset(Offset = "0x14")]
      public int Killable;
    }
  }
}
