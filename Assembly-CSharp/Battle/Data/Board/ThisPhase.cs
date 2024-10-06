// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ThisPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027A0")]
  public class ThisPhase : IEffectDuration
  {
    [Token(Token = "0x400A8EB")]
    [FieldOffset(Offset = "0x10")]
    private int effectedTurn;
    [Token(Token = "0x400A8EC")]
    [FieldOffset(Offset = "0x14")]
    private int effectedPhaseIndex;

    [Token(Token = "0x17003532")]
    public bool IsExpire
    {
      [Token(Token = "0x600F771"), Address(RVA = "0x1EDA020", Offset = "0x1EDA020", VA = "0x1EDA020", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F772"), Address(RVA = "0x1EDA028", Offset = "0x1EDA028", VA = "0x1EDA028")] private set
      {
      }
    }

    [Token(Token = "0x17003533")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F773"), Address(RVA = "0x1EDA034", Offset = "0x1EDA034", VA = "0x1EDA034", Slot = "5")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600F774")]
    [Address(RVA = "0x1EDA16C", Offset = "0x1EDA16C", VA = "0x1EDA16C")]
    public ThisPhase(int effectedTurn, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F775")]
    [Address(RVA = "0x1EDA1A0", Offset = "0x1EDA1A0", VA = "0x1EDA1A0", Slot = "6")]
    public void Initialize(List<int> contexts)
    {
    }

    [Token(Token = "0x600F776")]
    [Address(RVA = "0x1EDA198", Offset = "0x1EDA198", VA = "0x1EDA198", Slot = "7")]
    public void Reset(int effectedTurnNumber, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F777")]
    [Address(RVA = "0x1EDA204", Offset = "0x1EDA204", VA = "0x1EDA204", Slot = "8")]
    public void Update(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x20027A1")]
    private enum ContextType
    {
      [Token(Token = "0x400A8EF")] EffectedTurn,
      [Token(Token = "0x400A8F0")] EffectedPhaseIndex,
    }
  }
}
