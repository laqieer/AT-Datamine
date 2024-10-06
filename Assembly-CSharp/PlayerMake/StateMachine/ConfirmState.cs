// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.ConfirmState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009BF")]
  public class ConfirmState : IPlayerMakeState
  {
    [Token(Token = "0x4002D21")]
    [FieldOffset(Offset = "0x10")]
    private readonly PlayerMakeManager manager;

    [Token(Token = "0x6003778")]
    [Address(RVA = "0x31037A0", Offset = "0x31037A0", VA = "0x31037A0")]
    public ConfirmState(PlayerMakeManager manager)
    {
    }

    [Token(Token = "0x6003779")]
    [Address(RVA = "0x31037C8", Offset = "0x31037C8", VA = "0x31037C8", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x600377A")]
    [Address(RVA = "0x3103858", Offset = "0x3103858", VA = "0x3103858")]
    private void Decide()
    {
    }

    [Token(Token = "0x600377B")]
    [Address(RVA = "0x3103888", Offset = "0x3103888", VA = "0x3103888", Slot = "5")]
    public IEnumerator Exit() => (IEnumerator) null;
  }
}
