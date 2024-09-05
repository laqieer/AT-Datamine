// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.ReverseLookupGUIDropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x20030B7")]
  internal class ReverseLookupGUIDropdown
  {
    [Token(Token = "0x400CF3E")]
    [FieldOffset(Offset = "0x20")]
    public bool view;
    [Token(Token = "0x400CF3F")]
    [FieldOffset(Offset = "0x28")]
    public GUIDropdown dropDownList;

    [Token(Token = "0x140001F7")]
    public event Action<bool> OnSelectAction
    {
      [Token(Token = "0x601308A"), Address(RVA = "0x432D204", Offset = "0x432D204", VA = "0x432D204")] add
      {
      }
      [Token(Token = "0x601308B"), Address(RVA = "0x432D2B4", Offset = "0x432D2B4", VA = "0x432D2B4")] remove
      {
      }
    }

    [Token(Token = "0x140001F8")]
    public event Action<string> OnChangeAction
    {
      [Token(Token = "0x601308C"), Address(RVA = "0x432D364", Offset = "0x432D364", VA = "0x432D364")] add
      {
      }
      [Token(Token = "0x601308D"), Address(RVA = "0x432D414", Offset = "0x432D414", VA = "0x432D414")] remove
      {
      }
    }

    [Token(Token = "0x601308E")]
    [Address(RVA = "0x432D4C4", Offset = "0x432D4C4", VA = "0x432D4C4")]
    public void OnChangeView(bool view)
    {
    }

    [Token(Token = "0x601308F")]
    [Address(RVA = "0x4329244", Offset = "0x4329244", VA = "0x4329244")]
    public void OnSelect(bool select)
    {
    }

    [Token(Token = "0x6013090")]
    [Address(RVA = "0x43293BC", Offset = "0x43293BC", VA = "0x43293BC")]
    public void OnChange(string text)
    {
    }

    [Token(Token = "0x6013091")]
    [Address(RVA = "0x432D4D0", Offset = "0x432D4D0", VA = "0x432D4D0", Slot = "4")]
    public virtual void DoMainWindow()
    {
    }

    [Token(Token = "0x6013092")]
    [Address(RVA = "0x432D4D4", Offset = "0x432D4D4", VA = "0x432D4D4", Slot = "5")]
    public virtual int OnGui(int windowId, Rect dropdownRect) => new int();

    [Token(Token = "0x6013093")]
    [Address(RVA = "0x432D4DC", Offset = "0x432D4DC", VA = "0x432D4DC", Slot = "6")]
    public virtual void Initialize()
    {
    }

    [Token(Token = "0x6013094")]
    [Address(RVA = "0x4329214", Offset = "0x4329214", VA = "0x4329214")]
    public ReverseLookupGUIDropdown()
    {
    }
  }
}
