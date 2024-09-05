// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CSVParser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013CC")]
  public struct CSVParser
  {
    [Token(Token = "0x4005C95")]
    [FieldOffset(Offset = "0x0")]
    public bool Literal;
    [Token(Token = "0x4005C96")]
    [FieldOffset(Offset = "0x1")]
    public bool ColumnStart;
    [Token(Token = "0x4005C97")]
    [FieldOffset(Offset = "0x2")]
    public bool DoubleQuote;
    [Token(Token = "0x4005C98")]
    [FieldOffset(Offset = "0x3")]
    public bool CarriageReturn;
    [Token(Token = "0x4005C99")]
    [FieldOffset(Offset = "0x4")]
    public bool StackEnabled;
    [Token(Token = "0x4005C9A")]
    [FieldOffset(Offset = "0x5")]
    public bool LoadBuffer;
    [Token(Token = "0x4005C9B")]
    [FieldOffset(Offset = "0x6")]
    public bool ColumnLast;
    [Token(Token = "0x4005C9C")]
    [FieldOffset(Offset = "0x7")]
    public byte StackValue;
    [Token(Token = "0x4005C9D")]
    [FieldOffset(Offset = "0x8")]
    public int Length;
    [Token(Token = "0x4005C9E")]
    [FieldOffset(Offset = "0xC")]
    public int Fetch;
    [Token(Token = "0x4005C9F")]
    [FieldOffset(Offset = "0x10")]
    public int Read;
    [Token(Token = "0x4005CA0")]
    [FieldOffset(Offset = "0x14")]
    public int ColumnOffset;
    [Token(Token = "0x4005CA1")]
    [FieldOffset(Offset = "0x18")]
    public int ColumnLength;
  }
}
