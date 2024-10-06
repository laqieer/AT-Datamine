// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.EndState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009C2")]
  public class EndState : IPlayerMakeState
  {
    [Token(Token = "0x4002D27")]
    [FieldOffset(Offset = "0x10")]
    private readonly PlayerMakeManager manager;

    [Token(Token = "0x6003788")]
    [Address(RVA = "0x3103A80", Offset = "0x3103A80", VA = "0x3103A80")]
    public EndState(PlayerMakeManager manager)
    {
    }

    [Token(Token = "0x6003789")]
    [Address(RVA = "0x3103AA8", Offset = "0x3103AA8", VA = "0x3103AA8", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x600378A")]
    [Address(RVA = "0x3103B38", Offset = "0x3103B38", VA = "0x3103B38", Slot = "5")]
    public IEnumerator Exit() => (IEnumerator) null;
  }
}
