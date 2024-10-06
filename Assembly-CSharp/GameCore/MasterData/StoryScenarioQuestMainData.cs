// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestMainData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200116A")]
  [Serializable]
  public sealed class StoryScenarioQuestMainData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestReleaseConditionData,
    IStoryQuestNumberOfClearsPerDayData
  {
    [Token(Token = "0x400545F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005460")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x4005461")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x4005462")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x4005463")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x4005464")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x4005465")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int numberOfClearsPerDay;
    [Token(Token = "0x4005466")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int storyBattleMissionSetID;
    [Token(Token = "0x4005467")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int chapter;

    [Token(Token = "0x17000F20")]
    public int Key
    {
      [Token(Token = "0x6006427"), Address(RVA = "0x4AEDCE8", Offset = "0x4AEDCE8", VA = "0x4AEDCE8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006428")]
    [Address(RVA = "0x4AEDCF0", Offset = "0x4AEDCF0", VA = "0x4AEDCF0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006429")]
    [Address(RVA = "0x4AEE09C", Offset = "0x4AEE09C", VA = "0x4AEE09C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600642A")]
    [Address(RVA = "0x4AEE190", Offset = "0x4AEE190", VA = "0x4AEE190", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000F21")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x600642B"), Address(RVA = "0x4AEE198", Offset = "0x4AEE198", VA = "0x4AEE198", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000F22")]
    public int StageId
    {
      [Token(Token = "0x600642C"), Address(RVA = "0x4AEE1A0", Offset = "0x4AEE1A0", VA = "0x4AEE1A0", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F23")]
    public int QuestLevel
    {
      [Token(Token = "0x600642D"), Address(RVA = "0x4AEE1A8", Offset = "0x4AEE1A8", VA = "0x4AEE1A8", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F24")]
    public int MissionId
    {
      [Token(Token = "0x600642E"), Address(RVA = "0x4AEE1B0", Offset = "0x4AEE1B0", VA = "0x4AEE1B0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F25")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x600642F"), Address(RVA = "0x4AEE1B8", Offset = "0x4AEE1B8", VA = "0x4AEE1B8", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F26")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x6006430"), Address(RVA = "0x4AEE1C0", Offset = "0x4AEE1C0", VA = "0x4AEE1C0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006431")]
    [Address(RVA = "0x4AEE1C8", Offset = "0x4AEE1C8", VA = "0x4AEE1C8", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestReleaseConditionData\u002EGetConditionQuestID()
    {
      return new int();
    }

    [Token(Token = "0x6006432")]
    [Address(RVA = "0x4AEE1D0", Offset = "0x4AEE1D0", VA = "0x4AEE1D0", Slot = "15")]
    private int GameCore\u002EMasterData\u002EIStoryQuestNumberOfClearsPerDayData\u002EGetNumberOfClearsPerDay()
    {
      return new int();
    }

    [Token(Token = "0x6006433")]
    [Address(RVA = "0x4AEE1D8", Offset = "0x4AEE1D8", VA = "0x4AEE1D8")]
    public StoryScenarioQuestMainData()
    {
    }
  }
}
