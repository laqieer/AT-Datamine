// Decompiled with JetBrains decompiler
// Type: RawImageGachaTriangleUVDissolveMaterialController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200020B")]
[RequireComponent(typeof (RawImage))]
[ExecuteInEditMode]
public class RawImageGachaTriangleUVDissolveMaterialController : MonoBehaviour
{
  [Token(Token = "0x4000C2F")]
  [FieldOffset(Offset = "0x18")]
  private Material targetMaterial;
  [Token(Token = "0x4000C30")]
  [FieldOffset(Offset = "0x20")]
  [Range(0.0f, 1f)]
  public float dissolve2;
  [Token(Token = "0x4000C31")]
  [FieldOffset(Offset = "0x24")]
  [Range(0.0f, 1f)]
  public float dissolve3;
  [Token(Token = "0x4000C32")]
  [FieldOffset(Offset = "0x28")]
  [Range(0.0f, 1f)]
  public float markDissolve;
  [Token(Token = "0x4000C33")]
  [FieldOffset(Offset = "0x0")]
  private static readonly int dissolve2PropertyID;
  [Token(Token = "0x4000C34")]
  [FieldOffset(Offset = "0x4")]
  private static readonly int dissolve3PropertyID;
  [Token(Token = "0x4000C35")]
  [FieldOffset(Offset = "0x8")]
  private static readonly int markDissolvePropertyID;

  [Token(Token = "0x6000CE2")]
  [Address(RVA = "0x4C7EDC0", Offset = "0x4C7EDC0", VA = "0x4C7EDC0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000CE3")]
  [Address(RVA = "0x4C7EE28", Offset = "0x4C7EE28", VA = "0x4C7EE28")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CE4")]
  [Address(RVA = "0x4C7EE2C", Offset = "0x4C7EE2C", VA = "0x4C7EE2C")]
  private void UpdateMaterialProperties()
  {
  }

  [Token(Token = "0x6000CE5")]
  [Address(RVA = "0x4C7EF28", Offset = "0x4C7EF28", VA = "0x4C7EF28")]
  public RawImageGachaTriangleUVDissolveMaterialController()
  {
  }

  [Token(Token = "0x6000CE6")]
  [Address(RVA = "0x4C7EF30", Offset = "0x4C7EF30", VA = "0x4C7EF30")]
  static RawImageGachaTriangleUVDissolveMaterialController()
  {
  }
}
