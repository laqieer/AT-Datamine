// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillTriggerTimingTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F1E")]
  public enum SkillTriggerTimingTypeEnum
  {
    [Token(Token = "0x4004B80")] AnyTime = 1,
    [Token(Token = "0x4004B81")] BattleStart = 2,
    [Token(Token = "0x4004B82")] TurnStart = 3,
    [Token(Token = "0x4004B83")] PhaseStart = 4,
    [Token(Token = "0x4004B84")] PreAttack = 5,
    [Token(Token = "0x4004B85")] PostAttack = 6,
    [Token(Token = "0x4004B86")] ActionStart = 7,
    [Token(Token = "0x4004B87")] ActionEnd = 8,
    [Token(Token = "0x4004B88")] PreDuel = 9,
    [Token(Token = "0x4004B89")] PostDuel = 10, // 0x0000000A
    [Token(Token = "0x4004B8A")] ActiveSkill = 11, // 0x0000000B
    [Token(Token = "0x4004B8B")] Stay = 12, // 0x0000000C
    [Token(Token = "0x4004B8C")] PreActiveSkill = 13, // 0x0000000D
    [Token(Token = "0x4004B8D")] PostActiveSkill = 14, // 0x0000000E
    [Token(Token = "0x4004B8E")] PreEffect = 101, // 0x00000065
    [Token(Token = "0x4004B8F")] MainEffect = 102, // 0x00000066
    [Token(Token = "0x4004B90")] PostEffect = 103, // 0x00000067
  }
}
