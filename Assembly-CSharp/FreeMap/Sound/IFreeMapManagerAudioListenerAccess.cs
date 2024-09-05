// Decompiled with JetBrains decompiler
// Type: FreeMap.Sound.IFreeMapManagerAudioListenerAccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Sound
{
  [Token(Token = "0x2001846")]
  public interface IFreeMapManagerAudioListenerAccess
  {
    [Token(Token = "0x6008953")]
    void SetTargetCamera(Camera cameraRef);

    [Token(Token = "0x6008954")]
    void SetTargetTransfrom(Transform target);

    [Token(Token = "0x6008955")]
    void SetListenerPointParam(float rate, Vector3 offset);

    [Token(Token = "0x6008956")]
    void ChangeInterpolationRate(float rate, Vector3 offset, float time);

    [Token(Token = "0x6008957")]
    void AudioListenerUpdate();
  }
}
