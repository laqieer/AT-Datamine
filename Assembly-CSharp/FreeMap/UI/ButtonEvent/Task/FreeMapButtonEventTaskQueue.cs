// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.FreeMapButtonEventTaskQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001726")]
  public class FreeMapButtonEventTaskQueue : IFreeMapButtonEventTask
  {
    [Token(Token = "0x400670D")]
    [FieldOffset(Offset = "0x10")]
    protected int processCounter;
    [Token(Token = "0x400670E")]
    [FieldOffset(Offset = "0x18")]
    protected List<IFreeMapButtonEventTask> tasks;
    [Token(Token = "0x400670F")]
    [FieldOffset(Offset = "0x20")]
    protected IFreeMapButtonEventTask current;

    [Token(Token = "0x60082FB")]
    [Address(RVA = "0x4203248", Offset = "0x4203248", VA = "0x4203248", Slot = "7")]
    public virtual void Enqueue(IFreeMapButtonEventTask task)
    {
    }

    [Token(Token = "0x60082FC")]
    [Address(RVA = "0x42032F0", Offset = "0x42032F0", VA = "0x42032F0", Slot = "8")]
    public virtual void Execute()
    {
    }

    [Token(Token = "0x60082FD")]
    [Address(RVA = "0x42033C4", Offset = "0x42033C4", VA = "0x42033C4", Slot = "9")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x60082FE")]
    [Address(RVA = "0x420356C", Offset = "0x420356C", VA = "0x420356C", Slot = "10")]
    public virtual bool IsBusy() => new bool();

    [Token(Token = "0x60082FF")]
    [Address(RVA = "0x420357C", Offset = "0x420357C", VA = "0x420357C")]
    public FreeMapButtonEventTaskQueue()
    {
    }
  }
}
