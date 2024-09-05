// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewSystemMenuEvent
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
  [Token(Token = "0x20030AE")]
  internal class AdvViewerViewSystemMenuEvent : AdvViewerViewBase
  {
    [Token(Token = "0x400CF20")]
    [FieldOffset(Offset = "0x40")]
    private GUIDropdown systemMenu;
    [Token(Token = "0x400CF21")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown sequences;
    [Token(Token = "0x400CF22")]
    [FieldOffset(Offset = "0x50")]
    private bool canPlay;

    [Token(Token = "0x140001F0")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x601305C"), Address(RVA = "0x432B144", Offset = "0x432B144", VA = "0x432B144")] add
      {
      }
      [Token(Token = "0x601305D"), Address(RVA = "0x432B1E0", Offset = "0x432B1E0", VA = "0x432B1E0")] remove
      {
      }
    }

    [Token(Token = "0x140001F1")]
    public event Action<int> OnChangeEventID
    {
      [Token(Token = "0x601305E"), Address(RVA = "0x432B27C", Offset = "0x432B27C", VA = "0x432B27C")] add
      {
      }
      [Token(Token = "0x601305F"), Address(RVA = "0x432B32C", Offset = "0x432B32C", VA = "0x432B32C")] remove
      {
      }
    }

    [Token(Token = "0x140001F2")]
    public event Action<int> OnChangeSequenceId
    {
      [Token(Token = "0x6013060"), Address(RVA = "0x432B3DC", Offset = "0x432B3DC", VA = "0x432B3DC")] add
      {
      }
      [Token(Token = "0x6013061"), Address(RVA = "0x432B48C", Offset = "0x432B48C", VA = "0x432B48C")] remove
      {
      }
    }

    [Token(Token = "0x6013062")]
    [Address(RVA = "0x432B53C", Offset = "0x432B53C", VA = "0x432B53C", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6013063")]
    [Address(RVA = "0x432B634", Offset = "0x432B634", VA = "0x432B634", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6013064")]
    [Address(RVA = "0x432B7A0", Offset = "0x432B7A0", VA = "0x432B7A0")]
    public void SetMainSequenceParamList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x6013065")]
    [Address(RVA = "0x432B9F0", Offset = "0x432B9F0", VA = "0x432B9F0")]
    public void SetSystemMenuEventList(
      IEnumerable<StoryFreeActionSystemMenuEventData> list)
    {
    }

    [Token(Token = "0x6013066")]
    [Address(RVA = "0x432BC40", Offset = "0x432BC40", VA = "0x432BC40")]
    public void SetCanPlay(bool can)
    {
    }

    [Token(Token = "0x6013067")]
    [Address(RVA = "0x432BC4C", Offset = "0x432BC4C", VA = "0x432BC4C")]
    public AdvViewerViewSystemMenuEvent()
    {
    }
  }
}
