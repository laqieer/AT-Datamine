// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewEnding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x200308A")]
  internal class AdvViewerViewEnding : AdvViewerViewBase
  {
    [Token(Token = "0x400CEA4")]
    [FieldOffset(Offset = "0x50")]
    private GUIDropdown enging;
    [Token(Token = "0x400CEA5")]
    [FieldOffset(Offset = "0x58")]
    private string scriptFileName;
    [Token(Token = "0x400CEA6")]
    [FieldOffset(Offset = "0x60")]
    private int selectEndingId;

    [Token(Token = "0x140001D2")]
    public event Action<int, int> OnPlayADV
    {
      [Token(Token = "0x6012F98"), Address(RVA = "0x4321230", Offset = "0x4321230", VA = "0x4321230")] add
      {
      }
      [Token(Token = "0x6012F99"), Address(RVA = "0x43212E0", Offset = "0x43212E0", VA = "0x43212E0")] remove
      {
      }
    }

    [Token(Token = "0x140001D3")]
    public event Action<int> OnChangeChapterID
    {
      [Token(Token = "0x6012F9A"), Address(RVA = "0x4321390", Offset = "0x4321390", VA = "0x4321390")] add
      {
      }
      [Token(Token = "0x6012F9B"), Address(RVA = "0x4321440", Offset = "0x4321440", VA = "0x4321440")] remove
      {
      }
    }

    [Token(Token = "0x140001D4")]
    public event Action<StoryTimeSlotTypeEnum> OnChangeTimeSlot
    {
      [Token(Token = "0x6012F9C"), Address(RVA = "0x43214F0", Offset = "0x43214F0", VA = "0x43214F0")] add
      {
      }
      [Token(Token = "0x6012F9D"), Address(RVA = "0x43215A0", Offset = "0x43215A0", VA = "0x43215A0")] remove
      {
      }
    }

    [Token(Token = "0x140001D5")]
    public event Action<int> OnChangeWeather
    {
      [Token(Token = "0x6012F9E"), Address(RVA = "0x4321650", Offset = "0x4321650", VA = "0x4321650")] add
      {
      }
      [Token(Token = "0x6012F9F"), Address(RVA = "0x4321700", Offset = "0x4321700", VA = "0x4321700")] remove
      {
      }
    }

    [Token(Token = "0x140001D6")]
    public event Action<string> OnChangeScritpFileName
    {
      [Token(Token = "0x6012FA0"), Address(RVA = "0x43217B0", Offset = "0x43217B0", VA = "0x43217B0")] add
      {
      }
      [Token(Token = "0x6012FA1"), Address(RVA = "0x4321860", Offset = "0x4321860", VA = "0x4321860")] remove
      {
      }
    }

    [Token(Token = "0x6012FA2")]
    [Address(RVA = "0x4321910", Offset = "0x4321910", VA = "0x4321910", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012FA3")]
    [Address(RVA = "0x43219A8", Offset = "0x43219A8", VA = "0x43219A8", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012FA4")]
    [Address(RVA = "0x43220BC", Offset = "0x43220BC", VA = "0x43220BC")]
    public void SetEndingList(IEnumerable<StoryEndingData> list)
    {
    }

    [Token(Token = "0x6012FA5")]
    [Address(RVA = "0x432230C", Offset = "0x432230C", VA = "0x432230C")]
    public AdvViewerViewEnding()
    {
    }
  }
}
