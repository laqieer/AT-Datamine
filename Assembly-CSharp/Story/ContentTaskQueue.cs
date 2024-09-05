// Decompiled with JetBrains decompiler
// Type: Story.ContentTaskQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000576")]
  public class ContentTaskQueue : IContentTaskHandler
  {
    [Token(Token = "0x4001C03")]
    [FieldOffset(Offset = "0x10")]
    private ICoroutineWorker entity;
    [Token(Token = "0x4001C04")]
    [FieldOffset(Offset = "0x18")]
    private Queue<IContentTask> tasks;
    [Token(Token = "0x4001C05")]
    [FieldOffset(Offset = "0x20")]
    private IContentTask current;

    [Token(Token = "0x6001F81")]
    [Address(RVA = "0x2A03E98", Offset = "0x2A03E98", VA = "0x2A03E98", Slot = "4")]
    public void Add(IContentTask task)
    {
    }

    [Token(Token = "0x6001F82")]
    [Address(RVA = "0x2A03F08", Offset = "0x2A03F08", VA = "0x2A03F08", Slot = "5")]
    public void Clear()
    {
    }

    [Token(Token = "0x6001F83")]
    [Address(RVA = "0x2A03F58", Offset = "0x2A03F58", VA = "0x2A03F58", Slot = "8")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x6001F84")]
    [Address(RVA = "0x2A03F68", Offset = "0x2A03F68", VA = "0x2A03F68")]
    private IContentTask TaskPickup() => (IContentTask) null;

    [Token(Token = "0x6001F85")]
    [Address(RVA = "0x2A03FD0", Offset = "0x2A03FD0", VA = "0x2A03FD0", Slot = "6")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F86")]
    [Address(RVA = "0x2A04004", Offset = "0x2A04004", VA = "0x2A04004")]
    private void TaskStart(IContentTask task)
    {
    }

    [Token(Token = "0x6001F87")]
    [Address(RVA = "0x2A04158", Offset = "0x2A04158", VA = "0x2A04158", Slot = "7")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F88")]
    [Address(RVA = "0x2A04290", Offset = "0x2A04290", VA = "0x2A04290")]
    public ContentTaskQueue()
    {
    }
  }
}
