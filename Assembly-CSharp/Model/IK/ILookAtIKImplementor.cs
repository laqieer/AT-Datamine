// Decompiled with JetBrains decompiler
// Type: Model.IK.ILookAtIKImplementor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Model.IK
{
  [Token(Token = "0x2003F25")]
  public interface ILookAtIKImplementor : IIKImplementor
  {
    [Token(Token = "0x601980B")]
    bool TryGetLookAtWeight(
      out float weight,
      out float bodyWeight,
      out float headWeight,
      out float eyesWeight,
      out float clampWeight);

    [Token(Token = "0x601980C")]
    bool TryGetLookAtPosition(out Vector3 position);
  }
}
