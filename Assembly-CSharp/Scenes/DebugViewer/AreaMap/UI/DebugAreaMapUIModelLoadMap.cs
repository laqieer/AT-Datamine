// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIModelLoadMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F4E")]
  internal class DebugAreaMapUIModelLoadMap
  {
    [Token(Token = "0x400CAC1")]
    [FieldOffset(Offset = "0x10")]
    private DebugAreaMapUIModel parent;

    [Token(Token = "0x17003EA3")]
    public DebugAreaMapUIModelLoadMap.BackgroundTableData BackgroundList
    {
      [Token(Token = "0x60127D2"), Address(RVA = "0x211F798", Offset = "0x211F798", VA = "0x211F798")] private set
      {
      }
      [Token(Token = "0x60127D3"), Address(RVA = "0x211F7A0", Offset = "0x211F7A0", VA = "0x211F7A0")] get
      {
        return (DebugAreaMapUIModelLoadMap.BackgroundTableData) null;
      }
    }

    [Token(Token = "0x17003EA4")]
    public TableData ChapterList
    {
      [Token(Token = "0x60127D4"), Address(RVA = "0x211F7A8", Offset = "0x211F7A8", VA = "0x211F7A8")] private set
      {
      }
      [Token(Token = "0x60127D5"), Address(RVA = "0x211F7B0", Offset = "0x211F7B0", VA = "0x211F7B0")] get
      {
        return (TableData) null;
      }
    }

    [Token(Token = "0x17003EA5")]
    public TableData WeatherList
    {
      [Token(Token = "0x60127D6"), Address(RVA = "0x211F7B8", Offset = "0x211F7B8", VA = "0x211F7B8")] private set
      {
      }
      [Token(Token = "0x60127D7"), Address(RVA = "0x211F7C0", Offset = "0x211F7C0", VA = "0x211F7C0")] get
      {
        return (TableData) null;
      }
    }

    [Token(Token = "0x17003EA6")]
    public TableData TimeslotList
    {
      [Token(Token = "0x60127D8"), Address(RVA = "0x211F7C8", Offset = "0x211F7C8", VA = "0x211F7C8")] private set
      {
      }
      [Token(Token = "0x60127D9"), Address(RVA = "0x211F7D0", Offset = "0x211F7D0", VA = "0x211F7D0")] get
      {
        return (TableData) null;
      }
    }

    [Token(Token = "0x17003EA7")]
    public TableData AreaNameList
    {
      [Token(Token = "0x60127DA"), Address(RVA = "0x211F7D8", Offset = "0x211F7D8", VA = "0x211F7D8")] private set
      {
      }
      [Token(Token = "0x60127DB"), Address(RVA = "0x211F7E0", Offset = "0x211F7E0", VA = "0x211F7E0")] get
      {
        return (TableData) null;
      }
    }

    [Token(Token = "0x14000196")]
    public event EventHandler<StoryFreeActionBackgroundData> OnRefresh
    {
      [Token(Token = "0x60127DC"), Address(RVA = "0x211957C", Offset = "0x211957C", VA = "0x211957C")] add
      {
      }
      [Token(Token = "0x60127DD"), Address(RVA = "0x211F7E8", Offset = "0x211F7E8", VA = "0x211F7E8")] remove
      {
      }
    }

    [Token(Token = "0x60127DE")]
    [Address(RVA = "0x211DA48", Offset = "0x211DA48", VA = "0x211DA48")]
    public DebugAreaMapUIModelLoadMap(DebugAreaMapUIModel parent)
    {
    }

    [Token(Token = "0x60127DF")]
    [Address(RVA = "0x211FECC", Offset = "0x211FECC", VA = "0x211FECC")]
    public void RequestMapStart(object sender, int modelId)
    {
    }

    [Token(Token = "0x60127E0")]
    [Address(RVA = "0x211BC58", Offset = "0x211BC58", VA = "0x211BC58")]
    public void ChangeChapterIndex(int index)
    {
    }

    [Token(Token = "0x60127E1")]
    [Address(RVA = "0x211BE74", Offset = "0x211BE74", VA = "0x211BE74")]
    public void ChangeAreaNameIndex(int index)
    {
    }

    [Token(Token = "0x60127E2")]
    [Address(RVA = "0x211BDC0", Offset = "0x211BDC0", VA = "0x211BDC0")]
    public void ChangeWeatherIndex(int index)
    {
    }

    [Token(Token = "0x60127E3")]
    [Address(RVA = "0x211BD0C", Offset = "0x211BD0C", VA = "0x211BD0C")]
    public void ChangeTimeslotIndex(int index)
    {
    }

    [Token(Token = "0x60127E4")]
    [Address(RVA = "0x211BF28", Offset = "0x211BF28", VA = "0x211BF28")]
    public void ChangeBackgroundIndex(int index)
    {
    }

    [Token(Token = "0x60127E5")]
    [Address(RVA = "0x2120010", Offset = "0x2120010", VA = "0x2120010")]
    private void UpdateAreaFilter()
    {
    }

    [Token(Token = "0x60127E6")]
    [Address(RVA = "0x2120318", Offset = "0x2120318", VA = "0x2120318")]
    private void UpdateWeatherTimeslotFilter()
    {
    }

    [Token(Token = "0x60127E7")]
    [Address(RVA = "0x2120720", Offset = "0x2120720", VA = "0x2120720")]
    private void UpdateBackgroundFilter()
    {
    }

    [Token(Token = "0x60127E8")]
    [Address(RVA = "0x2120828", Offset = "0x2120828", VA = "0x2120828")]
    private void SelectBackground()
    {
    }

    [Token(Token = "0x60127E9")]
    [Address(RVA = "0x211F898", Offset = "0x211F898", VA = "0x211F898")]
    private void BuildRelationTable()
    {
    }

    [Token(Token = "0x60127EA")]
    [Address(RVA = "0x21208B4", Offset = "0x21208B4", VA = "0x21208B4")]
    private List<TableData.Value> CreateTagTable(Func<StoryFreeActionBackgroundData, string> target)
    {
      return (List<TableData.Value>) null;
    }

    [Token(Token = "0x2002F4F")]
    public class BackgroundTableData : 
      TableDataBase<DebugAreaMapUIModelLoadMap.BackgroundTableData.Value>
    {
      [Token(Token = "0x60127EF")]
      [Address(RVA = "0x2120B68", Offset = "0x2120B68", VA = "0x2120B68")]
      public BackgroundTableData(
        List<DebugAreaMapUIModelLoadMap.BackgroundTableData.Value> values)
      {
      }

      [Token(Token = "0x2002F50")]
      internal struct Value : ITableDataValue
      {
        [Token(Token = "0x400CAC8")]
        [FieldOffset(Offset = "0x0")]
        public int id;
        [Token(Token = "0x400CAC9")]
        [FieldOffset(Offset = "0x8")]
        public StoryFreeActionBackgroundData data;

        [Token(Token = "0x60127F0")]
        [Address(RVA = "0x2120E48", Offset = "0x2120E48", VA = "0x2120E48")]
        public Value(int id, StoryFreeActionBackgroundData data)
        {
        }

        [Token(Token = "0x17003EA8")]
        public string Name
        {
          [Token(Token = "0x60127F1"), Address(RVA = "0x211B04C", Offset = "0x211B04C", VA = "0x211B04C")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x17003EA9")]
        public string AreaName
        {
          [Token(Token = "0x60127F2"), Address(RVA = "0x2120E24", Offset = "0x2120E24", VA = "0x2120E24")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x17003EAA")]
        public string Chapter
        {
          [Token(Token = "0x60127F3"), Address(RVA = "0x2120DD0", Offset = "0x2120DD0", VA = "0x2120DD0")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x17003EAB")]
        public string Weather
        {
          [Token(Token = "0x60127F4"), Address(RVA = "0x2120DEC", Offset = "0x2120DEC", VA = "0x2120DEC")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x17003EAC")]
        public string Timeslot
        {
          [Token(Token = "0x60127F5"), Address(RVA = "0x2120E08", Offset = "0x2120E08", VA = "0x2120E08")] get
          {
            return (string) null;
          }
        }
      }
    }
  }
}
