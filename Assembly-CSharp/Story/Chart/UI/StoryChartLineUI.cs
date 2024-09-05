// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.StoryChartLineUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x20006F9")]
  public class StoryChartLineUI : MonoBehaviour
  {
    [Token(Token = "0x40020C1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryChartStraightLineUI[] straightLine;
    [Token(Token = "0x40020C2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Vector2 parentLineAnchorOffset;
    [Token(Token = "0x40020C3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Vector2 childLineAnchorOffset;
    [Token(Token = "0x40020C4")]
    [FieldOffset(Offset = "0x30")]
    private Queue<StoryChartStraightLineUI> stock;
    [Token(Token = "0x40020C5")]
    [FieldOffset(Offset = "0x38")]
    private List<StoryChartStraightLineUI> rental;

    [Token(Token = "0x170005E2")]
    public IEnumerable<StoryChartStraightLineUI> ShowLines
    {
      [Token(Token = "0x6002778"), Address(RVA = "0x366E864", Offset = "0x366E864", VA = "0x366E864")] get
      {
        return (IEnumerable<StoryChartStraightLineUI>) null;
      }
    }

    [Token(Token = "0x6002779")]
    [Address(RVA = "0x366E86C", Offset = "0x366E86C", VA = "0x366E86C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600277A")]
    [Address(RVA = "0x366E908", Offset = "0x366E908", VA = "0x366E908")]
    public void Show(Vector2 from, Vector2 to)
    {
    }

    [Token(Token = "0x600277B")]
    [Address(RVA = "0x366EE54", Offset = "0x366EE54", VA = "0x366EE54")]
    public void Lock(bool locked)
    {
    }

    [Token(Token = "0x600277C")]
    [Address(RVA = "0x366F174", Offset = "0x366F174", VA = "0x366F174")]
    public void Show(bool highlight, bool withEffect)
    {
    }

    [Token(Token = "0x600277D")]
    [Address(RVA = "0x366ECE0", Offset = "0x366ECE0", VA = "0x366ECE0")]
    public StoryChartStraightLineUI Straight() => (StoryChartStraightLineUI) null;

    [Token(Token = "0x600277E")]
    [Address(RVA = "0x366ED08", Offset = "0x366ED08", VA = "0x366ED08")]
    public StoryChartStraightLineUI UpperStraight() => (StoryChartStraightLineUI) null;

    [Token(Token = "0x600277F")]
    [Address(RVA = "0x366EE28", Offset = "0x366EE28", VA = "0x366EE28")]
    public StoryChartStraightLineUI LowerStraight() => (StoryChartStraightLineUI) null;

    [Token(Token = "0x6002780")]
    [Address(RVA = "0x366F620", Offset = "0x366F620", VA = "0x366F620")]
    private StoryChartStraightLineUI Rental() => (StoryChartStraightLineUI) null;

    [Token(Token = "0x6002781")]
    [Address(RVA = "0x366EAF0", Offset = "0x366EAF0", VA = "0x366EAF0")]
    public void Release()
    {
    }

    [Token(Token = "0x6002782")]
    [Address(RVA = "0x366F73C", Offset = "0x366F73C", VA = "0x366F73C")]
    public StoryChartLineUI()
    {
    }
  }
}
