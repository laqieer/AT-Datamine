// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CSVDateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013CB")]
  public struct CSVDateTime
  {
    [Token(Token = "0x4005C8B")]
    [FieldOffset(Offset = "0x0")]
    public int Year;
    [Token(Token = "0x4005C8C")]
    [FieldOffset(Offset = "0x4")]
    public int Month;
    [Token(Token = "0x4005C8D")]
    [FieldOffset(Offset = "0x8")]
    public int Day;
    [Token(Token = "0x4005C8E")]
    [FieldOffset(Offset = "0xC")]
    public int Hour;
    [Token(Token = "0x4005C8F")]
    [FieldOffset(Offset = "0x10")]
    public int Minute;
    [Token(Token = "0x4005C90")]
    [FieldOffset(Offset = "0x14")]
    public int Second;
    [Token(Token = "0x4005C91")]
    [FieldOffset(Offset = "0x18")]
    public int Millisecond;
    [Token(Token = "0x4005C92")]
    [FieldOffset(Offset = "0x1C")]
    public byte TZSign;
    [Token(Token = "0x4005C93")]
    [FieldOffset(Offset = "0x20")]
    public int TZHour;
    [Token(Token = "0x4005C94")]
    [FieldOffset(Offset = "0x24")]
    public int TZMin;
  }
}
