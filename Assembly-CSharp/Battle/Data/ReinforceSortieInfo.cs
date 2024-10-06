// Decompiled with JetBrains decompiler
// Type: Battle.Data.ReinforceSortieInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002730")]
  public struct ReinforceSortieInfo
  {
    [Token(Token = "0x400A79A")]
    [FieldOffset(Offset = "0x0")]
    public UnitParameterData Unit;
    [Token(Token = "0x400A79B")]
    [FieldOffset(Offset = "0x8")]
    public int ToX;
    [Token(Token = "0x400A79C")]
    [FieldOffset(Offset = "0xC")]
    public int ToY;
    [Token(Token = "0x400A79D")]
    [FieldOffset(Offset = "0x10")]
    public int FromX;
    [Token(Token = "0x400A79E")]
    [FieldOffset(Offset = "0x14")]
    public int FromY;
  }
}
