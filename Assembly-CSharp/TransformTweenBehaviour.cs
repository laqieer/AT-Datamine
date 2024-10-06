// Decompiled with JetBrains decompiler
// Type: TransformTweenBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000355")]
[Serializable]
public class TransformTweenBehaviour : PlayableBehaviour
{
  [Token(Token = "0x40013C0")]
  [FieldOffset(Offset = "0x10")]
  public Transform startLocation;
  [Token(Token = "0x40013C1")]
  [FieldOffset(Offset = "0x18")]
  public Transform endLocation;
  [Token(Token = "0x40013C2")]
  [FieldOffset(Offset = "0x20")]
  public bool tweenPosition;
  [Token(Token = "0x40013C3")]
  [FieldOffset(Offset = "0x21")]
  public bool tweenRotation;
  [Token(Token = "0x40013C4")]
  [FieldOffset(Offset = "0x24")]
  public TransformTweenBehaviour.TweenType tweenType;
  [Token(Token = "0x40013C5")]
  [FieldOffset(Offset = "0x28")]
  public AnimationCurve customCurve;
  [Token(Token = "0x40013C6")]
  [FieldOffset(Offset = "0x30")]
  public Vector3 startingPosition;
  [Token(Token = "0x40013C7")]
  [FieldOffset(Offset = "0x3C")]
  public Quaternion startingRotation;
  [Token(Token = "0x40013C8")]
  [FieldOffset(Offset = "0x50")]
  private AnimationCurve m_LinearCurve;
  [Token(Token = "0x40013C9")]
  [FieldOffset(Offset = "0x58")]
  private AnimationCurve m_DecelerationCurve;
  [Token(Token = "0x40013CA")]
  [FieldOffset(Offset = "0x60")]
  private AnimationCurve m_HarmonicCurve;
  [Token(Token = "0x40013CB")]
  private const float k_RightAngleInRads = 1.57079637f;

  [Token(Token = "0x600133B")]
  [Address(RVA = "0x2867994", Offset = "0x2867994", VA = "0x2867994", Slot = "20")]
  public override void PrepareFrame(Playable playable, FrameData info)
  {
  }

  [Token(Token = "0x600133C")]
  [Address(RVA = "0x2867A2C", Offset = "0x2867A2C", VA = "0x2867A2C")]
  public float EvaluateCurrentCurve(float time) => new float();

  [Token(Token = "0x600133D")]
  [Address(RVA = "0x2867B20", Offset = "0x2867B20", VA = "0x2867B20")]
  private bool IsCustomCurveNormalised() => new bool();

  [Token(Token = "0x600133E")]
  [Address(RVA = "0x2867DC4", Offset = "0x2867DC4", VA = "0x2867DC4")]
  public TransformTweenBehaviour()
  {
  }

  [Token(Token = "0x2000356")]
  public enum TweenType
  {
    [Token(Token = "0x40013CD")] Linear,
    [Token(Token = "0x40013CE")] Deceleration,
    [Token(Token = "0x40013CF")] Harmonic,
    [Token(Token = "0x40013D0")] Custom,
  }
}
