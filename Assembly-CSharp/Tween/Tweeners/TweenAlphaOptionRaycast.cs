// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenAlphaOptionRaycast
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000506")]
  [AddComponentMenu("Tween/Tweeners/Tween Alpha Option Raycast")]
  public class TweenAlphaOptionRaycast : MonoBehaviour
  {
    [Token(Token = "0x4001AE9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("Raycastをオフにするアルファの閾値")]
    private float raycastOffThreshold;
    [Token(Token = "0x4001AEA")]
    private const float DefaultThreshold = 0.001f;

    [Token(Token = "0x6001CF1")]
    [Address(RVA = "0x29F7D1C", Offset = "0x29F7D1C", VA = "0x29F7D1C")]
    public bool IsEnable(float alpha) => new bool();

    [Token(Token = "0x6001CF2")]
    [Address(RVA = "0x29F7D2C", Offset = "0x29F7D2C", VA = "0x29F7D2C")]
    public TweenAlphaOptionRaycast()
    {
    }
  }
}
