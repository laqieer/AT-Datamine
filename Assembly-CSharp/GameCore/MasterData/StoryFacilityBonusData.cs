// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001217")]
  [Serializable]
  public sealed class StoryFacilityBonusData : IMasterDataEntity
  {
    [Token(Token = "0x400569A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400569B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facilityAttachID;
    [Token(Token = "0x400569C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int conditionWeather;
    [Token(Token = "0x400569D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public DayofweekEnum conditionDayOfWeek;
    [Token(Token = "0x400569E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public StoryTimeSlotTypeEnum conditionTimeSlot;
    [Token(Token = "0x400569F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int cycleYearID;
    [Token(Token = "0x40056A0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int cycleMonth;
    [Token(Token = "0x40056A1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int cycleDate;
    [Token(Token = "0x40056A2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40056A3")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int bonusIntroductionADVID;
    [Token(Token = "0x40056A4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int bonusADVID;

    [Token(Token = "0x17000F8C")]
    public int Key
    {
      [Token(Token = "0x600671F"), Address(RVA = "0x4D2C79C", Offset = "0x4D2C79C", VA = "0x4D2C79C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006720")]
    [Address(RVA = "0x4D2C7A4", Offset = "0x4D2C7A4", VA = "0x4D2C7A4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006721")]
    [Address(RVA = "0x4D2CC10", Offset = "0x4D2CC10", VA = "0x4D2CC10", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006722")]
    [Address(RVA = "0x4D2CD24", Offset = "0x4D2CD24", VA = "0x4D2CD24")]
    public StoryFacilityBonusData()
    {
    }
  }
}
