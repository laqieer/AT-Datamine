// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.GUIDropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer
{
  [Token(Token = "0x2002F1F")]
  internal class GUIDropdown
  {
    [Token(Token = "0x400CA22")]
    public const int NotSelected = -1;
    [Token(Token = "0x400CA25")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 scrollViewVector;

    [Token(Token = "0x14000190")]
    public event EventHandler<int> OnSelect
    {
      [Token(Token = "0x6012690"), Address(RVA = "0x2305204", Offset = "0x2305204", VA = "0x2305204")] add
      {
      }
      [Token(Token = "0x6012691"), Address(RVA = "0x23052B4", Offset = "0x23052B4", VA = "0x23052B4")] remove
      {
      }
    }

    [Token(Token = "0x14000191")]
    public event EventHandler<int> OnRemoveSelect
    {
      [Token(Token = "0x6012692"), Address(RVA = "0x2305364", Offset = "0x2305364", VA = "0x2305364")] add
      {
      }
      [Token(Token = "0x6012693"), Address(RVA = "0x2305414", Offset = "0x2305414", VA = "0x2305414")] remove
      {
      }
    }

    [Token(Token = "0x17003E68")]
    public string Title
    {
      [Token(Token = "0x6012694"), Address(RVA = "0x23054C4", Offset = "0x23054C4", VA = "0x23054C4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003E69")]
    public bool IsShow
    {
      [Token(Token = "0x6012695"), Address(RVA = "0x23054CC", Offset = "0x23054CC", VA = "0x23054CC")] private set
      {
      }
      [Token(Token = "0x6012696"), Address(RVA = "0x23054D8", Offset = "0x23054D8", VA = "0x23054D8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003E6A")]
    public int Index
    {
      [Token(Token = "0x6012697"), Address(RVA = "0x23054E0", Offset = "0x23054E0", VA = "0x23054E0")] set
      {
      }
      [Token(Token = "0x6012698"), Address(RVA = "0x23054E8", Offset = "0x23054E8", VA = "0x23054E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003E6B")]
    public List<string> Items
    {
      [Token(Token = "0x6012699"), Address(RVA = "0x23054F0", Offset = "0x23054F0", VA = "0x23054F0")] private set
      {
      }
      [Token(Token = "0x601269A"), Address(RVA = "0x23054F8", Offset = "0x23054F8", VA = "0x23054F8")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17003E6C")]
    public bool NotSelectable
    {
      [Token(Token = "0x601269B"), Address(RVA = "0x2305500", Offset = "0x2305500", VA = "0x2305500")] set
      {
      }
      [Token(Token = "0x601269C"), Address(RVA = "0x230550C", Offset = "0x230550C", VA = "0x230550C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003E6D")]
    public bool IsTextLeftAlign
    {
      [Token(Token = "0x601269D"), Address(RVA = "0x2305514", Offset = "0x2305514", VA = "0x2305514")] set
      {
      }
      [Token(Token = "0x601269E"), Address(RVA = "0x2305520", Offset = "0x2305520", VA = "0x2305520")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601269F")]
    [Address(RVA = "0x2305528", Offset = "0x2305528", VA = "0x2305528")]
    public string SelectedItem(string @default = "") => (string) null;

    [Token(Token = "0x60126A0")]
    [Address(RVA = "0x23055B0", Offset = "0x23055B0", VA = "0x23055B0")]
    public GUIDropdown(
      string title,
      List<string> list,
      bool notSelectable = true,
      bool isTextLeftAlign = false,
      bool isShow = false)
    {
    }

    [Token(Token = "0x60126A1")]
    [Address(RVA = "0x2305658", Offset = "0x2305658", VA = "0x2305658")]
    public void ShowButton(EventHandler<int> RemoveSelect = null)
    {
    }

    [Token(Token = "0x60126A2")]
    [Address(RVA = "0x23058C8", Offset = "0x23058C8", VA = "0x23058C8")]
    public void ShowWindow(int windowId, Rect windowRect, EventHandler<int> Select = null)
    {
    }

    [Token(Token = "0x60126A3")]
    [Address(RVA = "0x2305A40", Offset = "0x2305A40", VA = "0x2305A40")]
    private void DoWindow(int id, EventHandler<int> Select)
    {
    }
  }
}
