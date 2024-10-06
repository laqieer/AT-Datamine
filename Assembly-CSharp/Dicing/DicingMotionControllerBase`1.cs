// Decompiled with JetBrains decompiler
// Type: Dicing.DicingMotionControllerBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Dicing
{
  [Token(Token = "0x2001F2F")]
  public abstract class DicingMotionControllerBase<T> : MonoBehaviour where T : struct
  {
    [Token(Token = "0x40085C3")]
    [FieldOffset(Offset = "0x0")]
    protected int direction;
    [Token(Token = "0x40085C4")]
    [FieldOffset(Offset = "0x0")]
    protected Coroutine coroutine;
    [Token(Token = "0x40085C5")]
    [FieldOffset(Offset = "0x0")]
    public Action<T> ChangeMotion;
    [Token(Token = "0x40085C6")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [Header("---ループ時の開始間隔")]
    private float intervalTime;
    [Token(Token = "0x40085C7")]
    [FieldOffset(Offset = "0x0")]
    private Coroutine debugCoroutine;
    [Token(Token = "0x40085C8")]
    [FieldOffset(Offset = "0x0")]
    protected T? fixedMotion;
    [Token(Token = "0x40085C9")]
    [FieldOffset(Offset = "0x0")]
    protected T? restartMotion;

    [Token(Token = "0x600B953")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600B954")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B955")]
    public abstract void FixedClose(float transitionTime = -1f);

    [Token(Token = "0x600B956")]
    public abstract void FixedOpen(float transitionTime = -1f);

    [Token(Token = "0x600B957")]
    protected abstract IEnumerator WaitDuration(float transitionTime = -1f, bool debugflag = false);

    [Token(Token = "0x600B958")]
    public void StartMotionOnce(float transitionTime, bool debugflag)
    {
    }

    [Token(Token = "0x600B959")]
    protected void StartMotionInternal(float transitionTime, bool debugflag = false)
    {
    }

    [Token(Token = "0x600B95A")]
    protected virtual void EndMotion()
    {
    }

    [Token(Token = "0x600B95B")]
    private IEnumerator DebugLoop() => (IEnumerator) null;

    [Token(Token = "0x600B95C")]
    public void StopDebugLoop()
    {
    }

    [Token(Token = "0x600B95D")]
    public void StartDebugLoop()
    {
    }

    [Token(Token = "0x600B95E")]
    protected DicingMotionControllerBase()
    {
    }

    [Token(Token = "0x2001F30")]
    protected interface IMotionGroup
    {
      [Token(Token = "0x1700267C")]
      T Motion { [Token(Token = "0x600B95F")] get; }

      [Token(Token = "0x1700267D")]
      float Duration { [Token(Token = "0x600B960")] get; }
    }

    [Token(Token = "0x2001F31")]
    protected class AnimationData
    {
      [Token(Token = "0x1700267E")]
      public float DelayTime
      {
        [Token(Token = "0x600B961")] get => new float();
        [Token(Token = "0x600B962")] private set
        {
        }
      }

      [Token(Token = "0x1700267F")]
      public T NextMotion
      {
        [Token(Token = "0x600B963")] get => (T) null;
        [Token(Token = "0x600B964")] private set
        {
        }
      }

      [Token(Token = "0x600B965")]
      public AnimationData(float duration, T nextMotion)
      {
      }
    }
  }
}
