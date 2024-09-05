// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.BackTransitToPlayerNameInputState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009B8")]
  public class BackTransitToPlayerNameInputState : IPlayerMakeState
  {
    [Token(Token = "0x4002D12")]
    [FieldOffset(Offset = "0x10")]
    private readonly PlayerMakeManager manager;

    [Token(Token = "0x6003752")]
    [Address(RVA = "0x353B32C", Offset = "0x353B32C", VA = "0x353B32C")]
    public BackTransitToPlayerNameInputState(PlayerMakeManager manager)
    {
    }

    [Token(Token = "0x6003753")]
    [Address(RVA = "0x353B354", Offset = "0x353B354", VA = "0x353B354", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003754")]
    [Address(RVA = "0x353B3E4", Offset = "0x353B3E4", VA = "0x353B3E4", Slot = "5")]
    public IEnumerator Exit() => (IEnumerator) null;
  }
}
