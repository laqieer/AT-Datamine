// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewMainSequence
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
  [Token(Token = "0x2003099")]
  internal class AdvViewerViewMainSequence : AdvViewerViewBase
  {
    [Token(Token = "0x400CEDE")]
    [FieldOffset(Offset = "0x50")]
    private GUIDropdown sequence;
    [Token(Token = "0x400CEDF")]
    [FieldOffset(Offset = "0x58")]
    private GUIDropdown chapter;
    [Token(Token = "0x400CEE0")]
    [FieldOffset(Offset = "0x60")]
    private GUIDropdown weather;
    [Token(Token = "0x400CEE1")]
    [FieldOffset(Offset = "0x68")]
    private GUIDropdown timeslot;
    [Token(Token = "0x400CEE2")]
    [FieldOffset(Offset = "0x70")]
    private string scriptFileName;
    [Token(Token = "0x400CEE3")]
    [FieldOffset(Offset = "0x78")]
    private int selectSequenceID;

    [Token(Token = "0x140001E0")]
    public event Action<int> OnPlayADV
    {
      [Token(Token = "0x6012FEF"), Address(RVA = "0x4325EE0", Offset = "0x4325EE0", VA = "0x4325EE0")] add
      {
      }
      [Token(Token = "0x6012FF0"), Address(RVA = "0x4325F90", Offset = "0x4325F90", VA = "0x4325F90")] remove
      {
      }
    }

    [Token(Token = "0x140001E1")]
    public event Action<int> OnChangeChapterID
    {
      [Token(Token = "0x6012FF1"), Address(RVA = "0x4326040", Offset = "0x4326040", VA = "0x4326040")] add
      {
      }
      [Token(Token = "0x6012FF2"), Address(RVA = "0x43260F0", Offset = "0x43260F0", VA = "0x43260F0")] remove
      {
      }
    }

    [Token(Token = "0x140001E2")]
    public event Action<StoryTimeSlotTypeEnum> OnChangeTimeSlot
    {
      [Token(Token = "0x6012FF3"), Address(RVA = "0x43261A0", Offset = "0x43261A0", VA = "0x43261A0")] add
      {
      }
      [Token(Token = "0x6012FF4"), Address(RVA = "0x4326250", Offset = "0x4326250", VA = "0x4326250")] remove
      {
      }
    }

    [Token(Token = "0x140001E3")]
    public event Action<int> OnChangeWeather
    {
      [Token(Token = "0x6012FF5"), Address(RVA = "0x4326300", Offset = "0x4326300", VA = "0x4326300")] add
      {
      }
      [Token(Token = "0x6012FF6"), Address(RVA = "0x43263B0", Offset = "0x43263B0", VA = "0x43263B0")] remove
      {
      }
    }

    [Token(Token = "0x140001E4")]
    public event Action<string> OnChangeScritpFileName
    {
      [Token(Token = "0x6012FF7"), Address(RVA = "0x4326460", Offset = "0x4326460", VA = "0x4326460")] add
      {
      }
      [Token(Token = "0x6012FF8"), Address(RVA = "0x4326510", Offset = "0x4326510", VA = "0x4326510")] remove
      {
      }
    }

    [Token(Token = "0x6012FF9")]
    [Address(RVA = "0x43265C0", Offset = "0x43265C0", VA = "0x43265C0", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012FFA")]
    [Address(RVA = "0x4326708", Offset = "0x4326708", VA = "0x4326708", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012FFB")]
    [Address(RVA = "0x4326A0C", Offset = "0x4326A0C", VA = "0x4326A0C")]
    public void SetChapterList(IEnumerable<StoryChapterData> list)
    {
    }

    [Token(Token = "0x6012FFC")]
    [Address(RVA = "0x4326C5C", Offset = "0x4326C5C", VA = "0x4326C5C")]
    public void SetTimeSlotList(IEnumerable<StoryTimeSlotTypeEnum> list)
    {
    }

    [Token(Token = "0x6012FFD")]
    [Address(RVA = "0x4326EAC", Offset = "0x4326EAC", VA = "0x4326EAC")]
    public void SetWeatherList(IEnumerable<StoryWeatherData> list)
    {
    }

    [Token(Token = "0x6012FFE")]
    [Address(RVA = "0x43270FC", Offset = "0x43270FC", VA = "0x43270FC")]
    public void SetMainQuestSequenceList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x6012FFF")]
    [Address(RVA = "0x432734C", Offset = "0x432734C", VA = "0x432734C")]
    public AdvViewerViewMainSequence()
    {
    }
  }
}
