// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEffectValueTypeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EC3")]
  public enum BattleEffectValueTypeEnum
  {
    [Token(Token = "0x40047DF")] Fixed = 0,
    [Token(Token = "0x40047E0")] Ratio = 1,
    [Token(Token = "0x40047E1")] Variable = 2,
    [Token(Token = "0x40047E2")] DistanceProp = 10, // 0x0000000A
    [Token(Token = "0x40047E3")] DistanceInvProp = 11, // 0x0000000B
    [Token(Token = "0x40047E4")] MoveProp = 20, // 0x00000014
    [Token(Token = "0x40047E5")] MoveInvProp = 21, // 0x00000015
    [Token(Token = "0x40047E6")] HPRateProp = 30, // 0x0000001E
    [Token(Token = "0x40047E7")] HPRateInvProp = 31, // 0x0000001F
  }
}
