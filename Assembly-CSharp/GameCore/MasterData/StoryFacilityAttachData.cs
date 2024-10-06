// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityAttachData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001215")]
  [Serializable]
  public sealed class StoryFacilityAttachData : IMasterDataEntity
  {
    [Token(Token = "0x4005680")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005681")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int grouplabel;
    [Token(Token = "0x4005682")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005683")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int releaseStoryAbility;
    [Token(Token = "0x4005684")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int conditionDate;
    [Token(Token = "0x4005685")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int conditionWeather;
    [Token(Token = "0x4005686")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int conditionTimeslot;
    [Token(Token = "0x4005687")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public bool onceDay;
    [Token(Token = "0x4005688")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public StoryFacilityTypeEnum facilityType;
    [Token(Token = "0x4005689")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int conditions;
    [Token(Token = "0x400568A")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int costs;
    [Token(Token = "0x400568B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int rewards;
    [Token(Token = "0x400568C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public bool timespend;
    [Token(Token = "0x400568D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int facilityTag;
    [Token(Token = "0x400568E")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int adv;
    [Token(Token = "0x400568F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int objectID;
    [Token(Token = "0x4005690")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int cameraMovePosition;
    [Token(Token = "0x4005691")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int playerMovePosition;
    [Token(Token = "0x4005692")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public EventNpcActEnum beginNpcAct;
    [Token(Token = "0x4005693")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int iconType;
    [Token(Token = "0x4005694")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x4005695")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x4005696")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public float iconPositionZ;
    [Token(Token = "0x4005697")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int weeklyID;
    [Token(Token = "0x4005698")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int tutorialID;

    [Token(Token = "0x17000F87")]
    public int Key
    {
      [Token(Token = "0x600670F"), Address(RVA = "0x4D2B6E4", Offset = "0x4D2B6E4", VA = "0x4D2B6E4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006710")]
    [Address(RVA = "0x4D2B6EC", Offset = "0x4D2B6EC", VA = "0x4D2B6EC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006711")]
    [Address(RVA = "0x4D2C0A0", Offset = "0x4D2C0A0", VA = "0x4D2C0A0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F88")]
    public ConditionDate ConditionDate
    {
      [Token(Token = "0x6006712"), Address(RVA = "0x4D2C298", Offset = "0x4D2C298", VA = "0x4D2C298")] get
      {
        return new ConditionDate();
      }
    }

    [Token(Token = "0x17000F89")]
    public ConditionWeather ConditionWeather
    {
      [Token(Token = "0x6006713"), Address(RVA = "0x4D2C2A0", Offset = "0x4D2C2A0", VA = "0x4D2C2A0")] get
      {
        return new ConditionWeather();
      }
    }

    [Token(Token = "0x17000F8A")]
    public ConditionTimeslot ConditionTimeslot
    {
      [Token(Token = "0x6006714"), Address(RVA = "0x4D2C2A8", Offset = "0x4D2C2A8", VA = "0x4D2C2A8")] get
      {
        return new ConditionTimeslot();
      }
    }

    [Token(Token = "0x17000F8B")]
    public string Text
    {
      [Token(Token = "0x6006715"), Address(RVA = "0x4D2C2B0", Offset = "0x4D2C2B0", VA = "0x4D2C2B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006716")]
    [Address(RVA = "0x4D2C38C", Offset = "0x4D2C38C", VA = "0x4D2C38C")]
    public StoryFacilityAttachData()
    {
    }
  }
}
