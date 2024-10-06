// Decompiled with JetBrains decompiler
// Type: ADV2.Timeline.AdvDemoTextBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace ADV2.Timeline
{
  [Token(Token = "0x2003E67")]
  [Serializable]
  public class AdvDemoTextBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x40111D0")]
    private const double OutMovieTime = 0.3;
    [Token(Token = "0x40111D1")]
    [FieldOffset(Offset = "0x10")]
    public string TalkerTag;
    [Token(Token = "0x40111D2")]
    [FieldOffset(Offset = "0x18")]
    public string MessageTag;
    [Token(Token = "0x40111D3")]
    [FieldOffset(Offset = "0x20")]
    private GameObject bindTarget;
    [Token(Token = "0x40111D4")]
    [FieldOffset(Offset = "0x28")]
    private Adv2UiLinker linker;
    [Token(Token = "0x40111D5")]
    [FieldOffset(Offset = "0x30")]
    private Adv2UI uiContorller;
    [Token(Token = "0x40111D6")]
    [FieldOffset(Offset = "0x38")]
    private bool ignoreTweenIn;
    [Token(Token = "0x40111D7")]
    [FieldOffset(Offset = "0x39")]
    private bool ignoreTweenOut;
    [Token(Token = "0x40111D8")]
    [FieldOffset(Offset = "0x40")]
    private double lifeTime;

    [Token(Token = "0x60191CA")]
    [Address(RVA = "0x2CF20CC", Offset = "0x2CF20CC", VA = "0x2CF20CC")]
    public void Initialize(GameObject bindTarget, double lifeTime)
    {
    }

    [Token(Token = "0x60191CB")]
    [Address(RVA = "0x2CF22EC", Offset = "0x2CF22EC", VA = "0x2CF22EC")]
    public void SetIgnoreTweenIn()
    {
    }

    [Token(Token = "0x60191CC")]
    [Address(RVA = "0x2CF22F8", Offset = "0x2CF22F8", VA = "0x2CF22F8")]
    public void SetIgnoreTweenOut()
    {
    }

    [Token(Token = "0x60191CD")]
    [Address(RVA = "0x2CF2304", Offset = "0x2CF2304", VA = "0x2CF2304", Slot = "15")]
    public override void OnPlayableCreate(Playable playable)
    {
    }

    [Token(Token = "0x60191CE")]
    [Address(RVA = "0x2CF230C", Offset = "0x2CF230C", VA = "0x2CF230C", Slot = "13")]
    public override void OnGraphStart(Playable playable)
    {
    }

    [Token(Token = "0x60191CF")]
    [Address(RVA = "0x2CF23E0", Offset = "0x2CF23E0", VA = "0x2CF23E0", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x60191D0")]
    [Address(RVA = "0x2CF24DC", Offset = "0x2CF24DC", VA = "0x2CF24DC", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x60191D1")]
    [Address(RVA = "0x2CF2584", Offset = "0x2CF2584", VA = "0x2CF2584", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60191D2")]
    [Address(RVA = "0x2CF294C", Offset = "0x2CF294C", VA = "0x2CF294C", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60191D3")]
    [Address(RVA = "0x2CF297C", Offset = "0x2CF297C", VA = "0x2CF297C")]
    public AdvDemoTextBehaviour()
    {
    }
  }
}
