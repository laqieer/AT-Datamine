// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.CharacterSelectState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009BB")]
  public class CharacterSelectState : IPlayerMakeState
  {
    [Token(Token = "0x4002D18")]
    [FieldOffset(Offset = "0x10")]
    private readonly PlayerMakeManager manager;

    [Token(Token = "0x6003761")]
    [Address(RVA = "0x353980C", Offset = "0x353980C", VA = "0x353980C")]
    public CharacterSelectState(PlayerMakeManager manager)
    {
    }

    [Token(Token = "0x6003762")]
    [Address(RVA = "0x353B5BC", Offset = "0x353B5BC", VA = "0x353B5BC", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003763")]
    [Address(RVA = "0x353B624", Offset = "0x353B624", VA = "0x353B624", Slot = "5")]
    public IEnumerator Exit() => (IEnumerator) null;

    [Token(Token = "0x6003764")]
    [Address(RVA = "0x353B684", Offset = "0x353B684", VA = "0x353B684")]
    private IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x6003765")]
    [Address(RVA = "0x353B6EC", Offset = "0x353B6EC", VA = "0x353B6EC")]
    private void CharacterDecide()
    {
    }
  }
}
