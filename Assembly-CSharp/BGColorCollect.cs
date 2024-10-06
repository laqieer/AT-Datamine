// Decompiled with JetBrains decompiler
// Type: BGColorCollect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000A8")]
[DisallowMultipleComponent]
public class BGColorCollect : MonoBehaviour
{
  [Token(Token = "0x4000297")]
  [FieldOffset(Offset = "0x0")]
  private static readonly Color HardlightNeutral;
  [Token(Token = "0x4000298")]
  [FieldOffset(Offset = "0x10")]
  private static readonly Vector3 WaveLength;
  [Token(Token = "0x4000299")]
  [FieldOffset(Offset = "0x1C")]
  private static readonly float WaveLengthExponent;
  [Token(Token = "0x400029A")]
  [FieldOffset(Offset = "0x20")]
  private static readonly Vector3 WaveLengthPow;
  [Token(Token = "0x400029B")]
  [FieldOffset(Offset = "0x2C")]
  private static readonly Vector3 WaveLengthRatio;
  [Token(Token = "0x400029C")]
  [FieldOffset(Offset = "0x38")]
  private static readonly float CollectWaterColorAdjustment;
  [Token(Token = "0x400029D")]
  [FieldOffset(Offset = "0x18")]
  [Range(0.0f, 1f)]
  public float CollectBlend;
  [Token(Token = "0x400029E")]
  [FieldOffset(Offset = "0x1C")]
  public Color CollectColor;
  [Token(Token = "0x400029F")]
  [FieldOffset(Offset = "0x2C")]
  public BGColorCollect.CollectMode Mode;
  [Token(Token = "0x40002A0")]
  [FieldOffset(Offset = "0x30")]
  [Range(0.0f, 1f)]
  public float MixRatio;
  [Token(Token = "0x40002A1")]
  [FieldOffset(Offset = "0x34")]
  public bool FogRange;
  [Token(Token = "0x40002A2")]
  [FieldOffset(Offset = "0x38")]
  public Color FogColor;
  [Token(Token = "0x40002A3")]
  [FieldOffset(Offset = "0x48")]
  public float Start;
  [Token(Token = "0x40002A4")]
  [FieldOffset(Offset = "0x4C")]
  public float End;
  [Token(Token = "0x40002A5")]
  [FieldOffset(Offset = "0x50")]
  public bool BlendFog;
  [Token(Token = "0x40002A6")]
  [FieldOffset(Offset = "0x54")]
  public Color SkyColor;
  [Token(Token = "0x40002A7")]
  [FieldOffset(Offset = "0x64")]
  [Range(0.0f, 1f)]
  public float LightProbeForCharacters;
  [Token(Token = "0x40002A8")]
  [FieldOffset(Offset = "0x68")]
  [Range(0.0f, 1f)]
  public float LightProbeForDot;
  [Token(Token = "0x40002A9")]
  [FieldOffset(Offset = "0x6C")]
  [Range(0.0f, 1f)]
  public float LightProbeForRealtimeBG;
  [Token(Token = "0x40002AA")]
  [FieldOffset(Offset = "0x70")]
  public bool UseLightProbeMap;
  [Token(Token = "0x40002AB")]
  [FieldOffset(Offset = "0x78")]
  public Texture2D LightProbeMap;
  [Token(Token = "0x40002AC")]
  [FieldOffset(Offset = "0x80")]
  public Vector2 LightProbeMapScale;
  [Token(Token = "0x40002AD")]
  [FieldOffset(Offset = "0x88")]
  public Vector2 LightProbeMapOffset;

  [Token(Token = "0x600056B")]
  [Address(RVA = "0x44B1F08", Offset = "0x44B1F08", VA = "0x44B1F08")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x600056C")]
  [Address(RVA = "0x44B2100", Offset = "0x44B2100", VA = "0x44B2100")]
  private void Update()
  {
  }

  [Token(Token = "0x600056D")]
  [Address(RVA = "0x44B2490", Offset = "0x44B2490", VA = "0x44B2490")]
  public BGColorCollect()
  {
  }

  [Token(Token = "0x600056E")]
  [Address(RVA = "0x44B2530", Offset = "0x44B2530", VA = "0x44B2530")]
  static BGColorCollect()
  {
  }

  [Token(Token = "0x20000A9")]
  public enum CollectMode
  {
    [Token(Token = "0x40002AF")] Hardlight,
    [Token(Token = "0x40002B0")] Overlay,
    [Token(Token = "0x40002B1")] Mix,
  }
}
