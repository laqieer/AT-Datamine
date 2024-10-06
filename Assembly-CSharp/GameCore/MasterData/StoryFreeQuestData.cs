// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001159")]
  [Serializable]
  public sealed class StoryFreeQuestData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestNumberOfClearsPerDayData
  {
    [Token(Token = "0x4005422")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005423")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x4005424")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x4005425")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int mission;
    [Token(Token = "0x4005426")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x4005427")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x4005428")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x4005429")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int numberOfClearsPerDay;
    [Token(Token = "0x400542A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int route;
    [Token(Token = "0x400542B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public QuestDifficultyTypeEnum difficultyType;
    [Token(Token = "0x400542C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x400542D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int questGroupId;
    [Token(Token = "0x400542E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int releaseConditionMainQuestGroupId;
    [Token(Token = "0x400542F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int releaseConditionAreaNodeQuestGroupId;

    [Token(Token = "0x17000EFD")]
    public int Key
    {
      [Token(Token = "0x60063BA"), Address(RVA = "0x4AEABA0", Offset = "0x4AEABA0", VA = "0x4AEABA0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60063BB")]
    [Address(RVA = "0x4AEABA8", Offset = "0x4AEABA8", VA = "0x4AEABA8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60063BC")]
    [Address(RVA = "0x4AEB134", Offset = "0x4AEB134", VA = "0x4AEB134", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60063BD")]
    [Address(RVA = "0x4AEB278", Offset = "0x4AEB278", VA = "0x4AEB278", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000EFE")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x60063BE"), Address(RVA = "0x4AEB280", Offset = "0x4AEB280", VA = "0x4AEB280", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000EFF")]
    public int StageId
    {
      [Token(Token = "0x60063BF"), Address(RVA = "0x4AEB288", Offset = "0x4AEB288", VA = "0x4AEB288", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F00")]
    public int QuestLevel
    {
      [Token(Token = "0x60063C0"), Address(RVA = "0x4AEB290", Offset = "0x4AEB290", VA = "0x4AEB290", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F01")]
    public int MissionId
    {
      [Token(Token = "0x60063C1"), Address(RVA = "0x4AEB298", Offset = "0x4AEB298", VA = "0x4AEB298", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F02")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x60063C2"), Address(RVA = "0x4AEB2A0", Offset = "0x4AEB2A0", VA = "0x4AEB2A0", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F03")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x60063C3"), Address(RVA = "0x4AEB2A8", Offset = "0x4AEB2A8", VA = "0x4AEB2A8", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60063C4")]
    [Address(RVA = "0x4AEB2B0", Offset = "0x4AEB2B0", VA = "0x4AEB2B0", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestNumberOfClearsPerDayData\u002EGetNumberOfClearsPerDay()
    {
      return new int();
    }

    [Token(Token = "0x60063C5")]
    [Address(RVA = "0x4AEB2B8", Offset = "0x4AEB2B8", VA = "0x4AEB2B8")]
    public StoryFreeQuestData()
    {
    }
  }
}
