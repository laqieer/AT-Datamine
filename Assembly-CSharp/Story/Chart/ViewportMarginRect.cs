// Decompiled with JetBrains decompiler
// Type: Story.Chart.ViewportMarginRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006F2")]
  public class ViewportMarginRect
  {
    [Token(Token = "0x40020B1")]
    [FieldOffset(Offset = "0x10")]
    private Rect marginRect;
    [Token(Token = "0x40020B2")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 space;
    [Token(Token = "0x40020B3")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 size;
    [Token(Token = "0x40020B4")]
    [FieldOffset(Offset = "0x30")]
    public ScrollRect scroll;
    [Token(Token = "0x40020B5")]
    [FieldOffset(Offset = "0x38")]
    private Vector2 contentAnchorPosition;

    [Token(Token = "0x170005E0")]
    public Vector2 Margin
    {
      [Token(Token = "0x600275D"), Address(RVA = "0x366E0D4", Offset = "0x366E0D4", VA = "0x366E0D4")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x600275E"), Address(RVA = "0x366E0DC", Offset = "0x366E0DC", VA = "0x366E0DC")] set
      {
      }
    }

    [Token(Token = "0x600275F")]
    [Address(RVA = "0x366E0E4", Offset = "0x366E0E4", VA = "0x366E0E4")]
    public ViewportMarginRect(ScrollRect scroll, Vector2 space, Vector2 size)
    {
    }

    [Token(Token = "0x6002760")]
    [Address(RVA = "0x366E208", Offset = "0x366E208", VA = "0x366E208")]
    public void OnShow()
    {
    }

    [Token(Token = "0x6002761")]
    [Address(RVA = "0x366E238", Offset = "0x366E238", VA = "0x366E238")]
    public bool ContainsInRect(Node node) => new bool();

    [Token(Token = "0x6002762")]
    [Address(RVA = "0x366E43C", Offset = "0x366E43C", VA = "0x366E43C")]
    public Vector2 Position(Node node) => new Vector2();
  }
}
