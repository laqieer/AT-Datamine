// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001315")]
  [Serializable]
  public sealed class StorySubquestData : IMasterDataEntity
  {
    [Token(Token = "0x4005A34")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A35")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x4005A36")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4005A37")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int requireQuest;
    [Token(Token = "0x4005A38")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int seasonBegin;
    [Token(Token = "0x4005A39")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int seasonEnd;
    [Token(Token = "0x4005A3A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int conditionDate;
    [Token(Token = "0x4005A3B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int conditionWeather;
    [Token(Token = "0x4005A3C")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int conditionTimeslot;
    [Token(Token = "0x4005A3D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string firstRewards;
    [Token(Token = "0x4005A3E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string clearedRewards;
    [Token(Token = "0x4005A3F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public StorySubQuestCycleTypeEnum cycleType;
    [Token(Token = "0x4005A40")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public DayofweekEnum weeklyCycleDayOfWeek;
    [Token(Token = "0x4005A41")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int monthlyCycleDate;
    [Token(Token = "0x4005A42")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int conditionCommuID;
    [Token(Token = "0x4005A43")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int conditionCommuRank;
    [Token(Token = "0x4005A44")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int conditionHumanParamID;
    [Token(Token = "0x4005A45")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int conditionHumanParamRank;

    [Token(Token = "0x17001048")]
    public int Key
    {
      [Token(Token = "0x6006BC7"), Address(RVA = "0x48E5188", Offset = "0x48E5188", VA = "0x48E5188", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BC8")]
    [Address(RVA = "0x48E5190", Offset = "0x48E5190", VA = "0x48E5190", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006BC9")]
    [Address(RVA = "0x48E589C", Offset = "0x48E589C", VA = "0x48E589C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001049")]
    public string QuestNameText
    {
      [Token(Token = "0x6006BCA"), Address(RVA = "0x48E5A2C", Offset = "0x48E5A2C", VA = "0x48E5A2C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700104A")]
    public string QuestDescriptionText
    {
      [Token(Token = "0x6006BCB"), Address(RVA = "0x48E5B08", Offset = "0x48E5B08", VA = "0x48E5B08")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006BCC")]
    [Address(RVA = "0x48E5BE4", Offset = "0x48E5BE4", VA = "0x48E5BE4")]
    public string QuestConditionHintCommu() => (string) null;

    [Token(Token = "0x6006BCD")]
    [Address(RVA = "0x48E5CC0", Offset = "0x48E5CC0", VA = "0x48E5CC0")]
    public string QuestConditionHitHuman() => (string) null;

    [Token(Token = "0x6006BCE")]
    [Address(RVA = "0x48E5D50", Offset = "0x48E5D50", VA = "0x48E5D50")]
    public StorySubquestData()
    {
    }
  }
}
