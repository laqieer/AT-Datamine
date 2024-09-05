// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200115E")]
  [Serializable]
  public sealed class StoryMainQuestData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestNumberOfClearsPerDayData
  {
    [Token(Token = "0x4005439")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400543A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x400543B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x400543C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x400543D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x400543E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x400543F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int numberOfClearsPerDay;
    [Token(Token = "0x4005440")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int storyBattleMissionSetID;
    [Token(Token = "0x4005441")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public QuestDifficultyTypeEnum difficultyType;
    [Token(Token = "0x4005442")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int questGroupId;

    [Token(Token = "0x17000F09")]
    public int Key
    {
      [Token(Token = "0x60063DE"), Address(RVA = "0x4AEBD8C", Offset = "0x4AEBD8C", VA = "0x4AEBD8C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60063DF")]
    [Address(RVA = "0x4AEBD94", Offset = "0x4AEBD94", VA = "0x4AEBD94", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60063E0")]
    [Address(RVA = "0x4AEC1A0", Offset = "0x4AEC1A0", VA = "0x4AEC1A0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60063E1")]
    [Address(RVA = "0x4AEC2A4", Offset = "0x4AEC2A4", VA = "0x4AEC2A4", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000F0A")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x60063E2"), Address(RVA = "0x4AEC2AC", Offset = "0x4AEC2AC", VA = "0x4AEC2AC", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000F0B")]
    public int StageId
    {
      [Token(Token = "0x60063E3"), Address(RVA = "0x4AEC2B4", Offset = "0x4AEC2B4", VA = "0x4AEC2B4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F0C")]
    public int QuestLevel
    {
      [Token(Token = "0x60063E4"), Address(RVA = "0x4AEC2BC", Offset = "0x4AEC2BC", VA = "0x4AEC2BC", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F0D")]
    public int MissionId
    {
      [Token(Token = "0x60063E5"), Address(RVA = "0x4AEC2C4", Offset = "0x4AEC2C4", VA = "0x4AEC2C4", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F0E")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x60063E6"), Address(RVA = "0x4AEC2CC", Offset = "0x4AEC2CC", VA = "0x4AEC2CC", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F0F")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x60063E7"), Address(RVA = "0x4AEC2D4", Offset = "0x4AEC2D4", VA = "0x4AEC2D4", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60063E8")]
    [Address(RVA = "0x4AEC2DC", Offset = "0x4AEC2DC", VA = "0x4AEC2DC", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestNumberOfClearsPerDayData\u002EGetNumberOfClearsPerDay()
    {
      return new int();
    }

    [Token(Token = "0x60063E9")]
    [Address(RVA = "0x4AEC2E4", Offset = "0x4AEC2E4", VA = "0x4AEC2E4")]
    public StoryMainQuestData()
    {
    }
  }
}
