// Decompiled with JetBrains decompiler
// Type: WaterParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000B6")]
[RequireComponent(typeof (Renderer))]
[DisallowMultipleComponent]
public class WaterParameters : MonoBehaviour
{
  [Token(Token = "0x40002E8")]
  [FieldOffset(Offset = "0x0")]
  private static readonly float LimitTime;
  [Token(Token = "0x40002E9")]
  [FieldOffset(Offset = "0x4")]
  private static readonly float Period;
  [Token(Token = "0x40002EA")]
  [FieldOffset(Offset = "0x8")]
  private static readonly Vector4 Variant;
  [Token(Token = "0x40002EB")]
  [FieldOffset(Offset = "0x18")]
  private static readonly float SpeedAdjustment;
  [Token(Token = "0x40002EC")]
  [FieldOffset(Offset = "0x18")]
  private Renderer rend;
  [Token(Token = "0x40002ED")]
  [FieldOffset(Offset = "0x20")]
  private float time;
  [Token(Token = "0x40002EE")]
  [FieldOffset(Offset = "0x24")]
  private int idSpeedU;
  [Token(Token = "0x40002EF")]
  [FieldOffset(Offset = "0x28")]
  private int idSpeedV;
  [Token(Token = "0x40002F0")]
  [FieldOffset(Offset = "0x2C")]
  private int idRandomness;
  [Token(Token = "0x40002F1")]
  [FieldOffset(Offset = "0x30")]
  private int idSpeed;
  [Token(Token = "0x40002F2")]
  [FieldOffset(Offset = "0x34")]
  private int idNormalUVOffsetA;
  [Token(Token = "0x40002F3")]
  [FieldOffset(Offset = "0x38")]
  private int idNormalUVOffsetA2;
  [Token(Token = "0x40002F4")]
  [FieldOffset(Offset = "0x3C")]
  private int idNormalUVOffsetB;
  [Token(Token = "0x40002F5")]
  [FieldOffset(Offset = "0x40")]
  private int idNormalUVOffsetB2;
  [Token(Token = "0x40002F6")]
  [FieldOffset(Offset = "0x44")]
  private int idFlowNormalWeightA;
  [Token(Token = "0x40002F7")]
  [FieldOffset(Offset = "0x48")]
  private int idFoamUVOffset;
  [Token(Token = "0x40002F8")]
  [FieldOffset(Offset = "0x4C")]
  private int idFoamTime;

  [Token(Token = "0x6000593")]
  [Address(RVA = "0x44B3E74", Offset = "0x44B3E74", VA = "0x44B3E74")]
  private void Start()
  {
  }

  [Token(Token = "0x6000594")]
  [Address(RVA = "0x44B4070", Offset = "0x44B4070", VA = "0x44B4070")]
  private void Update()
  {
  }

  [Token(Token = "0x6000595")]
  [Address(RVA = "0x44B4638", Offset = "0x44B4638", VA = "0x44B4638")]
  public WaterParameters()
  {
  }

  [Token(Token = "0x6000596")]
  [Address(RVA = "0x44B4640", Offset = "0x44B4640", VA = "0x44B4640")]
  static WaterParameters()
  {
  }
}
