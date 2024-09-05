// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestFreeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001166")]
  [Serializable]
  public sealed class StoryScenarioQuestFreeData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestReleaseConditionData,
    IStoryQuestNumberOfClearsPerDayData
  {
    [Token(Token = "0x4005452")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005453")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x4005454")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x4005455")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int mission;
    [Token(Token = "0x4005456")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x4005457")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x4005458")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x4005459")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int numberOfClearsPerDay;
    [Token(Token = "0x400545A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int route;
    [Token(Token = "0x400545B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public QuestDifficultyTypeEnum difficultyType;
    [Token(Token = "0x400545C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int chapter;

    [Token(Token = "0x17000F17")]
    public int Key
    {
      [Token(Token = "0x600640D"), Address(RVA = "0x4AED100", Offset = "0x4AED100", VA = "0x4AED100", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600640E")]
    [Address(RVA = "0x4AED108", Offset = "0x4AED108", VA = "0x4AED108", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600640F")]
    [Address(RVA = "0x4AED574", Offset = "0x4AED574", VA = "0x4AED574", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006410")]
    [Address(RVA = "0x4AED688", Offset = "0x4AED688", VA = "0x4AED688", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000F18")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x6006411"), Address(RVA = "0x4AED690", Offset = "0x4AED690", VA = "0x4AED690", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000F19")]
    public int StageId
    {
      [Token(Token = "0x6006412"), Address(RVA = "0x4AED698", Offset = "0x4AED698", VA = "0x4AED698", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F1A")]
    public int QuestLevel
    {
      [Token(Token = "0x6006413"), Address(RVA = "0x4AED6A0", Offset = "0x4AED6A0", VA = "0x4AED6A0", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F1B")]
    public int MissionId
    {
      [Token(Token = "0x6006414"), Address(RVA = "0x4AED6A8", Offset = "0x4AED6A8", VA = "0x4AED6A8", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F1C")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x6006415"), Address(RVA = "0x4AED6B0", Offset = "0x4AED6B0", VA = "0x4AED6B0", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F1D")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x6006416"), Address(RVA = "0x4AED6B8", Offset = "0x4AED6B8", VA = "0x4AED6B8", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006417")]
    [Address(RVA = "0x4AED6C0", Offset = "0x4AED6C0", VA = "0x4AED6C0", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestReleaseConditionData\u002EGetConditionQuestID()
    {
      return new int();
    }

    [Token(Token = "0x6006418")]
    [Address(RVA = "0x4AED6C8", Offset = "0x4AED6C8", VA = "0x4AED6C8", Slot = "15")]
    private int GameCore\u002EMasterData\u002EIStoryQuestNumberOfClearsPerDayData\u002EGetNumberOfClearsPerDay()
    {
      return new int();
    }

    [Token(Token = "0x17000F1E")]
    public bool IsEndPlayable
    {
      [Token(Token = "0x6006419"), Address(RVA = "0x4AED6D0", Offset = "0x4AED6D0", VA = "0x4AED6D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000F1F")]
    public bool IsNotPlayable
    {
      [Token(Token = "0x600641A"), Address(RVA = "0x4AED7D0", Offset = "0x4AED7D0", VA = "0x4AED7D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600641B")]
    [Address(RVA = "0x4AED90C", Offset = "0x4AED90C", VA = "0x4AED90C")]
    public StoryScenarioQuestFreeData()
    {
    }
  }
}
