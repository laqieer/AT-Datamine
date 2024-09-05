// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.NpcActionConditionTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F01")]
  public enum NpcActionConditionTypeEnum
  {
    [Token(Token = "0x4004A65")] NONE = 1,
    [Token(Token = "0x4004A66")] QUEST_TURN_ONE = 2,
    [Token(Token = "0x4004A67")] QUEST_TURN_LOOP = 3,
    [Token(Token = "0x4004A68")] TOTAL_HP_LESS = 4,
    [Token(Token = "0x4004A69")] HP_STOCK_LESS = 5,
    [Token(Token = "0x4004A6A")] SHIELD_COUNT_LESS = 6,
    [Token(Token = "0x4004A6B")] TAKE_BAD_STATUS = 7,
    [Token(Token = "0x4004A6C")] TAKE_BUFF_DEBUFF = 8,
    [Token(Token = "0x4004A6D")] ACTION_COUNT_ONCE = 9,
    [Token(Token = "0x4004A6E")] ACTION_COUNT_LOOP = 10, // 0x0000000A
  }
}
