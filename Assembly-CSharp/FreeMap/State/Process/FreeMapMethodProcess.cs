// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapMethodProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017D2")]
  public abstract class FreeMapMethodProcess
  {
    [Token(Token = "0x40068C6")]
    [FieldOffset(Offset = "0x10")]
    public Action OnParentEnd;
    [Token(Token = "0x40068C7")]
    [FieldOffset(Offset = "0x18")]
    protected FreeMapStateManager entity;

    [Token(Token = "0x60086E9")]
    [Address(RVA = "0x43D2F14", Offset = "0x43D2F14", VA = "0x43D2F14")]
    public FreeMapMethodProcess(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60086EA")]
    [Address(RVA = "0x43D3008", Offset = "0x43D3008", VA = "0x43D3008", Slot = "4")]
    public virtual void Begin()
    {
    }

    [Token(Token = "0x60086EB")]
    [Address(RVA = "0x43D300C", Offset = "0x43D300C", VA = "0x43D300C", Slot = "5")]
    protected virtual void OnEnd()
    {
    }

    [Token(Token = "0x60086EC")]
    [Address(RVA = "0x43D3010", Offset = "0x43D3010", VA = "0x43D3010")]
    protected void End()
    {
    }

    [Token(Token = "0x60086ED")]
    [Address(RVA = "0x43D3044", Offset = "0x43D3044", VA = "0x43D3044", Slot = "6")]
    public virtual void Abort()
    {
    }
  }
}
