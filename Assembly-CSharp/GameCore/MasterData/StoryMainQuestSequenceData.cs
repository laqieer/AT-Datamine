// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012AB")]
  [Serializable]
  public sealed class StoryMainQuestSequenceData : IMasterDataEntity
  {
    [Token(Token = "0x40058E9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058EA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x40058EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int calendarId;
    [Token(Token = "0x40058EC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string SequenceName;
    [Token(Token = "0x40058ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public StoryTimeSlotTypeEnum timeslot;
    [Token(Token = "0x40058EE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int weather;
    [Token(Token = "0x40058EF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int sceneType;
    [Token(Token = "0x40058F0")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int summaryID;
    [Token(Token = "0x40058F1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int advScene;
    [Token(Token = "0x40058F2")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int freeActionSettingId;
    [Token(Token = "0x40058F3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int questID;
    [Token(Token = "0x40058F4")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int conditionType;
    [Token(Token = "0x40058F5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int defaultSequenceId;
    [Token(Token = "0x40058F6")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int timeZoneElapsedID;
    [Token(Token = "0x40058F7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int calendarElapsedID;
    [Token(Token = "0x40058F8")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17001002")]
    public int Key
    {
      [Token(Token = "0x60069FE"), Address(RVA = "0x48D50A0", Offset = "0x48D50A0", VA = "0x48D50A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60069FF")]
    [Address(RVA = "0x48D50A8", Offset = "0x48D50A8", VA = "0x48D50A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A00")]
    [Address(RVA = "0x48D5694", Offset = "0x48D5694", VA = "0x48D5694", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001003")]
    public string Title
    {
      [Token(Token = "0x6006A01"), Address(RVA = "0x48D57EC", Offset = "0x48D57EC", VA = "0x48D57EC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001004")]
    public StorySceneTypeEnum SceneTypeEnum
    {
      [Token(Token = "0x6006A02"), Address(RVA = "0x48D58C8", Offset = "0x48D58C8", VA = "0x48D58C8")] get
      {
        return new StorySceneTypeEnum();
      }
    }

    [Token(Token = "0x17001005")]
    public StorySequenceConditionTypeEnum ConditionTypeEnum
    {
      [Token(Token = "0x6006A03"), Address(RVA = "0x48D58D0", Offset = "0x48D58D0", VA = "0x48D58D0")] get
      {
        return new StorySequenceConditionTypeEnum();
      }
    }

    [Token(Token = "0x17001006")]
    public StoryWeatherTypeEnum WeatherType
    {
      [Token(Token = "0x6006A04"), Address(RVA = "0x48D58D8", Offset = "0x48D58D8", VA = "0x48D58D8")] get
      {
        return new StoryWeatherTypeEnum();
      }
    }

    [Token(Token = "0x17001007")]
    public StoryMainQuestCalendarData Calendar
    {
      [Token(Token = "0x6006A05"), Address(RVA = "0x48D58E0", Offset = "0x48D58E0", VA = "0x48D58E0")] get
      {
        return (StoryMainQuestCalendarData) null;
      }
    }

    [Token(Token = "0x6006A06")]
    [Address(RVA = "0x48D597C", Offset = "0x48D597C", VA = "0x48D597C")]
    public StoryMainQuestSequenceData()
    {
    }
  }
}
