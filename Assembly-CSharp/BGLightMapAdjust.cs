// Decompiled with JetBrains decompiler
// Type: BGLightMapAdjust
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000AA")]
public class BGLightMapAdjust : MonoBehaviour
{
  [Token(Token = "0x40002B2")]
  [FieldOffset(Offset = "0x0")]
  public static string UseToneName;
  [Token(Token = "0x40002B3")]
  [FieldOffset(Offset = "0x8")]
  public static string ToneIntensityName;
  [Token(Token = "0x40002B4")]
  [FieldOffset(Offset = "0x10")]
  public static string ToneShadowColorName;
  [Token(Token = "0x40002B5")]
  [FieldOffset(Offset = "0x18")]
  public static string ToneMidColorName;
  [Token(Token = "0x40002B6")]
  [FieldOffset(Offset = "0x20")]
  public static string ToneHighColorName;
  [Token(Token = "0x40002B7")]
  [FieldOffset(Offset = "0x28")]
  public static string ToneGammaName;
  [Token(Token = "0x40002B8")]
  [FieldOffset(Offset = "0x18")]
  [Range(0.0f, 1f)]
  public float GI_Intensity;
  [Token(Token = "0x40002B9")]
  [FieldOffset(Offset = "0x1C")]
  [ColorUsage(false, false)]
  public Color shadowColor;
  [Token(Token = "0x40002BA")]
  [FieldOffset(Offset = "0x2C")]
  [ColorUsage(false, false)]
  public Color midColor;
  [Token(Token = "0x40002BB")]
  [FieldOffset(Offset = "0x3C")]
  [ColorUsage(false, false)]
  public Color highColor;
  [Token(Token = "0x40002BC")]
  [FieldOffset(Offset = "0x4C")]
  [Range(0.0f, 2f)]
  public float Gamma;

  [Token(Token = "0x600056F")]
  [Address(RVA = "0x44B2634", Offset = "0x44B2634", VA = "0x44B2634")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000570")]
  [Address(RVA = "0x44B2748", Offset = "0x44B2748", VA = "0x44B2748")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000571")]
  [Address(RVA = "0x44B27A8", Offset = "0x44B27A8", VA = "0x44B27A8")]
  public BGLightMapAdjust()
  {
  }

  [Token(Token = "0x6000572")]
  [Address(RVA = "0x44B27D4", Offset = "0x44B27D4", VA = "0x44B27D4")]
  static BGLightMapAdjust()
  {
  }
}
