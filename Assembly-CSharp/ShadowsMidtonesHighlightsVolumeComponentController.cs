// Decompiled with JetBrains decompiler
// Type: ShadowsMidtonesHighlightsVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002F9")]
[ExecuteInEditMode]
public class ShadowsMidtonesHighlightsVolumeComponentController : 
  BaseVolumeComponentController<ShadowsMidtonesHighlights>
{
  [Token(Token = "0x4001192")]
  [FieldOffset(Offset = "0x29")]
  public bool shadowsOverrideState;
  [Token(Token = "0x4001193")]
  [FieldOffset(Offset = "0x2C")]
  public Vector4 shadows;
  [Token(Token = "0x4001194")]
  [FieldOffset(Offset = "0x3C")]
  public bool shadowsStartOverrideState;
  [Token(Token = "0x4001195")]
  [FieldOffset(Offset = "0x40")]
  [Min(0.0f)]
  public float shadowsStart;
  [Token(Token = "0x4001196")]
  [FieldOffset(Offset = "0x44")]
  public bool shadowsEndOverrideState;
  [Token(Token = "0x4001197")]
  [FieldOffset(Offset = "0x48")]
  [Min(0.0f)]
  public float shadowsEnd;
  [Token(Token = "0x4001198")]
  [FieldOffset(Offset = "0x4C")]
  public bool midtonesOverrideState;
  [Token(Token = "0x4001199")]
  [FieldOffset(Offset = "0x50")]
  public Vector4 midtones;
  [Token(Token = "0x400119A")]
  [FieldOffset(Offset = "0x60")]
  public bool highlightsOverrideState;
  [Token(Token = "0x400119B")]
  [FieldOffset(Offset = "0x64")]
  public Vector4 highlights;
  [Token(Token = "0x400119C")]
  [FieldOffset(Offset = "0x74")]
  public bool highlightsStartOverrideState;
  [Token(Token = "0x400119D")]
  [FieldOffset(Offset = "0x78")]
  [Min(0.0f)]
  public float highlightsStart;
  [Token(Token = "0x400119E")]
  [FieldOffset(Offset = "0x7C")]
  public bool highlightsEndOverrideState;
  [Token(Token = "0x400119F")]
  [FieldOffset(Offset = "0x80")]
  [Min(0.0f)]
  public float highlightsEnd;

  [Token(Token = "0x6001249")]
  [Address(RVA = "0x27DF434", Offset = "0x27DF434", VA = "0x27DF434", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600124A")]
  [Address(RVA = "0x27DF668", Offset = "0x27DF668", VA = "0x27DF668")]
  public ShadowsMidtonesHighlightsVolumeComponentController()
  {
  }
}
