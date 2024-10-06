// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIViewLayoutCreate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F6D")]
  internal class DebugAreaMapUIViewLayoutCreate : DebugAreaMapUIViewBase
  {
    [Token(Token = "0x400CB16")]
    [FieldOffset(Offset = "0x28")]
    private GUIDropdown setting;
    [Token(Token = "0x400CB17")]
    [FieldOffset(Offset = "0x30")]
    private GUIDropdown transition;

    [Token(Token = "0x140001A5")]
    public event EventHandler<int> OnCreate
    {
      [Token(Token = "0x6012892"), Address(RVA = "0x211A530", Offset = "0x211A530", VA = "0x211A530")] add
      {
      }
      [Token(Token = "0x6012893"), Address(RVA = "0x2125E34", Offset = "0x2125E34", VA = "0x2125E34")] remove
      {
      }
    }

    [Token(Token = "0x140001A6")]
    public event EventHandler OnDelete
    {
      [Token(Token = "0x6012894"), Address(RVA = "0x211A5E0", Offset = "0x211A5E0", VA = "0x211A5E0")] add
      {
      }
      [Token(Token = "0x6012895"), Address(RVA = "0x2125EE4", Offset = "0x2125EE4", VA = "0x2125EE4")] remove
      {
      }
    }

    [Token(Token = "0x140001A7")]
    public event EventHandler<int> OnWarpAnchor
    {
      [Token(Token = "0x6012896"), Address(RVA = "0x211A67C", Offset = "0x211A67C", VA = "0x211A67C")] add
      {
      }
      [Token(Token = "0x6012897"), Address(RVA = "0x2125F80", Offset = "0x2125F80", VA = "0x2125F80")] remove
      {
      }
    }

    [Token(Token = "0x140001A8")]
    public event EventHandler<int> OnTransitionArea
    {
      [Token(Token = "0x6012898"), Address(RVA = "0x211A72C", Offset = "0x211A72C", VA = "0x211A72C")] add
      {
      }
      [Token(Token = "0x6012899"), Address(RVA = "0x2126030", Offset = "0x2126030", VA = "0x2126030")] remove
      {
      }
    }

    [Token(Token = "0x601289A")]
    [Address(RVA = "0x211A3F8", Offset = "0x211A3F8", VA = "0x211A3F8")]
    public DebugAreaMapUIViewLayoutCreate()
    {
    }

    [Token(Token = "0x601289B")]
    [Address(RVA = "0x21260E0", Offset = "0x21260E0", VA = "0x21260E0", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x601289C")]
    [Address(RVA = "0x21261B4", Offset = "0x21261B4", VA = "0x21261B4", Slot = "13")]
    protected override void DoMainWindow(int windowID)
    {
    }

    [Token(Token = "0x601289D")]
    [Address(RVA = "0x211CF14", Offset = "0x211CF14", VA = "0x211CF14")]
    public void SetSettingList(List<string> list)
    {
    }

    [Token(Token = "0x601289E")]
    [Address(RVA = "0x211D0D4", Offset = "0x211D0D4", VA = "0x211D0D4")]
    public void SetTransitionList(List<string> list)
    {
    }
  }
}
