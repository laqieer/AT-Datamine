// Decompiled with JetBrains decompiler
// Type: Battle.Particle.IParticleTransformUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Particle
{
  [Token(Token = "0x20024CA")]
  public interface IParticleTransformUpdater
  {
    [Token(Token = "0x600E253")]
    void UpdatePosition(Vector3 pos);

    [Token(Token = "0x600E254")]
    void UpdateLocalPosition(Vector3 pos);

    [Token(Token = "0x600E255")]
    void UpdateRotation(Quaternion rot);

    [Token(Token = "0x600E256")]
    void UpdateLocalRotation(Quaternion rot);

    [Token(Token = "0x600E257")]
    void LookAtTo(Vector3 target);
  }
}
