// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewSubQuest
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
  [Token(Token = "0x20030A9")]
  internal class AdvViewerViewSubQuest : AdvViewerViewBase
  {
    [Token(Token = "0x400CF0E")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown quest;
    [Token(Token = "0x400CF0F")]
    [FieldOffset(Offset = "0x50")]
    private GUIDropdown tasklist;
    [Token(Token = "0x400CF10")]
    [FieldOffset(Offset = "0x58")]
    private GUIDropdown sequences;
    [Token(Token = "0x400CF11")]
    [FieldOffset(Offset = "0x60")]
    private bool canPlay;

    [Token(Token = "0x140001EC")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6013041"), Address(RVA = "0x4329DB4", Offset = "0x4329DB4", VA = "0x4329DB4")] add
      {
      }
      [Token(Token = "0x6013042"), Address(RVA = "0x4329E50", Offset = "0x4329E50", VA = "0x4329E50")] remove
      {
      }
    }

    [Token(Token = "0x140001ED")]
    public event Action<int> OnChangeQuestID
    {
      [Token(Token = "0x6013043"), Address(RVA = "0x4329EEC", Offset = "0x4329EEC", VA = "0x4329EEC")] add
      {
      }
      [Token(Token = "0x6013044"), Address(RVA = "0x4329F9C", Offset = "0x4329F9C", VA = "0x4329F9C")] remove
      {
      }
    }

    [Token(Token = "0x140001EE")]
    public event Action<int> OnChangeQuestTaskID
    {
      [Token(Token = "0x6013045"), Address(RVA = "0x432A04C", Offset = "0x432A04C", VA = "0x432A04C")] add
      {
      }
      [Token(Token = "0x6013046"), Address(RVA = "0x432A0FC", Offset = "0x432A0FC", VA = "0x432A0FC")] remove
      {
      }
    }

    [Token(Token = "0x140001EF")]
    public event Action<int> OnChangeSequenceId
    {
      [Token(Token = "0x6013047"), Address(RVA = "0x432A1AC", Offset = "0x432A1AC", VA = "0x432A1AC")] add
      {
      }
      [Token(Token = "0x6013048"), Address(RVA = "0x432A25C", Offset = "0x432A25C", VA = "0x432A25C")] remove
      {
      }
    }

    [Token(Token = "0x6013049")]
    [Address(RVA = "0x432A30C", Offset = "0x432A30C", VA = "0x432A30C", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x601304A")]
    [Address(RVA = "0x432A42C", Offset = "0x432A42C", VA = "0x432A42C", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x601304B")]
    [Address(RVA = "0x432A5AC", Offset = "0x432A5AC", VA = "0x432A5AC")]
    public void SetMainSequenceParamList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x601304C")]
    [Address(RVA = "0x432A888", Offset = "0x432A888", VA = "0x432A888")]
    public void SetSubQuestList(IEnumerable<StorySubquestData> list)
    {
    }

    [Token(Token = "0x601304D")]
    [Address(RVA = "0x432AAD8", Offset = "0x432AAD8", VA = "0x432AAD8")]
    public void SetSubQuestTaskList(IEnumerable<StorySubquestTaskData> list)
    {
    }

    [Token(Token = "0x601304E")]
    [Address(RVA = "0x432ADE4", Offset = "0x432ADE4", VA = "0x432ADE4")]
    public void SetCanPlay(bool can)
    {
    }

    [Token(Token = "0x601304F")]
    [Address(RVA = "0x432ADF0", Offset = "0x432ADF0", VA = "0x432ADF0")]
    public AdvViewerViewSubQuest()
    {
    }
  }
}
