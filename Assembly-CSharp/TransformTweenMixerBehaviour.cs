// Decompiled with JetBrains decompiler
// Type: TransformTweenMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000358")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
  [Token(Token = "0x40013D4")]
  [FieldOffset(Offset = "0x10")]
  private bool m_FirstFrameHappened;

  [Token(Token = "0x6001342")]
  [Address(RVA = "0x286816C", Offset = "0x286816C", VA = "0x286816C", Slot = "21")]
  public override void ProcessFrame(Playable playable, FrameData info, object playerData)
  {
  }

  [Token(Token = "0x6001343")]
  [Address(RVA = "0x286883C", Offset = "0x286883C", VA = "0x286883C", Slot = "16")]
  public override void OnPlayableDestroy(Playable playable)
  {
  }

  [Token(Token = "0x6001344")]
  [Address(RVA = "0x2868828", Offset = "0x2868828", VA = "0x2868828")]
  private static Quaternion AddQuaternions(Quaternion first, Quaternion second) => new Quaternion();

  [Token(Token = "0x6001345")]
  [Address(RVA = "0x2868814", Offset = "0x2868814", VA = "0x2868814")]
  private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
  {
    return new Quaternion();
  }

  [Token(Token = "0x6001346")]
  [Address(RVA = "0x2868844", Offset = "0x2868844", VA = "0x2868844")]
  private static float QuaternionMagnitude(Quaternion rotation) => new float();

  [Token(Token = "0x6001347")]
  [Address(RVA = "0x2868714", Offset = "0x2868714", VA = "0x2868714")]
  private static Quaternion NormalizeQuaternion(Quaternion rotation) => new Quaternion();

  [Token(Token = "0x6001348")]
  [Address(RVA = "0x2868868", Offset = "0x2868868", VA = "0x2868868")]
  public TransformTweenMixerBehaviour()
  {
  }
}
