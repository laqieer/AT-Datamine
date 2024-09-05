// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.Instant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200279E")]
  public class Instant : IEffectDuration
  {
    [Token(Token = "0x1700352E")]
    public bool IsExpire
    {
      [Token(Token = "0x600F765"), Address(RVA = "0x1ED9F00", Offset = "0x1ED9F00", VA = "0x1ED9F00", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700352F")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F766"), Address(RVA = "0x1ED9F08", Offset = "0x1ED9F08", VA = "0x1ED9F08", Slot = "5")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600F767")]
    [Address(RVA = "0x1ED9F7C", Offset = "0x1ED9F7C", VA = "0x1ED9F7C", Slot = "6")]
    public void Initialize(List<int> contexts)
    {
    }

    [Token(Token = "0x600F768")]
    [Address(RVA = "0x1ED9F80", Offset = "0x1ED9F80", VA = "0x1ED9F80", Slot = "7")]
    public void Reset(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x600F769")]
    [Address(RVA = "0x1ED9F84", Offset = "0x1ED9F84", VA = "0x1ED9F84", Slot = "8")]
    public void Update(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x600F76A")]
    [Address(RVA = "0x1ED9F88", Offset = "0x1ED9F88", VA = "0x1ED9F88")]
    public Instant()
    {
    }
  }
}
