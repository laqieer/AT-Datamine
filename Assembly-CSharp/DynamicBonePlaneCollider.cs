// Decompiled with JetBrains decompiler
// Type: DynamicBonePlaneCollider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000CA")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Plane Collider")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
  [Token(Token = "0x60005E9")]
  [Address(RVA = "0x44BA490", Offset = "0x44BA490", VA = "0x44BA490")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x60005EA")]
  [Address(RVA = "0x44BA494", Offset = "0x44BA494", VA = "0x44BA494", Slot = "4")]
  public override void Collide(ref Vector3 particlePosition, float particleRadius)
  {
  }

  [Token(Token = "0x60005EB")]
  [Address(RVA = "0x44BA61C", Offset = "0x44BA61C", VA = "0x44BA61C")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x60005EC")]
  [Address(RVA = "0x44BA77C", Offset = "0x44BA77C", VA = "0x44BA77C")]
  public DynamicBonePlaneCollider()
  {
  }
}
