// Decompiled with JetBrains decompiler
// Type: Battle.Particle.HpStockBreakParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.Particle
{
  [Token(Token = "0x20024BF")]
  public class HpStockBreakParticle : MonoBehaviour
  {
    [Token(Token = "0x4009D95")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ParticleSystem particle;
    [Token(Token = "0x4009D96")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4009D97")]
    private const string tweenName = "HPStockDown";

    [Token(Token = "0x600E212")]
    [Address(RVA = "0x4014290", Offset = "0x4014290", VA = "0x4014290")]
    public void Play(Action breakAction, Action CompleteAction)
    {
    }

    [Token(Token = "0x600E213")]
    [Address(RVA = "0x40142B0", Offset = "0x40142B0", VA = "0x40142B0")]
    private IEnumerator StartCoroutine(Action breakAction, Action CompleteAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600E214")]
    [Address(RVA = "0x4014354", Offset = "0x4014354", VA = "0x4014354")]
    private IEnumerator WaitCoroutine(float waitTime, Action action) => (IEnumerator) null;

    [Token(Token = "0x600E215")]
    [Address(RVA = "0x40143F4", Offset = "0x40143F4", VA = "0x40143F4")]
    public HpStockBreakParticle()
    {
    }
  }
}
