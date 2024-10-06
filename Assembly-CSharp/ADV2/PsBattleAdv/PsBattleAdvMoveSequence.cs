// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.PsBattleAdvMoveSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data.Board;
using Battle.Staging;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E7A")]
  public class PsBattleAdvMoveSequence : MoveGridSequence
  {
    [Token(Token = "0x6019252")]
    [Address(RVA = "0x2CFA2D8", Offset = "0x2CFA2D8", VA = "0x2CFA2D8")]
    private PsBattleAdvMoveSequence()
    {
    }

    [Token(Token = "0x6019253")]
    [Address(RVA = "0x2CFA2E0", Offset = "0x2CFA2E0", VA = "0x2CFA2E0")]
    public static PsBattleAdvMoveSequence Create(
      IDirector mainDirector,
      UnitParameterData targetUnit,
      GridData startGrid,
      Stack<GridData> route,
      bool resetDir = false,
      float speedMutiplier = 1f)
    {
      return (PsBattleAdvMoveSequence) null;
    }

    [Token(Token = "0x6019254")]
    [Address(RVA = "0x2CFA428", Offset = "0x2CFA428", VA = "0x2CFA428", Slot = "12")]
    public override void Complete()
    {
    }
  }
}
