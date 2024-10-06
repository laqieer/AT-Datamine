// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F4")]
  [Serializable]
  public sealed class AreaQuestAreaNodeQuestData : IMasterDataEntity, IStoryQuestData
  {
    [Token(Token = "0x40052D2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052D3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int areaNodeQuestGroupId;
    [Token(Token = "0x40052D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public QuestDifficultyTypeEnum difficultyType;
    [Token(Token = "0x40052D5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x40052D6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int mission;
    [Token(Token = "0x40052D7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int firstClearRewardGroupID;
    [Token(Token = "0x40052D8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int clearRewardGroupID;
    [Token(Token = "0x40052D9")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int areaNodeDisplayScenarioStringId;
    [Token(Token = "0x40052DA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public bool canSkipOverride;

    [Token(Token = "0x17000E8A")]
    public int Key
    {
      [Token(Token = "0x60061BC"), Address(RVA = "0x4AD8144", Offset = "0x4AD8144", VA = "0x4AD8144", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60061BD")]
    [Address(RVA = "0x4AD814C", Offset = "0x4AD814C", VA = "0x4AD814C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60061BE")]
    [Address(RVA = "0x4AD84FC", Offset = "0x4AD84FC", VA = "0x4AD84FC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E8B")]
    public string Scenario
    {
      [Token(Token = "0x60061BF"), Address(RVA = "0x4AD85F0", Offset = "0x4AD85F0", VA = "0x4AD85F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60061C0")]
    [Address(RVA = "0x4AD86F0", Offset = "0x4AD86F0", VA = "0x4AD86F0", Slot = "7")]
    private int GameCore\u002EMasterData\u002EIStoryQuestData\u002EGetID() => new int();

    [Token(Token = "0x17000E8C")]
    private QuestTypeEnum GameCore\u002EMasterData\u002EIStoryQuestData\u002ETypeEnum
    {
      [Token(Token = "0x60061C1"), Address(RVA = "0x4AD86F8", Offset = "0x4AD86F8", VA = "0x4AD86F8", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000E8D")]
    public int StageId
    {
      [Token(Token = "0x60061C2"), Address(RVA = "0x4AD8700", Offset = "0x4AD8700", VA = "0x4AD8700", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E8E")]
    public int QuestLevel
    {
      [Token(Token = "0x60061C3"), Address(RVA = "0x4AD8708", Offset = "0x4AD8708", VA = "0x4AD8708", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E8F")]
    public int MissionId
    {
      [Token(Token = "0x60061C4"), Address(RVA = "0x4AD8710", Offset = "0x4AD8710", VA = "0x4AD8710", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E90")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x60061C5"), Address(RVA = "0x4AD8718", Offset = "0x4AD8718", VA = "0x4AD8718", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E91")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x60061C6"), Address(RVA = "0x4AD8720", Offset = "0x4AD8720", VA = "0x4AD8720", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60061C7")]
    [Address(RVA = "0x4AD8728", Offset = "0x4AD8728", VA = "0x4AD8728")]
    public AreaQuestAreaNodeQuestData()
    {
    }
  }
}
