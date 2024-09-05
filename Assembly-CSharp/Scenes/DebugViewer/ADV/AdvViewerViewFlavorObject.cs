// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewFlavorObject
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
  [Token(Token = "0x2003093")]
  internal class AdvViewerViewFlavorObject : AdvViewerViewBase
  {
    [Token(Token = "0x400CECB")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown events;
    [Token(Token = "0x400CECC")]
    [FieldOffset(Offset = "0x50")]
    private GUIDropdown eventTexts;
    [Token(Token = "0x400CECD")]
    [FieldOffset(Offset = "0x58")]
    private GUIDropdown sequences;
    [Token(Token = "0x400CECE")]
    [FieldOffset(Offset = "0x60")]
    private bool canPlay;

    [Token(Token = "0x140001DC")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6012FD3"), Address(RVA = "0x432483C", Offset = "0x432483C", VA = "0x432483C")] add
      {
      }
      [Token(Token = "0x6012FD4"), Address(RVA = "0x43248D8", Offset = "0x43248D8", VA = "0x43248D8")] remove
      {
      }
    }

    [Token(Token = "0x140001DD")]
    public event Action<int> OnChangeEventID
    {
      [Token(Token = "0x6012FD5"), Address(RVA = "0x4324974", Offset = "0x4324974", VA = "0x4324974")] add
      {
      }
      [Token(Token = "0x6012FD6"), Address(RVA = "0x4324A24", Offset = "0x4324A24", VA = "0x4324A24")] remove
      {
      }
    }

    [Token(Token = "0x140001DE")]
    public event Action<int> OnChangeEventTextID
    {
      [Token(Token = "0x6012FD7"), Address(RVA = "0x4324AD4", Offset = "0x4324AD4", VA = "0x4324AD4")] add
      {
      }
      [Token(Token = "0x6012FD8"), Address(RVA = "0x4324B84", Offset = "0x4324B84", VA = "0x4324B84")] remove
      {
      }
    }

    [Token(Token = "0x140001DF")]
    public event Action<int> OnChangeSequenceId
    {
      [Token(Token = "0x6012FD9"), Address(RVA = "0x4324C34", Offset = "0x4324C34", VA = "0x4324C34")] add
      {
      }
      [Token(Token = "0x6012FDA"), Address(RVA = "0x4324CE4", Offset = "0x4324CE4", VA = "0x4324CE4")] remove
      {
      }
    }

    [Token(Token = "0x6012FDB")]
    [Address(RVA = "0x4324D94", Offset = "0x4324D94", VA = "0x4324D94", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012FDC")]
    [Address(RVA = "0x4324EB4", Offset = "0x4324EB4", VA = "0x4324EB4", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012FDD")]
    [Address(RVA = "0x4325034", Offset = "0x4325034", VA = "0x4325034")]
    public void SetMainSequenceParamList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x6012FDE")]
    [Address(RVA = "0x4325284", Offset = "0x4325284", VA = "0x4325284")]
    public void SetEventList(IEnumerable<StoryFreeActionFlavorObjectData> list)
    {
    }

    [Token(Token = "0x6012FDF")]
    [Address(RVA = "0x43254D4", Offset = "0x43254D4", VA = "0x43254D4")]
    public void SetEventTextList(
      IEnumerable<StoryFreeActionFlavorObjectTextData> list)
    {
    }

    [Token(Token = "0x6012FE0")]
    [Address(RVA = "0x4325724", Offset = "0x4325724", VA = "0x4325724")]
    public void SetCanPlay(bool can)
    {
    }

    [Token(Token = "0x6012FE1")]
    [Address(RVA = "0x4325730", Offset = "0x4325730", VA = "0x4325730")]
    public AdvViewerViewFlavorObject()
    {
    }
  }
}
