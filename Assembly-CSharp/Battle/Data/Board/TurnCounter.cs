// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.TurnCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027A2")]
  public class TurnCounter : IEffectDuration
  {
    [Token(Token = "0x17003534")]
    public int EffectedTurn
    {
      [Token(Token = "0x600F778"), Address(RVA = "0x1EDA22C", Offset = "0x1EDA22C", VA = "0x1EDA22C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F779"), Address(RVA = "0x1EDA234", Offset = "0x1EDA234", VA = "0x1EDA234")] private set
      {
      }
    }

    [Token(Token = "0x17003535")]
    public int EffectedPhaseIndex
    {
      [Token(Token = "0x600F77A"), Address(RVA = "0x1EDA23C", Offset = "0x1EDA23C", VA = "0x1EDA23C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F77B"), Address(RVA = "0x1EDA244", Offset = "0x1EDA244", VA = "0x1EDA244")] private set
      {
      }
    }

    [Token(Token = "0x17003536")]
    public int ElapsedTurn
    {
      [Token(Token = "0x600F77C"), Address(RVA = "0x1EDA24C", Offset = "0x1EDA24C", VA = "0x1EDA24C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F77D"), Address(RVA = "0x1EDA254", Offset = "0x1EDA254", VA = "0x1EDA254")] private set
      {
      }
    }

    [Token(Token = "0x17003537")]
    public bool IsExpire
    {
      [Token(Token = "0x600F77E"), Address(RVA = "0x1EDA25C", Offset = "0x1EDA25C", VA = "0x1EDA25C", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003538")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F77F"), Address(RVA = "0x1EDA264", Offset = "0x1EDA264", VA = "0x1EDA264", Slot = "5")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600F780")]
    [Address(RVA = "0x1EDA3F4", Offset = "0x1EDA3F4", VA = "0x1EDA3F4")]
    public TurnCounter(int effectedTurnNumber, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F781")]
    [Address(RVA = "0x1EDA428", Offset = "0x1EDA428", VA = "0x1EDA428", Slot = "6")]
    public void Initialize(List<int> contexts)
    {
    }

    [Token(Token = "0x600F782")]
    [Address(RVA = "0x1EDA420", Offset = "0x1EDA420", VA = "0x1EDA420", Slot = "7")]
    public void Reset(int effectedTurnNumber, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F783")]
    [Address(RVA = "0x1EDA4B8", Offset = "0x1EDA4B8", VA = "0x1EDA4B8", Slot = "8")]
    public void Update(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x20027A3")]
    private enum ContextType
    {
      [Token(Token = "0x400A8F5")] EffectedTurn,
      [Token(Token = "0x400A8F6")] EffectedPhaseIndex,
      [Token(Token = "0x400A8F7")] ElapsedTurn,
    }
  }
}
