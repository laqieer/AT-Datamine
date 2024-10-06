// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.TimelineInOutFader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032CA")]
  public class TimelineInOutFader : InOutFaderBase
  {
    [Token(Token = "0x400DABB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController _timeLineController;
    [Token(Token = "0x400DABC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup _canvasGroup;

    [Token(Token = "0x6013E88")]
    [Address(RVA = "0x1AEC890", Offset = "0x1AEC890", VA = "0x1AEC890", Slot = "7")]
    public override void Initialize(Action onFinish = null)
    {
    }

    [Token(Token = "0x6013E89")]
    [Address(RVA = "0x1AEC98C", Offset = "0x1AEC98C", VA = "0x1AEC98C", Slot = "8")]
    public override void Open(Action onFinish = null)
    {
    }

    [Token(Token = "0x6013E8A")]
    [Address(RVA = "0x1AECA34", Offset = "0x1AECA34", VA = "0x1AECA34", Slot = "9")]
    public override void Close(Action onFinish = null)
    {
    }

    [Token(Token = "0x6013E8B")]
    [Address(RVA = "0x1AEC9B4", Offset = "0x1AEC9B4", VA = "0x1AEC9B4")]
    private IEnumerator PlayInOutAndWait(
      UITimelineController.DirectionType direction,
      Action onFinish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013E8C")]
    [Address(RVA = "0x1AEC8F8", Offset = "0x1AEC8F8", VA = "0x1AEC8F8")]
    private void SetAlpha(float alpha)
    {
    }

    [Token(Token = "0x6013E8D")]
    [Address(RVA = "0x1AECA84", Offset = "0x1AECA84", VA = "0x1AECA84")]
    public TimelineInOutFader()
    {
    }
  }
}
