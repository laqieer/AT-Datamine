// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.CalenderData.CalendarDayItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using Story.MainQuest;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.CalenderData
{
  [Token(Token = "0x2002E4C")]
  public class CalendarDayItem : MonoBehaviour
  {
    [Token(Token = "0x400C692")]
    [FieldOffset(Offset = "0x18")]
    private int SCENE_TYPE_FREE_ACTION_ID;
    [Token(Token = "0x400C693")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, string> tweenNameMap;
    [Token(Token = "0x400C694")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C695")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text dayText;
    [Token(Token = "0x400C696")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text holidayText;
    [Token(Token = "0x400C697")]
    [FieldOffset(Offset = "0x40")]
    private bool isFreeAction;
    [Token(Token = "0x400C698")]
    [FieldOffset(Offset = "0x41")]
    private bool isHolidaySelectFlg;
    [Token(Token = "0x400C699")]
    [FieldOffset(Offset = "0x48")]
    private CalendarInfo calendarInfo;
    [Token(Token = "0x400C69A")]
    [FieldOffset(Offset = "0x50")]
    private List<string> tweenKeys;

    [Token(Token = "0x17003D89")]
    public Action<CalendarInfo> OnClickDayButtonAction
    {
      [Token(Token = "0x6012187"), Address(RVA = "0x438536C", Offset = "0x438536C", VA = "0x438536C")] get
      {
        return (Action<CalendarInfo>) null;
      }
      [Token(Token = "0x6012188"), Address(RVA = "0x4385374", Offset = "0x4385374", VA = "0x4385374")] set
      {
      }
    }

    [Token(Token = "0x6012189")]
    [Address(RVA = "0x438537C", Offset = "0x438537C", VA = "0x438537C")]
    public void SetToggleGroup(ToggleGroup toggleGroup)
    {
    }

    [Token(Token = "0x601218A")]
    [Address(RVA = "0x43853E4", Offset = "0x43853E4", VA = "0x43853E4")]
    public void Initialize(
      CalendarInfo calendarInfo,
      CalendarInfo todayCalendarInfo,
      IReadOnlyCollection<SubQuestData> subQuestList,
      Dictionary<int, List<int>> dayToSequenceIdMap)
    {
    }

    [Token(Token = "0x601218B")]
    [Address(RVA = "0x4385B78", Offset = "0x4385B78", VA = "0x4385B78")]
    private void SetData(
      IReadOnlyCollection<StoryMainQuestSequenceData> sequenceDatas,
      CalendarInfo todayCalendarInfo,
      IReadOnlyCollection<SubQuestData> subQuestList)
    {
    }

    [Token(Token = "0x601218C")]
    [Address(RVA = "0x4386330", Offset = "0x4386330", VA = "0x4386330")]
    private void SetUnknownData(
      IReadOnlyCollection<StoryMainQuestSequenceData> sequenceDatas,
      CalendarInfo calendarInfo)
    {
    }

    [Token(Token = "0x601218D")]
    [Address(RVA = "0x43866F8", Offset = "0x43866F8", VA = "0x43866F8")]
    private bool IsPredictionFreeAction(int sequenceID, int throughoutDays) => new bool();

    [Token(Token = "0x601218E")]
    [Address(RVA = "0x4386BD0", Offset = "0x4386BD0", VA = "0x4386BD0")]
    public void OnClickDayButton(Toggle toggle)
    {
    }

    [Token(Token = "0x601218F")]
    [Address(RVA = "0x4386CFC", Offset = "0x4386CFC", VA = "0x4386CFC")]
    public CalendarDayItem()
    {
    }

    [Token(Token = "0x2002E4D")]
    public enum TweenType
    {
      [Token(Token = "0x400C69D")] DateIn,
      [Token(Token = "0x400C69E")] DateOut,
      [Token(Token = "0x400C69F")] FreeIn,
      [Token(Token = "0x400C6A0")] FreeOut,
      [Token(Token = "0x400C6A1")] HolidayIn,
      [Token(Token = "0x400C6A2")] WeekdayIn,
      [Token(Token = "0x400C6A3")] SaturdayIn,
      [Token(Token = "0x400C6A4")] SundayIn,
      [Token(Token = "0x400C6A5")] LimitIn,
      [Token(Token = "0x400C6A6")] LimitOut,
      [Token(Token = "0x400C6A7")] TodayMarkIn,
      [Token(Token = "0x400C6A8")] TodayMarkOut,
      [Token(Token = "0x400C6A9")] HolidayNameIn,
      [Token(Token = "0x400C6AA")] HolidayNameOut,
    }

    [Token(Token = "0x2002E4E")]
    public enum IconType
    {
      [Token(Token = "0x400C6AC")] FreeAction,
      [Token(Token = "0x400C6AD")] Event,
      [Token(Token = "0x400C6AE")] Limit,
    }
  }
}
