// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapPlayerProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017D4")]
  public abstract class FreeMapPlayerProcess
  {
    [Token(Token = "0x40068CA")]
    [FieldOffset(Offset = "0x10")]
    public Action OnParentEnd;
    [Token(Token = "0x40068CB")]
    [FieldOffset(Offset = "0x18")]
    protected FreeMapStateManager entity;

    [Token(Token = "0x60086F1")]
    [Address(RVA = "0x43CE9E8", Offset = "0x43CE9E8", VA = "0x43CE9E8")]
    public FreeMapPlayerProcess(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60086F2")]
    [Address(RVA = "0x43D30B8", Offset = "0x43D30B8", VA = "0x43D30B8", Slot = "4")]
    public virtual void Begin()
    {
    }

    [Token(Token = "0x60086F3")]
    [Address(RVA = "0x43D30BC", Offset = "0x43D30BC", VA = "0x43D30BC")]
    public void Update()
    {
    }

    [Token(Token = "0x60086F4")]
    [Address(RVA = "0x43D30C8", Offset = "0x43D30C8", VA = "0x43D30C8", Slot = "5")]
    protected virtual void OnUpdate()
    {
    }

    [Token(Token = "0x60086F5")]
    [Address(RVA = "0x43D30CC", Offset = "0x43D30CC", VA = "0x43D30CC", Slot = "6")]
    protected virtual void OnEnd()
    {
    }

    [Token(Token = "0x60086F6")]
    [Address(RVA = "0x43CEC68", Offset = "0x43CEC68", VA = "0x43CEC68")]
    protected void End()
    {
    }

    [Token(Token = "0x60086F7")]
    [Address(RVA = "0x43D30D0", Offset = "0x43D30D0", VA = "0x43D30D0", Slot = "7")]
    public virtual void Abort()
    {
    }
  }
}
