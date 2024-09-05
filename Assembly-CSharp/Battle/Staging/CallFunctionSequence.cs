// Decompiled with JetBrains decompiler
// Type: Battle.Staging.CallFunctionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200259C")]
  public class CallFunctionSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1C8")]
    [FieldOffset(Offset = "0x10")]
    private Action function;

    [Token(Token = "0x170031A1")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E843"), Address(RVA = "0x4C3F520", Offset = "0x4C3F520", VA = "0x4C3F520", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E844")]
    [Address(RVA = "0x4C3BB18", Offset = "0x4C3BB18", VA = "0x4C3BB18")]
    public static CallFunctionSequence Create(Action function) => (CallFunctionSequence) null;

    [Token(Token = "0x600E845")]
    [Address(RVA = "0x4C3F528", Offset = "0x4C3F528", VA = "0x4C3F528")]
    private CallFunctionSequence(Action function)
    {
    }

    [Token(Token = "0x600E846")]
    [Address(RVA = "0x4C3F550", Offset = "0x4C3F550", VA = "0x4C3F550", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E847")]
    [Address(RVA = "0x4C3F56C", Offset = "0x4C3F56C", VA = "0x4C3F56C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E848")]
    [Address(RVA = "0x4C3F570", Offset = "0x4C3F570", VA = "0x4C3F570", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E849")]
    [Address(RVA = "0x4C3F574", Offset = "0x4C3F574", VA = "0x4C3F574", Slot = "6")]
    public void Abort()
    {
    }
  }
}
