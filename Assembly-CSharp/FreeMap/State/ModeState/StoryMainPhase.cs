// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.StoryMainPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.AreaEvent;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200180F")]
  public class StoryMainPhase : MainPhase<StoryModeStateBase>
  {
    [Token(Token = "0x6008829")]
    [Address(RVA = "0x43D8F3C", Offset = "0x43D8F3C", VA = "0x43D8F3C")]
    public StoryMainPhase(
      FreeMapStateManager entity,
      StoryModeStateBase state,
      StoryMainPhase.ISubPhaseBuilder startSubPhaseBuilder)
    {
    }

    [Token(Token = "0x2001810")]
    public interface ISubPhaseBuilder
    {
      [Token(Token = "0x600882A")]
      MainSubPhase<StoryModeStateBase> BuildStartPhase(
        FreeMapStateManager entity,
        StoryModeStateBase state,
        StoryMainPhase mainphase);
    }

    [Token(Token = "0x2001811")]
    public class FreeMapStartPhaseBuilder : StoryMainPhase.ISubPhaseBuilder
    {
      [Token(Token = "0x600882B")]
      [Address(RVA = "0x43DAEF8", Offset = "0x43DAEF8", VA = "0x43DAEF8", Slot = "4")]
      private MainSubPhase<StoryModeStateBase> FreeMap\u002EState\u002EModeState\u002EStoryMainPhase\u002EISubPhaseBuilder\u002EBuildStartPhase(
        FreeMapStateManager entity,
        StoryModeStateBase state,
        StoryMainPhase mainphase)
      {
        return (MainSubPhase<StoryModeStateBase>) null;
      }

      [Token(Token = "0x600882C")]
      [Address(RVA = "0x43DB5EC", Offset = "0x43DB5EC", VA = "0x43DB5EC")]
      private void OnPlayAdvFlow(
        FreeMapStateManager entity,
        List<FreeMapProcess> processes,
        AreaAdv areaAdv,
        AdvDemoInfoData demo)
      {
      }

      [Token(Token = "0x600882D")]
      [Address(RVA = "0x43D8F34", Offset = "0x43D8F34", VA = "0x43D8F34")]
      public FreeMapStartPhaseBuilder()
      {
      }
    }

    [Token(Token = "0x2001812")]
    public class AreaEventMapStartPhaseBuilder : StoryMainPhase.ISubPhaseBuilder
    {
      [Token(Token = "0x600882E")]
      [Address(RVA = "0x43DB99C", Offset = "0x43DB99C", VA = "0x43DB99C", Slot = "4")]
      private MainSubPhase<StoryModeStateBase> FreeMap\u002EState\u002EModeState\u002EStoryMainPhase\u002EISubPhaseBuilder\u002EBuildStartPhase(
        FreeMapStateManager entity,
        StoryModeStateBase state,
        StoryMainPhase mainphase)
      {
        return (MainSubPhase<StoryModeStateBase>) null;
      }

      [Token(Token = "0x600882F")]
      [Address(RVA = "0x43DBE84", Offset = "0x43DBE84", VA = "0x43DBE84")]
      private void OnReceipt(
        FreeMapStateManager entity,
        AreaEventQuestData areaevent,
        List<FreeMapProcess> processes)
      {
      }

      [Token(Token = "0x6008830")]
      [Address(RVA = "0x43D93D0", Offset = "0x43D93D0", VA = "0x43D93D0")]
      public AreaEventMapStartPhaseBuilder()
      {
      }
    }

    [Token(Token = "0x2001813")]
    private class TrackerRefresh : FreeMapProcess
    {
      [Token(Token = "0x6008831")]
      [Address(RVA = "0x43DB910", Offset = "0x43DB910", VA = "0x43DB910")]
      public TrackerRefresh(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008832")]
      [Address(RVA = "0x43DC230", Offset = "0x43DC230", VA = "0x43DC230", Slot = "4")]
      public override void Begin()
      {
      }
    }

    [Token(Token = "0x2001814")]
    private class FadeMaintainInitialize : FreeMapProcess
    {
      [Token(Token = "0x6008833")]
      [Address(RVA = "0x43DB994", Offset = "0x43DB994", VA = "0x43DB994")]
      public FadeMaintainInitialize(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008834")]
      [Address(RVA = "0x43DC294", Offset = "0x43DC294", VA = "0x43DC294", Slot = "4")]
      public override void Begin()
      {
      }

      [Token(Token = "0x6008835")]
      [Address(RVA = "0x43DC2C8", Offset = "0x43DC2C8", VA = "0x43DC2C8")]
      private IEnumerator FadeInSequence() => (IEnumerator) null;
    }

    [Token(Token = "0x2001816")]
    private class FadeOffOnly : FreeMapProcess
    {
      [Token(Token = "0x600883C")]
      [Address(RVA = "0x43DB998", Offset = "0x43DB998", VA = "0x43DB998")]
      public FadeOffOnly(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x600883D")]
      [Address(RVA = "0x43DC534", Offset = "0x43DC534", VA = "0x43DC534", Slot = "4")]
      public override void Begin()
      {
      }

      [Token(Token = "0x600883E")]
      [Address(RVA = "0x43DC568", Offset = "0x43DC568", VA = "0x43DC568")]
      private IEnumerator FadeInSequence() => (IEnumerator) null;
    }

    [Token(Token = "0x2001818")]
    private class FadeOffInitialize : FreeMapProcess
    {
      [Token(Token = "0x6008845")]
      [Address(RVA = "0x43DB914", Offset = "0x43DB914", VA = "0x43DB914")]
      public FadeOffInitialize(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008846")]
      [Address(RVA = "0x43DC7C0", Offset = "0x43DC7C0", VA = "0x43DC7C0", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
