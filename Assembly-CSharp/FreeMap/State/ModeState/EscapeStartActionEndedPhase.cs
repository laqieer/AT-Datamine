// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.EscapeStartActionEndedPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Instance.Builder;
using FreeMoveEscape;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001823")]
  public class EscapeStartActionEndedPhase : PhaseBase
  {
    [Token(Token = "0x4006968")]
    private const string MainPos_Start = "EscapeMain_Start";
    [Token(Token = "0x4006969")]
    private const string MainPos_End = "EscapeMain_End";
    [Token(Token = "0x400696A")]
    private const string SubPos_Start = "EscapeSub_Start";
    [Token(Token = "0x400696B")]
    private const string SubPos_End = "EscapeSub_End";
    [Token(Token = "0x400696C")]
    private const float distanceRatioCutOff = 0.05f;
    [Token(Token = "0x400696D")]
    [FieldOffset(Offset = "0x18")]
    private Vector3 mainStartPosW;
    [Token(Token = "0x400696E")]
    [FieldOffset(Offset = "0x24")]
    private Vector3 mainEndPosW;
    [Token(Token = "0x400696F")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 subEndPosW;
    [Token(Token = "0x4006970")]
    [FieldOffset(Offset = "0x40")]
    private FreeMapPlayerInstance mainPlayerIns;
    [Token(Token = "0x4006971")]
    [FieldOffset(Offset = "0x48")]
    private FreeMapPlayerInstance subPlayerIns;
    [Token(Token = "0x4006972")]
    [FieldOffset(Offset = "0x50")]
    private EscapeEffectControlHolder effecHolder;
    [Token(Token = "0x4006973")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapStateManager entity;
    [Token(Token = "0x4006974")]
    [FieldOffset(Offset = "0x60")]
    private TutorialModaState state;

    [Token(Token = "0x6008881")]
    [Address(RVA = "0x43DE274", Offset = "0x43DE274", VA = "0x43DE274")]
    public EscapeStartActionEndedPhase(
      FreeMapStateManager entity,
      TutorialModaState state,
      TutorialMainSubPhase mainPhase)
    {
    }

    [Token(Token = "0x6008882")]
    [Address(RVA = "0x43DE35C", Offset = "0x43DE35C", VA = "0x43DE35C", Slot = "4")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x6008883")]
    [Address(RVA = "0x43DE3F8", Offset = "0x43DE3F8", VA = "0x43DE3F8", Slot = "6")]
    protected override void OnEnd()
    {
    }

    [Token(Token = "0x6008884")]
    [Address(RVA = "0x43DE390", Offset = "0x43DE390", VA = "0x43DE390")]
    private IEnumerator GlobalSequence() => (IEnumerator) null;

    [Token(Token = "0x6008885")]
    [Address(RVA = "0x43DE448", Offset = "0x43DE448", VA = "0x43DE448")]
    private IEnumerator AreaExiStageSequence() => (IEnumerator) null;

    [Token(Token = "0x6008886")]
    [Address(RVA = "0x43DE4D0", Offset = "0x43DE4D0", VA = "0x43DE4D0")]
    private IEnumerator AreaLoadSetupSequence() => (IEnumerator) null;

    [Token(Token = "0x6008887")]
    [Address(RVA = "0x43DE560", Offset = "0x43DE560", VA = "0x43DE560")]
    private IEnumerator AreaSetupBeforeFadeIn() => (IEnumerator) null;

    [Token(Token = "0x6008888")]
    [Address(RVA = "0x43DE5F0", Offset = "0x43DE5F0", VA = "0x43DE5F0")]
    private IEnumerator AreaStageing() => (IEnumerator) null;

    [Token(Token = "0x6008889")]
    [Address(RVA = "0x43DE680", Offset = "0x43DE680", VA = "0x43DE680")]
    private void SetupPlayerBuilder(
      FreeMapCommonElement commonElement,
      FreeMapPlayerBuilderBase<FreeMapPlayerInstance> playerBuilder,
      Action onCreate)
    {
    }
  }
}
