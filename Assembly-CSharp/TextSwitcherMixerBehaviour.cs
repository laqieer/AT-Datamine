// Decompiled with JetBrains decompiler
// Type: TextSwitcherMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200034F")]
public class TextSwitcherMixerBehaviour : PlayableBehaviour
{
  [Token(Token = "0x40013B9")]
  [FieldOffset(Offset = "0x10")]
  private Color m_DefaultColor;
  [Token(Token = "0x40013BA")]
  [FieldOffset(Offset = "0x20")]
  private int m_DefaultFontSize;
  [Token(Token = "0x40013BB")]
  [FieldOffset(Offset = "0x28")]
  private string m_DefaultText;
  [Token(Token = "0x40013BC")]
  [FieldOffset(Offset = "0x30")]
  private Text m_TrackBinding;
  [Token(Token = "0x40013BD")]
  [FieldOffset(Offset = "0x38")]
  private bool m_FirstFrameHappened;

  [Token(Token = "0x600132A")]
  [Address(RVA = "0x2866C70", Offset = "0x2866C70", VA = "0x2866C70", Slot = "21")]
  public override void ProcessFrame(Playable playable, FrameData info, object playerData)
  {
  }

  [Token(Token = "0x600132B")]
  [Address(RVA = "0x286716C", Offset = "0x286716C", VA = "0x286716C", Slot = "16")]
  public override void OnPlayableDestroy(Playable playable)
  {
  }

  [Token(Token = "0x600132C")]
  [Address(RVA = "0x2867234", Offset = "0x2867234", VA = "0x2867234")]
  public TextSwitcherMixerBehaviour()
  {
  }
}
