// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestSubData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200116E")]
  [Serializable]
  public sealed class StoryScenarioQuestSubData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestReleaseConditionData,
    IStoryQuestNumberOfClearsPerDayData
  {
    [Token(Token = "0x400546A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400546B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x400546C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x400546D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int mission;
    [Token(Token = "0x400546E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x400546F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x4005470")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x4005471")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int numberOfClearsPerDay;
    [Token(Token = "0x4005472")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int chapter;

    [Token(Token = "0x17000F27")]
    public int Key
    {
      [Token(Token = "0x600643F"), Address(RVA = "0x4AEE5B4", Offset = "0x4AEE5B4", VA = "0x4AEE5B4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006440")]
    [Address(RVA = "0x4AEE5BC", Offset = "0x4AEE5BC", VA = "0x4AEE5BC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006441")]
    [Address(RVA = "0x4AEE968", Offset = "0x4AEE968", VA = "0x4AEE968", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006442")]
    [Address(RVA = "0x4AEEA5C", Offset = "0x4AEEA5C", VA = "0x4AEEA5C", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000F28")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x6006443"), Address(RVA = "0x4AEEA64", Offset = "0x4AEEA64", VA = "0x4AEEA64", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000F29")]
    public int StageId
    {
      [Token(Token = "0x6006444"), Address(RVA = "0x4AEEA6C", Offset = "0x4AEEA6C", VA = "0x4AEEA6C", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F2A")]
    public int QuestLevel
    {
      [Token(Token = "0x6006445"), Address(RVA = "0x4AEEA74", Offset = "0x4AEEA74", VA = "0x4AEEA74", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F2B")]
    public int MissionId
    {
      [Token(Token = "0x6006446"), Address(RVA = "0x4AEEA7C", Offset = "0x4AEEA7C", VA = "0x4AEEA7C", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F2C")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x6006447"), Address(RVA = "0x4AEEA84", Offset = "0x4AEEA84", VA = "0x4AEEA84", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F2D")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x6006448"), Address(RVA = "0x4AEEA8C", Offset = "0x4AEEA8C", VA = "0x4AEEA8C", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006449")]
    [Address(RVA = "0x4AEEA94", Offset = "0x4AEEA94", VA = "0x4AEEA94", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestReleaseConditionData\u002EGetConditionQuestID()
    {
      return new int();
    }

    [Token(Token = "0x600644A")]
    [Address(RVA = "0x4AEEA9C", Offset = "0x4AEEA9C", VA = "0x4AEEA9C", Slot = "15")]
    private int GameCore\u002EMasterData\u002EIStoryQuestNumberOfClearsPerDayData\u002EGetNumberOfClearsPerDay()
    {
      return new int();
    }

    [Token(Token = "0x600644B")]
    [Address(RVA = "0x4AEEAA4", Offset = "0x4AEEAA4", VA = "0x4AEEAA4")]
    public StoryScenarioQuestSubData()
    {
    }
  }
}
