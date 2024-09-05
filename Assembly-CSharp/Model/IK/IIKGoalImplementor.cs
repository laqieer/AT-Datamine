// Decompiled with JetBrains decompiler
// Type: Model.IK.IIKGoalImplementor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Model.IK
{
  [Token(Token = "0x2003F23")]
  public interface IIKGoalImplementor : IIKImplementor
  {
    [Token(Token = "0x6019805")]
    bool TryGetIKPosition(in AvatarIKGoal goal, out Vector3 goalPosition);

    [Token(Token = "0x6019806")]
    bool TryGetIKPositionWeight(in AvatarIKGoal goal, out float value);

    [Token(Token = "0x6019807")]
    bool TryGetIKRotation(in AvatarIKGoal goal, out Quaternion goalRotation);

    [Token(Token = "0x6019808")]
    bool TryGetIKRotationWeight(in AvatarIKGoal goal, out float value);
  }
}
