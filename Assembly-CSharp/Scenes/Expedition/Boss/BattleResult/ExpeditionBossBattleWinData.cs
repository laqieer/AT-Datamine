// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Boss.BattleResult.ExpeditionBossBattleWinData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Scenes.Expedition.Boss.BattleResult
{
  [Token(Token = "0x2002D61")]
  public class ExpeditionBossBattleWinData
  {
    [Token(Token = "0x400C2C2")]
    [FieldOffset(Offset = "0x10")]
    public int CurrentLevel;
    [Token(Token = "0x400C2C3")]
    [FieldOffset(Offset = "0x14")]
    public int MaxLevel;
    [Token(Token = "0x400C2C4")]
    [FieldOffset(Offset = "0x18")]
    public APIExpeditionStageBossBattleFinishResponse Response;

    [Token(Token = "0x6011BC4")]
    [Address(RVA = "0x42BB954", Offset = "0x42BB954", VA = "0x42BB954")]
    public ExpeditionBossBattleWinData(
      int currentLevel,
      int maxLevel,
      APIExpeditionStageBossBattleFinishResponse response)
    {
    }
  }
}
