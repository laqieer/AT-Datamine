// Decompiled with JetBrains decompiler
// Type: StaqData.Battle.BattleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Battle
{
  [Token(Token = "0x20021BE")]
  public class BattleInfo
  {
    [Token(Token = "0x4008EF1")]
    [FieldOffset(Offset = "0x20")]
    public DateTime TodayClearAt;
    [Token(Token = "0x4008EF2")]
    [FieldOffset(Offset = "0x28")]
    private List<int> achievedMissions;

    [Token(Token = "0x17002CF8")]
    public int QuestID
    {
      [Token(Token = "0x600CE19"), Address(RVA = "0x4B60CC8", Offset = "0x4B60CC8", VA = "0x4B60CC8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CE1A"), Address(RVA = "0x4B60CD0", Offset = "0x4B60CD0", VA = "0x4B60CD0")] private set
      {
      }
    }

    [Token(Token = "0x17002CF9")]
    public int TotalClearCount
    {
      [Token(Token = "0x600CE1B"), Address(RVA = "0x4B60CD8", Offset = "0x4B60CD8", VA = "0x4B60CD8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CE1C"), Address(RVA = "0x4B60CE0", Offset = "0x4B60CE0", VA = "0x4B60CE0")] private set
      {
      }
    }

    [Token(Token = "0x17002CFA")]
    public int TodayClearCount
    {
      [Token(Token = "0x600CE1D"), Address(RVA = "0x4B60CE8", Offset = "0x4B60CE8", VA = "0x4B60CE8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CE1E"), Address(RVA = "0x4B60CF0", Offset = "0x4B60CF0", VA = "0x4B60CF0")] private set
      {
      }
    }

    [Token(Token = "0x17002CFB")]
    public bool IsTotalCleared
    {
      [Token(Token = "0x600CE1F"), Address(RVA = "0x4B60CF8", Offset = "0x4B60CF8", VA = "0x4B60CF8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CFC")]
    public bool IsTodayCleared
    {
      [Token(Token = "0x600CE20"), Address(RVA = "0x4B60D08", Offset = "0x4B60D08", VA = "0x4B60D08")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CFD")]
    public IReadOnlyList<int> AchievedMissions
    {
      [Token(Token = "0x600CE21"), Address(RVA = "0x4B60D18", Offset = "0x4B60D18", VA = "0x4B60D18")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x600CE22")]
    [Address(RVA = "0x4B60D20", Offset = "0x4B60D20", VA = "0x4B60D20")]
    public BattleInfo(PlayerQuestBattleType entity)
    {
    }

    [Token(Token = "0x600CE23")]
    [Address(RVA = "0x4B60D44", Offset = "0x4B60D44", VA = "0x4B60D44")]
    public BattleInfo(int questId, int totalClearCount, int todayClearCount, string countAt)
    {
    }

    [Token(Token = "0x600CE24")]
    [Address(RVA = "0x4B60E20", Offset = "0x4B60E20", VA = "0x4B60E20")]
    public void ApplyTotalClearCount(int totalClearCount)
    {
    }

    [Token(Token = "0x600CE25")]
    [Address(RVA = "0x4B60E28", Offset = "0x4B60E28", VA = "0x4B60E28")]
    public void ApplyTodayClearCount(int todayClearCount, string countAt)
    {
    }

    [Token(Token = "0x600CE26")]
    [Address(RVA = "0x4B60E9C", Offset = "0x4B60E9C", VA = "0x4B60E9C")]
    public void ApplyAchievedMission(PlayerQuestBattleMissionType entity)
    {
    }

    [Token(Token = "0x600CE27")]
    [Address(RVA = "0x4B60EBC", Offset = "0x4B60EBC", VA = "0x4B60EBC")]
    public void ApplyAchievedMission(int missionId, bool achieved)
    {
    }
  }
}
