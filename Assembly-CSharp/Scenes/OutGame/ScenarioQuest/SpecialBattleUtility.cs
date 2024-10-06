// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ScenarioQuest.SpecialBattleUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.ScenarioQuest
{
  [Token(Token = "0x20034FD")]
  internal static class SpecialBattleUtility
  {
    [Token(Token = "0x6014C94")]
    [Address(RVA = "0x1D759C4", Offset = "0x1D759C4", VA = "0x1D759C4")]
    public static SpecialQuestData GetCurrentQuest(SpecialPeriodData periodData)
    {
      return (SpecialQuestData) null;
    }

    [Token(Token = "0x6014C95")]
    [Address(RVA = "0x1D77458", Offset = "0x1D77458", VA = "0x1D77458")]
    public static int GetTodayClearCount(SpecialPeriodData periodData) => new int();

    [Token(Token = "0x170044EE")]
    private static int BossGridSize
    {
      [Token(Token = "0x6014C96"), Address(RVA = "0x1D777C4", Offset = "0x1D777C4", VA = "0x1D777C4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170044EF")]
    public static int MaxBoss
    {
      [Token(Token = "0x6014C97"), Address(RVA = "0x1D7781C", Offset = "0x1D7781C", VA = "0x1D7781C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6014C98")]
    [Address(RVA = "0x1D75D88", Offset = "0x1D75D88", VA = "0x1D75D88")]
    public static (List<int>, ulong) GetBossIDsAndTotalHP(
      BattleData battleData,
      StageLevelData levelData)
    {
      return ();
    }

    [Token(Token = "0x6014C99")]
    [Address(RVA = "0x1D77E40", Offset = "0x1D77E40", VA = "0x1D77E40")]
    public static bool CheckBoss(int gridSize) => new bool();

    [Token(Token = "0x6014C9A")]
    [Address(RVA = "0x1D77874", Offset = "0x1D77874", VA = "0x1D77874")]
    public static (int, int) CreateParam(NpcUnitDataData npc, QuestCorrection correction) => ();

    [Token(Token = "0x6014C9B")]
    [Address(RVA = "0x1D77ED4", Offset = "0x1D77ED4", VA = "0x1D77ED4")]
    static SpecialBattleUtility()
    {
    }
  }
}
