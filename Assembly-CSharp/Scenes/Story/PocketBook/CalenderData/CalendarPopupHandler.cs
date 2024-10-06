// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.CalenderData.CalendarPopupHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.MainQuest;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.PocketBook.CalenderData
{
  [Token(Token = "0x2002E53")]
  public class CalendarPopupHandler
  {
    [Token(Token = "0x400C6C0")]
    [FieldOffset(Offset = "0x10")]
    private PocketBookLoader loader;
    [Token(Token = "0x400C6C1")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryMainQuestSequenceData>> sequenceMap;
    [Token(Token = "0x400C6C2")]
    [FieldOffset(Offset = "0x20")]
    protected Dictionary<int, List<int>> dayToSequenceIdMap;

    [Token(Token = "0x60121A5")]
    [Address(RVA = "0x4387E60", Offset = "0x4387E60", VA = "0x4387E60")]
    public CalendarPopupHandler(PocketBookLoader loader)
    {
    }

    [Token(Token = "0x60121A6")]
    [Address(RVA = "0x4387F34", Offset = "0x4387F34", VA = "0x4387F34")]
    private void Setup(CalendarInfo calendarInfo)
    {
    }

    [Token(Token = "0x60121A7")]
    [Address(RVA = "0x4388AA0", Offset = "0x4388AA0", VA = "0x4388AA0")]
    public void Show(CalendarInfo calendarInfo)
    {
    }
  }
}
