// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.FreeMapButtonEventTaskList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x200171A")]
  public class FreeMapButtonEventTaskList : IFreeMapButtonEventTask
  {
    [Token(Token = "0x40066F1")]
    [FieldOffset(Offset = "0x10")]
    protected List<IFreeMapButtonEventTask> tasks;

    [Token(Token = "0x60082BE")]
    [Address(RVA = "0x41F7198", Offset = "0x41F7198", VA = "0x41F7198")]
    public void Add(IFreeMapButtonEventTask task)
    {
    }

    [Token(Token = "0x60082BF")]
    [Address(RVA = "0x41FB034", Offset = "0x41FB034", VA = "0x41FB034")]
    public void Clear()
    {
    }

    [Token(Token = "0x60082C0")]
    [Address(RVA = "0x4201CBC", Offset = "0x4201CBC", VA = "0x4201CBC", Slot = "7")]
    public virtual void Execute()
    {
    }

    [Token(Token = "0x60082C1")]
    [Address(RVA = "0x4201DBC", Offset = "0x4201DBC", VA = "0x4201DBC", Slot = "8")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x60082C2")]
    [Address(RVA = "0x4201EBC", Offset = "0x4201EBC", VA = "0x4201EBC", Slot = "9")]
    public virtual bool IsBusy() => new bool();

    [Token(Token = "0x60082C3")]
    [Address(RVA = "0x4201FB8", Offset = "0x4201FB8", VA = "0x4201FB8")]
    public FreeMapButtonEventTaskList()
    {
    }
  }
}
