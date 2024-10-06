// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.WeaponParameterSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200281B")]
  public struct WeaponParameterSource
  {
    [Token(Token = "0x400AB29")]
    [FieldOffset(Offset = "0x0")]
    public WeaponData weapon;
    [Token(Token = "0x400AB2A")]
    [FieldOffset(Offset = "0x8")]
    public SkillParameterData normalAttackParam;
    [Token(Token = "0x400AB2B")]
    [FieldOffset(Offset = "0x10")]
    public List<SkillParameterData> activeSkillParams;
    [Token(Token = "0x400AB2C")]
    [FieldOffset(Offset = "0x18")]
    public List<SkillParameterData> passiveSkillParams;
    [Token(Token = "0x400AB2D")]
    [FieldOffset(Offset = "0x20")]
    public int exp;
    [Token(Token = "0x400AB2E")]
    [FieldOffset(Offset = "0x24")]
    public int durable;
    [Token(Token = "0x400AB2F")]
    [FieldOffset(Offset = "0x28")]
    public WeaponParameterData substitute;
  }
}
