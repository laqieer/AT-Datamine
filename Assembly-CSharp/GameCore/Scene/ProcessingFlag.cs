// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.ProcessingFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C81")]
  public abstract class ProcessingFlag : IDisposable
  {
    [Token(Token = "0x4003887")]
    [FieldOffset(Offset = "0x10")]
    private bool isCntlEventSystem;
    [Token(Token = "0x4003888")]
    [FieldOffset(Offset = "0x11")]
    private bool isDiposed;

    [Token(Token = "0x6004821")]
    protected abstract List<WeakReference<ProcessingFlag>> GetInspectors();

    [Token(Token = "0x6004822")]
    protected abstract IReadOnlyList<WeakReference<ProcessingFlag>>[] GetAllInspectors();

    [Token(Token = "0x6004823")]
    [Address(RVA = "0x313014C", Offset = "0x313014C", VA = "0x313014C", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6004824")]
    [Address(RVA = "0x3130154", Offset = "0x3130154", VA = "0x3130154")]
    private void Dispose(bool disposing)
    {
    }

    [Token(Token = "0x6004825")]
    [Address(RVA = "0x3130740", Offset = "0x3130740", VA = "0x3130740", Slot = "1")]
    ~ProcessingFlag()
    {
    }

    [Token(Token = "0x6004826")]
    [Address(RVA = "0x31307D8", Offset = "0x31307D8", VA = "0x31307D8")]
    protected ProcessingFlag(bool cntlEventSystem)
    {
    }
  }
}
