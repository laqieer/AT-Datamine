// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Data.Board.ExpeditionBoardValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Expedition.Data.Board
{
  [Token(Token = "0x2002611")]
  public class ExpeditionBoardValidator : BoardSettings
  {
    [Token(Token = "0x400A365")]
    [FieldOffset(Offset = "0x10")]
    private Rect battleArea;

    [Token(Token = "0x600EB03")]
    [Address(RVA = "0x4B982EC", Offset = "0x4B982EC", VA = "0x4B982EC")]
    public ExpeditionBoardValidator(ExpeditionBattleData data)
    {
    }

    [Token(Token = "0x600EB04")]
    [Address(RVA = "0x4B9839C", Offset = "0x4B9839C", VA = "0x4B9839C", Slot = "7")]
    public override PathSearcher2D.NodeValidationCallback GetMovableSearchTargetValidator(
      BoardData board,
      UnitParameterData owner)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600EB05")]
    [Address(RVA = "0x4B98464", Offset = "0x4B98464", VA = "0x4B98464", Slot = "8")]
    public override PathSearcher2D.NodeValidationCallback GetOccupiableSearchTargetValidator(
      BoardData board,
      UnitParameterData owner)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }
  }
}
