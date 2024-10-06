// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewDemoInfoAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003088")]
  internal class AdvViewerViewDemoInfoAdv : AdvViewerViewBase
  {
    [Token(Token = "0x400CE9A")]
    [FieldOffset(Offset = "0x48")]
    private GUIDropdown selectList;
    [Token(Token = "0x400CE9B")]
    [FieldOffset(Offset = "0x50")]
    private List<string> selectedPath;
    [Token(Token = "0x400CE9C")]
    [FieldOffset(Offset = "0x58")]
    private bool isPlayable;

    [Token(Token = "0x140001CE")]
    public event Action OnPlayADV
    {
      [Token(Token = "0x6012F88"), Address(RVA = "0x4320544", Offset = "0x4320544", VA = "0x4320544")] add
      {
      }
      [Token(Token = "0x6012F89"), Address(RVA = "0x43205E0", Offset = "0x43205E0", VA = "0x43205E0")] remove
      {
      }
    }

    [Token(Token = "0x140001CF")]
    public event Func<string, bool> OnChangeSelect
    {
      [Token(Token = "0x6012F8A"), Address(RVA = "0x432067C", Offset = "0x432067C", VA = "0x432067C")] add
      {
      }
      [Token(Token = "0x6012F8B"), Address(RVA = "0x432072C", Offset = "0x432072C", VA = "0x432072C")] remove
      {
      }
    }

    [Token(Token = "0x140001D0")]
    public event Action OnClear
    {
      [Token(Token = "0x6012F8C"), Address(RVA = "0x43207DC", Offset = "0x43207DC", VA = "0x43207DC")] add
      {
      }
      [Token(Token = "0x6012F8D"), Address(RVA = "0x4320878", Offset = "0x4320878", VA = "0x4320878")] remove
      {
      }
    }

    [Token(Token = "0x140001D1")]
    public event Action OnBack
    {
      [Token(Token = "0x6012F8E"), Address(RVA = "0x4320914", Offset = "0x4320914", VA = "0x4320914")] add
      {
      }
      [Token(Token = "0x6012F8F"), Address(RVA = "0x43209B0", Offset = "0x43209B0", VA = "0x43209B0")] remove
      {
      }
    }

    [Token(Token = "0x6012F90")]
    [Address(RVA = "0x4320A4C", Offset = "0x4320A4C", VA = "0x4320A4C", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012F91")]
    [Address(RVA = "0x4320AE4", Offset = "0x4320AE4", VA = "0x4320AE4")]
    public void Init(AdvViewerModelDemoInfoAdv.EventNamePath root)
    {
    }

    [Token(Token = "0x6012F92")]
    [Address(RVA = "0x4320C90", Offset = "0x4320C90", VA = "0x4320C90", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012F93")]
    [Address(RVA = "0x4321094", Offset = "0x4321094", VA = "0x4321094")]
    public void SetPlayEnable(bool enable)
    {
    }

    [Token(Token = "0x6012F94")]
    [Address(RVA = "0x4320B10", Offset = "0x4320B10", VA = "0x4320B10")]
    public void SetSelectList(IEnumerable<string> list)
    {
    }

    [Token(Token = "0x6012F95")]
    [Address(RVA = "0x43210A8", Offset = "0x43210A8", VA = "0x43210A8")]
    public AdvViewerViewDemoInfoAdv()
    {
    }
  }
}
