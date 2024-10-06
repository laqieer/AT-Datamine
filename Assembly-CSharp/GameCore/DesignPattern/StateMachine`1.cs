// Decompiled with JetBrains decompiler
// Type: GameCore.DesignPattern.StateMachine`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.DesignPattern
{
  [Token(Token = "0x20014DA")]
  public class StateMachine<Towner> where Towner : class
  {
    [Token(Token = "0x4005FE6")]
    [FieldOffset(Offset = "0x0")]
    private Towner owner;
    [Token(Token = "0x4005FE7")]
    [FieldOffset(Offset = "0x0")]
    private StateMachineState<Towner> current;
    [Token(Token = "0x4005FE8")]
    [FieldOffset(Offset = "0x0")]
    private StateMachineState<Towner> prev;
    [Token(Token = "0x4005FE9")]
    [FieldOffset(Offset = "0x0")]
    private StateMachineState<Towner> global;

    [Token(Token = "0x1700121E")]
    public StateMachineState<Towner> CurrentState
    {
      [Token(Token = "0x600759E")] get => (StateMachineState<Towner>) null;
    }

    [Token(Token = "0x1700121F")]
    public StateMachineState<Towner> PrevState
    {
      [Token(Token = "0x600759F")] get => (StateMachineState<Towner>) null;
    }

    [Token(Token = "0x17001220")]
    public StateMachineState<Towner> GlobalState
    {
      [Token(Token = "0x60075A0")] get => (StateMachineState<Towner>) null;
    }

    [Token(Token = "0x60075A1")]
    public StateMachine(Towner entity)
    {
    }

    [Token(Token = "0x60075A2")]
    public StateMachine(StateMachine<Towner> t)
    {
    }

    [Token(Token = "0x60075A3")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x60075A4")]
    public void ChangeGlobalState(StateMachineState<Towner> newstate)
    {
    }

    [Token(Token = "0x60075A5")]
    public void ChangeState(StateMachineState<Towner> newstate)
    {
    }

    [Token(Token = "0x60075A6")]
    public void RevertToPrevState()
    {
    }
  }
}
