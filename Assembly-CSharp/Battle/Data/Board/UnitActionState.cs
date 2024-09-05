// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.UnitActionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002810")]
  [Flags]
  public enum UnitActionState
  {
    [Token(Token = "0x400AAA0")] None = 0,
    [Token(Token = "0x400AAA1")] Moved = 1,
    [Token(Token = "0x400AAA2")] EndAction = 8,
  }
}
