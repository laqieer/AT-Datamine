// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.WeaponSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002818")]
  public struct WeaponSource
  {
    [Token(Token = "0x400AB10")]
    [FieldOffset(Offset = "0x0")]
    public string id;
    [Token(Token = "0x400AB11")]
    [FieldOffset(Offset = "0x8")]
    public int masterId;
    [Token(Token = "0x400AB12")]
    [FieldOffset(Offset = "0x10")]
    public UniqueID uniqueId;
    [Token(Token = "0x400AB13")]
    [FieldOffset(Offset = "0x18")]
    public int startExp;
    [Token(Token = "0x400AB14")]
    [FieldOffset(Offset = "0x1C")]
    public int startDurable;
    [Token(Token = "0x400AB15")]
    [FieldOffset(Offset = "0x20")]
    public int limitBreak;
    [Token(Token = "0x400AB16")]
    [FieldOffset(Offset = "0x28")]
    public List<SkillData> skills;
    [Token(Token = "0x400AB17")]
    [FieldOffset(Offset = "0x30")]
    public List<WeaponOptionEffect> options;
    [Token(Token = "0x400AB18")]
    [FieldOffset(Offset = "0x38")]
    public BattleParameter masterOffset;
    [Token(Token = "0x400AB19")]
    [FieldOffset(Offset = "0x40")]
    public WeaponData substitute;
  }
}
