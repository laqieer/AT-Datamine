// Decompiled with JetBrains decompiler
// Type: Story.Calendar.DayContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Story.MainQuest;
using System.Collections;
using System.Collections.Generic;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Story.Calendar
{
  [Token(Token = "0x200072D")]
  public class DayContainer : MonoBehaviour
  {
    [Token(Token = "0x4002165")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector monthPlayableDirector;
    [Token(Token = "0x4002166")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector dayPlayableDirector;
    [Token(Token = "0x4002167")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup weatherTweenGroup;
    [Token(Token = "0x4002168")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CalendarMonth[] monthItems;
    [Token(Token = "0x4002169")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CalendarDay[] dayItems;
    [Token(Token = "0x400216A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TweenValue dayTweenValue;
    [Token(Token = "0x400216B")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string TWEEN_WEATHER_IN_ID;
    [Token(Token = "0x400216C")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string TWEEN_WEATHER_OUT_ID;
    [Token(Token = "0x400216D")]
    [FieldOffset(Offset = "0x48")]
    private readonly int TODAY_TABEL_ID;
    [Token(Token = "0x400216E")]
    [FieldOffset(Offset = "0x50")]
    private List<StoryMainQuestCalendarData> calendarDatas;
    [Token(Token = "0x400216F")]
    [FieldOffset(Offset = "0x58")]
    private CalendarInfo calendarInfo;
    [Token(Token = "0x4002170")]
    [FieldOffset(Offset = "0x60")]
    private StoryWeatherTypeEnum fromWeather;
    [Token(Token = "0x4002171")]
    [FieldOffset(Offset = "0x64")]
    private StoryWeatherTypeEnum toWeather;
    [Token(Token = "0x4002172")]
    [FieldOffset(Offset = "0x68")]
    private int elapsedDays;
    [Token(Token = "0x4002173")]
    [FieldOffset(Offset = "0x70")]
    private DayContainer.ViewType viewType;

    [Token(Token = "0x600286D")]
    [Address(RVA = "0x3673DB8", Offset = "0x3673DB8", VA = "0x3673DB8")]
    public void Initialize(
      CalendarInfo calendarInfo,
      StoryWeatherTypeEnum fromWeather,
      StoryWeatherTypeEnum toWeather,
      int elapsedDays)
    {
    }

    [Token(Token = "0x600286E")]
    [Address(RVA = "0x36764D0", Offset = "0x36764D0", VA = "0x36764D0")]
    private void SetUI(
      int updateDay,
      StoryWeatherTypeEnum fromWeather = StoryWeatherTypeEnum.DEFAULT,
      StoryWeatherTypeEnum toWeather = StoryWeatherTypeEnum.DEFAULT)
    {
    }

    [Token(Token = "0x600286F")]
    [Address(RVA = "0x3674AA8", Offset = "0x3674AA8", VA = "0x3674AA8")]
    public IEnumerator NextDays() => (IEnumerator) null;

    [Token(Token = "0x6002870")]
    [Address(RVA = "0x3676E6C", Offset = "0x3676E6C", VA = "0x3676E6C")]
    public DayContainer()
    {
    }

    [Token(Token = "0x6002871")]
    [Address(RVA = "0x3676EF0", Offset = "0x3676EF0", VA = "0x3676EF0")]
    static DayContainer()
    {
    }

    [Token(Token = "0x200072E")]
    public abstract class ViewType
    {
      [Token(Token = "0x6002872")]
      public abstract void SetDay(CalendarDay dayItem, StoryMainQuestCalendarData day);

      [Token(Token = "0x6002873")]
      public abstract void SetMonth(CalendarMonth monthItem, int month);

      [Token(Token = "0x6002874")]
      [Address(RVA = "0x367643C", Offset = "0x367643C", VA = "0x367643C")]
      public static DayContainer.ViewType Create(CalendarTypeEnum viewtype)
      {
        return (DayContainer.ViewType) null;
      }

      [Token(Token = "0x6002875")]
      [Address(RVA = "0x3676F8C", Offset = "0x3676F8C", VA = "0x3676F8C")]
      protected ViewType()
      {
      }

      [Token(Token = "0x200072F")]
      public class Monthy : DayContainer.ViewType
      {
        [Token(Token = "0x6002876")]
        [Address(RVA = "0x3676F94", Offset = "0x3676F94", VA = "0x3676F94", Slot = "4")]
        public override void SetDay(CalendarDay dayItem, StoryMainQuestCalendarData day)
        {
        }

        [Token(Token = "0x6002877")]
        [Address(RVA = "0x3676FF4", Offset = "0x3676FF4", VA = "0x3676FF4", Slot = "5")]
        public override void SetMonth(CalendarMonth monthItem, int month)
        {
        }

        [Token(Token = "0x6002878")]
        [Address(RVA = "0x3676F7C", Offset = "0x3676F7C", VA = "0x3676F7C")]
        public Monthy()
        {
        }
      }

      [Token(Token = "0x2000730")]
      public class ConsecutiveDays : DayContainer.ViewType
      {
        [Token(Token = "0x6002879")]
        [Address(RVA = "0x367700C", Offset = "0x367700C", VA = "0x367700C", Slot = "4")]
        public override void SetDay(CalendarDay dayItem, StoryMainQuestCalendarData day)
        {
        }

        [Token(Token = "0x600287A")]
        [Address(RVA = "0x3677040", Offset = "0x3677040", VA = "0x3677040", Slot = "5")]
        public override void SetMonth(CalendarMonth monthItem, int month)
        {
        }

        [Token(Token = "0x600287B")]
        [Address(RVA = "0x3676F84", Offset = "0x3676F84", VA = "0x3676F84")]
        public ConsecutiveDays()
        {
        }
      }
    }
  }
}
