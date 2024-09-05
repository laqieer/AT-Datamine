// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.TimeLineFacade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine.Events;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000877")]
  public class TimeLineFacade
  {
    [Token(Token = "0x4002804")]
    [FieldOffset(Offset = "0x10")]
    private UITimelineController _timeline;
    [Token(Token = "0x4002805")]
    [FieldOffset(Offset = "0x18")]
    private bool isEnd;

    [Token(Token = "0x600308A")]
    [Address(RVA = "0x3E7A0D0", Offset = "0x3E7A0D0", VA = "0x3E7A0D0")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x600308B")]
    [Address(RVA = "0x3E74B6C", Offset = "0x3E74B6C", VA = "0x3E74B6C")]
    public TimeLineFacade(UITimelineController timeline)
    {
    }

    [Token(Token = "0x600308C")]
    [Address(RVA = "0x3E7596C", Offset = "0x3E7596C", VA = "0x3E7596C")]
    public IEnumerator InitializeAsync(UITimelineController timeline) => (IEnumerator) null;

    [Token(Token = "0x600308D")]
    [Address(RVA = "0x3E74BA8", Offset = "0x3E74BA8", VA = "0x3E74BA8")]
    protected void Play(TimeLineFacade.Direction direction, UnityAction callback)
    {
    }

    [Token(Token = "0x600308E")]
    [Address(RVA = "0x3E7A100", Offset = "0x3E7A100", VA = "0x3E7A100")]
    public void Play(
      string keyword,
      UITimelineController.DirectionType direction,
      UnityAction callback)
    {
    }

    [Token(Token = "0x2000878")]
    public struct Direction
    {
      [Token(Token = "0x4002806")]
      [FieldOffset(Offset = "0x0")]
      public string Keyword;
      [Token(Token = "0x4002807")]
      [FieldOffset(Offset = "0x8")]
      public UITimelineController.DirectionType Type;
    }
  }
}
