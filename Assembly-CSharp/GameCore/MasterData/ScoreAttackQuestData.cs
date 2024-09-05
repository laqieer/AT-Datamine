// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200113B")]
  [Serializable]
  public sealed class ScoreAttackQuestData : IMasterDataEntity, IStoryQuestData
  {
    [Token(Token = "0x40053CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053CB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public QuestTypeEnum questType;
    [Token(Token = "0x40053CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int questStageId;
    [Token(Token = "0x40053CD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int releaseConditionQuestId;
    [Token(Token = "0x40053CE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int difficulty;
    [Token(Token = "0x40053CF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int eventId;
    [Token(Token = "0x40053D0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int killedSpecifiedUnitGroupId;

    [Token(Token = "0x17000EDA")]
    public int Key
    {
      [Token(Token = "0x600631A"), Address(RVA = "0x4AE55A0", Offset = "0x4AE55A0", VA = "0x4AE55A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600631B")]
    [Address(RVA = "0x4AE55A8", Offset = "0x4AE55A8", VA = "0x4AE55A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600631C")]
    [Address(RVA = "0x4AE5894", Offset = "0x4AE5894", VA = "0x4AE5894", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600631D")]
    [Address(RVA = "0x4AE5968", Offset = "0x4AE5968", VA = "0x4AE5968", Slot = "7")]
    public int GetID() => new int();

    [Token(Token = "0x17000EDB")]
    public QuestTypeEnum TypeEnum
    {
      [Token(Token = "0x600631E"), Address(RVA = "0x4AE5970", Offset = "0x4AE5970", VA = "0x4AE5970", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17000EDC")]
    public int StageId
    {
      [Token(Token = "0x600631F"), Address(RVA = "0x4AE5978", Offset = "0x4AE5978", VA = "0x4AE5978", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EDD")]
    public int QuestLevel
    {
      [Token(Token = "0x6006320"), Address(RVA = "0x4AE5980", Offset = "0x4AE5980", VA = "0x4AE5980", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EDE")]
    public int MissionId
    {
      [Token(Token = "0x6006321"), Address(RVA = "0x4AE5988", Offset = "0x4AE5988", VA = "0x4AE5988", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EDF")]
    public int FirstClearRewardGroupID
    {
      [Token(Token = "0x6006322"), Address(RVA = "0x4AE5990", Offset = "0x4AE5990", VA = "0x4AE5990", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EE0")]
    public int ClearRewardGroupID
    {
      [Token(Token = "0x6006323"), Address(RVA = "0x4AE5998", Offset = "0x4AE5998", VA = "0x4AE5998", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006324")]
    [Address(RVA = "0x4AE59A0", Offset = "0x4AE59A0", VA = "0x4AE59A0")]
    public ScoreAttackQuestData()
    {
    }
  }
}
