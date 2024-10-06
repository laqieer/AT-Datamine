// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpecialQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001151")]
  [Serializable]
  public sealed class SpecialQuestData : 
    IMasterDataEntity,
    IStoryQuestData,
    IStoryQuestReleaseConditionData
  {
    [Token(Token = "0x4005403")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005404")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x4005405")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x4005406")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int questLevel;
    [Token(Token = "0x4005407")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x4005408")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x4005409")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int releaseConditionQuest;
    [Token(Token = "0x400540A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int periodID;
    [Token(Token = "0x400540B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int scenarioQuestID;

    [Token(Token = "0x17000EF5")]
    public int Key
    {
      [Token(Token = "0x6006388"), Address(RVA = "0x4AE8FE8", Offset = "0x4AE8FE8", VA = "0x4AE8FE8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006389")]
    [Address(RVA = "0x4AE8FF0", Offset = "0x4AE8FF0", VA = "0x4AE8FF0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600638A")]
    [Address(RVA = "0x4AE939C", Offset = "0x4AE939C", VA = "0x4AE939C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600638B")]
    [Address(RVA = "0x4AE9490", Offset = "0x4AE9490", VA = "0x4AE9490", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000EF6")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x600638C"), Address(RVA = "0x4AE9498", Offset = "0x4AE9498", VA = "0x4AE9498", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000EF7")]
    public int StageId
    {
      [Token(Token = "0x600638D"), Address(RVA = "0x4AE94A0", Offset = "0x4AE94A0", VA = "0x4AE94A0", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF8")]
    public int QuestLevel
    {
      [Token(Token = "0x600638E"), Address(RVA = "0x4AE94A8", Offset = "0x4AE94A8", VA = "0x4AE94A8", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF9")]
    public int MissionId
    {
      [Token(Token = "0x600638F"), Address(RVA = "0x4AE94B0", Offset = "0x4AE94B0", VA = "0x4AE94B0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EFA")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x6006390"), Address(RVA = "0x4AE94B8", Offset = "0x4AE94B8", VA = "0x4AE94B8", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EFB")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x6006391"), Address(RVA = "0x4AE94C0", Offset = "0x4AE94C0", VA = "0x4AE94C0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006392")]
    [Address(RVA = "0x4AE94C8", Offset = "0x4AE94C8", VA = "0x4AE94C8", Slot = "14")]
    private int GameCore\u002EMasterData\u002EIStoryQuestReleaseConditionData\u002EGetConditionQuestID()
    {
      return new int();
    }

    [Token(Token = "0x6006393")]
    [Address(RVA = "0x4AE94D0", Offset = "0x4AE94D0", VA = "0x4AE94D0")]
    public SpecialQuestData()
    {
    }
  }
}
