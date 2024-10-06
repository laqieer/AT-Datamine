// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.UnitDetailSubStateMachine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004CD")]
  public class UnitDetailSubStateMachine : StateMachine<UnitDetailStateHandlerBase>
  {
    [Token(Token = "0x6001B3E")]
    [Address(RVA = "0x2C2C560", Offset = "0x2C2C560", VA = "0x2C2C560")]
    public UnitDetailSubStateMachine(UnitDetailStateHandlerBase handler)
    {
    }

    [Token(Token = "0x6001B3F")]
    [Address(RVA = "0x2C2C5B8", Offset = "0x2C2C5B8", VA = "0x2C2C5B8")]
    public void ChangeState(UnitDetailSubState newState)
    {
    }

    [Token(Token = "0x6001B40")]
    [Address(RVA = "0x2C2C610", Offset = "0x2C2C610", VA = "0x2C2C610")]
    private new void ChangeState(
      StateMachineState<UnitDetailStateHandlerBase> newstate)
    {
    }

    [Token(Token = "0x17000357")]
    public UnitDetailSubState CurrentState
    {
      [Token(Token = "0x6001B41"), Address(RVA = "0x2C2C614", Offset = "0x2C2C614", VA = "0x2C2C614")] get
      {
        return (UnitDetailSubState) null;
      }
    }
  }
}
