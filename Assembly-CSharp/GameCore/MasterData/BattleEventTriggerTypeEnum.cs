// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEventTriggerTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EC5")]
  public enum BattleEventTriggerTypeEnum
  {
    [Token(Token = "0x40047F9")] NOTHING,
    [Token(Token = "0x40047FA")] IS_ALIVE,
    [Token(Token = "0x40047FB")] LIFE_LESS_THAN,
    [Token(Token = "0x40047FC")] GRID_POSITION,
    [Token(Token = "0x40047FD")] IS_ATTACKER,
    [Token(Token = "0x40047FE")] ADJACENT,
    [Token(Token = "0x40047FF")] BARRIER_LESS_THAN,
  }
}
