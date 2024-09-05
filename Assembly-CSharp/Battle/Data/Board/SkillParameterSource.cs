// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SkillParameterSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027FF")]
  public struct SkillParameterSource
  {
    [Token(Token = "0x400AA2C")]
    [FieldOffset(Offset = "0x0")]
    public int id;
    [Token(Token = "0x400AA2D")]
    [FieldOffset(Offset = "0x8")]
    public SkillData skill;
    [Token(Token = "0x400AA2E")]
    [FieldOffset(Offset = "0x10")]
    public bool isActive;
    [Token(Token = "0x400AA2F")]
    [FieldOffset(Offset = "0x14")]
    public int usableCount;
    [Token(Token = "0x400AA30")]
    [FieldOffset(Offset = "0x18")]
    public int coolTime;
  }
}
