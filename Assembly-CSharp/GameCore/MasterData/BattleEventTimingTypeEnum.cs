// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEventTimingTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EC4")]
  public enum BattleEventTimingTypeEnum
  {
    [Token(Token = "0x40047E9")] ANY_TIME = 1,
    [Token(Token = "0x40047EA")] BEGIN_BATTLE = 2,
    [Token(Token = "0x40047EB")] END_BATTLE = 3,
    [Token(Token = "0x40047EC")] BEGIN_PLAYER_PHASE = 4,
    [Token(Token = "0x40047ED")] END_ACTION = 5,
    [Token(Token = "0x40047EE")] BEGIN_USE_SKILL = 6,
    [Token(Token = "0x40047EF")] END_USE_SKILL = 7,
    [Token(Token = "0x40047F0")] BEGIN_ATTACK = 8,
    [Token(Token = "0x40047F1")] END_ATTACK = 9,
    [Token(Token = "0x40047F2")] END_MOVE = 10, // 0x0000000A
    [Token(Token = "0x40047F3")] DOUBLE = 11, // 0x0000000B
    [Token(Token = "0x40047F4")] DOUBLE_RELEASE = 12, // 0x0000000C
    [Token(Token = "0x40047F5")] BEGIN_INTERACT = 13, // 0x0000000D
    [Token(Token = "0x40047F6")] END_INTERACT = 14, // 0x0000000E
    [Token(Token = "0x40047F7")] UNIT_DEATH = 15, // 0x0000000F
  }
}
