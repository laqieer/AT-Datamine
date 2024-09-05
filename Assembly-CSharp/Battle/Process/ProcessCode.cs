// Decompiled with JetBrains decompiler
// Type: Battle.Process.ProcessCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002638")]
  public enum ProcessCode
  {
    [Token(Token = "0x400A43B")] None = -1, // 0xFFFFFFFF
    [Token(Token = "0x400A43C")] Initialize = 0,
    [Token(Token = "0x400A43D")] Ready = 1,
    [Token(Token = "0x400A43E")] BeginBattle = 2,
    [Token(Token = "0x400A43F")] LoseBattle = 100, // 0x00000064
    [Token(Token = "0x400A440")] WinBattle = 101, // 0x00000065
    [Token(Token = "0x400A441")] GiveupBattle = 102, // 0x00000066
    [Token(Token = "0x400A442")] Result = 999, // 0x000003E7
  }
}
