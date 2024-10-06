// Decompiled with JetBrains decompiler
// Type: GameCore.DesignPattern.StateMachineState`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.DesignPattern
{
  [Token(Token = "0x20014D9")]
  public abstract class StateMachineState<Towner> where Towner : class
  {
    [Token(Token = "0x4005FE4")]
    [FieldOffset(Offset = "0x0")]
    protected bool initialized;
    [Token(Token = "0x4005FE5")]
    [FieldOffset(Offset = "0x0")]
    protected Towner owner;

    [Token(Token = "0x6007596")]
    public StateMachineState()
    {
    }

    [Token(Token = "0x6007597")]
    public void Initialize(Towner entity)
    {
    }

    [Token(Token = "0x6007598")]
    protected virtual void OnInitialize(Towner entity)
    {
    }

    [Token(Token = "0x6007599")]
    public void Enter(Towner entity)
    {
    }

    [Token(Token = "0x600759A")]
    protected virtual void OnEnter(Towner entity)
    {
    }

    [Token(Token = "0x600759B")]
    public abstract void Execute(Towner entity, float deltaTime);

    [Token(Token = "0x600759C")]
    public abstract void Exit(Towner entity);

    [Token(Token = "0x600759D")]
    public abstract int GetStateType();
  }
}
