// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewTalkAdvEvent
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
  [Token(Token = "0x20030B2")]
  internal class AdvViewerViewTalkAdvEvent : AdvViewerViewBase
  {
    [Token(Token = "0x400CF2E")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown talkAdvEvents;
    [Token(Token = "0x400CF2F")]
    [FieldOffset(Offset = "0x50")]
    private GUIDropdown talkAdvEventTexts;
    [Token(Token = "0x400CF30")]
    [FieldOffset(Offset = "0x58")]
    private GUIDropdown sequences;
    [Token(Token = "0x400CF31")]
    [FieldOffset(Offset = "0x60")]
    private bool canPlay;

    [Token(Token = "0x140001F3")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6013070"), Address(RVA = "0x432BF0C", Offset = "0x432BF0C", VA = "0x432BF0C")] add
      {
      }
      [Token(Token = "0x6013071"), Address(RVA = "0x432BFA8", Offset = "0x432BFA8", VA = "0x432BFA8")] remove
      {
      }
    }

    [Token(Token = "0x140001F4")]
    public event Action<int> OnChangeTalkEventID
    {
      [Token(Token = "0x6013072"), Address(RVA = "0x432C044", Offset = "0x432C044", VA = "0x432C044")] add
      {
      }
      [Token(Token = "0x6013073"), Address(RVA = "0x432C0F4", Offset = "0x432C0F4", VA = "0x432C0F4")] remove
      {
      }
    }

    [Token(Token = "0x140001F5")]
    public event Action<int> OnChangeTalkEventTextID
    {
      [Token(Token = "0x6013074"), Address(RVA = "0x432C1A4", Offset = "0x432C1A4", VA = "0x432C1A4")] add
      {
      }
      [Token(Token = "0x6013075"), Address(RVA = "0x432C254", Offset = "0x432C254", VA = "0x432C254")] remove
      {
      }
    }

    [Token(Token = "0x140001F6")]
    public event Action<int> OnChangeSequenceId
    {
      [Token(Token = "0x6013076"), Address(RVA = "0x432C304", Offset = "0x432C304", VA = "0x432C304")] add
      {
      }
      [Token(Token = "0x6013077"), Address(RVA = "0x432C3B4", Offset = "0x432C3B4", VA = "0x432C3B4")] remove
      {
      }
    }

    [Token(Token = "0x6013078")]
    [Address(RVA = "0x432C464", Offset = "0x432C464", VA = "0x432C464", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6013079")]
    [Address(RVA = "0x432C584", Offset = "0x432C584", VA = "0x432C584", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x601307A")]
    [Address(RVA = "0x432C704", Offset = "0x432C704", VA = "0x432C704")]
    public void SetMainSequenceParamList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x601307B")]
    [Address(RVA = "0x432C9E0", Offset = "0x432C9E0", VA = "0x432C9E0")]
    public void SetTalkAdvEventList(IEnumerable<StoryFreeActionTalkADVEventData> list)
    {
    }

    [Token(Token = "0x601307C")]
    [Address(RVA = "0x432CC30", Offset = "0x432CC30", VA = "0x432CC30")]
    public void SetTalkAdvEventTextList(
      IEnumerable<StoryFreeActionTalkADVEventTextData> list)
    {
    }

    [Token(Token = "0x601307D")]
    [Address(RVA = "0x432CE80", Offset = "0x432CE80", VA = "0x432CE80")]
    public void SetCanPlay(bool can)
    {
    }

    [Token(Token = "0x601307E")]
    [Address(RVA = "0x432CE8C", Offset = "0x432CE8C", VA = "0x432CE8C")]
    public AdvViewerViewTalkAdvEvent()
    {
    }
  }
}
