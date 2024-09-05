// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SomeTurnsDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027A6")]
  public class SomeTurnsDamage : IEffectDuration
  {
    [Token(Token = "0x400A8FF")]
    [FieldOffset(Offset = "0x10")]
    private int effectedTurn;
    [Token(Token = "0x400A900")]
    [FieldOffset(Offset = "0x14")]
    private int effectedPhaseIndex;
    [Token(Token = "0x400A901")]
    [FieldOffset(Offset = "0x18")]
    private int length;
    [Token(Token = "0x400A902")]
    [FieldOffset(Offset = "0x1C")]
    private int elapsedTurn;
    [Token(Token = "0x400A903")]
    [FieldOffset(Offset = "0x20")]
    private int lastCountedTurnNumber;

    [Token(Token = "0x1700353C")]
    public int LeftTurn
    {
      [Token(Token = "0x600F78B"), Address(RVA = "0x1EDAA20", Offset = "0x1EDAA20", VA = "0x1EDAA20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700353D")]
    public bool IsExpire
    {
      [Token(Token = "0x600F78C"), Address(RVA = "0x1EDAA2C", Offset = "0x1EDAA2C", VA = "0x1EDAA2C", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700353E")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F78D"), Address(RVA = "0x1EDAA3C", Offset = "0x1EDAA3C", VA = "0x1EDAA3C", Slot = "5")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600F78E")]
    [Address(RVA = "0x1EDAC7C", Offset = "0x1EDAC7C", VA = "0x1EDAC7C")]
    public SomeTurnsDamage(int effectedTurnNumber, int effectedPhaseIndex, int length)
    {
    }

    [Token(Token = "0x600F78F")]
    [Address(RVA = "0x1EDACB8", Offset = "0x1EDACB8", VA = "0x1EDACB8", Slot = "6")]
    public void Initialize(List<int> contexts)
    {
    }

    [Token(Token = "0x600F790")]
    [Address(RVA = "0x1EDAD68", Offset = "0x1EDAD68", VA = "0x1EDAD68", Slot = "7")]
    public void Reset(int effectedTurnNumber, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F791")]
    [Address(RVA = "0x1EDAD74", Offset = "0x1EDAD74", VA = "0x1EDAD74", Slot = "8")]
    public void Update(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x20027A7")]
    private enum ContextType
    {
      [Token(Token = "0x400A905")] EffectedTurn,
      [Token(Token = "0x400A906")] EffectedPhaseIndex,
      [Token(Token = "0x400A907")] Length,
      [Token(Token = "0x400A908")] ElapsedTurn,
      [Token(Token = "0x400A909")] LastCountedTurnNumber,
    }
  }
}
