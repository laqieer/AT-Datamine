// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.AccessorySource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002752")]
  public struct AccessorySource
  {
    [Token(Token = "0x400A7F9")]
    [FieldOffset(Offset = "0x0")]
    public string id;
    [Token(Token = "0x400A7FA")]
    [FieldOffset(Offset = "0x8")]
    public UniqueID uniqueId;
    [Token(Token = "0x400A7FB")]
    [FieldOffset(Offset = "0x10")]
    public int masterId;
    [Token(Token = "0x400A7FC")]
    [FieldOffset(Offset = "0x14")]
    public int level;
    [Token(Token = "0x400A7FD")]
    [FieldOffset(Offset = "0x18")]
    public int limitBreak;
    [Token(Token = "0x400A7FE")]
    [FieldOffset(Offset = "0x20")]
    public List<SkillData> skills;
    [Token(Token = "0x400A7FF")]
    [FieldOffset(Offset = "0x28")]
    public List<AccessoryOptionEffect> options;
  }
}
