// Decompiled with JetBrains decompiler
// Type: Model.IK.IIKHintImplementor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Model.IK
{
  [Token(Token = "0x2003F24")]
  public interface IIKHintImplementor : IIKImplementor
  {
    [Token(Token = "0x6019809")]
    bool TryGetIKPosition(in AvatarIKHint hint, out Vector3 hintPosition);

    [Token(Token = "0x601980A")]
    bool TryGetIKPositionWeight(in AvatarIKHint hint, out float value);
  }
}
