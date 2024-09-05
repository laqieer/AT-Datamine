// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012F5")]
  [Serializable]
  public sealed class StoryScenarioQuestData : IMasterDataEntity
  {
    [Token(Token = "0x40059BB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059BC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int chapterID;
    [Token(Token = "0x40059BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40059BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int priority;
    [Token(Token = "0x40059BF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int homeADV;
    [Token(Token = "0x40059C0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int bannerID;
    [Token(Token = "0x40059C1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime begin;
    [Token(Token = "0x40059C2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public DateTime end;
    [Token(Token = "0x40059C3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int exchangeID;
    [Token(Token = "0x40059C4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string bgmPackName;
    [Token(Token = "0x40059C5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string bgmName;
    [Token(Token = "0x40059C6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int playConditionType;
    [Token(Token = "0x40059C7")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int playConditionParam1;
    [Token(Token = "0x40059C8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int playConditionParam2;
    [Token(Token = "0x40059C9")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int firstHalfMissionGroupID;
    [Token(Token = "0x40059CA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int firstHalfMissionScheduleID;
    [Token(Token = "0x40059CB")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int secondHalfMissionGroupID;
    [Token(Token = "0x40059CC")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int secondHalfMissionScheduleID;
    [Token(Token = "0x40059CD")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int specialQuestId;
    [Token(Token = "0x40059CE")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int consumeCostFreeDailyCount;
    [Token(Token = "0x40059CF")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int scoreAttackId;

    [Token(Token = "0x17001034")]
    public int Key
    {
      [Token(Token = "0x6006B36"), Address(RVA = "0x48E003C", Offset = "0x48E003C", VA = "0x48E003C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B37")]
    [Address(RVA = "0x48E0044", Offset = "0x48E0044", VA = "0x48E0044", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B38")]
    [Address(RVA = "0x48E0870", Offset = "0x48E0870", VA = "0x48E0870", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B39")]
    [Address(RVA = "0x48E0A84", Offset = "0x48E0A84", VA = "0x48E0A84")]
    public bool IsPlayalbeTime(DateTime current) => new bool();

    [Token(Token = "0x6006B3A")]
    [Address(RVA = "0x48E0B2C", Offset = "0x48E0B2C", VA = "0x48E0B2C")]
    public StoryScenarioQuestData()
    {
    }
  }
}
