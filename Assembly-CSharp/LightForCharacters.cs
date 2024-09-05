// Decompiled with JetBrains decompiler
// Type: LightForCharacters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000D9")]
[DisallowMultipleComponent]
public class LightForCharacters : MonoBehaviour
{
  [Token(Token = "0x40003BE")]
  [FieldOffset(Offset = "0x0")]
  private static readonly Color[] ColorsByType;
  [Token(Token = "0x40003BF")]
  [FieldOffset(Offset = "0x8")]
  private static readonly float[] IntensitiesByType;
  [Token(Token = "0x40003C0")]
  [FieldOffset(Offset = "0x10")]
  private static readonly Quaternion[] RotationsByType;
  [Token(Token = "0x40003C1")]
  [FieldOffset(Offset = "0x18")]
  private static readonly int[] DirectionIndicesPrecomputed;
  [Token(Token = "0x40003C2")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private LightForCharacters.LightColorType selectedColorType;
  [Token(Token = "0x40003C3")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private LightForCharacters.LightDirectionType selectedDirectionType;
  [Token(Token = "0x40003C4")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Color color;
  [Token(Token = "0x40003C5")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private float intensity;
  [Token(Token = "0x40003C6")]
  [FieldOffset(Offset = "0x34")]
  private int mainLightPositionID;
  [Token(Token = "0x40003C7")]
  [FieldOffset(Offset = "0x38")]
  private int mainLightColorID;
  [Token(Token = "0x40003C8")]
  [FieldOffset(Offset = "0x20")]
  private static readonly int Segment;
  [Token(Token = "0x40003C9")]
  [FieldOffset(Offset = "0x28")]
  private static Vector3[] directions;
  [Token(Token = "0x40003CA")]
  [FieldOffset(Offset = "0x30")]
  private static readonly float MinimumDP;
  [Token(Token = "0x40003CB")]
  [FieldOffset(Offset = "0x3C")]
  private Quaternion rotation;

  [Token(Token = "0x600065E")]
  [Address(RVA = "0x4181D58", Offset = "0x4181D58", VA = "0x4181D58")]
  public LightForCharacters.LightColorType GetColorType()
  {
    return new LightForCharacters.LightColorType();
  }

  [Token(Token = "0x600065F")]
  [Address(RVA = "0x4181D60", Offset = "0x4181D60", VA = "0x4181D60")]
  public void SetColorType(LightForCharacters.LightColorType lightColorType)
  {
  }

  [Token(Token = "0x6000660")]
  [Address(RVA = "0x4181D68", Offset = "0x4181D68", VA = "0x4181D68")]
  public Color GetColor() => new Color();

  [Token(Token = "0x6000661")]
  [Address(RVA = "0x4181D74", Offset = "0x4181D74", VA = "0x4181D74")]
  public void SetColor(Color color)
  {
  }

  [Token(Token = "0x6000662")]
  [Address(RVA = "0x4181D80", Offset = "0x4181D80", VA = "0x4181D80")]
  public float GetIntensity() => new float();

  [Token(Token = "0x6000663")]
  [Address(RVA = "0x4181D88", Offset = "0x4181D88", VA = "0x4181D88")]
  public void SetIntensity(float intensity)
  {
  }

  [Token(Token = "0x6000664")]
  [Address(RVA = "0x4181D90", Offset = "0x4181D90", VA = "0x4181D90")]
  public LightForCharacters.LightDirectionType GetLightDirectionType()
  {
    return new LightForCharacters.LightDirectionType();
  }

  [Token(Token = "0x6000665")]
  [Address(RVA = "0x4181D98", Offset = "0x4181D98", VA = "0x4181D98")]
  public void SetLightDirectionType(
    LightForCharacters.LightDirectionType lightDirectionType)
  {
  }

  [Token(Token = "0x6000666")]
  [Address(RVA = "0x4181DA0", Offset = "0x4181DA0", VA = "0x4181DA0")]
  static LightForCharacters()
  {
  }

  [Token(Token = "0x6000667")]
  [Address(RVA = "0x418257C", Offset = "0x418257C", VA = "0x418257C")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000668")]
  [Address(RVA = "0x41825F8", Offset = "0x41825F8", VA = "0x41825F8")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000669")]
  [Address(RVA = "0x4182670", Offset = "0x4182670", VA = "0x4182670")]
  public void ApplyColorSetting(LightForCharacters.LightColorType type)
  {
  }

  [Token(Token = "0x600066A")]
  [Address(RVA = "0x4182724", Offset = "0x4182724", VA = "0x4182724")]
  public void ApplyDirectionSetting(LightForCharacters.LightDirectionType type)
  {
  }

  [Token(Token = "0x600066B")]
  [Address(RVA = "0x41827D4", Offset = "0x41827D4", VA = "0x41827D4")]
  private static int GetDirectionsIndexByRotation(Quaternion localRotation) => new int();

  [Token(Token = "0x600066C")]
  [Address(RVA = "0x4182988", Offset = "0x4182988", VA = "0x4182988")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x600066D")]
  [Address(RVA = "0x4182C58", Offset = "0x4182C58", VA = "0x4182C58")]
  public LightForCharacters()
  {
  }

  [Token(Token = "0x20000DA")]
  public enum LightColorType
  {
    [Token(Token = "0x40003CD")] Custom,
    [Token(Token = "0x40003CE")] Daylight,
    [Token(Token = "0x40003CF")] Cloudy,
    [Token(Token = "0x40003D0")] Sunset,
    [Token(Token = "0x40003D1")] Night,
    [Token(Token = "0x40003D2")] Eclipse,
  }

  [Token(Token = "0x20000DB")]
  public enum LightDirectionType
  {
    [Token(Token = "0x40003D4")] Custom,
    [Token(Token = "0x40003D5")] TopRight,
    [Token(Token = "0x40003D6")] TopLeft,
    [Token(Token = "0x40003D7")] TopBack,
    [Token(Token = "0x40003D8")] MiddleRight,
    [Token(Token = "0x40003D9")] MiddleLeft,
    [Token(Token = "0x40003DA")] MiddleBack,
    [Token(Token = "0x40003DB")] Bottom,
  }
}
