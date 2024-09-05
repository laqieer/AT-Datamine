// Decompiled with JetBrains decompiler
// Type: Battle.Process.PhaseCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200265B")]
  public enum PhaseCode
  {
    [Token(Token = "0x400A49B")] None,
    [Token(Token = "0x400A49C")] BeginBattle,
    [Token(Token = "0x400A49D")] BeginTurn,
    [Token(Token = "0x400A49E")] BeginPlayerPhase,
    [Token(Token = "0x400A49F")] EndPlayerPhase,
    [Token(Token = "0x400A4A0")] EndTurn,
    [Token(Token = "0x400A4A1")] WinBattle,
    [Token(Token = "0x400A4A2")] LoseBattle,
  }
}
