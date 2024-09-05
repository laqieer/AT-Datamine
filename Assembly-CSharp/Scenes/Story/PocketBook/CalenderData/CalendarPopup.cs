// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.CalenderData.CalendarPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Story.MainQuest;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.CalenderData
{
  [Token(Token = "0x2002E51")]
  public class CalendarPopup : PopupBase
  {
    [Token(Token = "0x400C6B3")]
    private const int WEEKLY_MAX = 6;
    [Token(Token = "0x400C6B4")]
    [FieldOffset(Offset = "0x88")]
    private DayofweekEnum[] dayOfWeekPattern;
    [Token(Token = "0x400C6B5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ToggleGroup toggleGroup;
    [Token(Token = "0x400C6B6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CalendarWeeklyItem[] weeklyItems;
    [Token(Token = "0x400C6B7")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text monthText;
    [Token(Token = "0x400C6B8")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400C6B9")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400C6BC")]
    [FieldOffset(Offset = "0xC8")]
    private Dictionary<int, Dictionary<DayofweekEnum, CalendarInfo>> weeklyMap;

    [Token(Token = "0x17003D8A")]
    public Action<CalendarInfo> OnClickToDay
    {
      [Token(Token = "0x6012196"), Address(RVA = "0x43871C4", Offset = "0x43871C4", VA = "0x43871C4")] get
      {
        return (Action<CalendarInfo>) null;
      }
      [Token(Token = "0x6012197"), Address(RVA = "0x43871CC", Offset = "0x43871CC", VA = "0x43871CC")] set
      {
      }
    }

    [Token(Token = "0x17003D8B")]
    public Action OnClickToClose
    {
      [Token(Token = "0x6012198"), Address(RVA = "0x43871D4", Offset = "0x43871D4", VA = "0x43871D4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6012199"), Address(RVA = "0x43871DC", Offset = "0x43871DC", VA = "0x43871DC")] set
      {
      }
    }

    [Token(Token = "0x601219A")]
    [Address(RVA = "0x43871E4", Offset = "0x43871E4", VA = "0x43871E4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601219B")]
    [Address(RVA = "0x4387240", Offset = "0x4387240", VA = "0x4387240")]
    private void ResetData()
    {
    }

    [Token(Token = "0x601219C")]
    [Address(RVA = "0x43873E4", Offset = "0x43873E4", VA = "0x43873E4")]
    private void SetWeeklyData(CalendarInfo calendarInfo)
    {
    }

    [Token(Token = "0x601219D")]
    [Address(RVA = "0x4387788", Offset = "0x4387788", VA = "0x4387788")]
    public void SetData(CalendarInfo calendarInfo, Dictionary<int, List<int>> dayToSequenceIdMap)
    {
    }

    [Token(Token = "0x601219E")]
    [Address(RVA = "0x4387C9C", Offset = "0x4387C9C", VA = "0x4387C9C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601219F")]
    [Address(RVA = "0x4387CA0", Offset = "0x4387CA0", VA = "0x4387CA0")]
    public void OnClickToCloseButton()
    {
    }

    [Token(Token = "0x60121A0")]
    [Address(RVA = "0x4387CBC", Offset = "0x4387CBC", VA = "0x4387CBC")]
    public CalendarPopup()
    {
    }
  }
}
