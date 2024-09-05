// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.Count
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027A8")]
  public class Count : IEffectDuration
  {
    [Token(Token = "0x400A90A")]
    [FieldOffset(Offset = "0x10")]
    private int validCount;
    [Token(Token = "0x400A90B")]
    [FieldOffset(Offset = "0x14")]
    private int totalCount;

    [Token(Token = "0x1700353F")]
    public bool IsExpire
    {
      [Token(Token = "0x600F792"), Address(RVA = "0x1EDAD90", Offset = "0x1EDAD90", VA = "0x1EDAD90", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003540")]
    public List<int> Contexts
    {
      [Token(Token = "0x600F793"), Address(RVA = "0x1EDADA0", Offset = "0x1EDADA0", VA = "0x1EDADA0", Slot = "5")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600F794")]
    [Address(RVA = "0x1EDAED8", Offset = "0x1EDAED8", VA = "0x1EDAED8")]
    public Count(int count)
    {
    }

    [Token(Token = "0x600F795")]
    [Address(RVA = "0x1EDAF08", Offset = "0x1EDAF08", VA = "0x1EDAF08", Slot = "6")]
    public void Initialize(List<int> contexts)
    {
    }

    [Token(Token = "0x600F796")]
    [Address(RVA = "0x1EDAF00", Offset = "0x1EDAF00", VA = "0x1EDAF00", Slot = "7")]
    public void Reset(int effectedTurnNumber, int effectedPhaseIndex)
    {
    }

    [Token(Token = "0x600F797")]
    [Address(RVA = "0x1EDAF7C", Offset = "0x1EDAF7C", VA = "0x1EDAF7C", Slot = "8")]
    public void Update(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x20027A9")]
    private enum ContextType
    {
      [Token(Token = "0x400A90D")] ValidCount,
      [Token(Token = "0x400A90E")] TotalCount,
    }
  }
}
