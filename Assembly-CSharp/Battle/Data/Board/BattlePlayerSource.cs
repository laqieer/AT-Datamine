// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BattlePlayerSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002759")]
  public struct BattlePlayerSource
  {
    [Token(Token = "0x400A826")]
    [FieldOffset(Offset = "0x0")]
    public int id;
    [Token(Token = "0x400A827")]
    [FieldOffset(Offset = "0x4")]
    public int clearCondition;
    [Token(Token = "0x400A828")]
    [FieldOffset(Offset = "0x8")]
    public int failedCondition;
    [Token(Token = "0x400A829")]
    [FieldOffset(Offset = "0x10")]
    public List<UnitParameterData> ownedUnits;
    [Token(Token = "0x400A82A")]
    [FieldOffset(Offset = "0x18")]
    public List<UnitParameterData> controlledUnits;
    [Token(Token = "0x400A82B")]
    [FieldOffset(Offset = "0x20")]
    public List<ItemParameterData> itemParams;
    [Token(Token = "0x400A82C")]
    [FieldOffset(Offset = "0x28")]
    public ControllerType controllerType;
    [Token(Token = "0x400A82D")]
    [FieldOffset(Offset = "0x30")]
    public CharacterSupportData supports;
    [Token(Token = "0x400A82E")]
    [FieldOffset(Offset = "0x38")]
    public List<TroopsData> troopses;
    [Token(Token = "0x400A82F")]
    [FieldOffset(Offset = "0x40")]
    public Dictionary<int, int> gottenItemList;
    [Token(Token = "0x400A830")]
    [FieldOffset(Offset = "0x48")]
    public List<int> openedChestIds;
    [Token(Token = "0x400A831")]
    [FieldOffset(Offset = "0x50")]
    public bool isUser;
  }
}
