// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.UnitDetailStateMachine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using Scenes.OutGame;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004CC")]
  public class UnitDetailStateMachine : StateMachine<UnitDetailSubScene>
  {
    [Token(Token = "0x6001B3C")]
    [Address(RVA = "0x2C2C480", Offset = "0x2C2C480", VA = "0x2C2C480")]
    public UnitDetailStateMachine(UnitDetailSubScene subScene)
    {
    }

    [Token(Token = "0x17000356")]
    public UnitDetailState CurrentState
    {
      [Token(Token = "0x6001B3D"), Address(RVA = "0x2C2C4D8", Offset = "0x2C2C4D8", VA = "0x2C2C4D8")] get
      {
        return (UnitDetailState) null;
      }
    }
  }
}
