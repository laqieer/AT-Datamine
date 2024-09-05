// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.CalenderData.CalendarWeeklyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

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
  [Token(Token = "0x2002E55")]
  public class CalendarWeeklyItem : MonoBehaviour
  {
    [Token(Token = "0x400C6C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CalendarDayItem[] dayItems;

    [Token(Token = "0x60121AD")]
    [Address(RVA = "0x4586AC4", Offset = "0x4586AC4", VA = "0x4586AC4")]
    public void SetToggleGroup(ToggleGroup toggleGroup)
    {
    }

    [Token(Token = "0x60121AE")]
    [Address(RVA = "0x4586B2C", Offset = "0x4586B2C", VA = "0x4586B2C")]
    public void Initialize(
      CalendarInfo[] calendarInfos,
      CalendarInfo todayCalendarInfo,
      IReadOnlyCollection<SubQuestData> subQuestList,
      Dictionary<int, List<int>> dayToSequenceIdMap,
      Action<CalendarInfo> onClickDayItemAction)
    {
    }

    [Token(Token = "0x60121AF")]
    [Address(RVA = "0x4586BDC", Offset = "0x4586BDC", VA = "0x4586BDC")]
    public CalendarWeeklyItem()
    {
    }
  }
}
