// Decompiled with JetBrains decompiler
// Type: LightControlMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000343")]
public class LightControlMixerBehaviour : PlayableBehaviour
{
  [Token(Token = "0x40013A6")]
  [FieldOffset(Offset = "0x10")]
  private Color m_DefaultColor;
  [Token(Token = "0x40013A7")]
  [FieldOffset(Offset = "0x20")]
  private float m_DefaultIntensity;
  [Token(Token = "0x40013A8")]
  [FieldOffset(Offset = "0x24")]
  private float m_DefaultBounceIntensity;
  [Token(Token = "0x40013A9")]
  [FieldOffset(Offset = "0x28")]
  private float m_DefaultRange;
  [Token(Token = "0x40013AA")]
  [FieldOffset(Offset = "0x30")]
  private Light m_TrackBinding;
  [Token(Token = "0x40013AB")]
  [FieldOffset(Offset = "0x38")]
  private bool m_FirstFrameHappened;

  [Token(Token = "0x600130D")]
  [Address(RVA = "0x2865AE4", Offset = "0x2865AE4", VA = "0x2865AE4", Slot = "21")]
  public override void ProcessFrame(Playable playable, FrameData info, object playerData)
  {
  }

  [Token(Token = "0x600130E")]
  [Address(RVA = "0x2865E80", Offset = "0x2865E80", VA = "0x2865E80", Slot = "16")]
  public override void OnPlayableDestroy(Playable playable)
  {
  }

  [Token(Token = "0x600130F")]
  [Address(RVA = "0x2865F4C", Offset = "0x2865F4C", VA = "0x2865F4C")]
  public LightControlMixerBehaviour()
  {
  }
}
