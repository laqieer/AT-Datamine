// Decompiled with JetBrains decompiler
// Type: Story.StoryContentPlayDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005A6")]
  public class StoryContentPlayDirector : IStoryContentSystem, ISuperDirector
  {
    [Token(Token = "0x4001C6A")]
    [FieldOffset(Offset = "0x10")]
    private IContentDirectorFactory directors;
    [Token(Token = "0x4001C6B")]
    [FieldOffset(Offset = "0x18")]
    private bool initialized;
    [Token(Token = "0x4001C6C")]
    [FieldOffset(Offset = "0x19")]
    private bool destroyed;
    [Token(Token = "0x4001C6D")]
    [FieldOffset(Offset = "0x20")]
    private FlowInitializing flowInitialize;
    [Token(Token = "0x4001C6E")]
    [FieldOffset(Offset = "0x28")]
    private FlowExternalTaskRunning flowExternalTask;
    [Token(Token = "0x4001C6F")]
    [FieldOffset(Offset = "0x30")]
    private FlowTransition flowTransitionPlay;
    [Token(Token = "0x4001C70")]
    [FieldOffset(Offset = "0x38")]
    private FlowContentPlay flowContentPlay;
    [Token(Token = "0x4001C71")]
    [FieldOffset(Offset = "0x40")]
    private FlowFinalizing flowFinalizing;
    [Token(Token = "0x4001C72")]
    [FieldOffset(Offset = "0x48")]
    private StoryID playingStoryID;
    [Token(Token = "0x4001C73")]
    [FieldOffset(Offset = "0x50")]
    private SequenceInfo.SequenceHandler sequenceHandler;
    [Token(Token = "0x4001C74")]
    [FieldOffset(Offset = "0x58")]
    private ITransitionDirection transitionDirection;

    [Token(Token = "0x17000486")]
    private ISuperDirector superDirector
    {
      [Token(Token = "0x6002091"), Address(RVA = "0x2A095E0", Offset = "0x2A095E0", VA = "0x2A095E0")] get
      {
        return (ISuperDirector) null;
      }
    }

    [Token(Token = "0x17000487")]
    private IStoryContentSystem contentSystem
    {
      [Token(Token = "0x6002092"), Address(RVA = "0x2A095E4", Offset = "0x2A095E4", VA = "0x2A095E4")] get
      {
        return (IStoryContentSystem) null;
      }
    }

    [Token(Token = "0x6002093")]
    [Address(RVA = "0x2A09080", Offset = "0x2A09080", VA = "0x2A09080")]
    public StoryContentPlayDirector(StoryID playStoryID, IContentDirectorFactory directors)
    {
    }

    [Token(Token = "0x6002094")]
    [Address(RVA = "0x2A095E8", Offset = "0x2A095E8", VA = "0x2A095E8")]
    public void SetDirection(ITransitionDirection direction)
    {
    }

    [Token(Token = "0x6002095")]
    [Address(RVA = "0x2A09238", Offset = "0x2A09238", VA = "0x2A09238")]
    public void AddExternalTask(IContentTask task)
    {
    }

    [Token(Token = "0x6002096")]
    [Address(RVA = "0x2A094F8", Offset = "0x2A094F8", VA = "0x2A094F8", Slot = "11")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6002097")]
    [Address(RVA = "0x2A092B8", Offset = "0x2A092B8", VA = "0x2A092B8", Slot = "9")]
    public void Start()
    {
    }

    [Token(Token = "0x6002098")]
    [Address(RVA = "0x2A09680", Offset = "0x2A09680", VA = "0x2A09680")]
    private void OnInitialized()
    {
    }

    [Token(Token = "0x6002099")]
    [Address(RVA = "0x2A09448", Offset = "0x2A09448", VA = "0x2A09448", Slot = "10")]
    public void Update()
    {
    }

    [Token(Token = "0x600209A")]
    [Address(RVA = "0x2A095F0", Offset = "0x2A095F0", VA = "0x2A095F0")]
    private StoryContentPlayDirector.IFlow CurrentFlow() => (StoryContentPlayDirector.IFlow) null;

    [Token(Token = "0x600209B")]
    [Address(RVA = "0x2A09790", Offset = "0x2A09790", VA = "0x2A09790", Slot = "12")]
    private void Story\u002EISuperDirector\u002EDirection(
      FlowTransition flowTransition,
      FlowContentPlay flowContent)
    {
    }

    [Token(Token = "0x600209C")]
    [Address(RVA = "0x2A09B38", Offset = "0x2A09B38", VA = "0x2A09B38", Slot = "13")]
    private void Story\u002EISuperDirector\u002EOnEndContent(Content content)
    {
    }

    [Token(Token = "0x600209D")]
    [Address(RVA = "0x2A09E08", Offset = "0x2A09E08", VA = "0x2A09E08", Slot = "6")]
    private void Story\u002EIStoryContentSystem\u002EEndContent()
    {
    }

    [Token(Token = "0x600209E")]
    [Address(RVA = "0x2A09EE0", Offset = "0x2A09EE0", VA = "0x2A09EE0", Slot = "7")]
    private void Story\u002EIStoryContentSystem\u002EChangeHeader()
    {
    }

    [Token(Token = "0x600209F")]
    [Address(RVA = "0x2A09F0C", Offset = "0x2A09F0C", VA = "0x2A09F0C", Slot = "8")]
    private void Story\u002EIStoryContentSystem\u002EReturnHome()
    {
    }

    [Token(Token = "0x60020A0")]
    [Address(RVA = "0x2A09F28", Offset = "0x2A09F28", VA = "0x2A09F28", Slot = "5")]
    private PlayingStoryInfo Story\u002EIStoryContentSystem\u002EGetPlayingStory()
    {
      return (PlayingStoryInfo) null;
    }

    [Token(Token = "0x60020A1")]
    [Address(RVA = "0x2A09FEC", Offset = "0x2A09FEC", VA = "0x2A09FEC", Slot = "4")]
    private Coroutine Story\u002EIStoryContentSystem\u002EStartCoroutine(IEnumerator coroutine)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x20005A7")]
    public interface IFlow
    {
      [Token(Token = "0x60020A2")]
      void Update();
    }

    [Token(Token = "0x20005A8")]
    public interface IFlowStoppable : StoryContentPlayDirector.IFlow
    {
      [Token(Token = "0x60020A3")]
      void Abort();
    }
  }
}
