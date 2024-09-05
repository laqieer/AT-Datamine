// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.State.StateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.State
{
  [Token(Token = "0x2000486")]
  public class StateHandler
  {
    [Token(Token = "0x4001853")]
    [FieldOffset(Offset = "0x10")]
    private StateMachine<UnitEquipmentModify> subStateMachine;
    [Token(Token = "0x4001854")]
    [FieldOffset(Offset = "0x18")]
    private SubState[] subStates;

    [Token(Token = "0x17000313")]
    public SubState Current
    {
      [Token(Token = "0x600194F"), Address(RVA = "0x2C20E28", Offset = "0x2C20E28", VA = "0x2C20E28")] get
      {
        return (SubState) null;
      }
    }

    [Token(Token = "0x6001950")]
    [Address(RVA = "0x2C20EBC", Offset = "0x2C20EBC", VA = "0x2C20EBC")]
    public StateHandler(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x6001951")]
    [Address(RVA = "0x2C21078", Offset = "0x2C21078", VA = "0x2C21078")]
    public void ChangeSubState(StateHandler.SubStateIndex subState)
    {
    }

    [Token(Token = "0x2000487")]
    public enum SubStateIndex
    {
      [Token(Token = "0x4001856")] Top,
      [Token(Token = "0x4001857")] Select,
      [Token(Token = "0x4001858")] ChangeCompare,
      [Token(Token = "0x4001859")] Max,
    }
  }
}
