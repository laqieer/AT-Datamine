// Decompiled with JetBrains decompiler
// Type: StaqData.Facility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020B6")]
  public class Facility
  {
    [Token(Token = "0x4008AF4")]
    [FieldOffset(Offset = "0x5C")]
    private bool onceDay;
    [Token(Token = "0x4008AF5")]
    [FieldOffset(Offset = "0x60")]
    private StoryFacilityAttachData masterData;
    [Token(Token = "0x4008AF6")]
    [FieldOffset(Offset = "0x68")]
    private PlayerStoryFacilityType serverData;

    [Token(Token = "0x17002A51")]
    public int AttachID
    {
      [Token(Token = "0x600C5F9"), Address(RVA = "0x1CD32F8", Offset = "0x1CD32F8", VA = "0x1CD32F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A52")]
    public string Name
    {
      [Token(Token = "0x600C5FA"), Address(RVA = "0x1CD3300", Offset = "0x1CD3300", VA = "0x1CD3300")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002A53")]
    public int Adv
    {
      [Token(Token = "0x600C5FB"), Address(RVA = "0x1CD3308", Offset = "0x1CD3308", VA = "0x1CD3308")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A54")]
    public int RewardID
    {
      [Token(Token = "0x600C5FC"), Address(RVA = "0x1CD3310", Offset = "0x1CD3310", VA = "0x1CD3310")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A55")]
    public Facility.BonusInfo Bonus
    {
      [Token(Token = "0x600C5FD"), Address(RVA = "0x1CD3318", Offset = "0x1CD3318", VA = "0x1CD3318")] get
      {
        return (Facility.BonusInfo) null;
      }
    }

    [Token(Token = "0x17002A56")]
    public int ObjectID
    {
      [Token(Token = "0x600C5FE"), Address(RVA = "0x1CD388C", Offset = "0x1CD388C", VA = "0x1CD388C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A57")]
    public NPCInfo NPCInfo
    {
      [Token(Token = "0x600C5FF"), Address(RVA = "0x1CD3894", Offset = "0x1CD3894", VA = "0x1CD3894")] get
      {
        return (NPCInfo) null;
      }
    }

    [Token(Token = "0x17002A58")]
    public Vector3 IconOffset
    {
      [Token(Token = "0x600C600"), Address(RVA = "0x1CD389C", Offset = "0x1CD389C", VA = "0x1CD389C")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17002A59")]
    public int PlayerMovePositionID
    {
      [Token(Token = "0x600C601"), Address(RVA = "0x1CD38A8", Offset = "0x1CD38A8", VA = "0x1CD38A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A5A")]
    public int CameraMovePositionID
    {
      [Token(Token = "0x600C602"), Address(RVA = "0x1CD38B0", Offset = "0x1CD38B0", VA = "0x1CD38B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A5B")]
    public EventNpcActEnum BeginNpcAct
    {
      [Token(Token = "0x600C603"), Address(RVA = "0x1CD38B8", Offset = "0x1CD38B8", VA = "0x1CD38B8")] get
      {
        return new EventNpcActEnum();
      }
    }

    [Token(Token = "0x17002A5C")]
    public bool Acted
    {
      [Token(Token = "0x600C604"), Address(RVA = "0x1CD38C0", Offset = "0x1CD38C0", VA = "0x1CD38C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A5D")]
    public bool IsTimeSpend
    {
      [Token(Token = "0x600C605"), Address(RVA = "0x1CD3AA0", Offset = "0x1CD3AA0", VA = "0x1CD3AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C606"), Address(RVA = "0x1CD3AA8", Offset = "0x1CD3AA8", VA = "0x1CD3AA8")] private set
      {
      }
    }

    [Token(Token = "0x17002A5E")]
    public int Count
    {
      [Token(Token = "0x600C607"), Address(RVA = "0x1CD3AB4", Offset = "0x1CD3AB4", VA = "0x1CD3AB4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C608"), Address(RVA = "0x1CD3ABC", Offset = "0x1CD3ABC", VA = "0x1CD3ABC")] private set
      {
      }
    }

    [Token(Token = "0x17002A5F")]
    public int Level
    {
      [Token(Token = "0x600C609"), Address(RVA = "0x1CD3AC4", Offset = "0x1CD3AC4", VA = "0x1CD3AC4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C60A"), Address(RVA = "0x1CD3ACC", Offset = "0x1CD3ACC", VA = "0x1CD3ACC")] private set
      {
      }
    }

    [Token(Token = "0x17002A60")]
    public BookInfo Book
    {
      [Token(Token = "0x600C60B"), Address(RVA = "0x1CD3AD4", Offset = "0x1CD3AD4", VA = "0x1CD3AD4")] get
      {
        return (BookInfo) null;
      }
      [Token(Token = "0x600C60C"), Address(RVA = "0x1CD3ADC", Offset = "0x1CD3ADC", VA = "0x1CD3ADC")] private set
      {
      }
    }

    [Token(Token = "0x17002A61")]
    public bool Opened
    {
      [Token(Token = "0x600C60D"), Address(RVA = "0x1CD322C", Offset = "0x1CD322C", VA = "0x1CD322C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002A62")]
    public FacilityWorkMediation WorkMediation
    {
      [Token(Token = "0x600C60E"), Address(RVA = "0x1CD428C", Offset = "0x1CD428C", VA = "0x1CD428C")] get
      {
        return (FacilityWorkMediation) null;
      }
    }

    [Token(Token = "0x600C60F")]
    [Address(RVA = "0x1CD2C9C", Offset = "0x1CD2C9C", VA = "0x1CD2C9C")]
    public Facility(StoryFacilityAttachData record)
    {
    }

    [Token(Token = "0x600C610")]
    [Address(RVA = "0x1CD3AE4", Offset = "0x1CD3AE4", VA = "0x1CD3AE4")]
    private bool ReleasedSequence() => new bool();

    [Token(Token = "0x600C611")]
    [Address(RVA = "0x1CD41EC", Offset = "0x1CD41EC", VA = "0x1CD41EC")]
    private bool ContainsStoryAbility() => new bool();

    [Token(Token = "0x600C612")]
    [Address(RVA = "0x1CD2F40", Offset = "0x1CD2F40", VA = "0x1CD2F40")]
    public void Update(PlayerStoryFacilityType serverData)
    {
    }

    [Token(Token = "0x600C613")]
    [Address(RVA = "0x1CD4BA0", Offset = "0x1CD4BA0", VA = "0x1CD4BA0")]
    public void Rental(BookInfo book)
    {
    }

    [Token(Token = "0x600C614")]
    [Address(RVA = "0x1CD3268", Offset = "0x1CD3268", VA = "0x1CD3268")]
    public bool IsActive() => new bool();

    [Token(Token = "0x600C615")]
    [Address(RVA = "0x1CD4BA8", Offset = "0x1CD4BA8", VA = "0x1CD4BA8")]
    public bool IsValid(
      DayofweekEnum? dayofweekType = null,
      StoryWeatherTypeEnum? weatherType = null,
      StoryTimeSlotTypeEnum? timeslotType = null)
    {
      return new bool();
    }

    [Token(Token = "0x600C616")]
    [Address(RVA = "0x1CD3320", Offset = "0x1CD3320", VA = "0x1CD3320")]
    public static Facility.BonusInfo GetBonus(int attachID) => (Facility.BonusInfo) null;

    [Token(Token = "0x600C617")]
    [Address(RVA = "0x1CD5350", Offset = "0x1CD5350", VA = "0x1CD5350")]
    public List<FacilityItemBuff> FacilityBuffItems() => (List<FacilityItemBuff>) null;

    [Token(Token = "0x20020B7")]
    public class BonusInfo
    {
      [Token(Token = "0x4008AFE")]
      [FieldOffset(Offset = "0x18")]
      private List<(RewardTypeEnum, int, int)> bookBuffs;

      [Token(Token = "0x17002A63")]
      public bool IsAny
      {
        [Token(Token = "0x600C618"), Address(RVA = "0x1CD5898", Offset = "0x1CD5898", VA = "0x1CD5898")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002A64")]
      public bool IsTimeSlot
      {
        [Token(Token = "0x600C619"), Address(RVA = "0x1CD58C8", Offset = "0x1CD58C8", VA = "0x1CD58C8")] get
        {
          return new bool();
        }
        [Token(Token = "0x600C61A"), Address(RVA = "0x1CD58D0", Offset = "0x1CD58D0", VA = "0x1CD58D0")] set
        {
        }
      }

      [Token(Token = "0x17002A65")]
      public bool IsWeather
      {
        [Token(Token = "0x600C61B"), Address(RVA = "0x1CD58DC", Offset = "0x1CD58DC", VA = "0x1CD58DC")] get
        {
          return new bool();
        }
        [Token(Token = "0x600C61C"), Address(RVA = "0x1CD58E4", Offset = "0x1CD58E4", VA = "0x1CD58E4")] set
        {
        }
      }

      [Token(Token = "0x17002A66")]
      public bool IsCycle
      {
        [Token(Token = "0x600C61D"), Address(RVA = "0x1CD58F0", Offset = "0x1CD58F0", VA = "0x1CD58F0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600C61E"), Address(RVA = "0x1CD58F8", Offset = "0x1CD58F8", VA = "0x1CD58F8")] set
        {
        }
      }

      [Token(Token = "0x17002A67")]
      public bool IsDayOfWeek
      {
        [Token(Token = "0x600C61F"), Address(RVA = "0x1CD5904", Offset = "0x1CD5904", VA = "0x1CD5904")] get
        {
          return new bool();
        }
        [Token(Token = "0x600C620"), Address(RVA = "0x1CD590C", Offset = "0x1CD590C", VA = "0x1CD590C")] set
        {
        }
      }

      [Token(Token = "0x17002A68")]
      public int AddRewardSetID
      {
        [Token(Token = "0x600C621"), Address(RVA = "0x1CD5918", Offset = "0x1CD5918", VA = "0x1CD5918")] get
        {
          return new int();
        }
        [Token(Token = "0x600C622"), Address(RVA = "0x1CD5920", Offset = "0x1CD5920", VA = "0x1CD5920")] set
        {
        }
      }

      [Token(Token = "0x600C623")]
      [Address(RVA = "0x1CD4E6C", Offset = "0x1CD4E6C", VA = "0x1CD4E6C")]
      public bool IsValidCycle(int yearID, int month, int date) => new bool();

      [Token(Token = "0x17002A69")]
      public IEnumerable<(RewardTypeEnum category, int typeonID, int value)> BookBuffs
      {
        [Token(Token = "0x600C624"), Address(RVA = "0x1CD5928", Offset = "0x1CD5928", VA = "0x1CD5928")] get
        {
          return (IEnumerable<(RewardTypeEnum, int, int)>) null;
        }
      }

      [Token(Token = "0x600C625")]
      [Address(RVA = "0x1CD4F44", Offset = "0x1CD4F44", VA = "0x1CD4F44")]
      public void CalcBookBuff(int facilityID)
      {
      }

      [Token(Token = "0x600C626")]
      [Address(RVA = "0x1CD4DF0", Offset = "0x1CD4DF0", VA = "0x1CD4DF0")]
      public BonusInfo()
      {
      }
    }
  }
}
