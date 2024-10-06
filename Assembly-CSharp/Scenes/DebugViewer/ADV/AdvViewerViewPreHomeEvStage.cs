// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewPreHomeEvStage
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
  [Token(Token = "0x200309F")]
  internal class AdvViewerViewPreHomeEvStage : AdvViewerViewBase
  {
    [Token(Token = "0x400CEF3")]
    [FieldOffset(Offset = "0x38")]
    private GUIDropdown advContent;
    [Token(Token = "0x400CEF4")]
    [FieldOffset(Offset = "0x40")]
    private string scriptFileName;
    [Token(Token = "0x400CEF5")]
    [FieldOffset(Offset = "0x48")]
    private int selectContentId;

    [Token(Token = "0x140001E5")]
    public event Action<int> OnPlayADV
    {
      [Token(Token = "0x601300E"), Address(RVA = "0x4327798", Offset = "0x4327798", VA = "0x4327798")] add
      {
      }
      [Token(Token = "0x601300F"), Address(RVA = "0x4327848", Offset = "0x4327848", VA = "0x4327848")] remove
      {
      }
    }

    [Token(Token = "0x140001E6")]
    public event Action<string> OnChangeScritpFileName
    {
      [Token(Token = "0x6013010"), Address(RVA = "0x43278F8", Offset = "0x43278F8", VA = "0x43278F8")] add
      {
      }
      [Token(Token = "0x6013011"), Address(RVA = "0x43279A8", Offset = "0x43279A8", VA = "0x43279A8")] remove
      {
      }
    }

    [Token(Token = "0x6013012")]
    [Address(RVA = "0x4327A58", Offset = "0x4327A58", VA = "0x4327A58", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6013013")]
    [Address(RVA = "0x4327AF0", Offset = "0x4327AF0", VA = "0x4327AF0", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6013014")]
    [Address(RVA = "0x4327F0C", Offset = "0x4327F0C", VA = "0x4327F0C")]
    public void SetContentList(IEnumerable<PreHomeEventAdvContentData> list)
    {
    }

    [Token(Token = "0x6013015")]
    [Address(RVA = "0x432815C", Offset = "0x432815C", VA = "0x432815C")]
    public AdvViewerViewPreHomeEvStage()
    {
    }
  }
}
