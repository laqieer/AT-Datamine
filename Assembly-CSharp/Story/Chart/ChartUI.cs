// Decompiled with JetBrains decompiler
// Type: Story.Chart.ChartUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006E6")]
  [Serializable]
  public class ChartUI
  {
    [Token(Token = "0x400208D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public UITimelineController OutGameMenuTimeline;
    [Token(Token = "0x400208E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public UITimelineController Timeline;
    [Token(Token = "0x400208F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public ScrollRect Scroll;

    [Token(Token = "0x600271F")]
    [Address(RVA = "0x366C36C", Offset = "0x366C36C", VA = "0x366C36C")]
    public bool TimelinesIsBusy() => new bool();

    [Token(Token = "0x6002720")]
    [Address(RVA = "0x366C3AC", Offset = "0x366C3AC", VA = "0x366C3AC")]
    public ChartUI()
    {
    }
  }
}
