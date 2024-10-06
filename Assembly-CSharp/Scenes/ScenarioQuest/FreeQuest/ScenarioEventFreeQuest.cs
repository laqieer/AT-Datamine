// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.FreeQuest.ScenarioEventFreeQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.FreeQuest
{
  [Token(Token = "0x200296D")]
  public class ScenarioEventFreeQuest : IScenarioEventFreeQuest, IDisposable
  {
    [Token(Token = "0x400B077")]
    [FieldOffset(Offset = "0x10")]
    private List<ScenarioEventFreeQuest.BattleStageData> eventStageThumbnailList;
    [Token(Token = "0x400B078")]
    [FieldOffset(Offset = "0x18")]
    private int chapterId;
    [Token(Token = "0x400B079")]
    [FieldOffset(Offset = "0x1C")]
    private bool disposed;
    [Token(Token = "0x400B07A")]
    private const int MISSION_MAX = 5;
    [Token(Token = "0x400B07B")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, HashSet<(bool clear, BattleMissionData mission)>> missionInformations;
    [Token(Token = "0x400B07C")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<int, HashSet<(int rewardType, List<(RewardTypeEnum type, int Id)> rewards)>> rewardInfomations;
    [Token(Token = "0x400B07D")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<int, int> questClearCounts;

    [Token(Token = "0x170038FA")]
    public DateTime NowTime
    {
      [Token(Token = "0x6010498"), Address(RVA = "0x47576D0", Offset = "0x47576D0", VA = "0x47576D0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170038FB")]
    public IReadOnlyList<ScenarioEventFreeQuest.BattleStageData> EventStageThumbnailList
    {
      [Token(Token = "0x6010499"), Address(RVA = "0x4757720", Offset = "0x4757720", VA = "0x4757720", Slot = "4")] get
      {
        return (IReadOnlyList<ScenarioEventFreeQuest.BattleStageData>) null;
      }
    }

    [Token(Token = "0x601049A")]
    [Address(RVA = "0x4757728", Offset = "0x4757728", VA = "0x4757728")]
    public ScenarioEventFreeQuest(int chapterId)
    {
    }

    [Token(Token = "0x601049B")]
    [Address(RVA = "0x4757888", Offset = "0x4757888", VA = "0x4757888", Slot = "12")]
    public void Dispose()
    {
    }

    [Token(Token = "0x601049C")]
    [Address(RVA = "0x4757934", Offset = "0x4757934", VA = "0x4757934", Slot = "6")]
    public void Release()
    {
    }

    [Token(Token = "0x601049D")]
    [Address(RVA = "0x4757C6C", Offset = "0x4757C6C", VA = "0x4757C6C", Slot = "7")]
    public void CreateEventStageThumbnailDataList()
    {
    }

    [Token(Token = "0x601049E")]
    [Address(RVA = "0x4758220", Offset = "0x4758220", VA = "0x4758220", Slot = "8")]
    public void ReleaseEventStageThumbnailDataList()
    {
    }

    [Token(Token = "0x601049F")]
    [Address(RVA = "0x475841C", Offset = "0x475841C", VA = "0x475841C", Slot = "10")]
    public void CreateEventStageDataList()
    {
    }

    [Token(Token = "0x60104A0")]
    [Address(RVA = "0x4757938", Offset = "0x4757938", VA = "0x4757938", Slot = "11")]
    public void ReleaseEventStageDataList()
    {
    }

    [Token(Token = "0x60104A1")]
    [Address(RVA = "0x4757884", Offset = "0x4757884", VA = "0x4757884")]
    private void Initialize()
    {
    }

    [Token(Token = "0x60104A2")]
    [Address(RVA = "0x4758638", Offset = "0x4758638", VA = "0x4758638")]
    private void AddEventStageData(int questId)
    {
    }

    [Token(Token = "0x60104A3")]
    [Address(RVA = "0x475A128", Offset = "0x475A128", VA = "0x475A128", Slot = "9")]
    public (int, int)? GetOpenLeftTime(DateTime? checkTime) => new (int, int)?();

    [Token(Token = "0x200296E")]
    public class BattleStageData
    {
      [Token(Token = "0x400B07E")]
      [FieldOffset(Offset = "0x10")]
      public int EventStageId;
      [Token(Token = "0x400B07F")]
      [FieldOffset(Offset = "0x14")]
      public int QuestStageId;
      [Token(Token = "0x400B080")]
      [FieldOffset(Offset = "0x18")]
      public int ConsumeCost;
      [Token(Token = "0x400B081")]
      [FieldOffset(Offset = "0x20")]
      public string StageName;
      [Token(Token = "0x400B082")]
      [FieldOffset(Offset = "0x28")]
      public DateTime? StartAt;
      [Token(Token = "0x400B083")]
      [FieldOffset(Offset = "0x38")]
      public DateTime? EndAt;
      [Token(Token = "0x400B084")]
      [FieldOffset(Offset = "0x48")]
      public List<bool> MissionClearIndexes;
      [Token(Token = "0x400B085")]
      [FieldOffset(Offset = "0x50")]
      public bool IsStageLock;
      [Token(Token = "0x400B086")]
      [FieldOffset(Offset = "0x51")]
      public bool BossIcon;
      [Token(Token = "0x400B087")]
      [FieldOffset(Offset = "0x58")]
      public HashSet<(int rewardType, List<(RewardTypeEnum type, int Id)> rewards)> Reawrds;
      [Token(Token = "0x400B088")]
      [FieldOffset(Offset = "0x60")]
      public Sprite ThumbnailSprite;

      [Token(Token = "0x60104A4")]
      [Address(RVA = "0x4758414", Offset = "0x4758414", VA = "0x4758414")]
      public BattleStageData()
      {
      }
    }

    [Token(Token = "0x200296F")]
    public enum RewardType
    {
      [Token(Token = "0x400B08A")] FirstClear,
      [Token(Token = "0x400B08B")] Clear,
      [Token(Token = "0x400B08C")] Mission,
      [Token(Token = "0x400B08D")] Drop,
      [Token(Token = "0x400B08E")] Max,
    }
  }
}
