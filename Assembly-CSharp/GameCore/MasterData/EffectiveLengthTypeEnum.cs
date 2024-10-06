// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EffectiveLengthTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EE4")]
  public enum EffectiveLengthTypeEnum
  {
    [Token(Token = "0x40048F8")] Instant,
    [Token(Token = "0x40048F9")] Permanence,
    [Token(Token = "0x40048FA")] OnActive,
    [Token(Token = "0x40048FB")] ThisPhase,
    [Token(Token = "0x40048FC")] ThisAction,
    [Token(Token = "0x40048FD")] ThisActiveSkill,
    [Token(Token = "0x40048FE")] ThisDuel,
    [Token(Token = "0x40048FF")] SomeTurns,
    [Token(Token = "0x4004900")] SomeTurnsDamage,
    [Token(Token = "0x4004901")] SomeTurnsUntilTakeDamage,
    [Token(Token = "0x4004902")] SomeActions,
    [Token(Token = "0x4004903")] UntilBeginOwnPlayerPhase,
    [Token(Token = "0x4004904")] UntilBeginOwnPlayerPhaseOrTakeDamage,
  }
}
