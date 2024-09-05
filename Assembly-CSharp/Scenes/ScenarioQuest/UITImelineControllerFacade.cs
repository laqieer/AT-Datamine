// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UITImelineControllerFacade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine.Events;

#nullable disable
namespace Scenes.ScenarioQuest
{
  [Token(Token = "0x200293E")]
  public class UITImelineControllerFacade
  {
    [Token(Token = "0x400AFDA")]
    [FieldOffset(Offset = "0x10")]
    private UITImelineControllerFacade.Direction topIn;
    [Token(Token = "0x400AFDB")]
    [FieldOffset(Offset = "0x20")]
    private UITImelineControllerFacade.Direction topOut;
    [Token(Token = "0x400AFDC")]
    [FieldOffset(Offset = "0x30")]
    private UITImelineControllerFacade.Direction transitionTopIn;
    [Token(Token = "0x400AFDD")]
    [FieldOffset(Offset = "0x40")]
    private UITImelineControllerFacade.Direction transitionTopOut;
    [Token(Token = "0x400AFDE")]
    [FieldOffset(Offset = "0x50")]
    private UITImelineControllerFacade.Direction transitionFreeBattleIn;
    [Token(Token = "0x400AFDF")]
    [FieldOffset(Offset = "0x60")]
    private UITImelineControllerFacade.Direction transitionFreeBattleOut;
    [Token(Token = "0x400AFE0")]
    [FieldOffset(Offset = "0x70")]
    private UITImelineControllerFacade.Direction transitionEventMissionIn;
    [Token(Token = "0x400AFE1")]
    [FieldOffset(Offset = "0x80")]
    private UITImelineControllerFacade.Direction transitionEventMissionOut;
    [Token(Token = "0x400AFE2")]
    [FieldOffset(Offset = "0x90")]
    private UITimelineController timeline;
    [Token(Token = "0x400AFE3")]
    [FieldOffset(Offset = "0x98")]
    private bool isEnd;

    [Token(Token = "0x6010387")]
    [Address(RVA = "0x4750858", Offset = "0x4750858", VA = "0x4750858")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x6010388")]
    [Address(RVA = "0x4750860", Offset = "0x4750860", VA = "0x4750860")]
    public UITImelineControllerFacade(UITimelineController timeline)
    {
    }

    [Token(Token = "0x6010389")]
    [Address(RVA = "0x47509CC", Offset = "0x47509CC", VA = "0x47509CC")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601038A")]
    [Address(RVA = "0x4750A5C", Offset = "0x4750A5C", VA = "0x4750A5C")]
    public void In(UnityAction callback = null)
    {
    }

    [Token(Token = "0x601038B")]
    [Address(RVA = "0x4750A74", Offset = "0x4750A74", VA = "0x4750A74")]
    public void Out(UnityAction callback = null)
    {
    }

    [Token(Token = "0x601038C")]
    [Address(RVA = "0x4750A88", Offset = "0x4750A88", VA = "0x4750A88")]
    public void TransitionTopIn(UnityAction callback = null)
    {
    }

    [Token(Token = "0x601038D")]
    [Address(RVA = "0x4750A9C", Offset = "0x4750A9C", VA = "0x4750A9C")]
    public void TransitionTopOut(UnityAction callback = null)
    {
    }

    [Token(Token = "0x601038E")]
    [Address(RVA = "0x4750AB0", Offset = "0x4750AB0", VA = "0x4750AB0")]
    public void TransitionFreeBattleIn(UnityAction callback = null)
    {
    }

    [Token(Token = "0x601038F")]
    [Address(RVA = "0x4750AC4", Offset = "0x4750AC4", VA = "0x4750AC4")]
    public void TransitionFreeBattleOut(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6010390")]
    [Address(RVA = "0x4750AD8", Offset = "0x4750AD8", VA = "0x4750AD8")]
    public void TransitionEventMissionIn(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6010391")]
    [Address(RVA = "0x4750AEC", Offset = "0x4750AEC", VA = "0x4750AEC")]
    public void TransitionEventMissionOut(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6010392")]
    [Address(RVA = "0x4750A70", Offset = "0x4750A70", VA = "0x4750A70")]
    private void Play(UITImelineControllerFacade.Direction direction, UnityAction callback)
    {
    }

    [Token(Token = "0x6010393")]
    [Address(RVA = "0x4750B00", Offset = "0x4750B00", VA = "0x4750B00")]
    public void Play(
      string keyword,
      UITimelineController.DirectionType direction,
      UnityAction callback)
    {
    }

    [Token(Token = "0x200293F")]
    public struct Direction
    {
      [Token(Token = "0x400AFE4")]
      [FieldOffset(Offset = "0x0")]
      public string Keyword;
      [Token(Token = "0x400AFE5")]
      [FieldOffset(Offset = "0x8")]
      public UITimelineController.DirectionType Type;
    }
  }
}
