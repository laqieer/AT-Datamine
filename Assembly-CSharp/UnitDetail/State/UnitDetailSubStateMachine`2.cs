// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.UnitDetailSubStateMachine`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004CE")]
  public class UnitDetailSubStateMachine<TStateHandler, TSubState> : UnitDetailSubStateMachine
    where TStateHandler : UnitDetailStateHandlerBase
    where TSubState : UnitDetailSubState
  {
    [Token(Token = "0x6001B42")]
    public UnitDetailSubStateMachine(TStateHandler handler)
    {
    }

    [Token(Token = "0x6001B43")]
    public void ChangeState(TSubState newState)
    {
    }

    [Token(Token = "0x6001B44")]
    private new void ChangeState(UnitDetailSubState newState)
    {
    }

    [Token(Token = "0x17000358")]
    public TSubState CurrentState
    {
      [Token(Token = "0x6001B45")] get => (TSubState) null;
    }
  }
}
