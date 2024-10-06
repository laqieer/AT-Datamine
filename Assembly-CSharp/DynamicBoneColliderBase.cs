// Decompiled with JetBrains decompiler
// Type: DynamicBoneColliderBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000C7")]
public class DynamicBoneColliderBase : MonoBehaviour
{
  [Token(Token = "0x4000359")]
  [FieldOffset(Offset = "0x18")]
  public DynamicBoneColliderBase.Direction m_Direction;
  [Token(Token = "0x400035A")]
  [FieldOffset(Offset = "0x1C")]
  public Vector3 m_Center;
  [Token(Token = "0x400035B")]
  [FieldOffset(Offset = "0x28")]
  public DynamicBoneColliderBase.Bound m_Bound;

  [Token(Token = "0x60005E7")]
  [Address(RVA = "0x44BA48C", Offset = "0x44BA48C", VA = "0x44BA48C", Slot = "4")]
  public virtual void Collide(ref Vector3 particlePosition, float particleRadius)
  {
  }

  [Token(Token = "0x60005E8")]
  [Address(RVA = "0x44BA428", Offset = "0x44BA428", VA = "0x44BA428")]
  public DynamicBoneColliderBase()
  {
  }

  [Token(Token = "0x20000C8")]
  public enum Direction
  {
    [Token(Token = "0x400035D")] X,
    [Token(Token = "0x400035E")] Y,
    [Token(Token = "0x400035F")] Z,
  }

  [Token(Token = "0x20000C9")]
  public enum Bound
  {
    [Token(Token = "0x4000361")] Outside,
    [Token(Token = "0x4000362")] Inside,
  }
}
