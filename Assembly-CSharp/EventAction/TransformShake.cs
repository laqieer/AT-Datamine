// Decompiled with JetBrains decompiler
// Type: EventAction.TransformShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace EventAction
{
  [Token(Token = "0x2001F12")]
  public class TransformShake : EventActionBehaviour
  {
    [Token(Token = "0x4008550")]
    [FieldOffset(Offset = "0x20")]
    public TransformShake.Properties PropertiesSetting;
    [Token(Token = "0x4008551")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 pos;
    [Token(Token = "0x4008552")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 dir;

    [Token(Token = "0x600B895")]
    [Address(RVA = "0x2134DB4", Offset = "0x2134DB4", VA = "0x2134DB4", Slot = "6")]
    protected override IEnumerator Playing() => (IEnumerator) null;

    [Token(Token = "0x600B896")]
    [Address(RVA = "0x2134E44", Offset = "0x2134E44", VA = "0x2134E44", Slot = "7")]
    protected override void OnFinish()
    {
    }

    [Token(Token = "0x600B897")]
    [Address(RVA = "0x2134E50", Offset = "0x2134E50", VA = "0x2134E50")]
    private Vector3 CalculateDirection(float time) => new Vector3();

    [Token(Token = "0x600B898")]
    [Address(RVA = "0x2135100", Offset = "0x2135100", VA = "0x2135100")]
    private float Theta(
      float time,
      TransformShake.Frequency frequency,
      Func<TransformShake.Frequency, float> func)
    {
      return new float();
    }

    [Token(Token = "0x600B899")]
    [Address(RVA = "0x213514C", Offset = "0x213514C", VA = "0x213514C")]
    public TransformShake()
    {
    }

    [Token(Token = "0x2001F13")]
    [Serializable]
    public struct Frequency
    {
      [Token(Token = "0x4008553")]
      [FieldOffset(Offset = "0x0")]
      public float x;
      [Token(Token = "0x4008554")]
      [FieldOffset(Offset = "0x4")]
      public float y;
      [Token(Token = "0x4008555")]
      [FieldOffset(Offset = "0x8")]
      public float z;
      [Token(Token = "0x4008556")]
      [FieldOffset(Offset = "0x0")]
      public static TransformShake.Frequency Default;

      [Token(Token = "0x600B89A")]
      [Address(RVA = "0x2135154", Offset = "0x2135154", VA = "0x2135154")]
      static Frequency()
      {
      }
    }

    [Token(Token = "0x2001F14")]
    [Serializable]
    public class Properties
    {
      [Token(Token = "0x4008557")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public TransformShake.Frequency frequency;
      [Token(Token = "0x4008558")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      public AnimationCurve strength;
      [Token(Token = "0x4008559")]
      [FieldOffset(Offset = "0x28")]
      [Min(0.1f)]
      [SerializeField]
      public float amplitude;
      [Token(Token = "0x400855A")]
      [FieldOffset(Offset = "0x2C")]
      [SerializeField]
      public float duration;
      [Token(Token = "0x400855B")]
      [FieldOffset(Offset = "0x30")]
      [SerializeField]
      public float delay;

      [Token(Token = "0x600B89B")]
      [Address(RVA = "0x21351A8", Offset = "0x21351A8", VA = "0x21351A8")]
      public Properties()
      {
      }
    }
  }
}
