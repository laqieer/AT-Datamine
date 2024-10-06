// Decompiled with JetBrains decompiler
// Type: FreeMap.Animation.OverrideIKGoal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Model.IK;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Animation
{
  [Token(Token = "0x2001971")]
  public class OverrideIKGoal : IIKGoalImplementor, IIKImplementor
  {
    [Token(Token = "0x4006D64")]
    [FieldOffset(Offset = "0x10")]
    private global::IK component;
    [Token(Token = "0x4006D65")]
    [FieldOffset(Offset = "0x18")]
    private IIKGoalImplementor componentImpl;
    [Token(Token = "0x4006D66")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<AvatarIKGoal, Transform> IKTransformDic;
    [Token(Token = "0x4006D67")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<AvatarIKGoal, float> PosWeightDic;
    [Token(Token = "0x4006D68")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<AvatarIKGoal, float> RotWeightDic;

    [Token(Token = "0x6009115")]
    [Address(RVA = "0x4D08170", Offset = "0x4D08170", VA = "0x4D08170")]
    public void Initialize(Animator animator)
    {
    }

    [Token(Token = "0x6009116")]
    [Address(RVA = "0x4D082D0", Offset = "0x4D082D0", VA = "0x4D082D0")]
    public void Release()
    {
    }

    [Token(Token = "0x6009117")]
    [Address(RVA = "0x4D083A4", Offset = "0x4D083A4", VA = "0x4D083A4")]
    public void SetIKObject(AvatarIKGoal goal, Transform obj, float posWeight, float rotWeight)
    {
    }

    [Token(Token = "0x6009118")]
    [Address(RVA = "0x4D08460", Offset = "0x4D08460", VA = "0x4D08460")]
    public bool TryGetIKPosition(in AvatarIKGoal goal, out Vector3 goalPosition) => new bool();

    [Token(Token = "0x6009119")]
    [Address(RVA = "0x4D08650", Offset = "0x4D08650", VA = "0x4D08650")]
    public bool TryGetIKPositionWeight(in AvatarIKGoal goal, out float value) => new bool();

    [Token(Token = "0x600911A")]
    [Address(RVA = "0x4D08758", Offset = "0x4D08758", VA = "0x4D08758")]
    public bool TryGetIKRotation(in AvatarIKGoal goal, out Quaternion goalRotation) => new bool();

    [Token(Token = "0x600911B")]
    [Address(RVA = "0x4D088CC", Offset = "0x4D088CC", VA = "0x4D088CC")]
    public bool TryGetIKRotationWeight(in AvatarIKGoal goal, out float value) => new bool();

    [Token(Token = "0x600911C")]
    [Address(RVA = "0x4D085D8", Offset = "0x4D085D8", VA = "0x4D085D8")]
    private Transform GetGoalTransform(in AvatarIKGoal goal) => (Transform) null;

    [Token(Token = "0x600911D")]
    [Address(RVA = "0x4D089D4", Offset = "0x4D089D4", VA = "0x4D089D4")]
    public OverrideIKGoal()
    {
    }

    [Token(Token = "0x600911E")]
    [Address(RVA = "0x4D08AB8", Offset = "0x4D08AB8", VA = "0x4D08AB8", Slot = "4")]
    private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKPosition(
      in AvatarIKGoal goal,
      out Vector3 goalPosition)
    {
      return new bool();
    }

    [Token(Token = "0x600911F")]
    [Address(RVA = "0x4D08ABC", Offset = "0x4D08ABC", VA = "0x4D08ABC", Slot = "5")]
    private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKPositionWeight(
      in AvatarIKGoal goal,
      out float value)
    {
      return new bool();
    }

    [Token(Token = "0x6009120")]
    [Address(RVA = "0x4D08AC0", Offset = "0x4D08AC0", VA = "0x4D08AC0", Slot = "6")]
    private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKRotation(
      in AvatarIKGoal goal,
      out Quaternion goalRotation)
    {
      return new bool();
    }

    [Token(Token = "0x6009121")]
    [Address(RVA = "0x4D08AC4", Offset = "0x4D08AC4", VA = "0x4D08AC4", Slot = "7")]
    private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKRotationWeight(
      in AvatarIKGoal goal,
      out float value)
    {
      return new bool();
    }
  }
}
