// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapProcessBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017CE")]
  public abstract class FreeMapProcessBase<T> where T : FreeMapProcessBase<T>
  {
    [Token(Token = "0x40068BE")]
    [FieldOffset(Offset = "0x0")]
    public Action OnParentEnd;
    [Token(Token = "0x40068BF")]
    [FieldOffset(Offset = "0x0")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x40068C0")]
    [FieldOffset(Offset = "0x0")]
    private FreeMapProcessBase<T> processing;
    [Token(Token = "0x40068C2")]
    [FieldOffset(Offset = "0x0")]
    private bool isEnded;

    [Token(Token = "0x17001566")]
    private Queue<FreeMapProcessBase<T>> childProcesses
    {
      [Token(Token = "0x60086D7")] get => (Queue<FreeMapProcessBase<T>>) null;
    }

    [Token(Token = "0x60086D8")]
    public FreeMapProcessBase(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60086D9")]
    public virtual void Begin()
    {
    }

    [Token(Token = "0x60086DA")]
    public void Update()
    {
    }

    [Token(Token = "0x60086DB")]
    protected virtual void OnUpdate()
    {
    }

    [Token(Token = "0x60086DC")]
    protected void End()
    {
    }

    [Token(Token = "0x60086DD")]
    protected bool Next() => new bool();

    [Token(Token = "0x60086DE")]
    public virtual void OnBackKeyDownAction()
    {
    }

    [Token(Token = "0x60086DF")]
    private void OnChildEnd()
    {
    }

    [Token(Token = "0x60086E0")]
    protected void AddProcess(FreeMapProcessBase<T> process)
    {
    }

    [Token(Token = "0x60086E1")]
    protected void AddProcesses(params FreeMapProcessBase<T>[] processes)
    {
    }

    [Token(Token = "0x60086E2")]
    private void AddProcess(FreeMapProcessBase<T> process, Action action)
    {
    }
  }
}
