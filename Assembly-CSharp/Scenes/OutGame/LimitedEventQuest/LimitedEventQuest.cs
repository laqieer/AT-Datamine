// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.LimitedEventQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x200362B")]
  public class LimitedEventQuest : ILimitedEventQuest, IDisposable
  {
    [Token(Token = "0x400EB81")]
    private const int MISSION_MAX = 5;
    [Token(Token = "0x400EB82")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData> topBanners;
    [Token(Token = "0x400EB83")]
    [FieldOffset(Offset = "0x18")]
    private List<Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.BattleStageData> eventStageThumbnailList;
    [Token(Token = "0x400EB84")]
    [FieldOffset(Offset = "0x20")]
    private List<LimitedEventData> openEventMasterDataList;
    [Token(Token = "0x400EB85")]
    [FieldOffset(Offset = "0x28")]
    private bool disposed;
    [Token(Token = "0x400EB86")]
    [FieldOffset(Offset = "0x30")]
    private string bannerServerPath;
    [Token(Token = "0x400EB87")]
    [FieldOffset(Offset = "0x38")]
    private string titleServerPath;
    [Token(Token = "0x400EB88")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, HashSet<(bool clear, BattleMissionData mission)>> missionInformations;
    [Token(Token = "0x400EB89")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<int, HashSet<(int rewardType, List<(RewardTypeEnum type, int Id)> rewards)>> rewardInfomations;
    [Token(Token = "0x400EB8A")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<int, int> questClearCounts;

    [Token(Token = "0x170046F0")]
    public DateTime NowTime
    {
      [Token(Token = "0x6015555"), Address(RVA = "0x4D990A0", Offset = "0x4D990A0", VA = "0x4D990A0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170046F1")]
    public IReadOnlyDictionary<int, Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData> TopBanners
    {
      [Token(Token = "0x6015556"), Address(RVA = "0x4D990F0", Offset = "0x4D990F0", VA = "0x4D990F0", Slot = "5")] get
      {
        return (IReadOnlyDictionary<int, Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData>) null;
      }
    }

    [Token(Token = "0x170046F2")]
    public IReadOnlyList<Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData> TopBannerList
    {
      [Token(Token = "0x6015557"), Address(RVA = "0x4D990F8", Offset = "0x4D990F8", VA = "0x4D990F8", Slot = "4")] get
      {
        return (IReadOnlyList<Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.TopBannerData>) null;
      }
    }

    [Token(Token = "0x170046F3")]
    public IReadOnlyList<Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.BattleStageData> EventStageThumbnailList
    {
      [Token(Token = "0x6015558"), Address(RVA = "0x4D99164", Offset = "0x4D99164", VA = "0x4D99164", Slot = "6")] get
      {
        return (IReadOnlyList<Scenes.OutGame.LimitedEventQuest.LimitedEventQuest.BattleStageData>) null;
      }
    }

    [Token(Token = "0x6015559")]
    [Address(RVA = "0x4D9916C", Offset = "0x4D9916C", VA = "0x4D9916C")]
    public LimitedEventQuest(string bannerServerPath, string titleServerPath)
    {
    }

    [Token(Token = "0x601555A")]
    [Address(RVA = "0x4D99850", Offset = "0x4D99850", VA = "0x4D99850", Slot = "15")]
    public void Dispose()
    {
    }

    [Token(Token = "0x601555B")]
    [Address(RVA = "0x4D99904", Offset = "0x4D99904", VA = "0x4D99904", Slot = "8")]
    public void Release()
    {
    }

    [Token(Token = "0x601555C")]
    [Address(RVA = "0x4D99E2C", Offset = "0x4D99E2C", VA = "0x4D99E2C", Slot = "9")]
    public void CreateTopBannerDataList()
    {
    }

    [Token(Token = "0x601555D")]
    [Address(RVA = "0x4D9991C", Offset = "0x4D9991C", VA = "0x4D9991C")]
    private void ReleaseTopBannerDataList()
    {
    }

    [Token(Token = "0x601555E")]
    [Address(RVA = "0x4D9A494", Offset = "0x4D9A494", VA = "0x4D9A494", Slot = "10")]
    public void CreateEventStageThumbnailDataList(int eventId)
    {
    }

    [Token(Token = "0x601555F")]
    [Address(RVA = "0x4D9AB84", Offset = "0x4D9AB84", VA = "0x4D9AB84", Slot = "11")]
    public void ReleaseEventStageThumbnailDataList()
    {
    }

    [Token(Token = "0x6015560")]
    [Address(RVA = "0x4D9AD08", Offset = "0x4D9AD08", VA = "0x4D9AD08", Slot = "13")]
    public void CreateEventStageDataList(int eventId)
    {
    }

    [Token(Token = "0x6015561")]
    [Address(RVA = "0x4D99AF8", Offset = "0x4D99AF8", VA = "0x4D99AF8", Slot = "14")]
    public void ReleaseEventStageDataList()
    {
    }

    [Token(Token = "0x6015562")]
    [Address(RVA = "0x4D9935C", Offset = "0x4D9935C", VA = "0x4D9935C")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6015563")]
    [Address(RVA = "0x4D9AF30", Offset = "0x4D9AF30", VA = "0x4D9AF30")]
    private void AddEventStageData(int limitedEventQuestId)
    {
    }

    [Token(Token = "0x6015564")]
    [Address(RVA = "0x4D9CA20", Offset = "0x4D9CA20", VA = "0x4D9CA20", Slot = "12")]
    public (int, int)? GetOpenLeftTime(DateTime? checkTime) => new (int, int)?();

    [Token(Token = "0x6015565")]
    [Address(RVA = "0x4D9A37C", Offset = "0x4D9A37C", VA = "0x4D9A37C")]
    private string GetBannerUrl(int eventId) => (string) null;

    [Token(Token = "0x6015566")]
    [Address(RVA = "0x4D9A408", Offset = "0x4D9A408", VA = "0x4D9A408")]
    private string GetTitleUrl(int eventId) => (string) null;

    [Token(Token = "0x200362C")]
    public class TopBannerData
    {
      [Token(Token = "0x400EB8B")]
      [FieldOffset(Offset = "0x10")]
      public int EventId;
      [Token(Token = "0x400EB8C")]
      [FieldOffset(Offset = "0x18")]
      public DateTime? EndAt;
      [Token(Token = "0x400EB8D")]
      [FieldOffset(Offset = "0x28")]
      public int StaminaItemId;
      [Token(Token = "0x400EB8E")]
      [FieldOffset(Offset = "0x2C")]
      public int ShopId;
      [Token(Token = "0x400EB8F")]
      [FieldOffset(Offset = "0x30")]
      public int ExchangeId;
      [Token(Token = "0x400EB90")]
      [FieldOffset(Offset = "0x34")]
      public int MissionId;
      [Token(Token = "0x400EB91")]
      [FieldOffset(Offset = "0x38")]
      public int StaminaItemHolds;
      [Token(Token = "0x400EB92")]
      [FieldOffset(Offset = "0x3C")]
      public int StaminaItemReplenishmentCount;
      [Token(Token = "0x400EB93")]
      [FieldOffset(Offset = "0x40")]
      public BattleComsumeCostTypeEnum comsumeCostType;
      [Token(Token = "0x400EB94")]
      [FieldOffset(Offset = "0x48")]
      public string BannerUrl;
      [Token(Token = "0x400EB95")]
      [FieldOffset(Offset = "0x50")]
      public string TitleUrl;
      [Token(Token = "0x400EB96")]
      [FieldOffset(Offset = "0x58")]
      public Sprite StaminaItemSprite;

      [Token(Token = "0x6015567")]
      [Address(RVA = "0x4D9A374", Offset = "0x4D9A374", VA = "0x4D9A374")]
      public TopBannerData()
      {
      }
    }

    [Token(Token = "0x200362D")]
    public class BattleStageData
    {
      [Token(Token = "0x400EB97")]
      [FieldOffset(Offset = "0x10")]
      public int EventStageId;
      [Token(Token = "0x400EB98")]
      [FieldOffset(Offset = "0x14")]
      public int QuestStageId;
      [Token(Token = "0x400EB99")]
      [FieldOffset(Offset = "0x18")]
      public int ConsumeCost;
      [Token(Token = "0x400EB9A")]
      [FieldOffset(Offset = "0x1C")]
      public BattleComsumeCostTypeEnum ConsumeCostType;
      [Token(Token = "0x400EB9B")]
      [FieldOffset(Offset = "0x20")]
      public int ConsumeCostItemId;
      [Token(Token = "0x400EB9C")]
      [FieldOffset(Offset = "0x28")]
      public string StageName;
      [Token(Token = "0x400EB9D")]
      [FieldOffset(Offset = "0x30")]
      public DateTime? StartAt;
      [Token(Token = "0x400EB9E")]
      [FieldOffset(Offset = "0x40")]
      public DateTime? EndAt;
      [Token(Token = "0x400EB9F")]
      [FieldOffset(Offset = "0x50")]
      public List<bool> MissionClearIndexes;
      [Token(Token = "0x400EBA0")]
      [FieldOffset(Offset = "0x58")]
      public bool IsStageLock;
      [Token(Token = "0x400EBA1")]
      [FieldOffset(Offset = "0x59")]
      public bool BossIcon;
      [Token(Token = "0x400EBA2")]
      [FieldOffset(Offset = "0x60")]
      public HashSet<(int rewardType, List<(RewardTypeEnum type, int Id)> rewards)> Reawrds;
      [Token(Token = "0x400EBA3")]
      [FieldOffset(Offset = "0x68")]
      public Sprite ThumbnailSprite;

      [Token(Token = "0x6015568")]
      [Address(RVA = "0x4D9AD00", Offset = "0x4D9AD00", VA = "0x4D9AD00")]
      public BattleStageData()
      {
      }
    }

    [Token(Token = "0x200362E")]
    public enum RewardType
    {
      [Token(Token = "0x400EBA5")] FirstClear,
      [Token(Token = "0x400EBA6")] Clear,
      [Token(Token = "0x400EBA7")] Mission,
      [Token(Token = "0x400EBA8")] Drop,
      [Token(Token = "0x400EBA9")] Max,
    }
  }
}
