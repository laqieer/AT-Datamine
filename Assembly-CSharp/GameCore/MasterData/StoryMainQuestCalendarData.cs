// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200129F")]
  [Serializable]
  public sealed class StoryMainQuestCalendarData : IMasterDataEntity
  {
    [Token(Token = "0x40058C7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x40058C9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int ViewType;
    [Token(Token = "0x40058CA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int YearId;
    [Token(Token = "0x40058CB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int Month;
    [Token(Token = "0x40058CC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int Date;
    [Token(Token = "0x40058CD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DayofweekEnum DayOfWeek;
    [Token(Token = "0x40058CE")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int consecutiveDay;
    [Token(Token = "0x40058CF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int throughoutDays;
    [Token(Token = "0x40058D0")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int holidayFlg;
    [Token(Token = "0x40058D1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int holidayId;

    [Token(Token = "0x17000FF8")]
    public int Key
    {
      [Token(Token = "0x60069BC"), Address(RVA = "0x48D2B24", Offset = "0x48D2B24", VA = "0x48D2B24", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60069BD")]
    [Address(RVA = "0x48D2B2C", Offset = "0x48D2B2C", VA = "0x48D2B2C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60069BE")]
    [Address(RVA = "0x48D2F98", Offset = "0x48D2F98", VA = "0x48D2F98", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60069BF")]
    [Address(RVA = "0x48D30B0", Offset = "0x48D30B0", VA = "0x48D30B0")]
    public bool IsWeekday() => new bool();

    [Token(Token = "0x60069C0")]
    [Address(RVA = "0x48D30D8", Offset = "0x48D30D8", VA = "0x48D30D8")]
    public bool IsHoliday() => new bool();

    [Token(Token = "0x60069C1")]
    [Address(RVA = "0x48D206C", Offset = "0x48D206C", VA = "0x48D206C")]
    public static bool CheckCalendar(int begin, int end, int current) => new bool();

    [Token(Token = "0x60069C2")]
    [Address(RVA = "0x48D30E8", Offset = "0x48D30E8", VA = "0x48D30E8")]
    public StoryMainQuestCalendarData()
    {
    }
  }
}
