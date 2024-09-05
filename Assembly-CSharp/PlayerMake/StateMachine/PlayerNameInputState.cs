// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.PlayerNameInputState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009C6")]
  public class PlayerNameInputState : IPlayerMakeState
  {
    [Token(Token = "0x4002D2D")]
    [FieldOffset(Offset = "0x10")]
    private readonly PlayerMakeManager manager;
    [Token(Token = "0x4002D2E")]
    [FieldOffset(Offset = "0x18")]
    private readonly string initialPlayerName;
    [Token(Token = "0x4002D2F")]
    [FieldOffset(Offset = "0x20")]
    private bool isRunning;

    [Token(Token = "0x6003799")]
    [Address(RVA = "0x3103D58", Offset = "0x3103D58", VA = "0x3103D58")]
    public PlayerNameInputState(PlayerMakeManager manager, string initialPlayerName = "")
    {
    }

    [Token(Token = "0x600379A")]
    [Address(RVA = "0x3103D88", Offset = "0x3103D88", VA = "0x3103D88", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x600379B")]
    [Address(RVA = "0x3103E18", Offset = "0x3103E18", VA = "0x3103E18")]
    private void Decide()
    {
    }

    [Token(Token = "0x600379C")]
    [Address(RVA = "0x3103F60", Offset = "0x3103F60", VA = "0x3103F60")]
    private void OnValidationAccept()
    {
    }

    [Token(Token = "0x600379D")]
    [Address(RVA = "0x3103F7C", Offset = "0x3103F7C", VA = "0x3103F7C")]
    private void OnValidationDeny(PlayerMakeValidation.InvalidType invalidType)
    {
    }

    [Token(Token = "0x600379E")]
    [Address(RVA = "0x3104010", Offset = "0x3104010", VA = "0x3104010", Slot = "5")]
    public IEnumerator Exit() => (IEnumerator) null;
  }
}
