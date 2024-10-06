// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewFreeActionEnterAdv
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
  [Token(Token = "0x200307E")]
  internal class AdvViewerViewFreeActionEnterAdv : AdvViewerViewBase
  {
    [Token(Token = "0x400CE75")]
    [FieldOffset(Offset = "0x40")]
    private GUIDropdown telops;
    [Token(Token = "0x400CE76")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown sequences;
    [Token(Token = "0x400CE77")]
    [FieldOffset(Offset = "0x50")]
    private bool canPlay;

    [Token(Token = "0x140001C3")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6012F4F"), Address(RVA = "0x431DA7C", Offset = "0x431DA7C", VA = "0x431DA7C")] add
      {
      }
      [Token(Token = "0x6012F50"), Address(RVA = "0x431DB18", Offset = "0x431DB18", VA = "0x431DB18")] remove
      {
      }
    }

    [Token(Token = "0x140001C4")]
    public event Action<int> OnChangeTelopId
    {
      [Token(Token = "0x6012F51"), Address(RVA = "0x431DBB4", Offset = "0x431DBB4", VA = "0x431DBB4")] add
      {
      }
      [Token(Token = "0x6012F52"), Address(RVA = "0x431DC64", Offset = "0x431DC64", VA = "0x431DC64")] remove
      {
      }
    }

    [Token(Token = "0x140001C5")]
    public event Action<int> OnChangeSequenceId
    {
      [Token(Token = "0x6012F53"), Address(RVA = "0x431DD14", Offset = "0x431DD14", VA = "0x431DD14")] add
      {
      }
      [Token(Token = "0x6012F54"), Address(RVA = "0x431DDC4", Offset = "0x431DDC4", VA = "0x431DDC4")] remove
      {
      }
    }

    [Token(Token = "0x6012F55")]
    [Address(RVA = "0x431DE74", Offset = "0x431DE74", VA = "0x431DE74", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012F56")]
    [Address(RVA = "0x431DF6C", Offset = "0x431DF6C", VA = "0x431DF6C", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012F57")]
    [Address(RVA = "0x431E0D8", Offset = "0x431E0D8", VA = "0x431E0D8")]
    public void SetMainSequenceParamList(IEnumerable<StoryMainQuestSequenceData> list)
    {
    }

    [Token(Token = "0x6012F58")]
    [Address(RVA = "0x431E328", Offset = "0x431E328", VA = "0x431E328")]
    public void SetTelopList(IEnumerable<StoryFreeActionTelopData> list)
    {
    }

    [Token(Token = "0x6012F59")]
    [Address(RVA = "0x431E578", Offset = "0x431E578", VA = "0x431E578")]
    public void SetCanPlay(bool can)
    {
    }

    [Token(Token = "0x6012F5A")]
    [Address(RVA = "0x431E584", Offset = "0x431E584", VA = "0x431E584")]
    public AdvViewerViewFreeActionEnterAdv()
    {
    }
  }
}
