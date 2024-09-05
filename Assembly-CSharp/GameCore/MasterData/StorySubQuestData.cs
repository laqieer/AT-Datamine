// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001171")]
  [Serializable]
  public sealed class StorySubQuestData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestReleaseConditionData,
    IStoryQuestNumberOfClearsPerDayData
  {
    [Token(Token = "0x4005474")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005475")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x4005476")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x4005477")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int mission;
    [Token(Token = "0x4005478")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x4005479")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x400547A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x400547B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int numberOfClearsPerDay;

    [Token(Token = "0x17000F2E")]
    public int Key
    {
      [Token(Token = "0x6006455"), Address(RVA = "0x4AEED88", Offset = "0x4AEED88", VA = "0x4AEED88", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006456")]
    [Address(RVA = "0x4AEED90", Offset = "0x4AEED90", VA = "0x4AEED90", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006457")]
    [Address(RVA = "0x4AEF0DC", Offset = "0x4AEF0DC", VA = "0x4AEF0DC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006458")]
    [Address(RVA = "0x4AEF1C0", Offset = "0x4AEF1C0", VA = "0x4AEF1C0", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000F2F")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x6006459"), Address(RVA = "0x4AEF1C8", Offset = "0x4AEF1C8", VA = "0x4AEF1C8", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000F30")]
    public int StageId
    {
      [Token(Token = "0x600645A"), Address(RVA = "0x4AEF1D0", Offset = "0x4AEF1D0", VA = "0x4AEF1D0", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F31")]
    public int QuestLevel
    {
      [Token(Token = "0x600645B"), Address(RVA = "0x4AEF1D8", Offset = "0x4AEF1D8", VA = "0x4AEF1D8", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F32")]
    public int MissionId
    {
      [Token(Token = "0x600645C"), Address(RVA = "0x4AEF1E0", Offset = "0x4AEF1E0", VA = "0x4AEF1E0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F33")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x600645D"), Address(RVA = "0x4AEF1E8", Offset = "0x4AEF1E8", VA = "0x4AEF1E8", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F34")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x600645E"), Address(RVA = "0x4AEF1F0", Offset = "0x4AEF1F0", VA = "0x4AEF1F0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600645F")]
    [Address(RVA = "0x4AEF1F8", Offset = "0x4AEF1F8", VA = "0x4AEF1F8", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestReleaseConditionData\u002EGetConditionQuestID()
    {
      return new int();
    }

    [Token(Token = "0x6006460")]
    [Address(RVA = "0x4AEF200", Offset = "0x4AEF200", VA = "0x4AEF200", Slot = "15")]
    private int GameCore\u002EMasterData\u002EIStoryQuestNumberOfClearsPerDayData\u002EGetNumberOfClearsPerDay()
    {
      return new int();
    }

    [Token(Token = "0x6006461")]
    [Address(RVA = "0x4AEF208", Offset = "0x4AEF208", VA = "0x4AEF208")]
    public StorySubQuestData()
    {
    }
  }
}
