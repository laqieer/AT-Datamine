// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryObliviaeQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001162")]
  [Serializable]
  public sealed class StoryObliviaeQuestData : IMasterDataEntity, IStoryQuestData
  {
    [Token(Token = "0x4005445")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005446")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x4005447")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int obliviaeDetailId;
    [Token(Token = "0x4005448")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x4005449")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int mission;
    [Token(Token = "0x400544A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x400544B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x400544C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x400544D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int targetCommunicationGroup;
    [Token(Token = "0x400544E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int targetCommunicationGroupCount;
    [Token(Token = "0x400544F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public bool bossIcon;

    [Token(Token = "0x17000F10")]
    public int Key
    {
      [Token(Token = "0x60063F6"), Address(RVA = "0x4AEC710", Offset = "0x4AEC710", VA = "0x4AEC710", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60063F7")]
    [Address(RVA = "0x4AEC718", Offset = "0x4AEC718", VA = "0x4AEC718", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60063F8")]
    [Address(RVA = "0x4AECB88", Offset = "0x4AECB88", VA = "0x4AECB88", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60063F9")]
    [Address(RVA = "0x4AECC9C", Offset = "0x4AECC9C", VA = "0x4AECC9C", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000F11")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x60063FA"), Address(RVA = "0x4AECCA4", Offset = "0x4AECCA4", VA = "0x4AECCA4", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000F12")]
    public int StageId
    {
      [Token(Token = "0x60063FB"), Address(RVA = "0x4AECCAC", Offset = "0x4AECCAC", VA = "0x4AECCAC", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F13")]
    public int QuestLevel
    {
      [Token(Token = "0x60063FC"), Address(RVA = "0x4AECCB4", Offset = "0x4AECCB4", VA = "0x4AECCB4", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F14")]
    public int MissionId
    {
      [Token(Token = "0x60063FD"), Address(RVA = "0x4AECCBC", Offset = "0x4AECCBC", VA = "0x4AECCBC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F15")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x60063FE"), Address(RVA = "0x4AECCC4", Offset = "0x4AECCC4", VA = "0x4AECCC4", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F16")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x60063FF"), Address(RVA = "0x4AECCCC", Offset = "0x4AECCCC", VA = "0x4AECCCC", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006400")]
    [Address(RVA = "0x4AECCD4", Offset = "0x4AECCD4", VA = "0x4AECCD4")]
    public StoryObliviaeQuestData()
    {
    }
  }
}
