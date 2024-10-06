// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LimitedEventQuestStageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001122")]
  [Serializable]
  public sealed class LimitedEventQuestStageData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestReleaseConditionData,
    IStoryQuestNumberOfClearsPerDayData
  {
    [Token(Token = "0x4005355")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005356")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int eventId;
    [Token(Token = "0x4005357")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x4005358")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x4005359")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x400535A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x400535B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x400535C")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x400535D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int missionRewardGroupID;
    [Token(Token = "0x400535E")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int dropRewardGroupID;
    [Token(Token = "0x400535F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int battleMissionSet;
    [Token(Token = "0x4005360")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x4005361")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int numberOfClearsPerDay;
    [Token(Token = "0x4005362")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public bool bossIcon;
    [Token(Token = "0x4005363")]
    [FieldOffset(Offset = "0x0")]
    private static readonly DateTime DefaultStartAt;
    [Token(Token = "0x4005364")]
    [FieldOffset(Offset = "0x8")]
    private static readonly DateTime DefaultEndAt;

    [Token(Token = "0x17000EB8")]
    public int Key
    {
      [Token(Token = "0x6006297"), Address(RVA = "0x4AE0228", Offset = "0x4AE0228", VA = "0x4AE0228", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006298")]
    [Address(RVA = "0x4AE0230", Offset = "0x4AE0230", VA = "0x4AE0230", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006299")]
    [Address(RVA = "0x4AE07C0", Offset = "0x4AE07C0", VA = "0x4AE07C0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EB9")]
    public bool IsDefaultStartAt
    {
      [Token(Token = "0x600629A"), Address(RVA = "0x4AE0958", Offset = "0x4AE0958", VA = "0x4AE0958")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EBA")]
    public bool IsDefaultEndAt
    {
      [Token(Token = "0x600629B"), Address(RVA = "0x4AE09EC", Offset = "0x4AE09EC", VA = "0x4AE09EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600629C")]
    [Address(RVA = "0x4AE0A80", Offset = "0x4AE0A80", VA = "0x4AE0A80", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000EBB")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x600629D"), Address(RVA = "0x4AE0A88", Offset = "0x4AE0A88", VA = "0x4AE0A88", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000EBC")]
    public int StageId
    {
      [Token(Token = "0x600629E"), Address(RVA = "0x4AE0A90", Offset = "0x4AE0A90", VA = "0x4AE0A90", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EBD")]
    public int QuestLevel
    {
      [Token(Token = "0x600629F"), Address(RVA = "0x4AE0A98", Offset = "0x4AE0A98", VA = "0x4AE0A98", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EBE")]
    public int MissionId
    {
      [Token(Token = "0x60062A0"), Address(RVA = "0x4AE0AA0", Offset = "0x4AE0AA0", VA = "0x4AE0AA0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EBF")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x60062A1"), Address(RVA = "0x4AE0AA8", Offset = "0x4AE0AA8", VA = "0x4AE0AA8", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EC0")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x60062A2"), Address(RVA = "0x4AE0AB0", Offset = "0x4AE0AB0", VA = "0x4AE0AB0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062A3")]
    [Address(RVA = "0x4AE0AB8", Offset = "0x4AE0AB8", VA = "0x4AE0AB8", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestReleaseConditionData\u002EGetConditionQuestID()
    {
      return new int();
    }

    [Token(Token = "0x60062A4")]
    [Address(RVA = "0x4AE0AC0", Offset = "0x4AE0AC0", VA = "0x4AE0AC0", Slot = "15")]
    private int GameCore\u002EMasterData\u002EIStoryQuestNumberOfClearsPerDayData\u002EGetNumberOfClearsPerDay()
    {
      return new int();
    }

    [Token(Token = "0x60062A5")]
    [Address(RVA = "0x4AE0AC8", Offset = "0x4AE0AC8", VA = "0x4AE0AC8")]
    public LimitedEventQuestStageData()
    {
    }

    [Token(Token = "0x60062A6")]
    [Address(RVA = "0x4AE0AD0", Offset = "0x4AE0AD0", VA = "0x4AE0AD0")]
    static LimitedEventQuestStageData()
    {
    }
  }
}
