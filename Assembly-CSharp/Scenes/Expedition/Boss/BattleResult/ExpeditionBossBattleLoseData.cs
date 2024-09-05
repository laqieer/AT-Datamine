// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Boss.BattleResult.ExpeditionBossBattleLoseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Expedition.Boss.BattleResult
{
  [Token(Token = "0x2002D60")]
  public class ExpeditionBossBattleLoseData
  {
    [Token(Token = "0x400C2BD")]
    [FieldOffset(Offset = "0x10")]
    public string StageName;
    [Token(Token = "0x400C2BE")]
    [FieldOffset(Offset = "0x18")]
    public int Level;
    [Token(Token = "0x400C2BF")]
    [FieldOffset(Offset = "0x1C")]
    public int TurnCount;
    [Token(Token = "0x400C2C0")]
    [FieldOffset(Offset = "0x20")]
    public string ElapsedTime;
    [Token(Token = "0x400C2C1")]
    [FieldOffset(Offset = "0x28")]
    public List<BossData> BossDatas;

    [Token(Token = "0x6011BC3")]
    [Address(RVA = "0x42BB8BC", Offset = "0x42BB8BC", VA = "0x42BB8BC")]
    public ExpeditionBossBattleLoseData(
      string stageName,
      int level,
      int turnCount,
      string elapsedTime,
      List<BossData> bossDatas)
    {
    }
  }
}
