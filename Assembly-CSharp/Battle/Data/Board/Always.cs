// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.Always
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200279F")]
  public class Always : IEffectDuration
  {
    [Token(Token = "0x17003530")]
    public bool IsExpire
    {
      [Token(Token = "0x600F76B"), Address(RVA = "0x1ED9F90", Offset = "0x1ED9F90", VA = "0x1ED9F90", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003531")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F76C"), Address(RVA = "0x1ED9F98", Offset = "0x1ED9F98", VA = "0x1ED9F98", Slot = "5")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600F76D")]
    [Address(RVA = "0x1EDA00C", Offset = "0x1EDA00C", VA = "0x1EDA00C", Slot = "6")]
    public void Initialize(List<int> contexts)
    {
    }

    [Token(Token = "0x600F76E")]
    [Address(RVA = "0x1EDA010", Offset = "0x1EDA010", VA = "0x1EDA010", Slot = "7")]
    public void Reset(int effectedTurnNumber, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F76F")]
    [Address(RVA = "0x1EDA014", Offset = "0x1EDA014", VA = "0x1EDA014", Slot = "8")]
    public void Update(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x600F770")]
    [Address(RVA = "0x1EDA018", Offset = "0x1EDA018", VA = "0x1EDA018")]
    public Always()
    {
    }
  }
}
