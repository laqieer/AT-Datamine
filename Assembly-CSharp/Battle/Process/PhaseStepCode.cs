// Decompiled with JetBrains decompiler
// Type: Battle.Process.PhaseStepCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002676")]
  public enum PhaseStepCode
  {
    [Token(Token = "0x400A504")] None,
    [Token(Token = "0x400A505")] BeginPhaseStep,
    [Token(Token = "0x400A506")] CommandStep,
    [Token(Token = "0x400A507")] EndPhaseStep,
    [Token(Token = "0x400A508")] PhaseFinish,
    [Token(Token = "0x400A509")] WinBattle,
    [Token(Token = "0x400A50A")] LoseBattle,
  }
}
