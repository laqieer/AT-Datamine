// Decompiled with JetBrains decompiler
// Type: PlayerMake.StateMachine.IPlayerMakeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace PlayerMake.StateMachine
{
  [Token(Token = "0x20009C5")]
  public interface IPlayerMakeState
  {
    [Token(Token = "0x6003797")]
    IEnumerator InitializeAsync();

    [Token(Token = "0x6003798")]
    IEnumerator Exit();
  }
}
