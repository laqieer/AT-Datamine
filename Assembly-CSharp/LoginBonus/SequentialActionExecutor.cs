// Decompiled with JetBrains decompiler
// Type: LoginBonus.SequentialActionExecutor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AEC")]
  internal class SequentialActionExecutor
  {
    [Token(Token = "0x4003216")]
    [FieldOffset(Offset = "0x10")]
    private List<Action> actions;

    [Token(Token = "0x6003E44")]
    [Address(RVA = "0x2C147C0", Offset = "0x2C147C0", VA = "0x2C147C0")]
    public void Execute()
    {
    }

    [Token(Token = "0x6003E45")]
    [Address(RVA = "0x2C1484C", Offset = "0x2C1484C", VA = "0x2C1484C")]
    public void Next()
    {
    }

    [Token(Token = "0x6003E46")]
    [Address(RVA = "0x2C148C8", Offset = "0x2C148C8", VA = "0x2C148C8")]
    public SequentialActionExecutor Add(Action action) => (SequentialActionExecutor) null;

    [Token(Token = "0x6003E47")]
    [Address(RVA = "0x2C14970", Offset = "0x2C14970", VA = "0x2C14970")]
    public SequentialActionExecutor()
    {
    }
  }
}
