// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleSortieConditionTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000ECA")]
  public enum BattleSortieConditionTypeEnum
  {
    [Token(Token = "0x4004875")] ATTACK_TO = 1,
    [Token(Token = "0x4004876")] HP_LESS_THAN = 2,
    [Token(Token = "0x4004877")] HP_MORE_THAN = 3,
    [Token(Token = "0x4004878")] UNIT_ACTION_COUNT = 4,
    [Token(Token = "0x4004879")] NEAR_BY_UNIT = 5,
    [Token(Token = "0x400487A")] ANY_UNIT_REACH_AREA = 6,
    [Token(Token = "0x400487B")] UNIT_REACH_AREA = 7,
    [Token(Token = "0x400487C")] FORCE_REACH_AREA = 8,
    [Token(Token = "0x400487D")] UNIT_DAMAGED_COUNT = 9,
    [Token(Token = "0x400487E")] UNIT_USE_SKILL = 10, // 0x0000000A
    [Token(Token = "0x400487F")] UNIT_TAKEN_SKILL = 11, // 0x0000000B
    [Token(Token = "0x4004880")] DEFEAT_UNIT = 12, // 0x0000000C
    [Token(Token = "0x4004881")] DEFEAT_TROOPS = 13, // 0x0000000D
    [Token(Token = "0x4004882")] TURN = 14, // 0x0000000E
  }
}
