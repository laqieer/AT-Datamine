// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewAreaEventQuest
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
  [Token(Token = "0x200307A")]
  internal class AdvViewerViewAreaEventQuest : AdvViewerViewBase
  {
    [Token(Token = "0x400CE67")]
    [FieldOffset(Offset = "0x40")]
    private GUIDropdown quest;
    [Token(Token = "0x400CE68")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown tasklist;
    [Token(Token = "0x400CE69")]
    [FieldOffset(Offset = "0x50")]
    private bool canPlay;

    [Token(Token = "0x140001C0")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6012F3A"), Address(RVA = "0x431CC60", Offset = "0x431CC60", VA = "0x431CC60")] add
      {
      }
      [Token(Token = "0x6012F3B"), Address(RVA = "0x431CCFC", Offset = "0x431CCFC", VA = "0x431CCFC")] remove
      {
      }
    }

    [Token(Token = "0x140001C1")]
    public event Action<int> OnChangeQuestID
    {
      [Token(Token = "0x6012F3C"), Address(RVA = "0x431CD98", Offset = "0x431CD98", VA = "0x431CD98")] add
      {
      }
      [Token(Token = "0x6012F3D"), Address(RVA = "0x431CE48", Offset = "0x431CE48", VA = "0x431CE48")] remove
      {
      }
    }

    [Token(Token = "0x140001C2")]
    public event Action<int> OnChangeQuestTaskID
    {
      [Token(Token = "0x6012F3E"), Address(RVA = "0x431CEF8", Offset = "0x431CEF8", VA = "0x431CEF8")] add
      {
      }
      [Token(Token = "0x6012F3F"), Address(RVA = "0x431CFA8", Offset = "0x431CFA8", VA = "0x431CFA8")] remove
      {
      }
    }

    [Token(Token = "0x6012F40")]
    [Address(RVA = "0x431D058", Offset = "0x431D058", VA = "0x431D058", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012F41")]
    [Address(RVA = "0x431D150", Offset = "0x431D150", VA = "0x431D150", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012F42")]
    [Address(RVA = "0x431D25C", Offset = "0x431D25C", VA = "0x431D25C")]
    public void SetAreaEventQuestList(IEnumerable<StoryAreaEventQuestData> list)
    {
    }

    [Token(Token = "0x6012F43")]
    [Address(RVA = "0x431D4AC", Offset = "0x431D4AC", VA = "0x431D4AC")]
    public void SetAreaEventQuestTaskList(IEnumerable<StoryAreaEventQuestTaskData> list)
    {
    }

    [Token(Token = "0x6012F44")]
    [Address(RVA = "0x431D7B8", Offset = "0x431D7B8", VA = "0x431D7B8")]
    public void SetCanPlay(bool can)
    {
    }

    [Token(Token = "0x6012F45")]
    [Address(RVA = "0x431D7C4", Offset = "0x431D7C4", VA = "0x431D7C4")]
    public AdvViewerViewAreaEventQuest()
    {
    }
  }
}
