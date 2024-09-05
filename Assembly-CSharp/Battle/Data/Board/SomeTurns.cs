// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SomeTurns
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027A4")]
  public class SomeTurns : IEffectDuration
  {
    [Token(Token = "0x400A8F8")]
    [FieldOffset(Offset = "0x10")]
    private TurnCounter turnCounter;
    [Token(Token = "0x400A8F9")]
    [FieldOffset(Offset = "0x18")]
    private int length;

    [Token(Token = "0x17003539")]
    public int LeftTurn
    {
      [Token(Token = "0x600F784"), Address(RVA = "0x1EDA4D4", Offset = "0x1EDA4D4", VA = "0x1EDA4D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700353A")]
    public bool IsExpire
    {
      [Token(Token = "0x600F785"), Address(RVA = "0x1EDA4F8", Offset = "0x1EDA4F8", VA = "0x1EDA4F8", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700353B")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F786"), Address(RVA = "0x1EDA520", Offset = "0x1EDA520", VA = "0x1EDA520", Slot = "5")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600F787")]
    [Address(RVA = "0x1EDA720", Offset = "0x1EDA720", VA = "0x1EDA720")]
    public SomeTurns(int effectedTurnNumber, int effectedPhaseIndex, int length)
    {
    }

    [Token(Token = "0x600F788")]
    [Address(RVA = "0x1EDA7EC", Offset = "0x1EDA7EC", VA = "0x1EDA7EC", Slot = "6")]
    public void Initialize(List<int> contexts)
    {
    }

    [Token(Token = "0x600F789")]
    [Address(RVA = "0x1EDA768", Offset = "0x1EDA768", VA = "0x1EDA768", Slot = "7")]
    public void Reset(int effectedTurnNumber, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F78A")]
    [Address(RVA = "0x1EDA9F0", Offset = "0x1EDA9F0", VA = "0x1EDA9F0", Slot = "8")]
    public void Update(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x20027A5")]
    private enum ContextType
    {
      [Token(Token = "0x400A8FB")] EffectedTurn,
      [Token(Token = "0x400A8FC")] EffectedPhaseIndex,
      [Token(Token = "0x400A8FD")] Length,
      [Token(Token = "0x400A8FE")] ElapsedTurn,
    }
  }
}
