// Decompiled with JetBrains decompiler
// Type: Battle.Data.TargetPair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002731")]
  public class TargetPair : ITargettable
  {
    [Token(Token = "0x400A79F")]
    [FieldOffset(Offset = "0x10")]
    public UnitParameterData Unit;
    [Token(Token = "0x400A7A0")]
    [FieldOffset(Offset = "0x18")]
    public GridData Grid;

    [Token(Token = "0x17003427")]
    public List<Vector2Int> Coordinates
    {
      [Token(Token = "0x600F429"), Address(RVA = "0x1FA8058", Offset = "0x1FA8058", VA = "0x1FA8058", Slot = "4")] get
      {
        return (List<Vector2Int>) null;
      }
    }

    [Token(Token = "0x600F42A")]
    [Address(RVA = "0x1FA8144", Offset = "0x1FA8144", VA = "0x1FA8144", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F42B")]
    [Address(RVA = "0x1FA81AC", Offset = "0x1FA81AC", VA = "0x1FA81AC", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F42C")]
    [Address(RVA = "0x1FA8290", Offset = "0x1FA8290", VA = "0x1FA8290")]
    public TargetPair()
    {
    }
  }
}
