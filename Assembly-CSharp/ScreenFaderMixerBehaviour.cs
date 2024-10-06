// Decompiled with JetBrains decompiler
// Type: ScreenFaderMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200034B")]
public class ScreenFaderMixerBehaviour : PlayableBehaviour
{
  [Token(Token = "0x40013B2")]
  [FieldOffset(Offset = "0x10")]
  private Color m_DefaultColor;
  [Token(Token = "0x40013B3")]
  [FieldOffset(Offset = "0x20")]
  private Image m_TrackBinding;
  [Token(Token = "0x40013B4")]
  [FieldOffset(Offset = "0x28")]
  private bool m_FirstFrameHappened;

  [Token(Token = "0x6001320")]
  [Address(RVA = "0x28666A4", Offset = "0x28666A4", VA = "0x28666A4", Slot = "21")]
  public override void ProcessFrame(Playable playable, FrameData info, object playerData)
  {
  }

  [Token(Token = "0x6001321")]
  [Address(RVA = "0x2866990", Offset = "0x2866990", VA = "0x2866990", Slot = "16")]
  public override void OnPlayableDestroy(Playable playable)
  {
  }

  [Token(Token = "0x6001322")]
  [Address(RVA = "0x2866A28", Offset = "0x2866A28", VA = "0x2866A28")]
  public ScreenFaderMixerBehaviour()
  {
  }
}
