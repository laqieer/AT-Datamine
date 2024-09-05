// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.PlayerMakeStateMachine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009B2")]
  public class PlayerMakeStateMachine
  {
    [Token(Token = "0x4002D04")]
    [FieldOffset(Offset = "0x10")]
    private IPlayerMakeState currentState;
    [Token(Token = "0x4002D05")]
    [FieldOffset(Offset = "0x18")]
    private bool inTransitionSequence;

    [Token(Token = "0x6003734")]
    [Address(RVA = "0x3539834", Offset = "0x3539834", VA = "0x3539834")]
    public PlayerMakeStateMachine(IPlayerMakeState initialState)
    {
    }

    [Token(Token = "0x6003735")]
    [Address(RVA = "0x353985C", Offset = "0x353985C", VA = "0x353985C")]
    public IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6003736")]
    [Address(RVA = "0x35390FC", Offset = "0x35390FC", VA = "0x35390FC")]
    public IEnumerator ChangeState(IPlayerMakeState nextState) => (IEnumerator) null;
  }
}
