// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.BackTransitToCharacterSelectState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009B5")]
  public class BackTransitToCharacterSelectState : IPlayerMakeState
  {
    [Token(Token = "0x4002D0D")]
    [FieldOffset(Offset = "0x10")]
    private readonly PlayerMakeManager manager;

    [Token(Token = "0x6003743")]
    [Address(RVA = "0x353B0E4", Offset = "0x353B0E4", VA = "0x353B0E4")]
    public BackTransitToCharacterSelectState(PlayerMakeManager manager)
    {
    }

    [Token(Token = "0x6003744")]
    [Address(RVA = "0x353B10C", Offset = "0x353B10C", VA = "0x353B10C", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003745")]
    [Address(RVA = "0x353B194", Offset = "0x353B194", VA = "0x353B194", Slot = "5")]
    public IEnumerator Exit() => (IEnumerator) null;
  }
}
