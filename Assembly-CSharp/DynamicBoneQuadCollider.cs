// Decompiled with JetBrains decompiler
// Type: DynamicBoneQuadCollider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000CB")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Quad Collider")]
public class DynamicBoneQuadCollider : DynamicBoneColliderBase
{
  [Token(Token = "0x4000363")]
  [FieldOffset(Offset = "0x2C")]
  [SerializeField]
  [Tooltip("四角形の回転値")]
  private Vector3 rotate;
  [Token(Token = "0x4000364")]
  [FieldOffset(Offset = "0x38")]
  [Tooltip("四角形の1/2の横サイズ")]
  [SerializeField]
  private float halfWidth;
  [Token(Token = "0x4000365")]
  [FieldOffset(Offset = "0x3C")]
  [Tooltip("四角形の1/2の縦サイズ")]
  [SerializeField]
  private float halfHeight;
  [Token(Token = "0x4000366")]
  [FieldOffset(Offset = "0x40")]
  private Vector3[] positions;
  [Token(Token = "0x4000367")]
  [FieldOffset(Offset = "0x48")]
  private Vector3 normal;
  [Token(Token = "0x4000368")]
  [FieldOffset(Offset = "0x54")]
  private float normalDot;
  [Token(Token = "0x4000369")]
  [FieldOffset(Offset = "0x58")]
  private float normalDenom;
  [Token(Token = "0x400036A")]
  private const float epsilon = 1E-05f;
  [Token(Token = "0x400036B")]
  [FieldOffset(Offset = "0x5C")]
  private Vector3 centerPosition;
  [Token(Token = "0x400036C")]
  [FieldOffset(Offset = "0x68")]
  private bool isFrameUpdateMatrix;

  [Token(Token = "0x60005ED")]
  [Address(RVA = "0x417CEAC", Offset = "0x417CEAC", VA = "0x417CEAC", Slot = "4")]
  public override void Collide(ref Vector3 particlePosition, float particleRadius)
  {
  }

  [Token(Token = "0x60005EE")]
  [Address(RVA = "0x417D814", Offset = "0x417D814", VA = "0x417D814")]
  private void Update()
  {
  }

  [Token(Token = "0x60005EF")]
  [Address(RVA = "0x417D0E4", Offset = "0x417D0E4", VA = "0x417D0E4")]
  private void UpdateMatrix()
  {
  }

  [Token(Token = "0x60005F0")]
  [Address(RVA = "0x417D660", Offset = "0x417D660", VA = "0x417D660")]
  private bool GetClosestPosition(Vector3 targetPosition, ref Vector3 movePosition) => new bool();

  [Token(Token = "0x60005F1")]
  [Address(RVA = "0x417D81C", Offset = "0x417D81C", VA = "0x417D81C")]
  private bool CheckInsideTriangle(
    Vector3 position1,
    Vector3 position2,
    Vector3 position3,
    Vector3 targetPosition)
  {
    return new bool();
  }

  [Token(Token = "0x60005F2")]
  [Address(RVA = "0x417D964", Offset = "0x417D964", VA = "0x417D964")]
  public DynamicBoneQuadCollider()
  {
  }
}
