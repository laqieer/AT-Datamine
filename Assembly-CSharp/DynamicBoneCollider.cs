// Decompiled with JetBrains decompiler
// Type: DynamicBoneCollider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000C6")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
  [Token(Token = "0x4000357")]
  [FieldOffset(Offset = "0x2C")]
  public float m_Radius;
  [Token(Token = "0x4000358")]
  [FieldOffset(Offset = "0x30")]
  public float m_Height;

  [Token(Token = "0x60005DF")]
  [Address(RVA = "0x44B9CEC", Offset = "0x44B9CEC", VA = "0x44B9CEC")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x60005E0")]
  [Address(RVA = "0x44B9D04", Offset = "0x44B9D04", VA = "0x44B9D04", Slot = "4")]
  public override void Collide(ref Vector3 particlePosition, float particleRadius)
  {
  }

  [Token(Token = "0x60005E1")]
  [Address(RVA = "0x44B9EF8", Offset = "0x44B9EF8", VA = "0x44B9EF8")]
  private static void OutsideSphere(
    ref Vector3 particlePosition,
    float particleRadius,
    Vector3 sphereCenter,
    float sphereRadius)
  {
  }

  [Token(Token = "0x60005E2")]
  [Address(RVA = "0x44B9F58", Offset = "0x44B9F58", VA = "0x44B9F58")]
  private static void InsideSphere(
    ref Vector3 particlePosition,
    float particleRadius,
    Vector3 sphereCenter,
    float sphereRadius)
  {
  }

  [Token(Token = "0x60005E3")]
  [Address(RVA = "0x44B9FB0", Offset = "0x44B9FB0", VA = "0x44B9FB0")]
  private static void OutsideCapsule(
    ref Vector3 particlePosition,
    float particleRadius,
    Vector3 capsuleP0,
    Vector3 capsuleP1,
    float capsuleRadius)
  {
  }

  [Token(Token = "0x60005E4")]
  [Address(RVA = "0x44BA124", Offset = "0x44BA124", VA = "0x44BA124")]
  private static void InsideCapsule(
    ref Vector3 particlePosition,
    float particleRadius,
    Vector3 capsuleP0,
    Vector3 capsuleP1,
    float capsuleRadius)
  {
  }

  [Token(Token = "0x60005E5")]
  [Address(RVA = "0x44BA280", Offset = "0x44BA280", VA = "0x44BA280")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x60005E6")]
  [Address(RVA = "0x44BA41C", Offset = "0x44BA41C", VA = "0x44BA41C")]
  public DynamicBoneCollider()
  {
  }
}
