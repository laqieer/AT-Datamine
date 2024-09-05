// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IDuelFlowControlEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002793")]
  public interface IDuelFlowControlEffect
  {
    [Token(Token = "0x170034FC")]
    bool NullCounterStrike { [Token(Token = "0x600F6F2")] get; }

    [Token(Token = "0x170034FD")]
    bool AbsoluteSecondAttack { [Token(Token = "0x600F6F3")] get; }

    [Token(Token = "0x170034FE")]
    bool NullChase { [Token(Token = "0x600F6F4")] get; }

    [Token(Token = "0x170034FF")]
    bool AbsoluteChase { [Token(Token = "0x600F6F5")] get; }

    [Token(Token = "0x17003500")]
    bool FastChase { [Token(Token = "0x600F6F6")] get; }

    [Token(Token = "0x17003501")]
    bool FirstStrike { [Token(Token = "0x600F6F7")] get; }

    [Token(Token = "0x17003502")]
    bool SecondStrike { [Token(Token = "0x600F6F8")] get; }
  }
}
