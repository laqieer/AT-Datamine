// Decompiled with JetBrains decompiler
// Type: Battle.ValueCurve`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x20022A5")]
  public abstract class ValueCurve<T>
  {
    [Token(Token = "0x4009204")]
    [FieldOffset(Offset = "0x0")]
    public static readonly AnimationCurve DefaultCurve;
    [Token(Token = "0x4009205")]
    [FieldOffset(Offset = "0x0")]
    public static readonly AnimationCurve DefaultLinear;
    [Token(Token = "0x4009206")]
    [FieldOffset(Offset = "0x0")]
    public static readonly AnimationCurve DefaultPingpong;
    [Token(Token = "0x4009207")]
    [FieldOffset(Offset = "0x0")]
    private float duration;
    [Token(Token = "0x4009208")]
    [FieldOffset(Offset = "0x0")]
    private float passed;
    [Token(Token = "0x4009209")]
    [FieldOffset(Offset = "0x0")]
    protected T start;
    [Token(Token = "0x400920A")]
    [FieldOffset(Offset = "0x0")]
    protected T target;
    [Token(Token = "0x400920D")]
    [FieldOffset(Offset = "0x0")]
    public Action OnCompleteAction;

    [Token(Token = "0x17002DCE")]
    public bool IsCompleted
    {
      [Token(Token = "0x600D34F")] get => new bool();
    }

    [Token(Token = "0x17002DCF")]
    public bool IsActive
    {
      [Token(Token = "0x600D350")] get => new bool();
      [Token(Token = "0x600D351")] private set
      {
      }
    }

    [Token(Token = "0x17002DD0")]
    public AnimationCurve TweenCurve
    {
      [Token(Token = "0x600D352")] get => (AnimationCurve) null;
      [Token(Token = "0x600D353")] set
      {
      }
    }

    [Token(Token = "0x600D354")]
    public void Start(float duration, T start, T target)
    {
    }

    [Token(Token = "0x600D355")]
    public T Evaluate(float delta) => (T) null;

    [Token(Token = "0x600D356")]
    protected virtual T GetValueOnCompleted() => (T) null;

    [Token(Token = "0x600D357")]
    public void Reset()
    {
    }

    [Token(Token = "0x600D358")]
    protected abstract T EvaluateInternal(float curveValue);

    [Token(Token = "0x600D359")]
    protected ValueCurve()
    {
    }

    [Token(Token = "0x600D35A")]
    static ValueCurve()
    {
    }
  }
}
