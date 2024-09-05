// Decompiled with JetBrains decompiler
// Type: RadialBlurAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000193")]
[RequireComponent(typeof (Volume))]
[ExecuteInEditMode]
public class RadialBlurAnimator : MonoBehaviour
{
  [Token(Token = "0x4000A3B")]
  [FieldOffset(Offset = "0x18")]
  private RadialBlurPostProcessVolume volume;
  [Token(Token = "0x4000A3C")]
  [FieldOffset(Offset = "0x20")]
  public Vector2 center;
  [Token(Token = "0x4000A3D")]
  [FieldOffset(Offset = "0x28")]
  [Range(0.0f, 0.05f)]
  public float radius;
  [Token(Token = "0x4000A3E")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 20f)]
  public int iterationTime;

  [Token(Token = "0x6000AC7")]
  [Address(RVA = "0x4BBB084", Offset = "0x4BBB084", VA = "0x4BBB084")]
  private void Start()
  {
  }

  [Token(Token = "0x6000AC8")]
  [Address(RVA = "0x4BBB22C", Offset = "0x4BBB22C", VA = "0x4BBB22C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000AC9")]
  [Address(RVA = "0x4BBB4C4", Offset = "0x4BBB4C4", VA = "0x4BBB4C4")]
  public RadialBlurAnimator()
  {
  }
}
