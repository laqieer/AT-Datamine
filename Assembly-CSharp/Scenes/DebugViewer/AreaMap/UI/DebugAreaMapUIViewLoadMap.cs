// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIViewLoadMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F6E")]
  internal class DebugAreaMapUIViewLoadMap : DebugAreaMapUIViewBase
  {
    [Token(Token = "0x400CB1C")]
    [FieldOffset(Offset = "0x28")]
    private GUIDropdown chapter;
    [Token(Token = "0x400CB1D")]
    [FieldOffset(Offset = "0x30")]
    private GUIDropdown weather;
    [Token(Token = "0x400CB1E")]
    [FieldOffset(Offset = "0x38")]
    private GUIDropdown timeslot;
    [Token(Token = "0x400CB1F")]
    [FieldOffset(Offset = "0x40")]
    private GUIDropdown area;
    [Token(Token = "0x400CB20")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown background;
    [Token(Token = "0x400CB21")]
    [FieldOffset(Offset = "0x50")]
    private int selectModelId;

    [Token(Token = "0x17003EB6")]
    public int SelectModelId
    {
      [Token(Token = "0x601289F"), Address(RVA = "0x21264D8", Offset = "0x21264D8", VA = "0x21264D8")] set
      {
      }
      [Token(Token = "0x60128A0"), Address(RVA = "0x21264E0", Offset = "0x21264E0", VA = "0x21264E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x140001A9")]
    public event EventHandler<int> OnRequestMapStart
    {
      [Token(Token = "0x60128A1"), Address(RVA = "0x211999C", Offset = "0x211999C", VA = "0x211999C")] add
      {
      }
      [Token(Token = "0x60128A2"), Address(RVA = "0x21264E8", Offset = "0x21264E8", VA = "0x21264E8")] remove
      {
      }
    }

    [Token(Token = "0x140001AA")]
    public event EventHandler<int> OnChangeChapterIndex
    {
      [Token(Token = "0x60128A3"), Address(RVA = "0x211962C", Offset = "0x211962C", VA = "0x211962C")] add
      {
      }
      [Token(Token = "0x60128A4"), Address(RVA = "0x2126598", Offset = "0x2126598", VA = "0x2126598")] remove
      {
      }
    }

    [Token(Token = "0x140001AB")]
    public event EventHandler<int> OnChangeWeatherIndex
    {
      [Token(Token = "0x60128A5"), Address(RVA = "0x211978C", Offset = "0x211978C", VA = "0x211978C")] add
      {
      }
      [Token(Token = "0x60128A6"), Address(RVA = "0x2126648", Offset = "0x2126648", VA = "0x2126648")] remove
      {
      }
    }

    [Token(Token = "0x140001AC")]
    public event EventHandler<int> OnChangeTimeslotIndex
    {
      [Token(Token = "0x60128A7"), Address(RVA = "0x21196DC", Offset = "0x21196DC", VA = "0x21196DC")] add
      {
      }
      [Token(Token = "0x60128A8"), Address(RVA = "0x21266F8", Offset = "0x21266F8", VA = "0x21266F8")] remove
      {
      }
    }

    [Token(Token = "0x140001AD")]
    public event EventHandler<int> OnChangeAreaIndex
    {
      [Token(Token = "0x60128A9"), Address(RVA = "0x211983C", Offset = "0x211983C", VA = "0x211983C")] add
      {
      }
      [Token(Token = "0x60128AA"), Address(RVA = "0x21267A8", Offset = "0x21267A8", VA = "0x21267A8")] remove
      {
      }
    }

    [Token(Token = "0x140001AE")]
    public event EventHandler<int> OnChangeBackgroundIndex
    {
      [Token(Token = "0x60128AB"), Address(RVA = "0x21198EC", Offset = "0x21198EC", VA = "0x21198EC")] add
      {
      }
      [Token(Token = "0x60128AC"), Address(RVA = "0x2126858", Offset = "0x2126858", VA = "0x2126858")] remove
      {
      }
    }

    [Token(Token = "0x60128AD")]
    [Address(RVA = "0x2126908", Offset = "0x2126908", VA = "0x2126908", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x60128AE")]
    [Address(RVA = "0x2126A78", Offset = "0x2126A78", VA = "0x2126A78", Slot = "13")]
    protected override void DoMainWindow(int windowID)
    {
    }

    [Token(Token = "0x60128AF")]
    [Address(RVA = "0x211B2C0", Offset = "0x211B2C0", VA = "0x211B2C0")]
    public DebugAreaMapUIViewLoadMap SetChapter(List<string> list, int index)
    {
      return (DebugAreaMapUIViewLoadMap) null;
    }

    [Token(Token = "0x60128B0")]
    [Address(RVA = "0x211B384", Offset = "0x211B384", VA = "0x211B384")]
    public void SetChapterIndex(int index)
    {
    }

    [Token(Token = "0x60128B1")]
    [Address(RVA = "0x211B4DC", Offset = "0x211B4DC", VA = "0x211B4DC")]
    public DebugAreaMapUIViewLoadMap SetTimeslot(List<string> list, int index)
    {
      return (DebugAreaMapUIViewLoadMap) null;
    }

    [Token(Token = "0x60128B2")]
    [Address(RVA = "0x211B5A0", Offset = "0x211B5A0", VA = "0x211B5A0")]
    public void SetTimeslotIndex(int index)
    {
    }

    [Token(Token = "0x60128B3")]
    [Address(RVA = "0x211B6F8", Offset = "0x211B6F8", VA = "0x211B6F8")]
    public DebugAreaMapUIViewLoadMap SetWeather(List<string> list, int index)
    {
      return (DebugAreaMapUIViewLoadMap) null;
    }

    [Token(Token = "0x60128B4")]
    [Address(RVA = "0x211B7BC", Offset = "0x211B7BC", VA = "0x211B7BC")]
    public void SetWeatherIndex(int index)
    {
    }

    [Token(Token = "0x60128B5")]
    [Address(RVA = "0x211B914", Offset = "0x211B914", VA = "0x211B914")]
    public DebugAreaMapUIViewLoadMap SetArea(List<string> list, int index)
    {
      return (DebugAreaMapUIViewLoadMap) null;
    }

    [Token(Token = "0x60128B6")]
    [Address(RVA = "0x211B9D8", Offset = "0x211B9D8", VA = "0x211B9D8")]
    public void SetAreaIndex(int index)
    {
    }

    [Token(Token = "0x60128B7")]
    [Address(RVA = "0x211BB30", Offset = "0x211BB30", VA = "0x211BB30")]
    public DebugAreaMapUIViewLoadMap SetBackground(List<string> list, int index)
    {
      return (DebugAreaMapUIViewLoadMap) null;
    }

    [Token(Token = "0x60128B8")]
    [Address(RVA = "0x211BBF4", Offset = "0x211BBF4", VA = "0x211BBF4")]
    public void SetBackgroundIndex(int index)
    {
    }

    [Token(Token = "0x60128B9")]
    [Address(RVA = "0x2119578", Offset = "0x2119578", VA = "0x2119578")]
    public DebugAreaMapUIViewLoadMap()
    {
    }
  }
}
