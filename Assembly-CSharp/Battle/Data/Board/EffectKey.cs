// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectKey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200279A")]
  public struct EffectKey : IEquatable<EffectKey>
  {
    [Token(Token = "0x400A8E7")]
    [FieldOffset(Offset = "0x0")]
    public BattleEffectTypeEnum effectType;
    [Token(Token = "0x400A8E8")]
    [FieldOffset(Offset = "0x8")]
    public int[] subParameters;

    [Token(Token = "0x600F751")]
    [Address(RVA = "0x1ED9B9C", Offset = "0x1ED9B9C", VA = "0x1ED9B9C", Slot = "4")]
    public bool Equals(EffectKey other) => new bool();

    [Token(Token = "0x600F752")]
    [Address(RVA = "0x1ED9C20", Offset = "0x1ED9C20", VA = "0x1ED9C20", Slot = "0")]
    public override bool Equals(object other) => new bool();

    [Token(Token = "0x600F753")]
    [Address(RVA = "0x1ED9C98", Offset = "0x1ED9C98", VA = "0x1ED9C98", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F754")]
    [Address(RVA = "0x1ED9CF8", Offset = "0x1ED9CF8", VA = "0x1ED9CF8")]
    public static bool operator ==(EffectKey a, EffectKey b) => new bool();

    [Token(Token = "0x600F755")]
    [Address(RVA = "0x1ED9D94", Offset = "0x1ED9D94", VA = "0x1ED9D94")]
    public static bool operator !=(EffectKey a, EffectKey b) => new bool();
  }
}
