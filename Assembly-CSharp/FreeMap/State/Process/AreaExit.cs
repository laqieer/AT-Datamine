// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaExit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017A7")]
  public class AreaExit : AreaRelease
  {
    [Token(Token = "0x400687A")]
    [FieldOffset(Offset = "0x40")]
    private Action<int> noticeNextSequenceMethod;

    [Token(Token = "0x6008636")]
    [Address(RVA = "0x406FD8C", Offset = "0x406FD8C", VA = "0x406FD8C")]
    public AreaExit(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008637")]
    [Address(RVA = "0x406FDC8", Offset = "0x406FDC8", VA = "0x406FDC8", Slot = "4")]
    public override void Begin()
    {
    }
  }
}
