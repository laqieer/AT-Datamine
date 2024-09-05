// Decompiled with JetBrains decompiler
// Type: StaqDebug.DebugUIView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F5B")]
  public class DebugUIView
  {
    [Token(Token = "0x4008657")]
    [FieldOffset(Offset = "0x10")]
    private List<DebugUIView.DebugButton> buttons;
    [Token(Token = "0x4008658")]
    [FieldOffset(Offset = "0x18")]
    private DebugUIView.PivotVirtical virtical;
    [Token(Token = "0x4008659")]
    [FieldOffset(Offset = "0x1C")]
    private int pivotOffsetY;
    [Token(Token = "0x400865A")]
    [FieldOffset(Offset = "0x20")]
    private DebugUIView.PivotHorizontal horizontal;
    [Token(Token = "0x400865B")]
    [FieldOffset(Offset = "0x24")]
    private int pivotOffsetX;

    [Token(Token = "0x170026A8")]
    public bool Visible
    {
      [Token(Token = "0x600BA3A"), Address(RVA = "0x2143D10", Offset = "0x2143D10", VA = "0x2143D10")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BA3B"), Address(RVA = "0x2143D18", Offset = "0x2143D18", VA = "0x2143D18")] private set
      {
      }
    }

    [Token(Token = "0x600BA3C")]
    [Address(RVA = "0x2143314", Offset = "0x2143314", VA = "0x2143314")]
    public void RegisterButton(string name, Action OnClickedButton, int width, int height)
    {
    }

    [Token(Token = "0x600BA3D")]
    [Address(RVA = "0x214352C", Offset = "0x214352C", VA = "0x214352C")]
    public void Rename(string name, string rename)
    {
    }

    [Token(Token = "0x600BA3E")]
    [Address(RVA = "0x2143F5C", Offset = "0x2143F5C", VA = "0x2143F5C")]
    public void RemoveAll()
    {
    }

    [Token(Token = "0x600BA3F")]
    [Address(RVA = "0x2143648", Offset = "0x2143648", VA = "0x2143648")]
    public void SetPivotVirtical(DebugUIView.PivotVirtical pivot)
    {
    }

    [Token(Token = "0x600BA40")]
    [Address(RVA = "0x2143DF8", Offset = "0x2143DF8", VA = "0x2143DF8")]
    private void SetPivotVirticalInternal(DebugUIView.PivotVirtical pivot, int totalHeight)
    {
    }

    [Token(Token = "0x600BA41")]
    [Address(RVA = "0x2143E70", Offset = "0x2143E70", VA = "0x2143E70")]
    public void SetPivotHorizontal(DebugUIView.PivotHorizontal pivot)
    {
    }

    [Token(Token = "0x600BA42")]
    [Address(RVA = "0x2143FDC", Offset = "0x2143FDC", VA = "0x2143FDC")]
    private void SetPivotHorizontalInternal(DebugUIView.PivotHorizontal pivot, int maxWidth)
    {
    }

    [Token(Token = "0x600BA43")]
    [Address(RVA = "0x2143770", Offset = "0x2143770", VA = "0x2143770")]
    public void SetVisible(bool value)
    {
    }

    [Token(Token = "0x600BA44")]
    [Address(RVA = "0x2143950", Offset = "0x2143950", VA = "0x2143950")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x600BA45")]
    [Address(RVA = "0x21431D8", Offset = "0x21431D8", VA = "0x21431D8")]
    public DebugUIView()
    {
    }

    [Token(Token = "0x2001F5C")]
    public enum PivotVirtical
    {
      [Token(Token = "0x400865E")] Top,
      [Token(Token = "0x400865F")] Center,
      [Token(Token = "0x4008660")] Bottom,
    }

    [Token(Token = "0x2001F5D")]
    public enum PivotHorizontal
    {
      [Token(Token = "0x4008662")] Left,
      [Token(Token = "0x4008663")] Center,
      [Token(Token = "0x4008664")] Right,
    }

    [Token(Token = "0x2001F5E")]
    private class DebugButton
    {
      [Token(Token = "0x170026A9")]
      public Rect Rect
      {
        [Token(Token = "0x600BA46"), Address(RVA = "0x2144054", Offset = "0x2144054", VA = "0x2144054")] get
        {
          return new Rect();
        }
        [Token(Token = "0x600BA47"), Address(RVA = "0x2144060", Offset = "0x2144060", VA = "0x2144060")] private set
        {
        }
      }

      [Token(Token = "0x170026AA")]
      public Action Callback
      {
        [Token(Token = "0x600BA48"), Address(RVA = "0x214406C", Offset = "0x214406C", VA = "0x214406C")] get
        {
          return (Action) null;
        }
        [Token(Token = "0x600BA49"), Address(RVA = "0x2144074", Offset = "0x2144074", VA = "0x2144074")] private set
        {
        }
      }

      [Token(Token = "0x170026AB")]
      public string NameText
      {
        [Token(Token = "0x600BA4A"), Address(RVA = "0x214407C", Offset = "0x214407C", VA = "0x214407C")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600BA4B"), Address(RVA = "0x2144084", Offset = "0x2144084", VA = "0x2144084")] set
        {
        }
      }

      [Token(Token = "0x170026AC")]
      public bool Trash
      {
        [Token(Token = "0x600BA4C"), Address(RVA = "0x214408C", Offset = "0x214408C", VA = "0x214408C")] get
        {
          return new bool();
        }
        [Token(Token = "0x600BA4D"), Address(RVA = "0x2144094", Offset = "0x2144094", VA = "0x2144094")] set
        {
        }
      }

      [Token(Token = "0x600BA4E")]
      [Address(RVA = "0x2143D24", Offset = "0x2143D24", VA = "0x2143D24")]
      public DebugButton(
        string nameText,
        int posX,
        int posY,
        int width,
        int height,
        Action callback)
      {
      }
    }
  }
}
